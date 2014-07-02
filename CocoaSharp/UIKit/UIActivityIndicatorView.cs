using CoreGraphics;
using SwiftSharp.Attributes;

namespace UIKit

    /// <summary>
    /// The visual style of the progress indicator.
    /// </summary>
    public enum UIActivityIndicatorViewStyle
    {
        /// <summary>
        /// The large white style of indicator.
        /// </summary>
        [iOSVersion(2)]
        WhiteLarge,

        /// <summary>
        /// The standard white style of indicator (the default).
        /// </summary>
        [iOSVersion(2)]
        White,

        /// <summary>
        /// The standard gray style of indicator.
        /// </summary>
        [iOSVersion(2)]
        Gray,
    }