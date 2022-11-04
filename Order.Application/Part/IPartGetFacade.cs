using Order.Application.Core;
using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;

namespace Order.Application.Part
{
    public interface IPartGetFacade : IBaseFacade
    {
        Task<ServiceResult<IEnumerable<PartResponse>>> Get();
    }
}
