using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Interface;
using OrderService.Domain.Services.Part;

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

            var part = await _repository.Get();

            result.Data = part.Select(x => new OrderResponse(x)).ToList();

            return result;
        }
    }
}
