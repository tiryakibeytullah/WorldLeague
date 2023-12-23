using MediatR;

namespace WorldLeague.API.Features.Queries.DrawReports.GetByIdDrawReport
{
    public class GetByUserDrawReportQueryRequest : IRequest<GetByUserDrawReportQueryResponse>
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
