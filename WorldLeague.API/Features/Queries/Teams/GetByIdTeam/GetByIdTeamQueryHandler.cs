using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Teams.GetByIdTeam
{
    public class GetByIdTeamQueryHandler : IRequestHandler<GetByIdTeamQueryRequest, GetByIdTeamQueryResponse>
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        public GetByIdTeamQueryHandler(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        public async Task<GetByIdTeamQueryResponse> Handle(GetByIdTeamQueryRequest request, CancellationToken cancellationToken)
        {
            Team team = await _teamService.GetByIdAsync(request.Id);
            if (team != null)
                return _mapper.Map<Team, GetByIdTeamQueryResponse>(team);
            else
                throw new NotFoundGroupException();
        }
    }
}
