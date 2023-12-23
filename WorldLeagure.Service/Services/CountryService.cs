using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Service.Services.Common;

namespace WorldLeagure.Service.Services
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        public CountryService(IWriteRepository<Country> writeRepository, IReadRepository<Country> readRepository, IUnitOfWork unitOfWork) : base(writeRepository, readRepository, unitOfWork)
        {

        }

        public async Task<bool> CheckCountryAsync(Guid id)
        {
            return await _unitOfWork.CountryReadRepository.CheckCountryAsync(id);
        }

        public async Task<List<Country>> GetWithNavigationPropertiesAsync()
        {
            return await _unitOfWork.CountryReadRepository.GetWithNavigationPropertiesAsync();
        }
    }
}
