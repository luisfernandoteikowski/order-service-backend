using Microsoft.AspNetCore.Mvc;
using Order.Api.Controllers.Core;
using Order.Application.Part;
using OrderService.Domain.DTO;

namespace Order.Api.Controllers
{
    [ApiController]
    [Route("parts")]
    public class PartController : CustomController
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IPartGetFacade partGetFacade)
        {
            return Result(await partGetFacade.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IPartCreateFacade partCreateFacade, [FromBody] PartRequest request)
        {
            return Result(await partCreateFacade.Create(request));
        }
    }
}
