namespace ChessMates.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppDatabase : DbContext
    {

        public AppDatabase()
            : base("name=AppDatabase")
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Continent> Continents { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<News> News { get; set; }
    }

}