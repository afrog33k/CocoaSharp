using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// UILongPressGestureRecognizer is a concrete subclass of UIGestureRecognizer that looks for long-press gestures. The user must press one or more fingers on a view and hold them there for a minimum period of time before the action triggers. While down, the user’s fingers may not move more than a specified distance; if they move beyond the specified distance, the gesture fails.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UILongPressGestureRecognizer_Class/index.html#//apple_ref/occ/cl/UILongPressGestureRecognizer"/>    [iOSVersion(3.2)]    public class UILongPressGestureRecognizer : UIGestureRecognizer//, AnyObject, NSObjectProtocol    {        public UILongPressGestureRecognizer() { }        /// <summary>        /// The minimum period fingers must press on the view for the gesture to be recognized.        /// </summary>        [iOSVersion(3.2)]        [Export("minimumPressDuration")]        public CFTimeInterval MinimumPressDuration { get; set; }                /// <summary>        /// The number of fingers that must be pressed on the view for the gesture to be recognized.        /// </summary>        [iOSVersion(3.2)]        [Export("numberOfTouchesRequired")]        public int NumberOfTouchesRequired { get; set; }                /// <summary>        /// The number of taps on the view required for the gesture to be recognized.        /// </summary>        [iOSVersion(3.2)]        [Export("numberOfTapsRequired")]        public int NumberOfTapsRequired { get; set; }                /// <summary>        /// The maximum movement of the fingers on the view before the gesture fails.        /// </summary>        [iOSVersion(3.2)]        [Export("allowableMovement")]        public CGFloat AllowableMovement { get; set; }    }}