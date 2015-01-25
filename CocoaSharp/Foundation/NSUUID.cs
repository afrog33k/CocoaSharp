using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSUUID class creates UUID strings that are to uniquely identify types, interfaces, and other items.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSUUID_Class/index.html#//apple_ref/occ/cl/NSUUID"/>    [iOSVersion(6)]    [Export("")]    public class NSUUID : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable    {        /// <summary>        /// Create and returns a new UUID with RFC 4122 version 4 random bytes.        /// </summary>        [iOSVersion(6)]        public NSUUID() { }                /// <summary>        /// Creates and returns a new UUID with the given bytes.        /// </summary>        /// <param name="UUIDBytes">Raw UUID bytes to use to create the UUID.</param>        [iOSVersion(6)]        [Export("convenience init")]        public NSUUID(UnsafePointer<UInt8> UUIDBytes) { }                /// <summary>        /// Returns the UUIDs bytes.        /// </summary>        /// <param name="uuid">The value of uuid represented as raw bytes.</param>        [iOSVersion(6)]        [Export("getUUIDBytes")]        public virtual void GetUUIDBytes(UnsafeMutablePointer<UInt8> uuid) {  }                /// <summary>        /// The UUID as a string. (read-only)        /// </summary>        [iOSVersion(6)]        public string UUIDString { get; private set; }    }}