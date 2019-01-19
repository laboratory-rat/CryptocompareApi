using System.Linq;

namespace MRCryptocompareClient.Tools.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// ThisIsExample => this_is_example
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToSnakeLowerCase(this string source) => string.Concat(source.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();

        /// <summary>
        /// ThisIsExample => thisIsExample
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToFirstLowerCase(this string source) => string.IsNullOrWhiteSpace(source) ? string.Empty : (source.Length == 1 ? source.ToLower() : source.Substring(0, 1).ToLower() + source.Substring(1, source.Length - 1));
    }
}
