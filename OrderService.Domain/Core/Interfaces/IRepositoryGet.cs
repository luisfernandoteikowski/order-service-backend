using OrderService.Domain.Core.Entities;
using System.Linq.Expressions;

namespace OrderService.Domain.Core.Interfaces
{
    public interface IRepositoryGet<T>
        where T : BaseEntity
    {
        Task<List<T>> Get();
        Task<List<T>> Get(Expression<Func<T, bool>> predicate);
    }
}
