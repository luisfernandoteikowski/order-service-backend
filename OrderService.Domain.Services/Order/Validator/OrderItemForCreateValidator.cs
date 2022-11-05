using FluentValidation;
using OrderService.Domain.DTO;

namespace OrderService.Domain.Services.Order.Validator
{
    public class OrderItemForCreateValidator : AbstractValidator<OrderItemRequest>, IOrderItemForCreateValidator
    {
        public OrderItemForCreateValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Quantity)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
