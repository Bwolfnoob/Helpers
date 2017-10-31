using System.Globalization;

namespace Coffsy.Servicos.Helpers
{
    public static class StringExtensions
    {
        public static bool ContainsIgnoreCaseAndSymbols(this string source, string value)
        {
            var index = CultureInfo.InvariantCulture.CompareInfo.IndexOf
            (source, value, CompareOptions.IgnoreCase |
                            CompareOptions.IgnoreSymbols | CompareOptions.IgnoreNonSpace);
            return index != -1;
        }
    }
}
