using System;

namespace HoiPolloi
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxChars)
        {
            return StringHelper.Truncate(value, maxChars);
        }
    }
}
