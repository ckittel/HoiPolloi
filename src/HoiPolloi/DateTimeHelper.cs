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
            // Figure out the first day of the provided date's next month
            var firstDayOfProvidedMonth = FirstDayOfMonth(date);
            var firstDayOfNextMonth = new DateTime(firstDayOfProvidedMonth.Year, firstDayOfProvidedMonth.Month, 1);

            // then go back one day.
            return firstDayOfNextMonth.AddDays(-1);
        }

        /// <summary>
        /// Gets the first day of the month containing the provided date.
        /// </summary>
        public static DateTime FirstDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }
    }
}
