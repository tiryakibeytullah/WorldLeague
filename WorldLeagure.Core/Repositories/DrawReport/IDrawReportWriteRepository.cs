namespace WorldLeagure.Core.Repositories.DrawReport
{
    public interface IDrawReportWriteRepository : IWriteRepository<WorldLeagure.Core.Entities.DrawReport>
    {
        public void UpdateRange(List<Core.Entities.DrawReport> drawReports);
    }
}
