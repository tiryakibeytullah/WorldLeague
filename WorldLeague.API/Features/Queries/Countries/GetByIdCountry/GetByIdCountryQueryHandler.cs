using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Countries.GetByIdCountry
{
    public class GetByIdCountryQueryHandler : IRequestHandler<GetByIdCountryQueryRequest, GetByIdCountryQueryResponse>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public GetByIdCountryQueryHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<GetByIdCountryQueryResponse> Handle(GetByIdCountryQueryRequest request, CancellationToken cancellationToken)
        {
            Country country = await _countryService.GetByIdAsync(request.Id);
            if (country != null)
                return _mapper.Map<Country, GetByIdCountryQueryResponse>(country);
            else
                throw new NotFoundGroupException();
        }
    }
}
