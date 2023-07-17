using FrontToBackEnd.Domain.Constants;
using FrontToBackEnd.Domain.ContentModels;
using FrontToBackEnd.Domain.Extensions;

namespace FrontToBackEnd.Domain.Builders;
public class HtmlPageBuilder
{
    private readonly string _doctype = "<!DOCTYPE html>";
    private HtmlPage _page = new();
    private string _styles = String.Empty;
    private string _scripts = String.Empty;

    public HtmlPageBuilder WithStyle(string stylesheet)
    {
        _styles = $"<link rel=\"stylesheet\" href=\"{stylesheet}\" />";

        return this;
    }
    
    public HtmlPageBuilder WithScript(string script)
    {
        _scripts = $"<script type=\"application/javascript\" src=\"{script}\"></script>";

        return this;
    }

    public HtmlPageBuilder WithHeading(string heading)
    {
        heading = heading.Surround(HtmlTags.H1);
        _page.Content = _page.Content.Append(heading);

        return this;
    }

    public HtmlPageBuilder WithParagraph(string paragraph)
    {
        paragraph = paragraph.Surround(HtmlTags.P);
        _page.Content = _page.Content.Append(paragraph);

        return this;
    }

    public HtmlPageBuilder WithDiv(string div)
    {
        div = div.Surround(HtmlTags.Div);
        _page.Content = _page.Content.Append(div);

        return this;
    }

    public HtmlPageBuilder WithSpan(string span)
    {
        span = span.Surround(HtmlTags.Span);
        _page.Content = _page.Content.Append(span);

        return this;
    }

    public HtmlPage Build()
    {
        _page.Content = _page.Content.Surround(HtmlTags.Body);
        _page.Content = _page.Content.Prepend($"<head>{_styles}{_scripts}</head>");
        _page.Content = _page.Content.Surround(HtmlTags.Html);
        _page.Content = _page.Content.Prepend(_doctype);
        return _page;
    }
}
