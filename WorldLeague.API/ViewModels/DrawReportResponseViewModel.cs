using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;
using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;

namespace WorldLeague.API.ViewModels
{
    public class DrawReportResponseViewModel
    {
        public GetByIdGroupQueryResponse Group { get; set; }
        public List<GetByIdTeamQueryResponse> Teams { get; set; }
    }
}
