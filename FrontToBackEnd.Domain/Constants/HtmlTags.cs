namespace FrontToBackEnd.Domain.Constants;
internal static class HtmlTags
{
    private static readonly string _html = "html";
    private static readonly string _body = "body";
    private static readonly string _h1 = "h1";

    public static (string open, string close) Html { get => GetTag(_html); }
    public static (string open, string close) Body { get => GetTag(_body); }
    public static (string open, string close) H1 { get => GetTag(_h1); }

    private static (string open, string close) GetTag(string tag)
        => ($"<{tag}>", $"</{tag}>");
}
