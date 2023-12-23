using WorldLeagure.Core.Entities;

namespace WorldLeague.API.Features.Queries.Countries.GetAllCountryWithNavigationProperties
{
    public class GetAllCountryWithNavigationPropertiesQueryResponse
    {
        public IEnumerable<Country> Countries { get; set; }
    }
}
