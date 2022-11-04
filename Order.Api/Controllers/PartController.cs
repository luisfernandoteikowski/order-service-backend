using Microsoft.AspNetCore.Mvc;
using Order.Api.Controllers.Core;
using Order.Application.Part;

namespace Order.Api.Controllers
{
    [ApiController]
    public class PartController : CustomController
    {
        [HttpGet]
        [Route("parts")]
        public async Task<IActionResult> Get([FromServices] IPartGetFacade partGetFacade)
        {
            return Result(await partGetFacade.Get());
        }
    }
}
