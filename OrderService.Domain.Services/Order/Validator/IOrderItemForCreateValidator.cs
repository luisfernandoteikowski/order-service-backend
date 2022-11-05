using FluentValidation.Results;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Order.Validator
{
    public interface IOrderItemForCreateValidator : IBaseValidator
    {
        ValidationResult Validate(OrderItemRequest part);
    }
}
