using AutoMapper;
using MediatR;
using WorldLeague.API.Features.Queries.Countries.GetByIdCountry;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Countries.GetAllCountry
{
    public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQueryRequest, GetAllCountryQueryResponse>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public GetAllCountryQueryHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<GetAllCountryQueryResponse> Handle(GetAllCountryQueryRequest request, CancellationToken cancellationToken)
        {
            List<Country> countries = await _countryService.GetAllAsync();
            return new GetAllCountryQueryResponse() { Countries = _mapper.Map<List<Country>, List<GetByIdCountryQueryResponse>>(countries) };
        }
    }
}
