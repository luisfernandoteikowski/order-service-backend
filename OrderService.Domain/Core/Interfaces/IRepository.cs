using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.Core.Interfaces
{
    public interface IRepository<T> :
        IRepositoryGet<T>
        where T : BaseEntity
    {
        
    }
}
