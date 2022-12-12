namespace FrontToBackEnd.Domain.ContentModels;
public class CssStyleSheet : IWebContent
{
    public string Content { get; set; } = String.Empty;
    public string Mimetype { get; } = "text/css";
}
