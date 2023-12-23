using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeague.API.ViewModels;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.ViewModels;

namespace WorldLeague.API.Features.Queries.DrawReports.GetByIdDrawReport
{
    public class GetByUserDrawReportQueryHandler : IRequestHandler<GetByUserDrawReportQueryRequest, GetByUserDrawReportQueryResponse>
    {
        private readonly IDrawReportService _drawReportService;
        private readonly IMapper _mapper;

        public GetByUserDrawReportQueryHandler(IDrawReportService drawReportService, IMapper mapper)
        {
            _drawReportService = drawReportService;
            _mapper = mapper;
        }

        public async Task<GetByUserDrawReportQueryResponse> Handle(GetByUserDrawReportQueryRequest request, CancellationToken cancellationToken)
        {
            List<DrawReportViewModel> drawReportViewModels = await _drawReportService.GetListByUserAsync(request.Firstname, request.Surname);
            if (drawReportViewModels.Any())
            {
                return new GetByUserDrawReportQueryResponse() { DrawReportResponses = _mapper.Map<List<DrawReportViewModel>, List<DrawReportResponseViewModel>>(drawReportViewModels) };
            }
            else
                throw new NotFoundGroupException();

        }
    }
}