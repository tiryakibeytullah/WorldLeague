using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;
using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;

namespace WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport
{
    public class CreateDrawReportCommandResponse
    {
        public List<DrawReportResponse> DrawReportResponses { get; set; }
    }

    public class DrawReportResponse
    {
        public GetByIdGroupQueryResponse GroupName { get; set; }
        public List<GetByIdTeamQueryResponse> Teams { get; set; }
    }
}
