using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;
using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;

namespace WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport
{
    public class CreateDrawReportCommandResponse
    {
        //public List<DrawReportViewModel> DrawReportResponses { get; set; }
        public List<DrawReportResponse> DrawReportResponses { get; set; }
    }

    public class DrawReportResponse
    {
        public GetByIdGroupQueryResponse Group { get; set; }
        public List<GetByIdTeamQueryResponse> Teams { get; set; }
    }
}
