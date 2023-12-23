using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WorldLeagure.Core.Entities.Common;
using WorldLeagure.Core.Repositories;

namespace WorldLeagure.Repository.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        protected readonly WorldLeagueDbContext _context;

        public WriteRepository(WorldLeagueDbContext movieDbContext)
        {
            this._context = movieDbContext;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            return true;
        }

        public async Task<bool> AddRangeAsync(List<T> entites)
        {
            await Table.AddRangeAsync(entites);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            T entity = await Table.FirstOrDefaultAsync(t => t.Id == id);
            return Remove(entity);
        }

        public bool Update(T entity)
        {
            EntityEntry entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

    }
}
