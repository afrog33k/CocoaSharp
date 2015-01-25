using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSMetadataQueryResultGroup class represents a collection of grouped attribute results returned by an NSMetadataQuery object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMetadataQueryResultGroup_Class/index.html#//apple_ref/occ/cl/NSMetadataQueryResultGroup"/>    [iOSVersion(5)]    [Export("")]    public class NSMetadataQueryResultGroup : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public NSMetadataQueryResultGroup() { }        /// <summary>        /// Returns the query result at a specific index.        /// </summary>        /// <param name="index">The index of the desired result.</param>        [iOSVersion(5)]        [Export("resultAtIndex")]        [return:Unwrapped]        public virtual AnyObject ResultAtIndex(int index) { return default(AnyObject); }                /// <summary>        /// The result group’s attribute name. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("attribute")]        public string Attribute { get; private set; }                /// <summary>        /// The result group’s value. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("value")]        public AnyObject Value { get; private set; }                /// <summary>        /// An array containing the result group’s result objects. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("results")]        public AnyObject[] Results { get; private set; }                /// <summary>        /// The number of results returned by the result group. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("resultCount")]        public int ResultCount { get; private set; }                /// <summary>        /// An array containing the result group’s subgroups. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("subgroups")]        public AnyObject[] Subgroups { get; private set; }    }}