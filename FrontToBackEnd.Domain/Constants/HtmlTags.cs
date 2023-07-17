namespace FrontToBackEnd.Domain.Constants;

internal static class HtmlTags
{
    public static (string open, string close) Html => GetTag(HtmlConstants.Html);
    public static (string open, string close) Body => GetTag(HtmlConstants.Body);
    public static (string open, string close) H1 => GetTag(HtmlConstants.H1);
    public static (string open, string close) H2 => GetTag(HtmlConstants.H2);
    public static (string open, string close) H3 => GetTag(HtmlConstants.H3);
    public static (string open, string close) H4 => GetTag(HtmlConstants.H4);
    public static (string open, string close) H5 => GetTag(HtmlConstants.H5);
    public static (string open, string close) H6 => GetTag(HtmlConstants.H6);
    public static (string open, string close) P => GetTag(HtmlConstants.P);
    public static (string open, string close) Div => GetTag(HtmlConstants.Div);
    public static (string open, string close) Span => GetTag(HtmlConstants.Span);
    public static (string open, string close) A => GetTag(HtmlConstants.A);
    public static (string open, string close) B => GetTag(HtmlConstants.B);
    public static (string open, string close) I => GetTag(HtmlConstants.I);
    public static (string open, string close) U => GetTag(HtmlConstants.U);
    public static (string open, string close) Br => GetTag(HtmlConstants.Br);
    public static (string open, string close) Hr => GetTag(HtmlConstants.Hr);
    public static (string open, string close) Img => GetTag(HtmlConstants.Img);
    public static (string open, string close) Ul => GetTag(HtmlConstants.Ul);
    public static (string open, string close) Ol => GetTag(HtmlConstants.Ol);
    public static (string open, string close) Li => GetTag(HtmlConstants.Li);
    public static (string open, string close) Dl => GetTag(HtmlConstants.Dl);
    public static (string open, string close) Dt => GetTag(HtmlConstants.Dt);
    public static (string open, string close) Dd => GetTag(HtmlConstants.Dd);
    public static (string open, string close) Table => GetTag(HtmlConstants.Table);
    public static (string open, string close) Thead => GetTag(HtmlConstants.Thead);
    public static (string open, string close) Tbody => GetTag(HtmlConstants.Tbody);
    public static (string open, string close) Tfoot => GetTag(HtmlConstants.Tfoot);
    public static (string open, string close) Tr => GetTag(HtmlConstants.Tr);
    public static (string open, string close) Th => GetTag(HtmlConstants.Th);
    public static (string open, string close) Td => GetTag(HtmlConstants.Td);
    public static (string open, string close) Caption => GetTag(HtmlConstants.Caption);
    public static (string open, string close) Col => GetTag(HtmlConstants.Col);
    public static (string open, string close) Colgroup => GetTag(HtmlConstants.Colgroup);
    public static (string open, string close) Form => GetTag(HtmlConstants.Form);
    public static (string open, string close) Input => GetTag(HtmlConstants.Input);
    public static (string open, string close) Textarea => GetTag(HtmlConstants.Textarea);
    public static (string open, string close) Button => GetTag(HtmlConstants.Button);
    public static (string open, string close) Select => GetTag(HtmlConstants.Select);
    public static (string open, string close) Option => GetTag(HtmlConstants.Option);
    public static (string open, string close) Optgroup => GetTag(HtmlConstants.Optgroup);
    public static (string open, string close) Label => GetTag(HtmlConstants.Label);
    public static (string open, string close) Fieldset => GetTag(HtmlConstants.Fieldset);
    public static (string open, string close) Legend => GetTag(HtmlConstants.Legend);
    public static (string open, string close) Script => GetTag(HtmlConstants.Script);
    public static (string open, string close) Noscript => GetTag(HtmlConstants.Noscript);
    public static (string open, string close) Style => GetTag(HtmlConstants.Style);
    public static (string open, string close) Link => GetTag(HtmlConstants.Link);
    public static (string open, string close) Meta => GetTag(HtmlConstants.Meta);
    public static (string open, string close) Base => GetTag(HtmlConstants.Base);
    public static (string open, string close) Head => GetTag(HtmlConstants.Head);
    public static (string open, string close) Title => GetTag(HtmlConstants.Title);
    public static (string open, string close) Address => GetTag(HtmlConstants.Address);
    public static (string open, string close) Article => GetTag(HtmlConstants.Article);
    public static (string open, string close) Aside => GetTag(HtmlConstants.Aside);
    public static (string open, string close) Footer => GetTag(HtmlConstants.Footer);
    public static (string open, string close) Header => GetTag(HtmlConstants.Header);

    private static (string open, string close) GetTag(string tag)
        => ($"<{tag}>", $"</{tag}>");
}
