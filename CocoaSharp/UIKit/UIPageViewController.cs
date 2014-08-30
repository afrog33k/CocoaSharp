using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A page view controller lets the user navigate between pages of content, where each page is managed by its own view controller object. Navigation can be controlled programmatically by your app or directly by the user using gestures. When navigating from page to page, the page view controller uses the transition that you specify to animate the change.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPageViewControllerClassReferenceClassRef/index.html#//apple_ref/occ/cl/UIPageViewController"/>    [iOSVersion(5)]    public class UIPageViewController : UIViewController//, AnyObject, NSCoding, NSExtensionRequestHandling, NSObjectProtocol, UIAppearanceContainer, UIContentContainer, UIStateRestoring, UITraitEnvironment    {        public UIPageViewController() { }        /// <summary>        /// Initializes a newly created page view controller.        /// </summary>        /// <param name="transitionStyle">The style for transitions between pages.</param>        /// <param name="navigationOrientation">The orientation of the page-by-page navigation.</param>        /// <param name="options">A dictionary of options. For keys, see Options Keys.</param>        [iOSVersion(5)]        public UIPageViewController(UIPageViewControllerTransitionStyle transitionStyle, UIPageViewControllerNavigationOrientation navigationOrientation, Dictionary<NSObject, AnyObject> options) { }                /// <summary>        /// Sets the view controllers to be displayed.        /// </summary>        /// <param name="viewControllers">The view controller or view controllers to be displayed.</param>        /// <param name="direction">The navigation direction.</param>        /// <param name="animated">A Boolean value that indicates whether the transition is to be animated.</param>        /// <param name="completion">A block to be called when the page-turn animation completes.        ///   The block takes the following parameters:        ///       finished        ///   true if the animation finished; false if it was skipped.</param>        [iOSVersion(5)]        [Export("setViewControllers")]        public virtual void SetViewControllers(AnyObject[] viewControllers, UIPageViewControllerNavigationDirection direction, bool animated, Action<bool> completion) {  }                /// <summary>        /// The object that provides view controllers.        /// </summary>        [iOSVersion(5)]        [Export("dataSource")]        public UIPageViewControllerDataSource DataSource { get; set; }                /// <summary>        /// The delegate object.        /// </summary>        [iOSVersion(5)]        [Export("delegate")]        public UIPageViewControllerDelegate Delegate { get; set; }                /// <summary>        /// The view controllers displayed by the page view controller. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("viewControllers")]        public AnyObject[] ViewControllers { get; private set; }                /// <summary>        /// An array of UIGestureRecognizer objects that are configured to handle user interaction. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("gestureRecognizers")]        public AnyObject[] GestureRecognizers { get; private set; }                /// <summary>        /// The direction along which navigation occurs. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("navigationOrientation")]        public UIPageViewControllerNavigationOrientation NavigationOrientation { get; private set; }                /// <summary>        /// The location of the spine. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("spineLocation")]        public UIPageViewControllerSpineLocation SpineLocation { get; private set; }                /// <summary>        /// The style used to transition between view controllers. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("transitionStyle")]        public UIPageViewControllerTransitionStyle TransitionStyle { get; private set; }                /// <summary>        /// A Boolean value that indicates whether content appears on the back of pages.        /// </summary>        [iOSVersion(5)]        [Export("doubleSided")]        public bool DoubleSided { get; set; }    }    /// <summary>    /// Orientations for page-turn transitions.    /// </summary>    [iOSVersion(5)]    public enum UIPageViewControllerNavigationOrientation    {        /// <summary>        /// Horizontal orientation, with pages turning left and right.        /// </summary>        [iOSVersion(5)]        Horizontal,        /// <summary>        /// Vertical orientation, with pages turning up and down.        /// </summary>        [iOSVersion(5)]        Vertical,    }    /// <summary>    /// Directions for page-turn transitions.    /// </summary>    [iOSVersion(5)]    public enum UIPageViewControllerNavigationDirection    {        /// <summary>        /// Navigation to the next page.        /// </summary>        [iOSVersion(5)]        Forward,        /// <summary>        /// Navigation to the previous page.        /// </summary>        [iOSVersion(5)]        Reverse,    }    /// <summary>    /// Styles for the page-turn transition.    /// </summary>    [iOSVersion(5)]    public enum UIPageViewControllerTransitionStyle    {        /// <summary>        /// Page curl transition style.        /// When the page curl transition style is specified, the page view controller displays a page-turning animation when transitioning between view controllers. If a data source is specified, the animation follows the user’s finger during a navigation gesture.        /// </summary>        [iOSVersion(5)]        PageCurl,        /// <summary>        /// Scrolling transition style.        /// When the page scrolling style is specified, the page view controller displays a page-scrolling animation when transitioning between view controllers. If a data source is specified, the animation follows the user’s finger during a navigation gesture.        /// </summary>        [iOSVersion(6)]        Scroll,    }    /// <summary>    /// Locations for the spine.    /// </summary>    [iOSVersion(5)]    public enum UIPageViewControllerSpineLocation    {        /// <summary>        /// No spine.        /// This spine location is not valid if the transition style is UIPageViewControllerTransitionStylePageCurl.        /// </summary>        [iOSVersion(5)]        None,        /// <summary>        /// Spine at the left or top edge of the screen.        /// One view controller is displayed at a time.        /// </summary>        [iOSVersion(5)]        Min,        /// <summary>        /// Spine in the middle or the screen.        /// Two view controllers are displayed at a time.        /// </summary>        [iOSVersion(5)]        Mid,        /// <summary>        /// Spine at the right or bottom edge of the screen.        /// One view controller is displayed at a time.        /// </summary>        [iOSVersion(5)]        Max,    }}