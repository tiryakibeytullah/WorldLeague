using AutoMapper;
using MediatR;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Countries.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommandRequest, CreateCountryCommandResponse>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CreateCountryCommandHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<CreateCountryCommandResponse> Handle(CreateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            await _countryService.AddAsync(_mapper.Map<CreateCountryCommandRequest, Country>(request));
            return new();
        }
    }
}
