using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Service.Services.Common;

namespace WorldLeagure.Service.Services
{
    public class GroupService : BaseService<Group>, IGroupService
    {
        public GroupService(IWriteRepository<Group> writeRepository, IReadRepository<Group> readRepository, IUnitOfWork unitOfWork) : base(writeRepository, readRepository, unitOfWork)
        {
        }

        public async Task<bool> CheckGroupAsync(Guid id)
        {
            return await _unitOfWork.GroupReadRepository.CheckGroupAsync(id);
        }
    }
}
