using ObjectiveC;

    /// <summary>
    /// Constants indicating how the app alerts the user when a local or push notification arrives.
    /// </summary>
    public enum UIUserNotificationType
    {
        /// <summary>
        /// The app does not present any UI upon receiving a notification.
        /// </summary>
        [iOSVersion(8)]
        None,

        /// <summary>
        /// The app badges its icon.
        /// </summary>
        [iOSVersion(8)]
        Badge,

        /// <summary>
        /// The app plays a sound.
        /// </summary>
        [iOSVersion(8)]
        Sound,

        /// <summary>
        /// The app posts an alert.
        /// </summary>
        [iOSVersion(8)]
        Alert,
    }