using MediatR;

namespace WorldLeague.API.Features.Queries.DrawReports.GetByIdDrawReport
{
    public class GetByIdDrawReportQueryHandler : IRequestHandler<GetByIdDrawReportQueryRequest, GetByIdDrawReportQueryResponse>
    {
        public Task<GetByIdDrawReportQueryResponse> Handle(GetByIdDrawReportQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
