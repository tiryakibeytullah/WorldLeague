using WorldLeagure.Core.Repositories.DrawReport;

namespace WorldLeagure.Repository.Repositories.DrawReport
{
    public class DrawReportWriteRepository : WriteRepository<WorldLeagure.Core.Entities.DrawReport>, IDrawReportWriteRepository
    {
        public DrawReportWriteRepository(WorldLeagueDbContext movieDbContext) : base(movieDbContext)
        {
        }

        public void UpdateRange(List<Core.Entities.DrawReport> drawReports)
        {
            _context.UpdateRange(drawReports);
        }
    }
}
