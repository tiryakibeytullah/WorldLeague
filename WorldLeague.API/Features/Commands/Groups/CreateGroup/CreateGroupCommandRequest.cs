using MediatR;

namespace WorldLeague.API.Features.Commands.Groups.CreateGroup
{
    public class CreateGroupCommandRequest : IRequest<CreateGroupCommandResponse>
    {
        public string Name { get; set; }
    }
}
