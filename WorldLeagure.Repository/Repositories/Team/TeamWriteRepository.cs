using WorldLeagure.Core.Repositories.Team;

namespace WorldLeagure.Repository.Repositories.Team
{
    public class TeamWriteRepository : WriteRepository<WorldLeagure.Core.Entities.Team>, ITeamWriteRepository
    {
        public TeamWriteRepository(WorldLeagueDbContext movieDbContext) : base(movieDbContext)
        {
        }
    }
}
