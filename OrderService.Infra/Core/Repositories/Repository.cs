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
    }
}
