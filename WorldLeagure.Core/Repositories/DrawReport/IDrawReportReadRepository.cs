namespace WorldLeagure.Core.Repositories.DrawReport
{
    public interface IDrawReportReadRepository : IReadRepository<WorldLeagure.Core.Entities.DrawReport>
    {
        IQueryable<WorldLeagure.Core.Entities.DrawReport> GetWithNavigationProperties();
    }
}
