using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// Specifies the style of an action sheet.
    /// </summary>
    public enum UIActionSheetStyle
    {
        /// <summary>
        /// Takes the appearance of the bottom bar if specified; otherwise, same as UIActionSheetStyleDefault.
        /// </summary>
        [iOSVersion(2)]
        Automatic,

        /// <summary>
        /// The default style.
        /// </summary>
        [iOSVersion(2)]
        Default,

        /// <summary>
        /// A black translucent style.
        /// </summary>
        [iOSVersion(2)]
        BlackTranslucent,

        /// <summary>
        /// A black opaque style.
        /// </summary>
        [iOSVersion(2)]
        BlackOpaque,
    }