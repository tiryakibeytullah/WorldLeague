namespace WorldLeagure.Core.Repositories.Team
{
    public interface ITeamReadRepository : IReadRepository<WorldLeagure.Core.Entities.Team>
    {
        Task<bool> CheckTeamAsync(Guid id);

        Task<List<WorldLeagure.Core.Entities.Team>> GetWithNavigationPropertiesAsync();
    }
}
