using CoreGraphics;
using ObjectiveC;
        //TODO: UIImagePickerController constructors
        public UIImagePickerController() : base(null) { }
    }

    /// <summary>
    /// The source to use when picking an image or when determining available media types.
    /// </summary>
    public enum UIImagePickerControllerSourceType
    {
        /// <summary>
        /// Specifies the device’s photo library as the source for the image picker controller.
        /// </summary>
        [iOSVersion(2)]
        PhotoLibrary,

        /// <summary>
        /// Specifies the device’s built-in camera as the source for the image picker controller. Indicate the specific camera you want (front or rear, as available) by using the cameraDevice property.
        /// </summary>
        [iOSVersion(2)]
        Camera,

        /// <summary>
        /// Specifies the device’s Camera Roll album as the source for the image picker controller. If the device does not have a camera, specifies the Saved Photos album as the source.
        /// </summary>
        [iOSVersion(2)]
        SavedPhotosAlbum,
    }
    /// <summary>
    /// Video quality settings for movies recorded with the built-in camera, or transcoded by displaying in the image picker.
    /// </summary>
    public enum UIImagePickerControllerQualityType
    {
        /// <summary>
        /// If recording, specifies that you want to use the highest-quality video recording supported for the active camera on the device.
        /// </summary>
        [iOSVersion(3.1)]
        TypeHigh,

        /// <summary>
        /// If recording, specifies that you want to use medium-quality video recording.
        /// </summary>
        [iOSVersion(3.1)]
        TypeMedium,

        /// <summary>
        /// If recording, specifies that you want to use low-quality video recording.
        /// </summary>
        [iOSVersion(3.1)]
        TypeLow,

        /// <summary>
        /// If recording, specifies that you want to use VGA-quality video recording (pixel dimensions of 640x480).
        /// </summary>
        [iOSVersion(4)]
        Type640x480,

        /// <summary>
        /// If recording, specifies that you want to use 1280x720 iFrame format.
        /// </summary>
        [iOSVersion(5)]
        TypeIFrame1280x720,

        /// <summary>
        /// If recording, specifies that you want to use 960x540 iFrame format.
        /// </summary>
        [iOSVersion(5)]
        TypeIFrame960x540,
    }
    /// <summary>
    /// The camera to use for image or movie capture.
    /// </summary>
    public enum UIImagePickerControllerCameraDevice
    {
        /// <summary>
        /// Specifies the camera on the rear of the device.
        /// </summary>
        [iOSVersion(4)]
        Rear,

        /// <summary>
        /// Specifies the camera on the front of the device.
        /// </summary>
        [iOSVersion(4)]
        Front,
    }
    /// <summary>
    /// The category of media for the camera to capture.
    /// </summary>
    public enum UIImagePickerControllerCameraCaptureMode
    {
        /// <summary>
        /// Specifies that the camera captures still images.
        /// </summary>
        [iOSVersion(4)]
        Photo,

        /// <summary>
        /// Specifies that the camera captures movies.
        /// </summary>
        [iOSVersion(4)]
        Video,
    }
    /// <summary>
    /// The flash mode to use with the active camera.
    /// </summary>
    public enum UIImagePickerControllerCameraFlashMode
    {
        /// <summary>
        /// Specifies that flash illumination is always off, no matter what the ambient light conditions are.
        /// </summary>
        [iOSVersion(4)]
        Off,

        /// <summary>
        /// Specifies that the device should consider ambient light conditions to automatically determine whether or not to use flash illumination.
        /// </summary>
        [iOSVersion(4)]
        Auto,

        /// <summary>
        /// Specifies that flash illumination is always on, no matter what the ambient light conditions are.
        /// </summary>
        [iOSVersion(4)]
        On,
    }