using FrontToBackEnd.Application.Common;
using FrontToBackEnd.Domain.ContentModels;

namespace FrontToBackEnd.Application.Base;
public class BaseStylesHandler
{
    public BaseStylesHandler()
    {
    }

    public async Task<ResponseModel<CssStyleSheet>> Handle()
    {
        return ResponseModel.Ok(new CssStyleSheet() { Content = "h1 {font-family: Sans-serif;}" });
    }
}
