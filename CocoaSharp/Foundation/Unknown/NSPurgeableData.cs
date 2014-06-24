using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSPurgeableData_Class/index.html#//apple_ref/occ/cl/NSPurgeableData    /// <summary>    /// You should use the NSPurgeableData class when you have objects with bytes that can be discarded when no longer needed. Purging these bytes may be advantageous for your system, because doing so frees up memory needed by other applications. The NSPurgeableData class provides a default implementation of the NSDiscardableContent protocol, from which it inherits its interface.    /// </summary>    [iOSVersion(4)]    public class NSPurgeableData : NSMutableData    {        //No implementation?    }}