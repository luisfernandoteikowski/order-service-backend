using OrderService.Domain.Core.DTO;
using OrderService.Domain.DTO;
using OrderService.Domain.Services.Part;

namespace Order.Application.Part
{
    public class PartGetFacade : IPartGetFacade
    {
        private readonly IPartGetService _service;

        public PartGetFacade(IPartGetService service    )
        {
            _service = service;
        }

        public async Task<ServiceResult<IEnumerable<PartResponse>>> Get()
        {
            return await _service.Get();
        }
    }
}
