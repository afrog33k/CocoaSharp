using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIUserNotificationAction object represents a custom action that your app can perform in response to a remote or local notification. When a notification is delivered, the system displays a button for each custom action associated with the notification. Tapping a button launches your app (either in the foreground or background) and gives you a chance to perform the indicated action. You use this class to specify the text that is displayed in the button and the information your app needs to perform the corresponding action.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIUserNotificationAction_class/index.html#//apple_ref/occ/cl/UIUserNotificationAction"/>    [iOSVersion(8)]    public class UIUserNotificationAction : NSObject//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding    {        public UIUserNotificationAction() { }        /// <summary>        /// The string that you use internally to identify the action. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("identifier")]        public string Identifier { get; private set; }                /// <summary>        /// The localized string to use as the button title for the action. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("title")]        public string Title { get; private set; }                /// <summary>        /// The mode in which to run the app when the action is performed. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("activationMode")]        public UIUserNotificationActivationMode ActivationMode { get; private set; }                /// <summary>        /// A Boolean value indicating whether the user must unlock the device before the action is performed. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("authenticationRequired")]        public bool AuthenticationRequired { get; private set; }                /// <summary>        /// A Boolean value indicating whether the action is destructive. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("destructive")]        public bool Destructive { get; private set; }    }    /// <summary>    /// Constants indicating whether the app should activate to the foreground or background.    /// </summary>    [iOSVersion(8)]    public enum UIUserNotificationActivationMode    {        /// <summary>        /// Activate the app and put it in the foreground.        /// </summary>        [iOSVersion(8)]        Foreground,        /// <summary>        /// Activate the app and put it in the background. If the app is already in the foreground, it remains in the foreground.        /// </summary>        [iOSVersion(8)]        Background,    }}