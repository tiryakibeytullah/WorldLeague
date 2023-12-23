using MediatR;

namespace WorldLeague.API.Features.Commands.DrawReports.DeleteDrawReport
{
    public class DeleteDrawReportCommandHandler : IRequestHandler<DeleteDrawReportCommandRequest, DeleteDrawReportCommandResponse>
    {
        public Task<DeleteDrawReportCommandResponse> Handle(DeleteDrawReportCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
