using MediatR;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.DrawReports.DeleteDrawReport
{
    public class DeleteByUserDrawReportCommandHandler : IRequestHandler<DeleteByUserDrawReportCommandRequest, DeleteByUserDrawReportCommandResponse>
    {
        private readonly IDrawReportService _drawReportService;

        public DeleteByUserDrawReportCommandHandler(IDrawReportService drawReportService)
        {
            _drawReportService = drawReportService;
        }

        public async Task<DeleteByUserDrawReportCommandResponse> Handle(DeleteByUserDrawReportCommandRequest request, CancellationToken cancellationToken)
        {
            await _drawReportService.RemoveRangeAsync(request.Firstname, request.Surname);
            return new();
        }
    }
}
