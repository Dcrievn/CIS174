using Microsoft.EntityFrameworkCore;

namespace OlympicsWebsite.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<OlympicGame> Games { get; set; }
        public DbSet<SportType> Sports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<OlympicGame>().HasData(
                new OlympicGame { GameID = "wo", Name = "Winter Olympics"},
                new OlympicGame { GameID = "so", Name = "Summer Olympics"},
                new OlympicGame { GameID = "po", Name = "Paralympics"},
                new OlympicGame { GameID = "yo", Name = "Youth Olympics"}
                );

            modelBuilder.Entity<SportType>().HasData(
                new SportType { SportID = "curl", Name = "Curling", Category = "Indoor"},
                new SportType { SportID = "bobsl", Name = "Bobsleigh", Category = "Outdoor" },
                new SportType { SportID = "dive", Name = "Diving", Category = "Indoor" },
                new SportType { SportID = "cycl", Name = "Road Cycling", Category = "Outdoor" },
                new SportType { SportID = "arch", Name = "Archery", Category = "Indoor" },
                new SportType { SportID = "canoe", Name = "Canoe Sprint", Category = "Outdoor" },
                new SportType { SportID = "brkdnc", Name = "Breakdancing", Category = "Indoor" },
                new SportType { SportID = "skbrd", Name = "Skateboarding", Category = "Outdoor" }
                );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "can", Name = "Canada", GameID = "wo", SportID = "curl", CountryImage = "Canada.png" },
                new { CountryID = "swe", Name = "Sweden", GameID = "wo", SportID = "curl", CountryImage = "Sweden.png" },
                new { CountryID = "gbr", Name = "Great Britain", GameID = "wo", SportID = "curl", CountryImage = "GreatBritain.png" },
                new { CountryID = "jam", Name = "Jamaica", GameID = "wo", SportID = "bobsl", CountryImage = "Jamaica.png" },
                new { CountryID = "ita", Name = "Italy", GameID = "wo", SportID = "bobsl", CountryImage = "Italy.png" },
                new { CountryID = "jpn", Name = "Japan", GameID = "wo", SportID = "bobsl", CountryImage = "Japan.png" },

                new { CountryID = "ger", Name = "Germany", GameID = "so", SportID = "dive", CountryImage = "Germany.png" },
                new { CountryID = "chn", Name = "China", GameID = "so", SportID = "dive", CountryImage = "China.png" },
                new { CountryID = "mex", Name = "Mexico", GameID = "so", SportID = "dive", CountryImage = "Mexico.png" },
                new { CountryID = "bra", Name = "Brazil", GameID = "so", SportID = "cycl", CountryImage = "Brazil.png" },
                new { CountryID = "ned", Name = "Netherlands", GameID = "so", SportID = "cycl", CountryImage = "Netherlands.png" },
                new { CountryID = "usa", Name = "USA", GameID = "so", SportID = "cycl", CountryImage = "USA.png" },

                new { CountryID = "tha", Name = "Thailand", GameID = "po", SportID = "arch", CountryImage = "Thailand.png" },
                new { CountryID = "uru", Name = "Uruguay", GameID = "po", SportID = "arch", CountryImage = "Uruguay.png" },
                new { CountryID = "ukr", Name = "Ukraine", GameID = "po", SportID = "arch", CountryImage = "Ukraine.png" },
                new { CountryID = "aus", Name = "Austria", GameID = "po", SportID = "canoe", CountryImage = "Austria.png" },
                new { CountryID = "pak", Name = "Pakistan", GameID = "po", SportID = "canoe", CountryImage = "Pakistan.png" },
                new { CountryID = "zim", Name = "Zimbabwe", GameID = "po", SportID = "canoe", CountryImage = "Zimbabwe.png" },

                new { CountryID = "fra", Name = "France", GameID = "yo", SportID = "brkdnc", CountryImage = "France.png" },
                new { CountryID = "cyp", Name = "Cyprus", GameID = "yo", SportID = "brkdnc", CountryImage = "Cyprus.png" },
                new { CountryID = "rus", Name = "Russia", GameID = "yo", SportID = "brkdnc", CountryImage = "Russia.png" },
                new { CountryID = "fin", Name = "Finland", GameID = "yo", SportID = "skbrd", CountryImage = "Finland.png" },
                new { CountryID = "svk", Name = "Slovakia", GameID = "yo", SportID = "skbrd", CountryImage = "Slovakia.png" },
                new { CountryID = "por", Name = "Portugal", GameID = "yo", SportID = "skbrd", CountryImage = "Portugal.png" }
                );
        }
    }
}
