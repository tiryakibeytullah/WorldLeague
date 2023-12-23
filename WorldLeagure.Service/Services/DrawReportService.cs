using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Service.Services.Common;

namespace WorldLeagure.Service.Services
{
    public class DrawReportService : BaseService<DrawReport>, IDrawReportService
    {
        public DrawReportService(IWriteRepository<DrawReport> writeRepository, IReadRepository<DrawReport> readRepository, IUnitOfWork unitOfWork) : base(writeRepository, readRepository, unitOfWork)
        {
        }
    }
}
