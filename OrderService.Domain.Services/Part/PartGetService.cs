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
    }
}
