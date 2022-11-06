using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Interface;

namespace OrderService.Domain.Services.Order
{
    public class OrderGetService : IOrderGetService
    {
        private readonly IOrderRepository _repository;

        public OrderGetService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<ServiceResult<IEnumerable<OrderResponse>>> Get()
        {
            var result = new ServiceResult<IEnumerable<OrderResponse>>();
            OrderCalculateItemTotal _orderCalculateItemTotal = new OrderCalculateItemTotalWithoutFees(); 

            var orders = await _repository.Get();

            var ordersResponse = new List<OrderResponse>();
            
            foreach (var o in orders)
            {
                var order = new OrderResponse(o);
                _orderCalculateItemTotal.SetReponseItemTotal(order);
                ordersResponse.Add(order);
            }

            result.Data = ordersResponse;
            return result;
        }
    }
}
