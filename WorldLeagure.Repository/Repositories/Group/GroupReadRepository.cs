using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Repositories.Group;

namespace WorldLeagure.Repository.Repositories.Group
{
    public class GroupReadRepository : ReadRepository<WorldLeagure.Core.Entities.Group>, IGroupReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public GroupReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {
        }

        public async Task<bool> CheckGroupAsync(Guid id)
        {
            return await _worldLeagueDbContext.Groups.AnyAsync(g => g.Id == id && g.IsDeleted == false);
        }
    }
}
