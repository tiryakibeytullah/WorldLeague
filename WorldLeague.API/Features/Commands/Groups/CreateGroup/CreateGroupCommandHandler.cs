using AutoMapper;
using MediatR;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Groups.CreateGroup
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommandRequest, CreateGroupCommandResponse>
    {
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;

        public CreateGroupCommandHandler(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public async Task<CreateGroupCommandResponse> Handle(CreateGroupCommandRequest request, CancellationToken cancellationToken)
        {
            await _groupService.AddAsync(_mapper.Map<CreateGroupCommandRequest, Group>(request));
            return new();
        }
    }
}
