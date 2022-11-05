using FluentValidation.Results;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Part.Validator
{
    public interface IPartForCreateValidator : IBaseValidator
    {
        ValidationResult Validate(PartRequest part);
    }
}
