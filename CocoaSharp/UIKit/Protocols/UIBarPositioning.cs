using ObjectiveC;
    }

    /// <summary>
    /// Constants to specify metrics to use for appearance.
    /// </summary>
    public enum UIBarMetrics
    {
        /// <summary>
        /// Specifies default metrics for the device.
        /// </summary>
        [iOSVersion(5)]
        Default,
        Compact,
        Condensed,

        /// <summary>
        /// Specifies default metrics for the device for bars with the prompt property, such as UINavigationBar and UISearchBar.
        /// </summary>
        [iOSVersion(7)]
        DefaultPrompt,
        CompactPrompt,
    }
    /// <summary>
    /// Constants to identify the position of a bar.
    /// </summary>
    public enum UIBarPosition
    {
        /// <summary>
        /// Specifies that the position is unspecified.
        /// </summary>
        [iOSVersion(7)]
        Any,

        /// <summary>
        /// Specifies that the bar is at the bottom of its containing view.
        /// </summary>
        [iOSVersion(7)]
        Bottom,

        /// <summary>
        /// Specifies that the bar is at the top of its containing view.
        /// </summary>
        [iOSVersion(7)]
        Top,

        /// <summary>
        /// Specifies that the bar is at the top of the screen, as well as its containing view.
        /// </summary>
        [iOSVersion(7)]
        TopAttached,
    }