using OrderService.Domain.Core.DTO;
using OrderService.Domain.Interface;

namespace OrderService.Domain.Services.Part
{
    public class PartUpdateService : IPartUpdateService
    {
        private readonly IPartRepository _repository;
        private readonly IPartGetService _partGetService;

        public PartUpdateService(IPartRepository repository, IPartGetService partGetService)
        {
            _repository = repository;
            _partGetService = partGetService;
        }

        public async Task<ServiceResult<bool>> DecreaseFromStock(int id, int quantity)
        {
            var result = new ServiceResult<bool>();
            var part = _partGetService.GetById(id).Result.Data;

            part.Quantity = part.Quantity - quantity;
            await _repository.Update(part);
            
            return result;
        }
    }
}
