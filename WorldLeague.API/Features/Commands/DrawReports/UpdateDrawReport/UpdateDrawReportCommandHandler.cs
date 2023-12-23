using MediatR;

namespace WorldLeague.API.Features.Commands.DrawReports.UpdateDrawReport
{
    public class UpdateDrawReportCommandHandler : IRequestHandler<UpdateDrawReportCommandRequest, UpdateDrawReportCommandResponse>
    {
        public Task<UpdateDrawReportCommandResponse> Handle(UpdateDrawReportCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
