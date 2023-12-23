using WorldLeagure.Core.Repositories.DrawReport;

namespace WorldLeagure.Repository.Repositories.DrawReport
{
    public class DrawReportReadRepository : ReadRepository<WorldLeagure.Core.Entities.DrawReport>, IDrawReportReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public DrawReportReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {

        }
    }
}
