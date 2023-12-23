using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Service.Services.Common;

namespace WorldLeagure.Service.Services
{
    public class TeamService : BaseService<Team>, ITeamService
    {
        public TeamService(IWriteRepository<Team> writeRepository, IReadRepository<Team> readRepository, IUnitOfWork unitOfWork) : base(writeRepository, readRepository, unitOfWork)
        {
        }

        public async Task<bool> CheckTeamAsync(Guid id)
        {
            return await _unitOfWork.TeamReadRepository.CheckTeamAsync(id);
        }
    }
}
