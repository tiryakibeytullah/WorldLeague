namespace WorldLeagure.Core.Repositories.Country
{
    public interface ICountryReadRepository : IReadRepository<WorldLeagure.Core.Entities.Country>
    {
        Task<bool> CheckCountryAsync(Guid id);

        Task<List<WorldLeagure.Core.Entities.Country>> GetWithNavigationPropertiesAsync();
    }
}
