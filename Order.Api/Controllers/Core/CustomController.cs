using Microsoft.AspNetCore.Mvc;
using OrderService.Domain.Core.DTO;

namespace Order.Api.Controllers.Core
{
    public abstract class CustomController : ControllerBase
    {
        protected IActionResult Result(ServiceResult serviceResult)
        {
            var objectResult = new ObjectResult(serviceResult);
            objectResult.StatusCode = serviceResult.CodeId;
            return objectResult;
        }
    }
}
