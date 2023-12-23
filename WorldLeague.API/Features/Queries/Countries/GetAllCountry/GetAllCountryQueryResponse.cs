using WorldLeague.API.Features.Queries.Countries.GetByIdCountry;

namespace WorldLeague.API.Features.Queries.Countries.GetAllCountry
{
    public class GetAllCountryQueryResponse
    {
        public IEnumerable<GetByIdCountryQueryResponse> Countries { get; set; }
    }
}
