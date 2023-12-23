using WorldLeagure.Core.Repositories.Country;

namespace WorldLeagure.Repository.Repositories.Country
{
    public class CountryWriteRepository : WriteRepository<WorldLeagure.Core.Entities.Country>, ICountryWriteRepository
    {
        public CountryWriteRepository(WorldLeagueDbContext movieDbContext) : base(movieDbContext)
        {

        }
    }
}
