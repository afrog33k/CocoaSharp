using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// UITapGestureRecognizer is a concrete subclass of UIGestureRecognizer that looks for single or multiple taps. For the gesture to be recognized, the specified number of fingers must tap the view a specified number of times.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITapGestureRecognizer_Class/index.html#//apple_ref/occ/cl/UITapGestureRecognizer"/>    [iOSVersion(3.2)]    [Export("")]    public class UITapGestureRecognizer : UIGestureRecognizer//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public UITapGestureRecognizer() { }        /// <summary>        /// The number of taps for the gesture to be recognized.        /// </summary>        [iOSVersion(3.2)]        [Export("numberOfTapsRequired")]        public int NumberOfTapsRequired { get; set; }                /// <summary>        /// The number of fingers required to tap for the gesture to be recognized.        /// </summary>        [iOSVersion(3.2)]        [Export("numberOfTouchesRequired")]        public int NumberOfTouchesRequired { get; set; }    }}