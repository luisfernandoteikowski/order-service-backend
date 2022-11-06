using Order.Application.Core;
using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;

namespace Order.Application.Order
{
    public interface IOrderGetFacade : IBaseFacade
    {
        Task<ServiceResult<IEnumerable<OrderResponse>>> Get();
    }
}
