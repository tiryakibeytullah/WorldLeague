using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Countries.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommandRequest, UpdateCountryCommandResponse>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public UpdateCountryCommandHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<UpdateCountryCommandResponse> Handle(UpdateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            bool isCheckCountry = await _countryService.CheckCountryAsync(request.Id);
            if (!isCheckCountry)
                throw new NotFoundException();
            else
            {
                _countryService.Update(_mapper.Map<UpdateCountryCommandRequest, Country>(request));
                return new();
            }
        }
    }
}
