using AutoMapper;
using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Queries.Groups.GetByIdGroup
{
    public class GetByIdGroupQueryHandler : IRequestHandler<GetByIdGroupQueryRequest, GetByIdGroupQueryResponse>
    {
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;

        public GetByIdGroupQueryHandler(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public async Task<GetByIdGroupQueryResponse> Handle(GetByIdGroupQueryRequest request, CancellationToken cancellationToken)
        {
            Group group = await _groupService.GetByIdAsync(request.Id);
            if (group != null)
                return _mapper.Map<Group, GetByIdGroupQueryResponse>(group);
            else
                throw new NotFoundGroupException();
        }
    }
}
