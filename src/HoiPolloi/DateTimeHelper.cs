using System;

namespace HoiPolloi
{
    public static class DateTimeHelper
    {

        /// <summary>
        /// Gets the last day of the month containing the provided date.
        /// </summary>
        public static DateTime LastDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        /// <summary>
        /// Gets the first day of the month containing the provided date.
        /// </summary>
        public static DateTime FirstDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Gets the first day of the week containing the provided date.
        /// </summary>
        public static DateTime FirstDayOfWeek(DateTime date)
        {
            return date.AddDays(-((int)date.DayOfWeek));
        }
    }
}
