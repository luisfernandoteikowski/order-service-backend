using FluentValidation;
using OrderService.Domain.DTO;

namespace OrderService.Domain.Services.Order.Validator
{
    public class OrderForCreateValidator : AbstractValidator<OrderRequest>, IOrderForCreateValidator
    {
        public OrderForCreateValidator()
        {
            RuleFor(o => o.Parts)
                .NotEmpty();

            RuleForEach(o => o.Parts)
                .SetValidator(new OrderItemForCreateValidator());
        }
    }
}
