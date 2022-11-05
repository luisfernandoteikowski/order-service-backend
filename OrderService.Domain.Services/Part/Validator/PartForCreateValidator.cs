using FluentValidation;
using OrderService.Domain.DTO;

namespace OrderService.Domain.Services.Part.Validator
{
    public class PartForCreateValidator : AbstractValidator<PartRequest>, IPartForCreateValidator
    {
        public PartForCreateValidator()
        {
            RuleFor(p => p.Description)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(p => p.Price)
                .GreaterThan(0);

            RuleFor(p => p.Quantity)
                .GreaterThan(0);
        }
    }
}
