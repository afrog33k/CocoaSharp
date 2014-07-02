using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// Constants that specify tab bar item positioning.
    /// </summary>
    public enum UITabBarItemPositioning
    {
        /// <summary>
        /// Specifies automatic tab bar item positioning according to the user interface idiom, as follows:
        /// </summary>
        [iOSVersion(7)]
        Automatic,

        /// <summary>
        /// Default tab bar item positioning on iPhone. Specifies that tab bar items should be distributed to fill the width of the tab bar.
        /// </summary>
        [iOSVersion(7)]
        Fill,

        /// <summary>
        /// Default tab bar item positioning on iPad. Specifies that tab bar items should be positioned closely adjacent to each other with a default width and inter-item spacing (customizable with the itemWidth and itemSpacing properties). The group of tab bar items is centered in the tab bar, potentially leaving space in the tab bar at its left and right edges.
        /// </summary>
        [iOSVersion(7)]
        Centered,
    }