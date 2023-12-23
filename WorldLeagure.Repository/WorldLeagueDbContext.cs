using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Entities;
using WorldLeagure.Repository.Configurations;
using WorldLeagure.Repository.DataSeeds;

namespace WorldLeagure.Repository
{
    public class WorldLeagueDbContext : DbContext
    {
        public WorldLeagueDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<DrawReport> DrawReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new DrawReportConfiguration());

            Guid[] countryIds = new Guid[8];
            for (int i = 0; i < 8; i++)
                countryIds[i] = Guid.NewGuid();

            modelBuilder.ApplyConfiguration(new CountryDataSeed(countryIds));
            modelBuilder.ApplyConfiguration(new TeamDataSeed(countryIds));
            modelBuilder.ApplyConfiguration(new GroupDataSeed());

            base.OnModelCreating(modelBuilder);
        }
    }
}
