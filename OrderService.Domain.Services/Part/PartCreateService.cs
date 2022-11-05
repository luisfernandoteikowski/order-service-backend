using FluentValidation.Results;
using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Interface;
using OrderService.Domain.Services.Part.Validator;

namespace OrderService.Domain.Services.Part
{
    public class PartCreateService : IPartCreateService
    {
        private readonly IPartRepository _repository;
        private readonly IPartForCreateValidator _validator;

        public PartCreateService(IPartRepository repository, IPartForCreateValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<ServiceResult<PartResponse>> Create(PartRequest part)
        {
            var result = new ServiceResult<PartResponse>();
            ValidationResult results = _validator.Validate(part);

            if (!results.IsValid)
            {
                result.AddErrors(results.Errors);
            }
            else
            {
                var newPart = await _repository.Insert(part.ToEntity());
                result.Data = new PartResponse(newPart);
            }

            return result;
        }
    }
}
