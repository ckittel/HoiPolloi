using System;

namespace HoiPolloi
{

    /// <summary>
    /// Contains common validations used to guard against bad data in methods
    /// </summary>
    public static class Guard
    {

        /// <summary>
        /// Check that the value is not null, otherwise throw <see cref="ArgumentNullException" />.
        /// </summary>
        public static void EnsureIsNotNull(object obj, string paramName)
        {
            EnsureIsNotNull(obj, "Value cannot be null", paramName);
        }

        /// <summary>
        /// Check that the value is not null, otherwise throw <see cref="ArgumentNullException" />.
        /// </summary>
        public static void EnsureIsNotNull(object obj, string message, string paramName)
        {
            if (obj == null)
                throw new ArgumentNullException(paramName, message);
        }

        /// <summary>
        /// Check that the value is not null, otherwise throw <see cref="ArgumentNullException" />.
        /// </summary>
        public static void EnsureIsNull(object obj, string paramName)
        {
            EnsureIsNull(obj, "Value must be null", paramName);
        }

        /// <summary>
        /// Check that the value is null, otherwise throw <see cref="ArgumentNullException" />.
        /// </summary>
        public static void EnsureIsNull(object obj, string message, string paramName)
        {
            if (obj != null)
                throw new ArgumentException(paramName, message);
        }

        /// <summary>
        /// Check that the value is true, otherwise throw <see cref="ArgumentException" />.
        /// </summary>
        public static void EnsureIsTrue(bool state, string paramName)
        {
            EnsureIsTrue(state, "Value must be true", paramName);
        }

        /// <summary>
        /// Check that the value is true, otherwise throw <see cref="ArgumentException" />.
        /// </summary>
        public static void EnsureIsTrue(bool state, string message, string paramName)
        {
            if (!state)
                throw new ArgumentException(message, paramName);
        }

        /// <summary>
        /// Check that the value is false, otherwise throw <see cref="ArgumentException" />.
        /// </summary>
        public static void EnsureIsFalse(bool state, string paramName)
        {
            EnsureIsFalse(state, "Value must be false", paramName);
        }

        /// <summary>
        /// Check that the value is false, otherwise throw <see cref="ArgumentException" />.
        /// </summary>
        public static void EnsureIsFalse(bool state, string message, string paramName)
        {
            if (state)
                throw new ArgumentException(message, paramName);
        }

    }
}
