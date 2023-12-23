using MediatR;

namespace WorldLeague.API.Features.Queries.Groups.GetByIdGroup
{
    public class GetByIdGroupQueryRequest : IRequest<GetByIdGroupQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
