using FrontToBackEnd.Application.Common;
using FrontToBackEnd.Domain.ContentModels;
using Microsoft.AspNetCore.Mvc;

namespace MbhApi.WebApi.Controllers.Common;

public static class ResultBuilder
{
    public static ActionResult<ResponseModel> BuildActionResult(ResponseModel responseModel)
    {
        ActionResult<ResponseModel> result = responseModel.StatusCode switch
        {
            200 => new OkObjectResult(responseModel),
            201 => new ObjectResult(responseModel) { StatusCode = 201 },
            202 => new AcceptedResult(),
            400 => new BadRequestObjectResult(responseModel),
            401 => new UnauthorizedResult(),
            403 => new ForbidResult(),
            404 => new NotFoundObjectResult(responseModel),
            _ => new ObjectResult(responseModel) { StatusCode = responseModel.StatusCode },
        };

        return result;
    }

    public static ActionResult<ResponseModel<T>> BuildActionResult<T>(ResponseModel<T> responseModel)
    {
        ActionResult<ResponseModel<T>> result = responseModel.StatusCode switch
        {
            200 => new OkObjectResult(responseModel),
            201 => new ObjectResult(responseModel) { StatusCode = 201 },
            202 => new AcceptedResult(),
            400 => new BadRequestObjectResult(responseModel),
            401 => new UnauthorizedResult(),
            403 => new ForbidResult(),
            404 => new NotFoundObjectResult(responseModel),
            _ => new ObjectResult(responseModel) { StatusCode = responseModel.StatusCode },
        };

        return result;
    }

    public static ContentResult BuildContentResult<T>(ResponseModel<T> responseModel)
        where T : IWebContent
    {
        return new ContentResult()
        {
            Content = responseModel.Content.Content,
            ContentType = responseModel.Content.Mimetype,
            StatusCode = responseModel.StatusCode
        };
    }
}
