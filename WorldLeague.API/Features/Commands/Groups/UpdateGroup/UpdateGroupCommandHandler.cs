using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Groups.UpdateGroup
{
    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommandRequest, UpdateGroupCommandResponse>
    {
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;

        public UpdateGroupCommandHandler(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public async Task<UpdateGroupCommandResponse> Handle(UpdateGroupCommandRequest request, CancellationToken cancellationToken)
        {
            bool isCheckGroup = await _groupService.CheckGroupAsync(request.Id);
            if (!isCheckGroup)
                throw new NotFoundGroupException();
            else
            {
                _groupService.Update(_mapper.Map<UpdateGroupCommandRequest, Group>(request));
                return new();
            }
        }
    }
}
