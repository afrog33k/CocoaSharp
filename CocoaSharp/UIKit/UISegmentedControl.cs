using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// The styles of the segmented control.
    /// </summary>
    public enum UISegmentedControlStyle
    {
        /// <summary>
        /// The large plain style for segmented controls. This style is the default.
        /// </summary>
        [iOSVersion(7)]
        Plain,

        /// <summary>
        /// The large bordered style for segmented controls.
        /// </summary>
        [iOSVersion(7)]
        Bordered,

        /// <summary>
        /// The small toolbar style for segmented controls. Segmented controls in this style can have a tint color (see tintColor).
        /// </summary>
        [iOSVersion(7)]
        Bar,

        /// <summary>
        /// The large bezeled style for segmented controls. Segmented controls in this style can have a tint color (see tintColor).
        /// </summary>
        [iOSVersion(7)]
        Bezeled,
    }

    /// <summary>
    /// Constants for specifying a segment in a control
    /// </summary>
    public enum UISegmentedControlSegment
    {
        /// <summary>
        /// Specifies any segment.
        /// </summary>
        [iOSVersion(5)]
        Any,

        /// <summary>
        /// The capped, leftmost segment.
        /// </summary>
        [iOSVersion(5)]
        Left,

        /// <summary>
        /// Any segment between the left and rightmost segments.
        /// </summary>
        [iOSVersion(5)]
        Center,

        /// <summary>
        /// The capped,rightmost segment. .
        /// </summary>
        [iOSVersion(5)]
        Right,

        /// <summary>
        /// The standalone segment, capped on both ends.
        /// </summary>
        [iOSVersion(5)]
        Alone,
    }