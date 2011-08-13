using System;

namespace HoiPolloi
{
    public static class DateTimeExtensions
    {

        /// <summary>
        /// Gets if the provided date is the last day of the month.
        /// </summary>
        public static bool IsLastDayOfMonth(this DateTime date)
        {
            return date.Day == DateTimeHelper.LastDayOfMonth(date).Day;
        }

        /// <summary>
        /// Gets if the provided date is is a weekend.
        /// </summary>
        public static bool IsAWeekend(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Sunday || 
                   date.DayOfWeek == DayOfWeek.Saturday;
        }

    }
}
