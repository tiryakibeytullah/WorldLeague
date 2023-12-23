using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WorldLeagure.Core.Entities.Common;
using WorldLeagure.Core.Repositories;

namespace WorldLeagure.Repository.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        protected readonly WorldLeagueDbContext _context;

        public ReadRepository(WorldLeagueDbContext worldLeagueDbContext)
        {
            this._context = worldLeagueDbContext;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable().Where(q => q.IsDeleted == false);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
        {
            var query = Table.AsQueryable().Where(q => q.IsDeleted == false);
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = Table.AsQueryable().Where(q => q.IsDeleted == false);
            if (!tracking)
                query = query.AsNoTracking();
            return await query.SingleOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = Table.Where(expression).Where(q => q.IsDeleted == false);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
