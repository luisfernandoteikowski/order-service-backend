using OrderService.Domain.Core.Entities;
using OrderService.Domain.Core.Interfaces;

namespace OrderService.Domain.Interface
{
    public interface IOrderRepository :
        IBaseRepository,
        IRepositoryGet<Order>,
        IRepositoryInsert<Order>
    {
    }
}
