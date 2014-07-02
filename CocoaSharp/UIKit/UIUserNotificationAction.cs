using ObjectiveC;

    /// <summary>
    /// Constants indicating whether the app should activate to the foreground or background.
    /// </summary>
    public enum UIUserNotificationActivationMode
    {
        /// <summary>
        /// Activate the app and put it in the foreground.
        /// </summary>
        [iOSVersion(8)]
        Foreground,

        /// <summary>
        /// Activate the app and put it in the background. If the app is already in the foreground, it remains in the foreground.
        /// </summary>
        [iOSVersion(8)]
        Background,
    }