using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Order;

namespace Order.Application.Order
{
    public class OrderCreateFacade : IOrderCreateFacade
    {
        private readonly IOrderCreateService _service;

        public OrderCreateFacade(IOrderCreateService service)
        {
            _service = service;
        }

        public async Task<ServiceResult<OrderResponse>> Create(OrderRequest order)
        {
            return await _service.Create(order);
        }
    }
}
