using MediatR;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Countries.GetAllCountryWithNavigationProperties
{
    public class GetAllCountryWithNavigationPropertiesQueryHandler : IRequestHandler<GetAllCountryWithNavigationPropertiesQueryRequest, GetAllCountryWithNavigationPropertiesQueryResponse>
    {
        private readonly ICountryService _countryService;

        public GetAllCountryWithNavigationPropertiesQueryHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<GetAllCountryWithNavigationPropertiesQueryResponse> Handle(GetAllCountryWithNavigationPropertiesQueryRequest request, CancellationToken cancellationToken)
        {
            List<Country> countries = await _countryService.GetWithNavigationPropertiesAsync();
            return new GetAllCountryWithNavigationPropertiesQueryResponse() { Countries = countries };
        }
    }
}
