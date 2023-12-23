using WorldLeagure.Core.Repositories.Group;

namespace WorldLeagure.Repository.Repositories.Group
{
    public class GroupReadRepository : ReadRepository<WorldLeagure.Core.Entities.Group>, IGroupReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public GroupReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {
        }
    }
}
