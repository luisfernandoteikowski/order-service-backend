using OrderService.Domain.Core.Entities;
using OrderService.Infra.Core.Repositories;
using OrderService.Domain.Interface;

namespace OrderService.Infra.Repositories
{
    public class OrderRepository : InMemoryRepository<Order>, IOrderRepository
    {
    }
}
