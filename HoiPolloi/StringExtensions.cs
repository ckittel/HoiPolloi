using System;

namespace HoiPolloi
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxLength)
        {
            if ((!String.IsNullOrEmpty(value)) && (value.Length > maxLength))
                return value.Substring(0, maxLength);

            return value;
        }
    }
}
