using ObjectiveC;

    /// <summary>
    /// Styles to apply to action buttons in an alert.
    /// </summary>
    public enum UIAlertActionStyle
    {
        /// <summary>
        /// Apply the default style to the action’s button.
        /// </summary>
        [iOSVersion(8)]
        Default,

        /// <summary>
        /// Apply a style that indicates the action cancels the operation and leaves things unchanged.
        /// </summary>
        [iOSVersion(8)]
        Cancel,

        /// <summary>
        /// Apply a style that indicates the action might change or delete data.
        /// </summary>
        [iOSVersion(8)]
        Destructive,
    }