using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Teams.UpdateTeam
{
    public class UpdateTeamCommandHandler : IRequestHandler<UpdateTeamCommandRequest, UpdateTeamCommandResponse>
    {
        private readonly ITeamService _teamService;
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public UpdateTeamCommandHandler(ITeamService teamService, ICountryService countryService, IMapper mapper)
        {
            _teamService = teamService;
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<UpdateTeamCommandResponse> Handle(UpdateTeamCommandRequest request, CancellationToken cancellationToken)
        {
            bool isCountryCheck = await _countryService.CheckCountryAsync(request.CountryId);
            if (!isCountryCheck)
                throw new NotFoundCountryException();
            else
            {
                bool isTeamCheck = await _teamService.CheckTeamAsync(request.Id);
                if (!isTeamCheck)
                    throw new NotFoundTeamException();
                else
                {
                    _teamService.Update(_mapper.Map<UpdateTeamCommandRequest, Team>(request));
                    return new();
                }
            }
        }
    }
}
