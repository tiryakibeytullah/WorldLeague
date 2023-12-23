using MediatR;

namespace WorldLeague.API.Features.Queries.DrawReports.GetAllDrawReport
{
    public class GetAllDrawReportQueryHandler : IRequestHandler<GetAllDrawReportQueryRequest, GetAllDrawReportQueryResponse>
    {
        public Task<GetAllDrawReportQueryResponse> Handle(GetAllDrawReportQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
