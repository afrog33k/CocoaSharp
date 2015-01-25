using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSPortDelegate protocol defines the optional methods implemented by delegates of NSPort objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSPortDelegate_Protocol/index.html#//apple_ref/occ/intf/NSPortDelegate"/>    [iOSVersion(4)]    [Export("")]    public interface NSPortDelegate//: NSObjectProtocol    {        /// <summary>        /// Processes a given incoming message on the port.        /// </summary>        /// <param name="portMessage">An incoming port message.</param>        //[iOSVersion(2)]        //[Export("handlePortMessage")]        //[InheritOptional]        //void HandlePortMessage([Unwrapped] NSPortMessage portMessage);    }}