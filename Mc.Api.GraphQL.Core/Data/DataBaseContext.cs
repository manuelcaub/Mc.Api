namespace Mc.Api.Core.Data
{
    using Mc.Api.Core.Models;
    using Microsoft.EntityFrameworkCore;

    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Droid> Droids { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }
    }
}
