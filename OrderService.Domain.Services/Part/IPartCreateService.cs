using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Core;

namespace OrderService.Domain.Services.Part
{
    public interface IPartCreateService : IBaseService
    {
        Task<ServiceResult<PartResponse>> Create(PartRequest part);
    }
}
