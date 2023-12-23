using MediatR;

namespace WorldLeague.API.Features.Commands.Teams.UpdateTeam
{
    public class UpdateTeamCommandRequest : IRequest<UpdateTeamCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CountryId { get; set; }
    }
}
