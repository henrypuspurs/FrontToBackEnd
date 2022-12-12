namespace FrontToBackEnd.Domain.ContentModels;

public interface IWebContent
{
    string Content { get; set; }
    string Mimetype { get; }
}