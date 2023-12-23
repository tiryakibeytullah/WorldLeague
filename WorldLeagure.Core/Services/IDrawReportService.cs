using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services.Common;
using WorldLeagure.Core.ViewModels;

namespace WorldLeagure.Core.Services
{
    public interface IDrawReportService : IBaseService<DrawReport>
    {
        Task<List<DrawReportViewModel>> DrawLotsAsync(int groupCount, string firstName, string surname);
    }
}
