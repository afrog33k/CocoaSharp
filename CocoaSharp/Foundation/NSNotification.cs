using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSNotification objects encapsulate information so that it can be broadcast to other objects by an NSNotificationCenter object. An NSNotification object (referred to as a notification) contains a name, an object, and an optional dictionary. The name is a tag identifying the notification. The object is any object that the poster of the notification wants to send to observers of that notification (typically, it is the object that posted the notification). The dictionary stores other related objects, if any. NSNotification objects are immutable objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNotification_Class/index.html#//apple_ref/occ/cl/NSNotification"/>    [iOSVersion(2)]    public class NSNotification : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// Returns a new notification object with a specified name and object.        /// </summary>        /// <param name="name">The name for the new notification. May not be nil.</param>        /// <param name="@object">The object for the new notification.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSNotification(string name, AnyObject @object) { }                /// <summary>        /// Initializes a notification with a specified name, object, and user information.        /// </summary>        /// <param name="name">The name for the new notification. May not be nil.</param>        /// <param name="@object">The object for the new notification.</param>        /// <param name="userInfo">The user information dictionary for the new notification. May be nil.</param>        [iOSVersion(4)]        public NSNotification(string name, AnyObject @object, Dictionary<NSObject, AnyObject> userInfo) { }                /// <summary>        /// The name of the notification. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("name")]        public string Name { get; private set; }                /// <summary>        /// The object associated with the notification. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("object")]        public AnyObject Object { get; private set; }                /// <summary>        /// The user information dictionary associated with the receiver. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("userInfo")]        public Dictionary<NSObject, AnyObject> UserInfo { get; private set; }    }}