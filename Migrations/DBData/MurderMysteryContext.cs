using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_MurderMystery
{
    public class MurderMysteryContext : DbContext
    {
        public MurderMysteryContext() {
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CPW211_MurderMystery;Trusted_Connection=True;");
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }
}
