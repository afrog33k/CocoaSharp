using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSEnumerator is an abstract class, instances of whose subclasses enumerate collections of other objects, such as arrays and dictionaries.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSEnumerator_Class/index.html#//apple_ref/occ/cl/NSEnumerator"/>    [iOSVersion(2)]    [Export("")]    public class NSEnumerator : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSFastEnumeration, NSObjectProtocol, Printable    {        public NSEnumerator() { }        /// <summary>        /// Returns the next object from the collection being enumerated.        /// </summary>        [iOSVersion(2)]        [Export("nextObject")]        [return:Optional]        public virtual AnyObject NextObject() { return default(AnyObject); }                /// <summary>        /// The array of unenumerated objects. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("allObjects")]        public AnyObject[] AllObjects { get; private set; }    }}