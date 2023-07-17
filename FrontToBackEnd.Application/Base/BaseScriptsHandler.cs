using FrontToBackEnd.Application.Common;
using FrontToBackEnd.Domain.ContentModels;

namespace FrontToBackEnd.Application.Base;
public class BaseScriptsHandler
{
    public async Task<ResponseModel<JsScript>> Handle()
    {
        return ResponseModel.Ok(new JsScript() { Content = "alert('Hello World!');" });
    }
}
