using MediatR;

namespace WorldLeague.API.Features.Commands.Teams.DeleteTeam
{
    public class DeleteTeamCommandRequest : IRequest<DeleteTeamCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
