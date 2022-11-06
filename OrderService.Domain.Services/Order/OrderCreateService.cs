using FluentValidation.Results;
using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Interface;
using OrderService.Domain.Services.Order.Validator;
using OrderService.Domain.Services.Part;

namespace OrderService.Domain.Services.Order
{
    public class OrderCreateService : IOrderCreateService
    {
        private readonly IOrderRepository _repository;
        private readonly IPartGetService _partGetService;
        private readonly IPartUpdateService _partUpdateService;
        private readonly IOrderForCreateValidator _validator;

        public OrderCreateService(IOrderRepository repository,
            IPartGetService partGetService, 
            IPartUpdateService partUpdateService, 
            IOrderForCreateValidator validator)
        {
            _repository = repository;
            _partGetService = partGetService;
            _partUpdateService = partUpdateService;
            _validator = validator;
        }

        public async Task<ServiceResult<OrderResponse>> Create(OrderRequest request)
        {
            var result = new ServiceResult<OrderResponse>();
            ValidationResult results = _validator.Validate(request);
            OrderCalculateItemTotal _orderCalculateItemTotal = new OrderCalculateItemTotalWithoutFees();
            
            if (!results.IsValid)
            {
                result.AddErrors(results.Errors);
            }
            else
            {
                foreach (var part in request.Parts)
                {
                    var isAvailableInStock = await _partGetService.IsAvailableInStock(part.Id, part.Quantity);
                    var partData = _partGetService.GetById(part.Id).Result.Data;
                    part.SetData(partData.Description, partData.Price);

                    if (!isAvailableInStock.Data)
                    {
                        result.AddError($"Part {partData.Description}, unavailable in stock");
                    }
                }

                if(result.IsSuccess)
                {
                    var order = request.ToEntity();

                    foreach (var part in request.Parts)
                    {
                        await _partUpdateService.DecreaseFromStock(part.Id, part.Quantity);
                        order.Total += _orderCalculateItemTotal.CalculateItemTotal(part.Quantity, part.Price.GetValueOrDefault());
                    }

                    var newOrder = await _repository.Insert(order);
                    
                    var orderReponse = new OrderResponse(newOrder);
                    _orderCalculateItemTotal.SetReponseItemTotal(orderReponse);
                    
                    result.Data = orderReponse;
                }
            }

            return result;
        }
    }
}
