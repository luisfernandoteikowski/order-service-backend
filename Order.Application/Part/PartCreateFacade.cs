using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Part;

namespace Order.Application.Part
{
    public class PartCreateFacade : IPartCreateFacade
    {
        private readonly IPartCreateService _service;

        public PartCreateFacade(IPartCreateService service)
        {
            _service = service;
        }

        public Task<ServiceResult<PartResponse>> Create(PartRequest part)
        {
            return _service.Create(part);
        }
    }
}
