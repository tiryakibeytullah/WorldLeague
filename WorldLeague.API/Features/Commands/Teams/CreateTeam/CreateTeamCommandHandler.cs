using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Teams.CreateTeam
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommandRequest, CreateTeamCommandResponse>
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;
        private readonly ICountryService _countryService;

        public CreateTeamCommandHandler(ITeamService teamService, IMapper mapper, ICountryService countryService)
        {
            _teamService = teamService;
            _mapper = mapper;
            _countryService = countryService;
        }

        public async Task<CreateTeamCommandResponse> Handle(CreateTeamCommandRequest request, CancellationToken cancellationToken)
        {
            bool isCheckCountry = await _countryService.CheckCountryAsync(request.CountryId);
            if (!isCheckCountry)
                throw new NotFoundCountryException();
            else
            {
                await _teamService.AddAsync(_mapper.Map<CreateTeamCommandRequest, Team>(request));
                return new();
            }
        }
    }
}
