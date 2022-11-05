using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Interface;

namespace OrderService.Domain.Services.Part
{
    public class PartGetService : IPartGetService
    {
        private readonly IPartRepository _repository;

        public PartGetService(IPartRepository repository)
        {
            _repository = repository;
        }

        public async Task<ServiceResult<IEnumerable<PartResponse>>> Get()
        {
            var result = new ServiceResult<IEnumerable<PartResponse>>();
            
            var part = await _repository.Get();
           
            result.Data = part.Select(x => new PartResponse(x)).ToList();
            
            return result;
        }

        public async Task<ServiceResult<Domain.Core.Entities.Part>> GetById(int id)
        {
            var result = new ServiceResult<Domain.Core.Entities.Part>();
            
            var part =  await _repository.Get(x => x.Id == id);
            result.Data = part.FirstOrDefault();
            
            return result;
        }

        public async Task<ServiceResult<bool>> IsAvailableInStock(int id, int quantity)
        {
            var result = new ServiceResult<bool>();
            
            var part = GetById(id).Result.Data;
            
            if (part != null && part.Quantity >= quantity)
                result.Data = true;
            
            return result;
        }
    }
}
