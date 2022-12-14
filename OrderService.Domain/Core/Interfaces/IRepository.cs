using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.Core.Interfaces
{
    public interface IRepository<T> :
        IRepositoryGet<T>,
        IRepositoryInsert<T>,
        IRepositoryUpdate<T>
        where T : BaseEntity
    {
        
    }
}
