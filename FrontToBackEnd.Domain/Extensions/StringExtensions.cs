namespace FrontToBackEnd.Domain.Extensions;
public static class StringExtensions
{
    public static string Append(this string existing, string value)
        => existing += value;

    public static string Prepend(this string existing, string value)
        => value + existing;

    public static string Surround(this string existing, string prepend, string append)
        => prepend + existing + append;

    public static string Surround(this string existing, (string prepend, string append) pair)
        => pair.prepend + existing + pair.append;
}
