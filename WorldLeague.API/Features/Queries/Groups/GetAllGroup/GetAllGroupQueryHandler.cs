using AutoMapper;
using MediatR;
using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Groups.GetAllGroup
{
    public class GetAllGroupQueryHandler : IRequestHandler<GetAllGroupQueryRequest, GetAllGroupQueryResponse>
    {
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;

        public GetAllGroupQueryHandler(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public async Task<GetAllGroupQueryResponse> Handle(GetAllGroupQueryRequest request, CancellationToken cancellationToken)
        {
            List<Group> groups = await _groupService.GetAllAsync();
            return new GetAllGroupQueryResponse() { Groups = _mapper.Map<List<Group>, List<GetByIdGroupQueryResponse>>(groups) };
        }
    }
}
