using ObjectiveC;

    /// <summary>
    /// Sent after the iCloud (“ubiquity”) identity has changed.
    /// When your app receives this notification, call the ubiquityIdentityToken method to obtain a token that represents the new ubiquity identity, or nil if the user has disabled iCloud. There is no userInfo dictionary.
    /// </summary>
    [iOSVersion(6)]
    public class NSUbiquityIdentityDidChangeNotification : NSNotification
    {
        public NSUbiquityIdentityDidChangeNotification() : base("", null) { }
    }