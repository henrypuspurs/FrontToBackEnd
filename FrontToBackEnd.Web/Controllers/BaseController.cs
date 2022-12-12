using FrontToBackEnd.Application.Base;
using MbhApi.WebApi.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackEnd.Web.Controllers;
[ApiController, Route("")]
public class BaseController : ControllerBase
{
    [HttpGet]
    public async Task<ContentResult> GetIndex([FromServices] BasePageHandler handler)
        => ResultBuilder.BuildContentResult(await handler.Handle());
}
