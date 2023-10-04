using Microsoft.EntityFrameworkCore;

namespace RawDataShared
{
    public class RawDataContext : DbContext
    {
        public virtual DbSet<Instrument> Instrument { get; set; }

        public virtual DbSet<BusinessUnit> BusinessUnit { get; set; }

        public virtual DbSet<ProfitCentre> ProfitCentre { get; set; }

        public virtual DbSet<Trade> Trade {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(@"Data Source=C:\Mj\RawData.db");

    }
}