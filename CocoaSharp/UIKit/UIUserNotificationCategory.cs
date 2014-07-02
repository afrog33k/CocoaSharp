using ObjectiveC;

    /// <summary>
    /// Constants indicating the amount of space available for displaying actions in a notification.
    /// </summary>
    public enum UIUserNotificationActionContext
    {
        /// <summary>
        /// The default context for displaying the alert. In this context, the full UI is displayed for the notification’s alert. You may specify up to four custom actions in this context.
        /// </summary>
        [iOSVersion(8)]
        Default,

        /// <summary>
        /// A notification where space is minimal. In this context, a minimal UI is displayed for the notification’s alert. You may specify up to two custom actions in this context.
        /// </summary>
        [iOSVersion(8)]
        Minimal,
    }