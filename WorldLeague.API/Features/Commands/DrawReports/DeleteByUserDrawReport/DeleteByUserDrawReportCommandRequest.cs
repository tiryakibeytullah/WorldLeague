using MediatR;

namespace WorldLeague.API.Features.Commands.DrawReports.DeleteDrawReport
{
    public class DeleteByUserDrawReportCommandRequest : IRequest<DeleteByUserDrawReportCommandResponse>
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
