using System.Text.RegularExpressions;

namespace BookStackApi.Core
{
    internal static class StringExtensions
    {
        public static string ToSnakeCase(this string s)
        {
            string input = s.Trim();
            Regex regex = new Regex("[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+");
            return string.Join("_", new object[1] { regex.Matches(input) }).ToLower();
        }

        public static string UrlSafe(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            return s.Replace("%", "%25").Replace("<", "%3C").Replace(">", "%3E")
                .Replace("#", "%23")
                .Replace("{", "%7B")
                .Replace("}", "%7D")
                .Replace("|", "%7C")
                .Replace("\\", "%5C")
                .Replace("^", "%5E")
                .Replace("~", "%7E")
                .Replace("[", "%5B")
                .Replace("]", "%5D")
                .Replace("`", "%60")
                .Replace(";", "%3B")
                .Replace("/", "%2F")
                .Replace("?", "%3F")
                .Replace(":", "%3A")
                .Replace("@", "%40")
                .Replace("=", "%3D")
                .Replace("&", "%26")
                .Replace("$", "%24");
        }
    }
}