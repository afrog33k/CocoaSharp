using ObjectiveC;

    /// <summary>
    /// The direction of the swipe.
    /// </summary>
    public enum UISwipeGestureRecognizerDirection
    {
        /// <summary>
        /// The touch or touches swipe to the right. This direction is the default.
        /// </summary>
        [iOSVersion(3.2)]
        Right,

        /// <summary>
        /// The touch or touches swipe to the left.
        /// </summary>
        [iOSVersion(3.2)]
        Left,

        /// <summary>
        /// The touch or touches swipe upward.
        /// </summary>
        [iOSVersion(3.2)]
        Up,

        /// <summary>
        /// The touch or touches swipe downward.
        /// </summary>
        [iOSVersion(3.2)]
        Down,
    }