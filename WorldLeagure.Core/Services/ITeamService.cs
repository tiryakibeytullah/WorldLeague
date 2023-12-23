using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services.Common;

namespace WorldLeagure.Core.Services
{
    public interface ITeamService : IBaseService<Team>
    {
        Task<bool> CheckTeamAsync(Guid id);
    }
}
