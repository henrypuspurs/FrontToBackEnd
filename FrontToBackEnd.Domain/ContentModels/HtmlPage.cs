namespace FrontToBackEnd.Domain.ContentModels;
public class HtmlPage : IWebContent
{
    public string Content { get; set; } = String.Empty;
    public string Mimetype { get; } = "text/html";
}
