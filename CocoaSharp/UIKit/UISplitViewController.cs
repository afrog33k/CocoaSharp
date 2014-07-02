using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// Constants describing the possible display modes for a split view controller.
    /// </summary>
    public enum UISplitViewControllerDisplayMode
    {
        /// <summary>
        /// The split view controller automatically decides the most appropriate display mode based on the device and the current app size. You can assign this constant as the value of the preferredDisplayMode property but this value is never reported by the displayMode property.
        /// </summary>
        [iOSVersion(8)]
        Automatic,

        /// <summary>
        /// The primary view controller is hidden.
        /// </summary>
        [iOSVersion(8)]
        PrimaryHidden,

        /// <summary>
        /// The primary and secondary view controllers are displayed side-by-side onscreen.
        /// </summary>
        [iOSVersion(8)]
        AllVisible,

        /// <summary>
        /// The primary view controller is layered on top of the secondary view controller, leaving the secondary view controller partially visible.
        /// </summary>
        [iOSVersion(8)]
        PrimaryOverlay,
    }