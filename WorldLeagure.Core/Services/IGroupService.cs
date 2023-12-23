using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services.Common;

namespace WorldLeagure.Core.Services
{
    public interface IGroupService : IBaseService<Group>
    {
        Task<bool> CheckGroupAsync(Guid id);
    }
}
