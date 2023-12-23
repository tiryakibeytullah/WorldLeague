using System.Linq.Expressions;
using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Services.Common
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        void Remove(T entity);
        T Update(T entity);
    }
}
