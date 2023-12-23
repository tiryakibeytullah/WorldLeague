using MediatR;

namespace WorldLeague.API.Features.Commands.Groups.UpdateGroup
{
    public class UpdateGroupCommandRequest : IRequest<UpdateGroupCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
