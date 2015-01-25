using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSKeyValueCoding informal protocol defines a mechanism by which you can access the properties of an object indirectly by name (or key), rather than directly through invocation of an accessor method or as instance variables. Thus, all of an object’s properties can be accessed in a consistent manner.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSKeyValueCoding_Protocol/index.html#//apple_ref/doc/uid/TP40003780"/>    [iOSVersion(2)]    [Export("")]    public interface NSKeyValueCoding//:    {        /// <summary>        /// Returns the value for the property identified by a given key.        /// </summary>        /// <param name="key">The name of one of the receiver&#39;s properties.</param>        [iOSVersion(2)]        [Export("valueForKey")]        [return:Optional]        AnyObject ValueForKey(string key);                /// <summary>        /// Returns the value for the derived property identified by a given key path.        /// </summary>        /// <param name="keyPath">A key path of the form relationship.property (with one or more relationships); for example “department.name” or “department.manager.lastName”.</param>        [iOSVersion(2)]        [Export("valueForKeyPath")]        [return:Optional]        AnyObject ValueForKeyPath(string keyPath);                /// <summary>        /// Returns a dictionary containing the property values identified by each of the keys in a given array.        /// </summary>        /// <param name="keys">An array containing NSString objects that identify properties of the receiver.</param>        [iOSVersion(2)]        [Export("dictionaryWithValuesForKeys")]        Dictionary<NSObject, AnyObject> DictionaryWithValuesForKeys(AnyObject[] keys);                /// <summary>        /// Invoked by valueForKey: when it finds no property corresponding to a given key.        /// </summary>        /// <param name="key">A string that is not equal to the name of any of the receiver&#39;s properties.</param>        [iOSVersion(2)]        [Export("valueForUndefinedKey")]        [return:Optional]        AnyObject ValueForUndefinedKey(string key);                /// <summary>        /// Returns a mutable array proxy that provides read-write access to an ordered to-many relationship specified by a given key.        /// </summary>        /// <param name="key">The name of an ordered to-many relationship.</param>        [iOSVersion(2)]        [Export("mutableArrayValueForKey")]        NSMutableArray MutableArrayValueForKey(string key);                /// <summary>        /// Returns a mutable array that provides read-write access to the ordered to-many relationship specified by a given key path.        /// </summary>        /// <param name="keyPath">A key path, relative to the receiver, to an ordered to-many relationship.</param>        [iOSVersion(2)]        [Export("mutableArrayValueForKeyPath")]        NSMutableArray MutableArrayValueForKeyPath(string keyPath);                /// <summary>        /// Returns a mutable set proxy that provides read-write access to the unordered to-many relationship specified by a given key.        /// </summary>        /// <param name="key">The name of an unordered to-many relationship.</param>        [iOSVersion(2)]        [Export("mutableSetValueForKey")]        NSMutableSet MutableSetValueForKey(string key);                /// <summary>        /// Returns a mutable set that provides read-write access to the unordered to-many relationship specified by a given key path.        /// </summary>        /// <param name="keyPath">A key path, relative to the receiver, to an unordered to-many relationship.</param>        [iOSVersion(2)]        [Export("mutableSetValueForKeyPath")]        NSMutableSet MutableSetValueForKeyPath(string keyPath);                /// <summary>        /// Returns a mutable ordered set that provides read-write access to the uniquing ordered to-many relationship specified by a given key.        /// </summary>        /// <param name="key">The name of a uniquing ordered to-many relationship.</param>        [iOSVersion(5)]        [Export("mutableOrderedSetValueForKey")]        NSMutableOrderedSet MutableOrderedSetValueForKey(string key);                /// <summary>        /// Returns a mutable ordered set that provides read-write access to the uniquing ordered to-many relationship specified by a given key path.        /// </summary>        /// <param name="keyPath">A key path, relative to the receiver, to a uniquing ordered to-many relationship represented by a set.</param>        [iOSVersion(5)]        [Export("mutableOrderedSetValueForKeyPath")]        NSMutableOrderedSet MutableOrderedSetValueForKeyPath(string keyPath);                /// <summary>        /// Sets the value for the property identified by a given key path to a given value.        /// </summary>        /// <param name="value">The value for the property identified by keyPath.</param>        /// <param name="forKeyPath">A key path of the form relationship.property (with one or more relationships): for example “department.name” or “department.manager.lastName.”</param>        [iOSVersion(2)]        [Export("setValue")]        void SetValue([Optional] AnyObject value, string forKeyPath);                /// <summary>        /// Sets properties of the receiver with values from a given dictionary, using its keys to identify the properties.        /// </summary>        /// <param name="keyedValues">A dictionary whose keys identify properties in the receiver. The values of the properties in the receiver are set to the corresponding values in the dictionary.</param>        [iOSVersion(2)]        [Export("setValuesForKeysWithDictionary")]        void SetValuesForKeysWithDictionary(Dictionary<NSObject, AnyObject> keyedValues);                /// <summary>        /// Invoked by setValue:forKey: when it’s given a nil value for a scalar value (such as an int or float).        /// </summary>        /// <param name="key">The name of one of the receiver&#39;s properties.</param>        [iOSVersion(2)]        [Export("setNilValueForKey")]        void SetNilValueForKey(string key);                /// <summary>        /// Sets the property of the receiver specified by a given key to a given value.        /// </summary>        /// <param name="value">The value for the property identified by key.</param>        /// <param name="forKey">The name of one of the receiver&#39;s properties.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("setValue")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void SetValue([Optional] AnyObject value, string forKey, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Invoked by setValue:forKey: when it finds no property for a given key.        /// </summary>        /// <param name="value">The value for the key identified by key.</param>        /// <param name="forUndefinedKey">A string that is not equal to the name of any of the receiver&#39;s properties.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("setValue")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void SetValue([Optional] AnyObject value, string forUndefinedKey, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Returns a Boolean value that indicates whether the key-value coding methods should access the corresponding instance variable directly on finding no accessor method for a property.        /// </summary>        //[iOSVersion(2)]        //[Export("accessInstanceVariablesDirectly")]        //bool AccessInstanceVariablesDirectly();                /// <summary>        /// Returns a Boolean value that indicates whether the value specified by a given pointer is valid for the property identified by a given key.        /// </summary>        /// <param name="ioValue">A pointer to a new value for the property identified by key. This method may modify or replace the value in order to make it valid.</param>        /// <param name="forKey">The name of one of the receiver&#39;s properties. The key must specify an attribute or a to-one relationship.</param>        /// <param name="error">If validation is necessary and ioValue is not transformed into a valid value, upon return contains an NSError object that describes the reason that ioValue is not a valid value.</param>        [iOSVersion(2)]        [Export("validateValue")]        bool ValidateValue(AutoreleasingUnsafeMutablePointer<AnyObject> ioValue, string forKey, NSErrorPointer error);                /// <summary>        /// Returns a Boolean value that indicates whether the value specified by a given pointer is valid for a given key path relative to the receiver.        /// </summary>        /// <param name="ioValue">A pointer to a new value for the property identified by keyPath. This method may modify or replace the value in order to make it valid.</param>        /// <param name="forKeyPath">The name of one of the receiver&#39;s properties. The key path must specify an attribute or a to-one relationship. The key path has the form relationship.property (with one or more relationships); for example “department.name” or “department.manager.lastName”.</param>        /// <param name="error">If validation is necessary and ioValue is not transformed into a valid value, upon return contains an NSError object that describes the reason that ioValue is not a valid value.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("validateValue")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        bool ValidateValue(AutoreleasingUnsafeMutablePointer<AnyObject> ioValue, string forKeyPath, NSErrorPointer error, bool NAME_YOUR_PARAMS = false);    }}