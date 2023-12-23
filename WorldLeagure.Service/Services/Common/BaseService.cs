using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WorldLeagure.Core.Entities.Common;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services.Common;
using WorldLeagure.Core.UnitOfWorks;

namespace WorldLeagure.Service.Services.Common
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IWriteRepository<T> _writeRepository;
        private readonly IReadRepository<T> _readRepository;
        public readonly IUnitOfWork _unitOfWork;

        public BaseService(IWriteRepository<T> writeRepository, IReadRepository<T> readRepository, IUnitOfWork unitOfWork)
        {
            this._writeRepository = writeRepository;
            this._readRepository = readRepository;
            this._unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _writeRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _readRepository.GetAll(tracking: false).ToListAsync();
            return entities;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _readRepository.GetByIdAsync(id, tracking: true);
            return entity;
        }

        public void Remove(T entity)
        {
            _writeRepository.Remove(entity);
            _unitOfWork.Commit();
        }

        public T Update(T entity)
        {
            _writeRepository.Update(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public async Task<List<T>> Where(Expression<Func<T, bool>> expression)
        {
            var entities = await _readRepository.GetWhere(expression, tracking: true).ToListAsync();
            return entities;
        }
    }
}
