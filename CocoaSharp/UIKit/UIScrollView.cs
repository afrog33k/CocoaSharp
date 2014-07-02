using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// The style of the scroll indicators. You use these constants to set the value of the indicatorStyle style.
    /// </summary>
    public enum UIScrollViewIndicatorStyle
    {
        /// <summary>
        /// The default style of scroll indicator, which is black with a white border. This style is good against any content background.
        /// </summary>
        [iOSVersion(2)]
        Default,

        /// <summary>
        /// A style of indicator which is black and smaller than the default style. This style is good against a white content background.
        /// </summary>
        [iOSVersion(2)]
        Black,

        /// <summary>
        /// A style of indicator is white and smaller than the default style. This style is good against a black content background.
        /// </summary>
        [iOSVersion(2)]
        White,
    }

    /// <summary>
    /// The manner in which the keyboard is dismissed when a drag begins in the scroll view.
    /// </summary>
    public enum UIScrollViewKeyboardDismissMode
    {
        /// <summary>
        /// The keyboard does not get dismissed with a drag.
        /// </summary>
        [iOSVersion(7)]
        None,

        /// <summary>
        /// The keyboard is dismissed when a drag begins.
        /// </summary>
        [iOSVersion(7)]
        OnDrag,

        /// <summary>
        /// The keyboard follows the dragging touch offscreen, and can be pulled upward again to cancel the dismiss.
        /// </summary>
        [iOSVersion(7)]
        interactive,
    }