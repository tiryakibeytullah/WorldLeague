using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services.Common;
using WorldLeagure.Core.ViewModels;

namespace WorldLeagure.Core.Services
{
    public interface IDrawReportService : IBaseService<DrawReport>
    {
        Task<List<DrawReportViewModel>> DrawLotsAsync(int groupCount, string firstName, string surname);

        Task<List<DrawReportViewModel>> GetListByUserAsync(string firstName, string surname);

        Task RemoveRangeAsync(string firstName, string surname);
    }
}
