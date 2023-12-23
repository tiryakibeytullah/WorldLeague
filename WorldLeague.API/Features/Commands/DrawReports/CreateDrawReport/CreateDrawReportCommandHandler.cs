using MediatR;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport
{
    public class CreateDrawReportCommandHandler : IRequestHandler<CreateDrawReportCommandRequest, CreateDrawReportCommandResponse>
    {
        private readonly IDrawReportService _drawReportService;

        public CreateDrawReportCommandHandler(IDrawReportService drawReportService)
        {
            _drawReportService = drawReportService;
        }

        public Task<CreateDrawReportCommandResponse> Handle(CreateDrawReportCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
