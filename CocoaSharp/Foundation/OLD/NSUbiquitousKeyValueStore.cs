using ObjectiveC;

    /// <summary>
    /// !! IMPORTANT !! Early in your app’s launch sequence, register for the NSUbiquitousKeyValueStoreDidChangeExternallyNotification notification using the NSNotificationCenter class. Specify the default key-value store object (obtained using the defaultStore class method) as the object whose notifications you want to receive.
    /// 
    /// Posted when the value of one or more keys in the local key-value store changed due to incoming data pushed from iCloud.
    /// This notification is sent only upon a change received from iCloud; it is not sent when your app sets a value.
    /// The user info dictionary can contain the reason for the notification as well as a list of which values changed, as follows:
    ///     The value of the NSUbiquitousKeyValueStoreChangeReasonKey key, when present, indicates why the key-value store changed. Its value is one of the constants in Change Reason Values .
    ///     The value of the NSUbiquitousKeyValueStoreChangedKeysKey, when present, is an array of strings, each the name of a key whose value changed.
    /// The notification object is the NSUbiquitousKeyValueStore object whose contents changed.
    /// 
    /// </summary>
    [iOSVersion(5)]
    public class NSUbiquitousKeyValueStoreDidChangeExternallyNotification : NSNotification
    {
        public NSUbiquitousKeyValueStoreDidChangeExternallyNotification() : base("", null) { }
    }
