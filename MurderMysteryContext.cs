using Microsoft.EntityFrameworkCore;

namespace CPW211_MurderMystery
{
    public class MurderMysteryContext : DbContext
    {
        public MurderMysteryContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CPW211_MurderMystery;Trusted_Connection=True;");
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character { CharacterId = 1,  ThemeId = 1, FullName = "Mars Olufemi", Gender = "Male", Occupation = "Cartographer", CharScript = "TDB", Desc = "Father of Deimos, Phobos and Eden" },
                new Character { CharacterId = 2,  ThemeId = 1, FullName = "Deimos Olufemi", Gender = "Male", Occupation = "Singer", CharScript = "TDB", Desc = "Son of Mars, twin brother of Phobos, and elder brother of Eden." },
                new Character { CharacterId = 3,  ThemeId = 1, FullName = "Phobos Olufemi", Gender = "Male", Occupation = "Locksmith", CharScript = "TDB", Desc = "Son of Mars, twin brother of Deimos, and elder brother of Eden." },
                new Character { CharacterId = 4,  ThemeId = 1, FullName = "Eden Olufemi", Gender = "Female", Occupation = "Musician", CharScript = "TDB", Desc = "Adopted daughter of Mars and younger sister of Deimos and Phobos." },
                new Character { CharacterId = 5,  ThemeId = 1, FullName = "Tahlia Collins", Gender = "Female", Occupation = "Gardener", CharScript = "TDB", Desc = "Best friend of Phoebe." },
                new Character { CharacterId = 6,  ThemeId = 2, FullName = "Phoebe Mandrapilias", Gender = "Female", Occupation = "Painter", CharScript = "TDB", Desc = "Best friend of Tahlia." },
                new Character { CharacterId = 7,  ThemeId = 2, FullName = "Silvia Honey", Gender = "Female", Occupation = "Shop Owner", CharScript = "TDB", Desc = "Wife/business partner of Walter and mother of Jamie." },
                new Character { CharacterId = 8,  ThemeId = 2, FullName = "Walter Honey", Gender = "Male", Occupation = "Shop Owner", CharScript = "TDB", Desc = "Husband/business partner of Silvia and father of Jamie." },
                new Character { CharacterId = 9,  ThemeId = 2, FullName = "Jamie Honey", Gender = "Male", Occupation = "Waiter", CharScript = "TDB", Desc = "Son of Walter and Silvia. Jamie was often babysat by Deimos as a child, and the two are still very close to this day. Jamie is also friends with Elliot, and often spends time in his library. Although, while the two enjoy talking, Jamie can’t say he knows much about Elliot personally." },
                new Character { CharacterId = 10, ThemeId = 2, FullName = "Elliot Perry", Gender = "Male", Occupation = "Librarian", CharScript = "TDB", Desc = "Friend of Jamie, but much of his past is a mystery to Jamie." }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 1, PlayerFullName = "Player One", PlayerGender = "Male" },
                new Player { PlayerId = 2, PlayerFullName = "Person Two", PlayerGender = "Female" },
                new Player { PlayerId = 3, PlayerFullName = "User Three", PlayerGender = "No preference" }
            );

            modelBuilder.Entity<Theme>().HasData(
                new Theme { ThemeId = 1, Title = "", Summary = "" },
                new Theme { ThemeId = 2, Title = "Mansion Party", Summary = "The town business tycoon is hosting a mascarade at her manor to celebrate her sons taking over of the family company." },
                new Theme { ThemeId = 3, Title = "Train", Summary = "This train is on a two hour nonstop trip to the next city over. As this specific route goes through the countryside, phone connections are spotty at best." }
            );

            modelBuilder.Entity<Character>().ToTable(b => b.HasCheckConstraint("CK_Gender", "[Gender] IN ('Male', 'Female', 'No preference')"));

            modelBuilder.Entity<Player>().ToTable(b => b.HasCheckConstraint("CK_PlayerGender", "[PlayerGender] IN ('Male', 'Female', 'No preference')"));

            // Set up the foreign key relationship. One Theme to many characters
            modelBuilder.Entity<Character>().HasOne(c => c.Theme).WithMany(t => t.Characters).HasForeignKey(c => c.ThemeId);
        }
    }
}
