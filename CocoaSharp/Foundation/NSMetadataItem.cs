using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSMetadataItem class represents the metadata associated with a file, providing a simple interface to retrieve the available attribute names and values.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMetadataItem_Class/index.html#//apple_ref/occ/cl/NSMetadataItem"/>    [iOSVersion(5)]    public class NSMetadataItem : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Returns the receiver’s metadata attribute name specified by a given key.        /// </summary>        /// <param name="key">The name of a metadata attribute. See the “Constants” section for a list of possible keys.</param>        [iOSVersion(5)]        [Export("valueForAttribute")]        public AnyObject ValueForAttribute(string key) { return default(AnyObject); }                /// <summary>        /// Returns a dictionary containing the key-value pairs for the attribute names specified by a given array of keys.        /// </summary>        /// <param name="keys">An array containing NSString objects that specify the names of a metadata attributes. See the “Constants” section for a list of possible keys.</param>        [iOSVersion(5)]        [Export("valuesForAttributes")]        public Dictionary<NSObject, AnyObject> ValuesForAttributes(AnyObject[] keys) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// An array containing the attribute keys for the metadata item’s values. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("attributes")]        public AnyObject[] Attributes { get; private set; }    }}