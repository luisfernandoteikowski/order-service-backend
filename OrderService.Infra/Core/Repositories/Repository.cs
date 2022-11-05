using OrderService.Domain.Core.Entities;
using OrderService.Domain.Core.Interfaces;
using System.Linq.Expressions;

namespace OrderService.Infra.Core.Repositories
{
    public abstract class Repository<T> : IRepository<T>
        where T : BaseEntity
    {
        protected IList<T> _entities;

        public Repository()
        {
            _entities = new List<T>();
        }

        public Task<List<T>> Get() => Task.FromResult(_entities.ToList<T>());

        public Task<List<T>> Get(Expression<Func<T, bool>> predicate)
        {
            var result = _entities.AsQueryable()
                .Where(predicate)
                .ToList<T>();

            return Task.FromResult(result);    
        }

        public async Task<List<T>> Insert(List<T> entities)
        {
            var result = new List<T>();

            foreach (var entity in entities)
                result.Add(await Insert(entity));

            return result;
        }

        private int GetNextId()
        {
            var nextId = 1;
            if (_entities.Count == 0)
                return nextId;

            nextId =_entities.MaxBy(x => x.Id).Id + 1;
            
            return nextId;
        }

        public async Task<T> Insert(T entity)
        {
            entity.Id = GetNextId();

            _entities.Add(entity);

            return entity;
        }
    }
}
