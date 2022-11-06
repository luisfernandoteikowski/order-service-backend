using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Order
{
    public interface IOrderGetService : IBaseService
    {
        Task<ServiceResult<IEnumerable<OrderResponse>>> Get();
    }
}
