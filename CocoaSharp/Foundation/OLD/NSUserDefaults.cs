using ObjectiveC;

    /// <summary>
    /// This notification is posted when a change is made to defaults in a persistent domain.
    /// The notification object is the NSUserDefaults object. This notification does not contain a userInfo dictionary.
    /// </summary>
    [iOSVersion(2)]
    public class NSUserDefaultsDidChangeNotification : NSNotification
    {
        public NSUserDefaultsDidChangeNotification() : base("NSUserDefaultsDidChange", null) { }
    }

}