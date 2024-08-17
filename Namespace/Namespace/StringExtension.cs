namespace Namespace
{
    public static class StringExtension
    {
        public static string ToCapitalize(this string text)
        {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
        public static string ToCapitalize(this string text, string addedText)
        {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower() + addedText;
        }
    }
}
