using MediatR;

namespace WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport
{
    public class CreateDrawReportCommandRequest : IRequest<CreateDrawReportCommandResponse>
    {
        public int GroupCount { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
