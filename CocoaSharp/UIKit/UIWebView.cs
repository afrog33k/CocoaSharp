using CoreGraphics;
using ObjectiveC;
    }

    /// <summary>
    /// Constant indicating the user’s action.
    /// </summary>
    public enum UIWebViewNavigationType
    {
        /// <summary>
        /// User tapped a link.
        /// </summary>
        [iOSVersion(2)]
        LinkClicked,

        /// <summary>
        /// User submitted a form.
        /// </summary>
        [iOSVersion(2)]
        FormSubmitted,

        /// <summary>
        /// User tapped the back or forward button.
        /// </summary>
        [iOSVersion(2)]
        BackForward,

        /// <summary>
        /// User tapped the reload button.
        /// </summary>
        [iOSVersion(2)]
        Reload,

        /// <summary>
        /// User resubmitted a form.
        /// </summary>
        [iOSVersion(2)]
        FormResubmitted,

        /// <summary>
        /// Some other action occurred.
        /// </summary>
        [iOSVersion(2)]
        Other,
    }
    /// <summary>
    /// The manner in which column- or page-breaking occurs.
    /// </summary>
    public enum UIWebPaginationBreakingMode
    {
        /// <summary>
        /// Content respects CSS properties related to page-breaking.
        /// </summary>
        [iOSVersion(7)]
        Page,

        /// <summary>
        /// Content respects CSS properties related to column-breaking.
        /// </summary>
        [iOSVersion(7)]
        Column,
    }
    /// <summary>
    /// The layout of content in the web view, which determines the direction that the pages flow.
    /// </summary>
    public enum UIWebPaginationMode
    {
        /// <summary>
        /// Content appears as one long scrolling view with no distinct pages.
        /// </summary>
        [iOSVersion(7)]
        Unpaginated,

        /// <summary>
        /// Content is broken up into pages that flow from left to right.
        /// </summary>
        [iOSVersion(7)]
        LeftToRight,

        /// <summary>
        /// Content is broken up into pages that flow from top to bottom.
        /// </summary>
        [iOSVersion(7)]
        TopToBottom,

        /// <summary>
        /// Content is broken up into pages that flow from bottom to top.
        /// </summary>
        [iOSVersion(7)]
        BottomToTop,

        /// <summary>
        /// Content is broken up into pages that flow from right to left.
        /// </summary>
        [iOSVersion(7)]
        RightToLeft,
    }