using ObjectiveC;

    /// <summary>
    /// The axis to use when interpolating values.
    /// </summary>
    public enum UIinterpolatingMotionEffectType
    {
        /// <summary>
        /// interpolate values along the horizontal axis, which involves the device facing left or right of the user’s viewpoint.
        /// </summary>
        [iOSVersion(7)]
        TiltAlongHorizontalAxis,

        /// <summary>
        /// interpolate values along the vertical axis, which involves the device facing above or below the user’s viewpoint.
        /// </summary>
        [iOSVersion(7)]
        TiltAlongVerticalAxis,
    }