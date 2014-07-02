using ObjectiveC;
    /// <summary>
    /// The direction of a scrolling action.
    /// </summary>
    public enum UIAccessibilityScrollDirection
    {
        /// <summary>
        /// The user is scrolling to the right.
        /// </summary>
        [iOSVersion(4.2)]
        Right,

        /// <summary>
        /// The user is scrolling to the left.
        /// </summary>
        [iOSVersion(4.2)]
        Left,

        /// <summary>
        /// The user is scrolling up.
        /// </summary>
        [iOSVersion(4.2)]
        Up,

        /// <summary>
        /// The user is scrolling down.
        /// </summary>
        [iOSVersion(4.2)]
        Down,

        /// <summary>
        /// The user is scrolling to the next view in an ordered set of views.
        /// </summary>
        [iOSVersion(5)]
        Next,

        /// <summary>
        /// The user is scrolling to the previous view in an ordered set of views.
        /// </summary>
        [iOSVersion(5)]
        Previous,
    }