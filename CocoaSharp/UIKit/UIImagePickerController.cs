using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIImagePickerController class manages customizable, system-supplied user interfaces for taking pictures and movies on supported devices, and for choosing saved images and movies for use in your app. An image picker controller manages user interactions and delivers the results of those interactions to a delegate object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIImagePickerController_Class/index.html#//apple_ref/occ/cl/UIImagePickerController"/>    [iOSVersion(2)]    public class UIImagePickerController : UINavigationController//, AnyObject, NSCoding, NSExtensionRequestHandling, NSObjectProtocol, UIAppearanceContainer, UIContentContainer, UIStateRestoring, UITraitEnvironment    {        /// <summary>        /// Returns an array of the available media types for the specified source type.        /// </summary>        /// <param name="sourceType">The source to use to pick an image.</param>        [iOSVersion(3)]        [Export("availableMediaTypesForSourceType")]        public static AnyObject[] AvailableMediaTypesForSourceType(UIImagePickerControllerSourceType sourceType) { return default(AnyObject[]); }                /// <summary>        /// Returns a Boolean value indicating whether the device supports picking media using the specified source type.        /// </summary>        /// <param name="sourceType">The source to use to pick an image or movie.</param>        [iOSVersion(2)]        [Export("isSourceTypeAvailable")]        public static bool IsSourceTypeAvailable(UIImagePickerControllerSourceType sourceType) { return default(bool); }                /// <summary>        /// Captures a still image using the camera.        /// </summary>        [iOSVersion(3.1)]        [Export("takePicture")]        public void TakePicture() {  }                /// <summary>        /// Starts video capture using the camera specified by the UIImagePickerControllerCameraDevice property.        /// </summary>        [iOSVersion(4)]        [Export("startVideoCapture")]        public bool StartVideoCapture() { return default(bool); }                /// <summary>        /// Stops video capture.        /// </summary>        [iOSVersion(4)]        [Export("stopVideoCapture")]        public void StopVideoCapture() {  }                /// <summary>        /// Returns a Boolean value that indicates whether a given camera is available.        /// </summary>        /// <param name="cameraDevice">A UIImagePickerControllerCameraDevice constant indicating the camera whose availability you want to check.</param>        [iOSVersion(4)]        [Export("isCameraDeviceAvailable")]        public static bool IsCameraDeviceAvailable(UIImagePickerControllerCameraDevice cameraDevice) { return default(bool); }                /// <summary>        /// Returns an array of NSNumber objects indicating the capture modes supported by a given camera device.        /// </summary>        /// <param name="cameraDevice">A UIImagePickerControllerCameraDevice constant indicating the camera you want to interrogate.</param>        [iOSVersion(4)]        [Export("availableCaptureModesForCameraDevice")]        public static AnyObject[] AvailableCaptureModesForCameraDevice(UIImagePickerControllerCameraDevice cameraDevice) { return default(AnyObject[]); }                /// <summary>        /// Indicates whether a given camera has flash illumination capability.        /// </summary>        /// <param name="cameraDevice">A UIImagePickerControllerCameraDevice constant indicating the camera whose flash capability you want to know.</param>        [iOSVersion(4)]        [Export("isFlashAvailableForCameraDevice")]        public static bool IsFlashAvailableForCameraDevice(UIImagePickerControllerCameraDevice cameraDevice) { return default(bool); }                /// <summary>        /// The type of picker interface to be displayed by the controller.        /// </summary>        [iOSVersion(2)]        [Export("sourceType")]        public UIImagePickerControllerSourceType SourceType { get; set; }                /// <summary>        /// A Boolean value indicating whether the user is allowed to edit a selected still image or movie.        /// </summary>        [iOSVersion(3.1)]        [Export("allowsEditing")]        public bool AllowsEditing { get; set; }                /// <summary>        /// The image picker’s delegate object.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public protocol<UIImagePickerControllerDelegate, UINavigationControllerDelegate> Delegate { get; set; }                /// <summary>        /// An array indicating the media types to be accessed by the media picker controller.        /// </summary>        [iOSVersion(3)]        [Export("mediaTypes")]        public AnyObject[] MediaTypes { get; set; }                /// <summary>        /// The video recording and transcoding quality.        /// </summary>        [iOSVersion(3.1)]        [Export("videoQuality")]        public UIImagePickerControllerQualityType VideoQuality { get; set; }                /// <summary>        /// The maximum duration, in seconds, for a video recording.        /// </summary>        [iOSVersion(3.1)]        [Export("videoMaximumDuration")]        public NSTimeInterval VideoMaximumDuration { get; set; }                /// <summary>        /// Indicates whether the image picker displays the default camera controls.        /// </summary>        [iOSVersion(3.1)]        [Export("showsCameraControls")]        public bool ShowsCameraControls { get; set; }                /// <summary>        /// The view to display on top of the default image picker interface.        /// </summary>        [iOSVersion(3.1)]        [Export("cameraOverlayView")]        public UIView CameraOverlayView { get; set; }                /// <summary>        /// The transform to apply to the camera’s preview image.        /// </summary>        [iOSVersion(3.1)]        [Export("cameraViewTransform")]        public CGAffineTransform CameraViewTransform { get; set; }                /// <summary>        /// The camera used by the image picker controller.        /// </summary>        [iOSVersion(4)]        [Export("cameraDevice")]        public UIImagePickerControllerCameraDevice CameraDevice { get; set; }                /// <summary>        /// The capture mode used by the camera.        /// </summary>        [iOSVersion(4)]        [Export("cameraCaptureMode")]        public UIImagePickerControllerCameraCaptureMode CameraCaptureMode { get; set; }                /// <summary>        /// The flash mode used by the active camera.        /// </summary>        [iOSVersion(4)]        [Export("cameraFlashMode")]        public UIImagePickerControllerCameraFlashMode CameraFlashMode { get; set; }    }    /// <summary>    /// The source to use when picking an image or when determining available media types.    /// </summary>    [iOSVersion(2)]    public enum UIImagePickerControllerSourceType    {        /// <summary>        /// Specifies the device’s photo library as the source for the image picker controller.        /// </summary>        [iOSVersion(2)]        PhotoLibrary,        /// <summary>        /// Specifies the device’s built-in camera as the source for the image picker controller. Indicate the specific camera you want (front or rear, as available) by using the cameraDevice property.        /// </summary>        [iOSVersion(2)]        Camera,        /// <summary>        /// Specifies the device’s Camera Roll album as the source for the image picker controller. If the device does not have a camera, specifies the Saved Photos album as the source.        /// </summary>        [iOSVersion(2)]        SavedPhotosAlbum,    }    /// <summary>    /// Video quality settings for movies recorded with the built-in camera, or transcoded by displaying in the image picker.    /// </summary>    [iOSVersion(3.1)]    public enum UIImagePickerControllerQualityType    {        /// <summary>        /// If recording, specifies that you want to use the highest-quality video recording supported for the active camera on the device.        /// Recorded files are suitable for on-device playback and for wired transfer to the Desktop using Image Capture; they are likely to be too large for transfer using Wi-Fi.        /// If displaying a recorded movie in the image picker, specifies that you do not want to reduce the video quality of the movie.        /// </summary>        [iOSVersion(3.1)]        TypeHigh,        /// <summary>        /// If recording, specifies that you want to use medium-quality video recording.        /// Recorded files can usually be transferred using Wi-Fi. This is the default video quality setting.        /// If displaying a recorded movie in the image picker, specifies that you want to transcode higher-quality movies to medium video quality.        /// </summary>        [iOSVersion(3.1)]        TypeMedium,        /// <summary>        /// If recording, specifies that you want to use low-quality video recording.        /// Recorded files can usually be transferred over the cellular network.        /// If displaying a recorded movie in the image picker, specifies that you want to transcode higher-quality movies to low video quality.        /// </summary>        [iOSVersion(3.1)]        TypeLow,        /// <summary>        /// If recording, specifies that you want to use VGA-quality video recording (pixel dimensions of 640x480).        /// If displaying a recorded movie in the image picker, specifies that you want to transcode higher-quality movies to VGA video quality.        /// </summary>        [iOSVersion(4)]        Type640x480,        /// <summary>        /// If recording, specifies that you want to use 1280x720 iFrame format.        /// The Apple iFrame format supports video editing by keeping content in its native recorded format while editing.        /// </summary>        [iOSVersion(5)]        TypeIFrame1280x720,        /// <summary>        /// If recording, specifies that you want to use 960x540 iFrame format.        /// The Apple iFrame format supports video editing by keeping content in its native recorded format while editing.        /// </summary>        [iOSVersion(5)]        TypeIFrame960x540,    }    /// <summary>    /// The camera to use for image or movie capture.    /// </summary>    [iOSVersion(4)]    public enum UIImagePickerControllerCameraDevice    {        /// <summary>        /// Specifies the camera on the rear of the device.        /// </summary>        [iOSVersion(4)]        Rear,        /// <summary>        /// Specifies the camera on the front of the device.        /// </summary>        [iOSVersion(4)]        Front,    }    /// <summary>    /// The category of media for the camera to capture.    /// </summary>    [iOSVersion(4)]    public enum UIImagePickerControllerCameraCaptureMode    {        /// <summary>        /// Specifies that the camera captures still images.        /// </summary>        [iOSVersion(4)]        Photo,        /// <summary>        /// Specifies that the camera captures movies.        /// </summary>        [iOSVersion(4)]        Video,    }    /// <summary>    /// The flash mode to use with the active camera.    /// </summary>    [iOSVersion(4)]    public enum UIImagePickerControllerCameraFlashMode    {        /// <summary>        /// Specifies that flash illumination is always off, no matter what the ambient light conditions are.        /// </summary>        [iOSVersion(4)]        Off,        /// <summary>        /// Specifies that the device should consider ambient light conditions to automatically determine whether or not to use flash illumination.        /// </summary>        [iOSVersion(4)]        Auto,        /// <summary>        /// Specifies that flash illumination is always on, no matter what the ambient light conditions are.        /// </summary>        [iOSVersion(4)]        On,    }}