using FluentValidation.Results;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Order.Validator
{
    public interface IOrderForCreateValidator : IBaseValidator
    {
        ValidationResult Validate(OrderRequest part);
    }
}