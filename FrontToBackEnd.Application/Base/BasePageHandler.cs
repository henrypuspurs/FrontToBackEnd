using FrontToBackEnd.Application.Common;
using FrontToBackEnd.Domain.Builders;
using FrontToBackEnd.Domain.ContentModels;

namespace FrontToBackEnd.Application.Base;
public class BasePageHandler
{
    public async Task<ResponseModel<HtmlPage>> Handle()
    {
        var page = new HtmlPageBuilder()
            .WithStyle("https://localhost:1337/styles")
            .WithScript("https://localhost:1337/scripts")
            .WithHeading("This is a heading!")
            .Build();

        return ResponseModel.Ok(page);
    }
}
