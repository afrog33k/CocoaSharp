using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// Use the iCloud key-value store to make preference, configuration, and app-state data available to every instance of your app on every device connected to a user’s iCloud account. You can store scalar values such as BOOL, as well as values containing any of the property list object types: NSNumber, NSString, NSDate, NSData, NSArray, and NSDictionary.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSUbiquitousKeyValueStore_class/index.html#//apple_ref/occ/cl/NSUbiquitousKeyValueStore"/>    [iOSVersion(5)]    [Export("")]    public class NSUbiquitousKeyValueStore : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public NSUbiquitousKeyValueStore() { }        /// <summary>        /// Returns the shared iCloud key-value store object.        /// </summary>        [iOSVersion(5)]        [Export("defaultStore")]        public static NSUbiquitousKeyValueStore DefaultStore() { return default(NSUbiquitousKeyValueStore); }                /// <summary>        /// Returns the array associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("arrayForKey")]        public virtual AnyObject[] ArrayForKey(string aKey) { return default(AnyObject[]); }                /// <summary>        /// Returns the Boolean value associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("boolForKey")]        public virtual bool BoolForKey(string aKey) { return default(bool); }                /// <summary>        /// Returns the data object associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("dataForKey")]        [return:Optional]        public virtual NSData DataForKey(string aKey) { return default(NSData); }                /// <summary>        /// Returns the dictionary object associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("dictionaryForKey")]        public virtual Dictionary<NSObject, AnyObject> DictionaryForKey(string aKey) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Returns the double value associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("doubleForKey")]        public virtual Double DoubleForKey(string aKey) { return default(Double); }                /// <summary>        /// Returns the long long value associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("longLongForKey")]        public virtual Int64 LongLongForKey(string aKey) { return default(Int64); }                /// <summary>        /// Returns the object associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("objectForKey")]        [return:Optional]        public virtual AnyObject ObjectForKey(string aKey) { return default(AnyObject); }                /// <summary>        /// Returns the string associated with the specified key.        /// </summary>        /// <param name="aKey">A key in the key-value store.</param>        [iOSVersion(5)]        [Export("stringForKey")]        [return:Optional]        public virtual string StringForKey(string aKey) { return default(string); }                /// <summary>        /// Sets an array object for the specified key in the key-value store.        /// </summary>        /// <param name="anArray">An array whose contents can be stored in a property list format. In other words, the objects in the array must be of the types NSNumber, NSString, NSDate, NSData, NSArray, or NSDictionary. The total size (in bytes) of the array and its contents must not exceed the per-key size limits.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setArray")]        public virtual void SetArray(AnyObject[] anArray, string forKey) {  }                /// <summary>        /// Sets a Boolean value for the specified key in the key-value store.        /// </summary>        /// <param name="value">The Boolean value to store.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.\</param>        [iOSVersion(5)]        [Export("setBool")]        public virtual void SetBool(bool value, string forKey) {  }                /// <summary>        /// Sets a data object for the specified key in the key-value store.        /// </summary>        /// <param name="aData">The data object to store. The total size of this data object (including any object overhead) must not exceed 1 MB.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setData")]        public virtual void SetData([Optional] NSData aData, string forKey) {  }                /// <summary>        /// Sets a dictionary object for the specified key in the key-value store.        /// </summary>        /// <param name="aDictionary">A dictionary whose contents can be stored in a property list format. In other words, the objects in the dictionary must be of the types NSNumber, NSString, NSDate, NSData, NSArray, or NSDictionary. The total size (in bytes) of the dictionary and its contents must not exceed the per-key size limits.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setDictionary")]        public virtual void SetDictionary(Dictionary<NSObject, AnyObject> aDictionary, string forKey) {  }                /// <summary>        /// Sets a double value for the specified key in the key-value store.        /// </summary>        /// <param name="value">The double value to store.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setDouble")]        public virtual void SetDouble(Double value, string forKey) {  }                /// <summary>        /// Sets a long long value for the specified key in the key-value store.        /// </summary>        /// <param name="value">The long long value to store.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setLongLong")]        public virtual void SetLongLong(Int64 value, string forKey) {  }                /// <summary>        /// Sets an object for the specified key in the key-value store.        /// </summary>        /// <param name="anObject">The object you want to store. The type of the object must be one of the property list types: NSNumber, NSString, NSDate, NSData, NSArray, or NSDictionary. The total size (in bytes) of the object must not exceed the per-key size limits.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setObject")]        public virtual void SetObject([Optional] AnyObject anObject, string forKey) {  }                /// <summary>        /// Sets a string object for the specified key in the key-value store.        /// </summary>        /// <param name="aString">The string you want to store. The total size (in bytes) of the string must not exceed the per-key size limits.</param>        /// <param name="forKey">The key under which to store the value. The length of this key must not exceed 64 bytes using UTF8 encoding.</param>        [iOSVersion(5)]        [Export("setString")]        public virtual void SetString([Optional] string aString, string forKey) {  }                /// <summary>        /// Explicitly synchronizes in-memory keys and values with those stored on disk.        /// </summary>        [iOSVersion(5)]        [Export("synchronize")]        public virtual bool Synchronize() { return default(bool); }                /// <summary>        /// Removes the value associated with the specified key from the key-value store.        /// </summary>        /// <param name="aKey">The key corresponding to the value you want to remove.</param>        [iOSVersion(5)]        [Export("removeObjectForKey")]        public virtual void RemoveObjectForKey(string aKey) {  }                /// <summary>        /// A dictionary containing all of the key-value pairs in the key-value store. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("dictionaryRepresentation")]        public Dictionary<NSObject, AnyObject> DictionaryRepresentation { get; private set; }                /// <summary>        /// Possible values associated with the NSUbiquitousKeyValueStoreChangeReasonKey key.        /// </summary>        public int NSUbiquitousKeyValueStoreServerChange { get; private set; }    }    /// <summary>    /// Posted when the value of one or more keys in the local key-value store changed due to incoming data pushed from iCloud.    ///   This notification is sent only upon a change received from iCloud; it is not sent when your app sets a value.    ///   The user info dictionary can contain the reason for the notification as well as a list of which values changed, as follows:    ///   The value of the NSUbiquitousKeyValueStoreChangeReasonKey key, when present, indicates why the key-value store changed. Its value is one of the constants in Change Reason Values .    ///   The value of the NSUbiquitousKeyValueStoreChangedKeysKey, when present, is an array of strings, each the name of a key whose value changed.    ///   The notification object is the NSUbiquitousKeyValueStore object whose contents changed.    ///     Important    ///     Early in your app’s launch sequence, register for the NSUbiquitousKeyValueStoreDidChangeExternallyNotification notification using the NSNotificationCenter class. Specify the default key-value store object (obtained using the defaultStore class method) as the object whose notifications you want to receive.    /// </summary>    public class NSUbiquitousKeyValueStoreDidChangeExternallyNotification : NSNotification    {        public NSUbiquitousKeyValueStoreDidChangeExternallyNotification() : base("", null) { }    }}