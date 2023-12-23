using System.Linq.Expressions;
using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Repositories
{
    public interface IReadRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetByIdAsync(Guid id, bool tracking = true);
    }
}
