using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Repositories.Country;

namespace WorldLeagure.Repository.Repositories.Country
{
    public class CountryReadRepository : ReadRepository<WorldLeagure.Core.Entities.Country>, ICountryReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public CountryReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {

        }

        public async Task<bool> CheckCountryAsync(Guid id)
        {
            return await _worldLeagueDbContext.Countries.AnyAsync(c => c.Id == id && c.IsDeleted == false);
        }

        public async Task<List<Core.Entities.Country>> GetWithNavigationPropertiesAsync()
        {
            return await _worldLeagueDbContext.Countries.Include(c => c.Teams).ToListAsync();
        }
    }
}
