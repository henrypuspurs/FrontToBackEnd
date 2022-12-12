using FrontToBackEnd.Domain.Constants;
using FrontToBackEnd.Domain.ContentModels;
using FrontToBackEnd.Domain.Extensions;

namespace FrontToBackEnd.Domain.Builders;
public class HtmlPageBuilder
{
    private readonly string _doctype = "<!DOCTYPE html>";
    private HtmlPage _page = new();
    private string _styles = String.Empty;

    public HtmlPageBuilder WithStyle(string stylesheet)
    {
        _styles = $"<link rel=\"stylesheet\" href=\"{stylesheet}\" />";

        return this;
    }

    public HtmlPageBuilder WithHeading(string heading)
    {
        heading = heading.Surround(HtmlTags.H1);
        _page.Content = _page.Content.Append(heading);

        return this;
    }

    public HtmlPage Build()
    {
        _page.Content = _page.Content.Surround(HtmlTags.Body);
        _page.Content = _page.Content.Prepend($"<head>{_styles}</head>");
        _page.Content = _page.Content.Surround(HtmlTags.Html);
        _page.Content = _page.Content.Prepend(_doctype);
        return _page;
    }
}
