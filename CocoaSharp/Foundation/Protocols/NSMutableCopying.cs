using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSMutableCopying protocol declares a method for providing mutable copies of an object. Only classes that define an “immutable vs. mutable” distinction should adopt this protocol. Classes that don’t define such a distinction should adopt NSCopying instead.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSMutableCopying_Protocol/index.html#//apple_ref/occ/intf/NSMutableCopying"/>    [iOSVersion(2)]    public interface NSMutableCopying//:    {        /// <summary>        /// Returns a new instance that’s a mutable copy of the receiver. (required)        /// </summary>        /// <param name="zone">The zone from which memory is allocated for the new instance.  If zone is NULL, the new instance is allocated from the default zone, which is returned by NSDefaultMallocZone.</param>        [iOSVersion(2)]        [Export("mutableCopyWithZone")]        AnyObject MutableCopyWithZone(NSZone zone);    }}