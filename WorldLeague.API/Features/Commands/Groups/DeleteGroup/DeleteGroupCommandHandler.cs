using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Groups.DeleteGroup
{
    public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommandRequest, DeleteGroupCommandResponse>
    {
        private readonly IGroupService _groupService;

        public DeleteGroupCommandHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<DeleteGroupCommandResponse> Handle(DeleteGroupCommandRequest request, CancellationToken cancellationToken)
        {
            Group group = await _groupService.GetByIdAsync(request.Id);
            if (group != null)
            {
                _groupService.Remove(group);
                return new();
            }
            else
                throw new NotFoundException();
        }
    }
}
