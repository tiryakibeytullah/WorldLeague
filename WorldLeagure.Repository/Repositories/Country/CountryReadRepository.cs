using WorldLeagure.Core.Repositories.Country;

namespace WorldLeagure.Repository.Repositories.Country
{
    public class CountryReadRepository : ReadRepository<WorldLeagure.Core.Entities.Country>, ICountryReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public CountryReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {

        }
    }
}
