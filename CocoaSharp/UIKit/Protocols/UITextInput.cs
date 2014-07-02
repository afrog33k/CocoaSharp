using CoreGraphics;
using ObjectiveC;
    }

    /// <summary>
    /// The direction of text storage.
    /// </summary>
    public enum UITextStorageDirection
    {
        /// <summary>
        /// Storage of the text in a forward direction.
        /// </summary>
        [iOSVersion(3.2)]
        Forward,

        /// <summary>
        /// Storage of the text in a backward direction.
        /// </summary>
        [iOSVersion(3.2)]
        Backward,
    }

    /// <summary>
    /// The direction of text layout.
    /// </summary>
    public enum UITextLayoutDirection
    {
        /// <summary>
        /// Layout of the text to the right.
        /// </summary>
        [iOSVersion(3.2)]
        Right,

        /// <summary>
        /// Layout of the text to the left.
        /// </summary>
        [iOSVersion(3.2)]
        Left,

        /// <summary>
        /// Layout of the text in an upward direction.
        /// </summary>
        [iOSVersion(3.2)]
        Up,

        /// <summary>
        /// Layout of the text in a downward direction.
        /// </summary>
        [iOSVersion(3.2)]
        Down,
    }

    /// <summary>
    /// The writing direction of the text, based on language.
    /// </summary>
    public enum UITextWritingDirection
    {
        /// <summary>
        /// The natural writing direction as defined by the Bidi algorithm.
        /// </summary>
        [iOSVersion(3.2)]
        Natural,

        /// <summary>
        /// Writing that goes from left to right.
        /// </summary>
        [iOSVersion(3.2)]
        LeftToRight,

        /// <summary>
        /// Writing that goes from right to left.
        /// </summary>
        [iOSVersion(3.2)]
        RightToLeft,
    }