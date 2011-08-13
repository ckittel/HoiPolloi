namespace HoiPolloi
{
    public static class IntegerExtensions
    {

        /// <summary>
        /// Gets if the number is even.
        /// </summary>
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Gets if the number is odd.
        /// </summary>
        public static bool IsOdd(this int number)
        {
            return !IsEven(number);
        }

    }
}
