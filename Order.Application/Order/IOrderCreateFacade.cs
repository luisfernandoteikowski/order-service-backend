using Order.Application.Core;
using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;

namespace Order.Application.Order
{
    public interface IOrderCreateFacade : IBaseFacade
    {
        Task<ServiceResult<OrderResponse>> Create(OrderRequest order);
    }
}
