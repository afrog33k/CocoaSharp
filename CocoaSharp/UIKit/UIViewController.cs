using CoreGraphics;
using ObjectiveC;
        public UIStatusBarStyle PreferredStatusBarStyle() { return UIStatusBarStyle.Default; }
        public UIStatusBarAnimation PreferredStatusBarUpdateAnimation() { return UIStatusBarAnimation.None; }
    }

    /// <summary>
    /// Transition styles available when presenting view controllers.
    /// </summary>
    public enum UIModalTransitionStyle
    {
        /// <summary>
        /// When the view controller is presented, its view slides up from the bottom of the screen. On dismissal, the view slides back down. This is the default transition style.
        /// </summary>
        [iOSVersion(3)]
        CoverVertical,

        /// <summary>
        /// When the view controller is presented, the current view initiates a horizontal 3D flip from right-to-left, resulting in the revealing of the new view as if it were on the back of the previous view. On dismissal, the flip occurs from left-to-right, returning to the original view.
        /// </summary>
        [iOSVersion(3)]
        FlipHorizontal,

        /// <summary>
        /// When the view controller is presented, the current view fades out while the new view fades in at the same time. On dismissal, a similar type of cross-fade is used to return to the original view.
        /// </summary>
        [iOSVersion(3)]
        CrossDissolve,

        /// <summary>
        /// When the view controller is presented, one corner of the current view curls up to reveal the presented view underneath. On dismissal, the curled up page unfurls itself back on top of the presented view. A view presented using this transition is itself prevented from presenting any additional views.
        /// </summary>
        [iOSVersion(3.2)]
        PartialCurl,
    }
    /// <summary>
    /// Modal presentation styles available when presenting view controllers.
    /// </summary>
    public enum UIModalPresentationStyle
    {
        /// <summary>
        /// A presentation style in which the presented view covers the screen.
        /// </summary>
        [iOSVersion(3.2)]
        FullScreen,

        /// <summary>
        /// In a horizontally regular environment, a presentation style that partially covers the underlying content. The presented view's width is set to the width of the screen in a portrait orientation and the the height is set to the height of the screen. Any uncovered areas are dimmed to prevent the user from interacting with them. (In portrait orientations, this option is essentially the same as UIModalPresentationFullScreen.)
        /// </summary>
        [iOSVersion(3.2)]
        PageSheet,

        /// <summary>
        /// In a horizontally regular environment, a presentation style that displays the content centered in the screen. The width and height of the content area are smaller than the screen size and a dimming view is placed underneath the content. If the device is in a landscape orientation and the keyboard is visible, the position of the view is adjusted upward so the view remains visible. All uncovered areas are dimmed to prevent the user from interacting with them.
        /// </summary>
        [iOSVersion(3.2)]
        FormSheet,

        /// <summary>
        /// A presentation style where the content is displayed over only the presenting view controller’s content.
        /// </summary>
        [iOSVersion(3.2)]
        CurrentContext,

        /// <summary>
        /// A custom view presentation style that is managed by a custom presentation controller and one or more custom animator objects. All of these objects are provided by the presented view controller’s transitioning delegate, which is an object that conforms to the UIViewControllerTransitioningDelegate protocol. Before presenting a view controller using this style, set the view controller’s transitioningDelegate property to your custom transitioning delegate.
        /// </summary>
        [iOSVersion(7)]
        Custom,

        /// <summary>
        /// A view presentation style in which the presented view covers the screen. The views beneath the presented content are not removed from the view hierarchy when the presentation finishes. So if the presented view controller does not fill the screen with opaque content, the underlying content shows through.
        /// </summary>
        [iOSVersion(8)]
        OverFullScreen,

        /// <summary>
        /// A presentation style where the content is displayed over only the parent view controller’s content. The views beneath the presented content are not removed from the view hierarchy when the presentation finishes. So if the presented view controller does not fill the screen with opaque content, the underlying content shows through.
        /// </summary>
        [iOSVersion(8)]
        OverCurrentContext,

        /// <summary>
        /// In a horizontally regular environment, a presentation style where the content is displayed in a popover view. The background content is dimmed and taps outside the popover cause the popover to be dismissed. If you do not want taps to dismiss the popover, you can assign one or more views to the passthroughViews property of the associated UIPopoverPresentationController object, which you can get from the popoverPresentationController property.
        /// </summary>
        [iOSVersion(8)]
        Popover,

        /// <summary>
        /// A nonmodal view presentation or dismissal.
        /// </summary>
        [iOSVersion(7)]
        None,
    }