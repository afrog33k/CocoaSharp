using CoreGraphics;
using ObjectiveC;
        /// !! IMPORTANT !! Name the parameter you're using
        /// </summary>
        /// <summary>
        /// Creates and returns a new UIBezierPath object initialized with an oval path inscribed in the specified rectangle
        /// </summary>
        /// <param name="rect">The rectangle describing the path to create.</param>
        /// <param name="ovalInRect">The rectangle in which to inscribe an oval.</param>
        /// <returns>A new path object with the rectangular path.</returns>
        /// <returns>A new path object with the oval path.</returns>
        public UIBezierPath(CGRect rect = new CGRect(), CGRect ovalInRect = new CGRect()) { }

    /// <summary>
    /// The corners of a rectangle.
    /// </summary>
    public enum UIRectCorner
    {
        /// <summary>
        /// The top-left corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        TopLeft,

        /// <summary>
        /// The top-right corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        TopRight,

        /// <summary>
        /// The bottom-left corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        BottomLeft,

        /// <summary>
        /// The bottom-right corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        BottomRight,

        /// <summary>
        /// All corners of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        AllCorners,
    }