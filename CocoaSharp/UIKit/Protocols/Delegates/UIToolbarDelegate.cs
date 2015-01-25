using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIToolbarDelegate protocol defines the interface that toolbar delegate objects implement to manage the toolbar behavior. This protocol declares no methods of its own but conforms to the UIBarPositioningDelegate protocol to support the positioning of a toolbar when it is moved to a window.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIToolbarDelegate_protocol/index.html#//apple_ref/occ/intf/UIToolbarDelegate"/>    [iOSVersion(7)]    [Export("")]    public interface UIToolbarDelegate//: NSObjectProtocol, UIBarPositioningDelegate    {    }}