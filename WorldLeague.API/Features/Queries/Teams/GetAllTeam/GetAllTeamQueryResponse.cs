using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;

namespace WorldLeague.API.Features.Queries.Teams.GetAllTeam
{
    public class GetAllTeamQueryResponse
    {
        public IEnumerable<GetByIdTeamQueryResponse> Teams { get; set; }
    }
}
