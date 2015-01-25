using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSMetadataQueryDelegate protocol defines the optional methods implemented by delegates of NSMetadataQuery objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSMetadataQueryDelegate_Protocol/index.html#//apple_ref/occ/intf/NSMetadataQueryDelegate"/>    [iOSVersion(5)]    [Export("")]    public interface NSMetadataQueryDelegate//: NSObjectProtocol    {        /// <summary>        /// Implemented by the delegate to return a different object for a specific query result object.        /// </summary>        /// <param name="query">The query that produced the result object to replace.</param>        /// <param name="replacementObjectForResultObject">The query result object to replace.</param>        //[iOSVersion(5)]        //[Export("metadataQuery")]        //[InheritOptional]        //AnyObject MetadataQuery(NSMetadataQuery query, NSMetadataItem replacementObjectForResultObject);                /// <summary>        /// Implemented by the delegate to return a different value for a specific attribute.        /// </summary>        /// <param name="query">The query that produced the result object with attribute.</param>        /// <param name="replacementValueForAttribute">The attribute in question.</param>        /// <param name="value">The attribute value to replace.</param>        //[iOSVersion(5)]        //[Export("metadataQuery")]        //[InheritOptional]        //AnyObject MetadataQuery(NSMetadataQuery query, string replacementValueForAttribute, AnyObject value);    }}