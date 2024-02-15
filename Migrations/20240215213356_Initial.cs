using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CPW211_MurderMystery.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharScript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerFullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PlayerGender = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharScript", "Desc", "FullName", "Gender", "Occupation" },
                values: new object[,]
                {
                    { 1, "TDB", "Father of Deimos, Phobos and Eden", "Mars Olufemi", "Male", "Cartographer" },
                    { 2, "TDB", "Son of Mars, twin brother of Phobos, and elder brother of Eden.", "Deimos Olufemi", "Male", "Singer" },
                    { 3, "TDB", "Son of Mars, twin brother of Deimos, and elder brother of Eden.", "Phobos Olufemi", "Male", "Locksmith" },
                    { 4, "TDB", "Adopted daughter of Mars and younger sister of Deimos and Phobos.", "Eden Olufemi", "Female", "Musician" },
                    { 5, "TDB", "Best friend of Phoebe.", "Tahlia Collins", "Female", "Gardener" },
                    { 6, "TDB", "Best friend of Tahlia.", "Phoebe Mandrapilias", "Female", "Painter" },
                    { 7, "TDB", "Wife/business partner of Walter and mother of Jamie.", "Silvia Honey", "Female", "Shop Owner" },
                    { 8, "TDB", "Husband/business partner of Silvia and father of Jamie.", "Walter Honey", "Male", "Shop Owner" },
                    { 9, "TDB", "Son of Walter and Silvia. Jamie was often babysat by Deimos as a child, and the two are still very close to this day. Jamie is also friends with Elliot, and often spends time in his library. Although, while the two enjoy talking, Jamie can’t say he knows much about Elliot personally.", "Jamie Honey", "Male", "Waiter" },
                    { 10, "TDB", "Friend of Jamie, but much of his past is a mystery to Jamie.", "Elliot Perry", "Male", "Librarian" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "The town business tycoon is hosting a mascarade at her manor to celebrate her sons taking over of the family company.", "Mansion Party" },
                    { 2, "This train is on a two hour nonstop trip to the next city over.As this specific route goes through the countryside, phone connections are spotty at best.", "Train" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
