using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIBarPositioning protocol defines the ways that bars can be positioned on iOS devices. Bars can be positioned at the bottom of their enclosing view, at the top of their enclosing view, or at both the top of their enclosing view and also the top of the screen. In this last case, the bar will abut the status bar displayed by the system. Bars in this position need to have their background extend above their own frame to the top of the screen. This allows the background to show through the status bar.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIBarPositioning_Protocol/index.html#//apple_ref/occ/intf/UIBarPositioning"/>    [iOSVersion(7)]    [Export("")]    public interface UIBarPositioning//: NSObjectProtocol    {        /// <summary>        /// The position of the bar. (required)        /// </summary>        [iOSVersion(7)]        [Export("barPosition")]        UIBarPosition BarPosition { get; }    }    /// <summary>    /// Constants to specify metrics to use for appearance.    /// </summary>    public enum UIBarMetrics    {        /// <summary>        /// Specifies default metrics for the device.        /// </summary>        [iOSVersion(5)]        Default,        /// <summary>        ///         /// </summary>        Compact,        /// <summary>        /// Specifies default metrics for the device for bars with the prompt property, such as UINavigationBar and UISearchBar.        /// </summary>        [iOSVersion(7)]        DefaultPrompt,        /// <summary>        ///         /// </summary>        CompactPrompt,    }    /// <summary>    /// Constants to identify the position of a bar.    /// </summary>    public enum UIBarPosition    {        /// <summary>        /// Specifies that the position is unspecified.        /// </summary>        [iOSVersion(7)]        Any,        /// <summary>        /// Specifies that the bar is at the bottom of its containing view.        /// The system uses this as a hint to draw directional decoration accordingly. For example, any shadow would be drawn above the bar.        /// </summary>        [iOSVersion(7)]        Bottom,        /// <summary>        /// Specifies that the bar is at the top of its containing view.        /// The system uses this as a hint to draw directional decoration accordingly. For example, any shadow would be drawn below the bar.        /// Instances of UIToolbar do not appear with this position on iPhone, but they can on iPad.        /// </summary>        [iOSVersion(7)]        Top,        /// <summary>        /// Specifies that the bar is at the top of the screen, as well as its containing view.        /// Bars with this position draw their background extended upwards, allowing their background content to show through the status bar.        /// </summary>        [iOSVersion(7)]        TopAttached,    }}