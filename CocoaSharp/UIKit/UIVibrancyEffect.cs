using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIVibrancyEffect object amplifies and adjusts the color of the content layered behind a UIVisualEffectView object, allowing the content placed inside of the contentView to become more vivid. A vibrancy effect is intended to be used as a subview of or layered on top of a UIVisualEffectView that has been configured with a UIBlurEffect.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIVibrancyEffect/index.html#//apple_ref/occ/cl/UIVibrancyEffect"/>    [iOSVersion(8)]    [Export("")]    public class UIVibrancyEffect : UIVisualEffect//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable    {        public UIVibrancyEffect() { }        /// <summary>        /// Creates a vibrancy effect for a specific blur effect.        /// </summary>        /// <param name="forBlurEffect">The UIBlurEffect used by the blurred view the vibrancy effect is attached to.</param>        [iOSVersion(8)]        public UIVibrancyEffect(UIBlurEffect forBlurEffect) { }                /// <summary>        /// Creates a vibrancy effect for use in Notification Center.        /// </summary>        [iOSVersion(8)]        [Export("notificationCenterVibrancyEffect")]        [return:Unwrapped]        public static UIVibrancyEffect NotificationCenterVibrancyEffect() { return default(UIVibrancyEffect); }    }}