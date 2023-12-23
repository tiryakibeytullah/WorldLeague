using MediatR;

namespace WorldLeague.API.Features.Commands.Groups.DeleteGroup
{
    public class DeleteGroupCommandRequest : IRequest<DeleteGroupCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
