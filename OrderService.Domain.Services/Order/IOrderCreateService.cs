using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Order
{
    public interface IOrderCreateService : IBaseService
    {
        Task<ServiceResult<OrderResponse>> Create(OrderRequest order);
    }
}
