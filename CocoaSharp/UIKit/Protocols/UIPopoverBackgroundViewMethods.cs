using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIPopoverBackgroundViewMethods protocol defines methods that UIPopoverBackgroundView subclasses must implement. The methods in this protocol are called only once when the popover is presented. All methods of this protocol are required.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPopoverBackgroundViewMethods_protocol/index.html#//apple_ref/occ/intf/UIPopoverBackgroundViewMethods"/>    [iOSVersion(8)]    public interface UIPopoverBackgroundViewMethods//:    {        /// <summary>        /// The insets for the content portion of the popover. (required)        /// </summary>        //[iOSVersion(8)]        //[Export("contentViewInsets")]        //UIEdgeInsets ContentViewInsets();                /// <summary>        /// The width of the arrow triangle at its base. (required)        /// </summary>        //[iOSVersion(8)]        //[Export("arrowBase")]        //CGFloat ArrowBase();                /// <summary>        /// The height of the arrow (measured in points) from its base to its tip. (required)        /// </summary>        //[iOSVersion(8)]        //[Export("arrowHeight")]        //CGFloat ArrowHeight();    }}