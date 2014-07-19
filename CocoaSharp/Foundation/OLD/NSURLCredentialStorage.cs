using ObjectiveC;


    /// <summary>
    /// This notification is posted when the set of stored credentials changes.
    /// The notification object is the NSURLCredentialStorage instance. This notification does not contain a userInfo dictionary.
    /// </summary>
    [iOSVersion(2)]
    public class NSURLCredentialStorageChangedNotification : NSNotification
    {
        public NSURLCredentialStorageChangedNotification() : base("NSURLCredentialStorageChanged", null) { }
    }