using WorldLeagure.Core.Repositories.DrawReport;

namespace WorldLeagure.Repository.Repositories.DrawReport
{
    public class DrawReportWriteRepository : WriteRepository<WorldLeagure.Core.Entities.DrawReport>, IDrawReportWriteRepository
    {
        public DrawReportWriteRepository(WorldLeagueDbContext movieDbContext) : base(movieDbContext)
        {
        }
    }
}
