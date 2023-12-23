using AutoMapper;
using MediatR;
using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Teams.GetAllTeam
{
    public class GetAllTeamQueryHandler : IRequestHandler<GetAllTeamQueryRequest, GetAllTeamQueryResponse>
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        public GetAllTeamQueryHandler(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        public async Task<GetAllTeamQueryResponse> Handle(GetAllTeamQueryRequest request, CancellationToken cancellationToken)
        {
            List<Team> teams = await _teamService.GetAllAsync();
            return new GetAllTeamQueryResponse() { Teams = _mapper.Map<List<Team>, List<GetByIdTeamQueryResponse>>(teams) };
        }
    }
}
