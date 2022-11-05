using Order.Application.Core;
using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;

namespace Order.Application.Part
{
    public interface IPartCreateFacade : IBaseFacade
    {
        Task<ServiceResult<PartResponse>> Create(PartRequest part);
    }
}
