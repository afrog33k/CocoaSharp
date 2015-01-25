using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIMutableUserNotificationAction object represents a modifiable version of the UIUserNotificationAction class. When a notification is delivered, the system displays a button for each custom action associated with the notification. Tapping a button launches your app (either in the foreground or background) and gives you a chance to perform the indicated action. You use this class to configure the details about the button that is displayed and the information your app needs to perform the corresponding action.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMutableUserNotificationAction_class/index.html#//apple_ref/occ/cl/UIMutableUserNotificationAction"/>    [iOSVersion(8)]    [Export("")]    public class UIMutableUserNotificationAction : UIUserNotificationAction//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding, Printable    {        public UIMutableUserNotificationAction() { }        /// <summary>        /// The string that you use internally to identify the action. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("identifier")]        [Unwrapped]        public string Identifier { get; set; }                /// <summary>        /// The localized string to use as the button title for the action. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("title")]        [Unwrapped]        public string Title { get; set; }                /// <summary>        /// The mode in which to run the app when the action is performed. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("activationMode")]        public UIUserNotificationActivationMode ActivationMode { get; set; }                /// <summary>        /// A Boolean value indicating whether the user must unlock the device before the action is performed. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("authenticationRequired")]        public bool AuthenticationRequired { get; set; }                /// <summary>        /// A Boolean value indicating whether the action is destructive. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("destructive")]        public bool Destructive { get; set; }    }}