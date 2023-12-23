using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Repositories.Team;

namespace WorldLeagure.Repository.Repositories.Team
{
    public class TeamReadRepository : ReadRepository<WorldLeagure.Core.Entities.Team>, ITeamReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public TeamReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {
        }

        public async Task<bool> CheckTeamAsync(Guid id)
        {
            return await _worldLeagueDbContext.Teams.AnyAsync(t => t.Id == id && t.IsDeleted == false);
        }

        public async Task<List<Core.Entities.Team>> GetWithNavigationPropertiesAsync()
        {
            return await _worldLeagueDbContext.Teams.Include(t => t.Country).ToListAsync();
        }
    }
}
