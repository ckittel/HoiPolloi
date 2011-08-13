using System;
using System.Linq;

namespace HoiPolloi
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxChars)
        {
            return StringHelper.Truncate(value, maxChars);
        }

        public static string TrimAndTruncate(this string value, int maxChars)
        {
            return String.IsNullOrEmpty(value) ? value : Truncate(value.Trim(), maxChars);
        }

        public static bool IsUpperCase(this string value)
        {
            if (value == null) return false;

            return value.All(Char.IsUpper);
        }
    }
}
