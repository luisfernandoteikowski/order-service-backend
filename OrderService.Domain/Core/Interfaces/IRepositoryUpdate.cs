using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.Core.Interfaces
{
    public interface IRepositoryUpdate<T>
        where T : BaseEntity
    {
        Task<T> Update(T entity);
    }
}
