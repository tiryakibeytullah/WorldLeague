using WorldLeagure.Core.Repositories.Team;

namespace WorldLeagure.Repository.Repositories.Team
{
    public class TeamReadRepository : ReadRepository<WorldLeagure.Core.Entities.Team>, ITeamReadRepository
    {
        private WorldLeagueDbContext _worldLeagueDbContext { get => _context as WorldLeagueDbContext; }

        public TeamReadRepository(WorldLeagueDbContext worldLeagueDbContext) : base(worldLeagueDbContext)
        {
        }
    }
}
