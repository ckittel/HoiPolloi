namespace HoiPolloi
{

    /// <summary>
    /// A rounding method
    /// </summary>
    public enum RoundingMethod
    {
        /// <summary>
        /// No rounding.
        /// </summary>
        None = 0,

        /// <summary>
        /// Asymmetric arithmetic rounding. 
        /// </summary>
        /// <remarks>
        /// This is the started taught method of rounding where .5 is always rounded up,
        /// otherwise round to nearest.
        /// 
        /// Examples:
        /// With a precision of 0: 4.5 -> 5
        /// With a precision of 0: 5.5 -> 6
        /// With a precision of 2: 4.435 -> 4.44
        /// With a precision of 2: 5.435 -> 5.44
        /// </remarks>
        Arithmetic,

        /// <summary>
        /// Unbiased rounding.
        /// </summary>
        /// <remarks>
        /// This is also known as round-to-even or banker's rounding.
        /// It always rounds .5 toward even.
        /// 
        /// Examples:
        /// With a precision of 0: 4.5 -> 4
        /// With a precision of 0: 5.5 -> 6
        /// With a precision of 2: 4.425 -> 4.42
        /// With a precision of 2: 5.435 -> 5.44
        /// </remarks>
        Unbiased,

        /// <summary>
        /// Round up.
        /// </summary>
        /// <remarks>
        /// This is typically known as ceiling a number.
        /// 
        /// Examples:
        /// With a precision of 0: 4.2 -> 5
        /// With a precision of 2: 4.222 -> 4.23
        /// </remarks>
        Up,

        /// <summary>
        /// Round down.
        /// </summary>
        /// <remarks>
        /// This is typically known as flooring or truncating a number.
        /// 
        /// Examples:
        /// With a precision of 0: 4.8 -> 4
        /// With a precision of 2: 4.228 -> 4.22
        /// </remarks>
        Down
    }
}
