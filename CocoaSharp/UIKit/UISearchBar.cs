using ObjectiveC;
    }

    /// <summary>
    /// Constants to identify the icons used in the search bar.
    /// </summary>
    public enum UISearchBarIcon
    {
        /// <summary>
        /// Identifies the search icon.
        /// </summary>
        [iOSVersion(5)]
        Search,

        /// <summary>
        /// Identifies the clear action icon.
        /// </summary>
        [iOSVersion(5)]
        Clear,

        /// <summary>
        /// Identifies the bookmarks icon.
        /// </summary>
        [iOSVersion(5)]
        Bookmark,

        /// <summary>
        /// Identifies the results list icon.
        /// </summary>
        [iOSVersion(5)]
        ResultsList,
    }
    /// <summary>
    /// Specifies whether the search bar has a background.
    /// </summary>
    public enum UISearchBarStyle
    {
        /// <summary>
        /// The search bar has the default style.
        /// </summary>
        [iOSVersion(7)]
        Default,

        /// <summary>
        /// The search bar has a translucent background, and the search field is opaque.
        /// </summary>
        [iOSVersion(7)]
        Prominent,

        /// <summary>
        /// The search bar has no background, and the search field is translucent.
        /// </summary>
        [iOSVersion(7)]
        Minimal,
    }