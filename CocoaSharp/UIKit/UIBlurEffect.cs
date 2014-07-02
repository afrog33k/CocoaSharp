using ObjectiveC;
        public UIBlurEffect(UIBlurEffectStyle style) { }

    /// <summary>
    /// Blur styles available for UIBlurEffect objects.
    /// </summary>
    public enum UIBlurEffectStyle
    {
        /// <summary>
        /// Creates a blurring effect in the view. The area of the view will be lighter in hue than the underlying view.
        /// </summary>
        [iOSVersion(8)]
        ExtraLight,

        /// <summary>
        /// Creates a blurring effect in the view. The area of the view will be the same approximate hue of the underlying view.
        /// </summary>
        [iOSVersion(8)]
        Light,

        /// <summary>
        /// Creates a blurring effect in the view. The area of the view will be darker in hue than the underlying view.
        /// </summary>
        [iOSVersion(8)]
        Dark,
    }