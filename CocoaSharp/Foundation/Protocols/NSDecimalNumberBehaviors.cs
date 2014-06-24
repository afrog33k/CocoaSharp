using ObjectiveC;


    /// <summary>
    /// These constants specify rounding behaviors.
    /// </summary>
    public enum NSRoundingMode
    {
        /// <summary>
        /// Round to the closest possible return value; when caught halfway between two positive numbers, round up; when caught between two negative numbers, round down.
        /// </summary>
        [iOSVersion(2)]
        RoundPlain,

        /// <summary>
        /// Round return values down.
        /// </summary>
        [iOSVersion(2)]
        RoundDown,

        /// <summary>
        /// Round return values up.
        /// </summary>
        [iOSVersion(2)]
        RoundUp,

        /// <summary>
        /// Round to the closest possible return value; when halfway between two possibilities, return the possibility whose last digit is even.
        /// </summary>
        [iOSVersion(2)]
        RoundBankers,
    }
    /// <summary>
    /// Calculation error constants used to describe an error in exceptionDuringOperation:error:leftOperand:rightOperand:.
    /// </summary>
    public enum NSCalculationError
    {
        /// <summary>
        /// No error occurred.
        /// </summary>
        [iOSVersion(2)]
        NoError,

        /// <summary>
        /// The number can’t be represented in 38 significant digits.
        /// </summary>
        [iOSVersion(2)]
        LossOfPrecision,

        /// <summary>
        /// The number is too small to represent.
        /// </summary>
        [iOSVersion(2)]
        Underflow,

        /// <summary>
        /// The number is too large to represent.
        /// </summary>
        [iOSVersion(2)]
        Overflow,

        /// <summary>
        /// The caller tried to divide by 0.
        /// </summary>
        [iOSVersion(2)]
        DivideByZero,
    }