using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.Core.Interfaces
{
    public interface IRepositoryInsert<T>
        where T : BaseEntity
    {
        Task<T> Insert(T entity);
        Task<List<T>> Insert(List<T> entities);
    }
}
