namespace FrontToBackEnd.Domain.ContentModels;
public class JsScript : IWebContent
{
    public string Content { get; set; } = String.Empty;
    public string Mimetype { get; set; } = "text/javascript";
}
