using WorldLeagure.Core.Repositories.Group;

namespace WorldLeagure.Repository.Repositories.Group
{
    public class GroupWriteRepository : WriteRepository<WorldLeagure.Core.Entities.Group>, IGroupWriteRepository
    {
        public GroupWriteRepository(WorldLeagueDbContext movieDbContext) : base(movieDbContext)
        {

        }
    }
}
