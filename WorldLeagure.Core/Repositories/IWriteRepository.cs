using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Repositories
{
    public interface IWriteRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entites);
        bool Remove(T entity);
        Task<bool> RemoveAsync(Guid id);
        bool Update(T entity);
    }
}
