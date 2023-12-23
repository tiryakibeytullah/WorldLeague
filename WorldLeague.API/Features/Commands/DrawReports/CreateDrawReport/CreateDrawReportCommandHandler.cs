using AutoMapper;
using MediatR;
using WorldLeague.API.ViewModels;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.ViewModels;

namespace WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport
{
    public class CreateDrawReportCommandHandler : IRequestHandler<CreateDrawReportCommandRequest, CreateDrawReportCommandResponse>
    {
        private readonly IDrawReportService _drawReportService;
        private readonly IMapper _mapper;

        public CreateDrawReportCommandHandler(IDrawReportService drawReportService, IMapper mapper)
        {
            _drawReportService = drawReportService;
            _mapper = mapper;
        }

        public async Task<CreateDrawReportCommandResponse> Handle(CreateDrawReportCommandRequest request, CancellationToken cancellationToken)
        {
            List<DrawReportViewModel> drawReportViewModels = await _drawReportService.DrawLotsAsync(request.GroupCount, request.Firstname, request.Surname);
            List<DrawReportViewModel> response = drawReportViewModels.Where(t => t.Teams.Any()).ToList();
            return new CreateDrawReportCommandResponse() { DrawReportResponses = _mapper.Map<List<DrawReportViewModel>, List<DrawReportResponseViewModel>>(response) };
        }
    }
}
