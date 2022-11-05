using OrderService.Domain.Core.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Part
{
    public interface IPartUpdateService : IBaseService
    {
        Task<ServiceResult<bool>> DecreaseFromStock(int id, int quantity);
    }
}
