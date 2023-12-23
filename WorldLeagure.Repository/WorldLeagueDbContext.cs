using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Entities;

namespace WorldLeagure.Repository
{
    public class WorldLeagueDbContext : DbContext
    {
        public WorldLeagueDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<DrawReport> DrawReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
