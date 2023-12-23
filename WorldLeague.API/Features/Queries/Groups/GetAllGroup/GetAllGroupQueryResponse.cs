using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;

namespace WorldLeague.API.Features.Queries.Groups.GetAllGroup
{
    public class GetAllGroupQueryResponse
    {
        public IEnumerable<GetByIdGroupQueryResponse> Groups { get; set; }
    }
}
