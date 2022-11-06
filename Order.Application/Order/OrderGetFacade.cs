using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Order;

namespace Order.Application.Order
{
    public class OrderGetFacade : IOrderGetFacade
    {
        private readonly IOrderGetService _service;

        public OrderGetFacade(IOrderGetService service)
        {
            _service = service;
        }

        public async Task<ServiceResult<IEnumerable<OrderResponse>>> Get()
        {
            return await _service.Get();
        }
    }
}
