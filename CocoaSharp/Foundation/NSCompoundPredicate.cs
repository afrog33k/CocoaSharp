using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSCompoundPredicate is a subclass of NSPredicate used to represent logical “gate” operations (AND/OR/NOT) and comparison operations.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCompoundPredicate_Class/index.html#//apple_ref/occ/cl/NSCompoundPredicate"/>    [iOSVersion(3)]    [Export("")]    public class NSCompoundPredicate : NSPredicate//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable    {        public NSCompoundPredicate() { }        /// <summary>        /// Returns a new predicate formed by AND-ing the predicates in a given array.        /// </summary>        /// <param name="subpredicates">An array of NSPredicate objects.</param>        [iOSVersion(3)]        [Export("andPredicateWithSubpredicates")]        public static NSCompoundPredicate AndPredicateWithSubpredicates(AnyObject[] subpredicates) { return default(NSCompoundPredicate); }                /// <summary>        /// Returns a new predicate formed by NOT-ing a given predicate.        /// </summary>        /// <param name="predicate">A predicate.</param>        [iOSVersion(3)]        [Export("notPredicateWithSubpredicate")]        public static NSCompoundPredicate NotPredicateWithSubpredicate(NSPredicate predicate) { return default(NSCompoundPredicate); }                /// <summary>        /// Returns a new predicate formed by OR-ing the predicates in a given array.        /// </summary>        /// <param name="subpredicates">An array of NSPredicate objects.</param>        [iOSVersion(3)]        [Export("orPredicateWithSubpredicates")]        public static NSCompoundPredicate OrPredicateWithSubpredicates(AnyObject[] subpredicates) { return default(NSCompoundPredicate); }                /// <summary>        /// Returns the receiver initialized to a given type using predicates from a given array.        /// </summary>        /// <param name="type">The type of the new predicate.</param>        /// <param name="subpredicates">An array of NSPredicate objects.</param>        [iOSVersion(3)]        public NSCompoundPredicate(NSCompoundPredicateType type, AnyObject[] subpredicates) { }                /// <summary>        /// The predicate type for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("compoundPredicateType")]        public NSCompoundPredicateType CompoundPredicateType { get; private set; }                /// <summary>        /// The receiver’s subpredicates. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("subpredicates")]        public AnyObject[] Subpredicates { get; private set; }    }    /// <summary>    /// These constants describe the possible types of NSCompoundPredicate.    /// </summary>    public enum NSCompoundPredicateType    {        /// <summary>        /// A logical NOT predicate.        /// </summary>        [iOSVersion(3)]        NotPredicateType,        /// <summary>        /// A logical AND predicate.        /// </summary>        [iOSVersion(3)]        AndPredicateType,        /// <summary>        /// A logical OR predicate.        /// </summary>        [iOSVersion(3)]        OrPredicateType,    }}