using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;
using OrderService.Domain.Core.DTO;

namespace OrderService.Domain.Services.Part
{
    public interface IPartGetService : IBaseService
    {
        Task<ServiceResult<IEnumerable<PartResponse>>> Get();
        Task<ServiceResult<bool>> IsAvailableInStock(int id, int quantity);
        Task<ServiceResult<Domain.Core.Entities.Part>> GetById(int id);
    }
}
