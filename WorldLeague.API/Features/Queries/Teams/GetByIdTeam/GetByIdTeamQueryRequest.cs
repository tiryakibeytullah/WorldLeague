using MediatR;

namespace WorldLeague.API.Features.Queries.Teams.GetByIdTeam
{
    public class GetByIdTeamQueryRequest : IRequest<GetByIdTeamQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
