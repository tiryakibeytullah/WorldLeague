using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services.Common;

namespace WorldLeagure.Core.Services
{
    public interface ICountryService : IBaseService<Country>
    {
        Task<bool> CheckCountryAsync(Guid id);

        Task<List<Country>> GetWithNavigationPropertiesAsync();
    }
}
