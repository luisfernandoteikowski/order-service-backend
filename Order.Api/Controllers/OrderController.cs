using Microsoft.AspNetCore.Mvc;
using Order.Api.Controllers.Core;
using Order.Application.Order;
using OrderService.Domain.DTO;

namespace Order.Api.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : CustomController
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IOrderCreateFacade orderCreateFacade, [FromBody] OrderRequest request)
        {
            return Result(await orderCreateFacade.Create(request));
        }
    }
}
