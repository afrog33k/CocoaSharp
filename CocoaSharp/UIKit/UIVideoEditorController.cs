using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIVideoEditorController object, or video editor, manages the system-supplied user interface for trimming video frames from the start and end of a previously recorded movie as well as reencoding to lower quality. The object manages user interactions and provides the filesystem path of the edited movie to your delegate object (see UIVideoEditorControllerDelegate Protocol Reference). The features of the UIVideoEditorController class are available only on devices that support video recording.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIVideoEditorController_ClassReference/index.html#//apple_ref/occ/cl/UIVideoEditorController"/>    [iOSVersion(3.1)]    [Export("")]    public class UIVideoEditorController : UINavigationController//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSExtensionRequestHandling, NSObjectProtocol, Printable, UIAppearanceContainer, UIContentContainer, UIStateRestoring, UITraitEnvironment    {        public UIVideoEditorController() { }        /// <summary>        /// Returns a Boolean value indicating whether a video file can be edited.        /// </summary>        /// <param name="videoPath">The filesystem path to the video file you want to edit.</param>        [iOSVersion(3.1)]        [Export("canEditVideoAtPath")]        public static bool CanEditVideoAtPath(string videoPath) { return default(bool); }                /// <summary>        /// The video editor’s delegate object.        /// </summary>        [iOSVersion(3.1)]        [Export("delegate")]        public Protocol<UINavigationControllerDelegate, UIVideoEditorControllerDelegate> Delegate { get; set; }                /// <summary>        /// The maximum duration, in seconds, permitted for trimmed movies saved by the video editor.        /// </summary>        [iOSVersion(3.1)]        [Export("videoMaximumDuration")]        public NSTimeInterval VideoMaximumDuration { get; set; }                /// <summary>        /// The filesystem path to the movie to be loaded by the video editor.        /// </summary>        [iOSVersion(3.1)]        [Export("videoPath")]        public string VideoPath { get; set; }                /// <summary>        /// The video quality to use when saving a trimmed movie.        /// </summary>        [iOSVersion(3.1)]        [Export("videoQuality")]        public UIImagePickerControllerQualityType VideoQuality { get; set; }    }}