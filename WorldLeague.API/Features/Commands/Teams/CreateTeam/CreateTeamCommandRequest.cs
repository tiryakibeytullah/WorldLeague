using MediatR;

namespace WorldLeague.API.Features.Commands.Teams.CreateTeam
{
    public class CreateTeamCommandRequest : IRequest<CreateTeamCommandResponse>
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }
    }
}
