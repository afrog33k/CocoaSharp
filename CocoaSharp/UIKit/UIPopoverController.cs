using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIPopoverController class is used to manage the presentation of content in a popover. You use popovers to present information temporarily. The popover content is layered on top of your existing content and the background is dimmed automatically. The popover remains visible until the user taps outside of the popover window or you explicitly dismiss it. Popover controllers are for use exclusively on iPad devices. Attempting to create one on other devices results in an exception.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPopoverController_class/index.html#//apple_ref/occ/cl/UIPopoverController"/>    [iOSVersion(3.2)]    public class UIPopoverController : NSObject//, AnyObject, NSObjectProtocol, UIAppearanceContainer    {        public UIPopoverController() { }        /// <summary>        /// Returns an initialized popover controller object.        /// </summary>        /// <param name="contentViewController">The view controller for managing the popover’s content. This parameter must not be nil.</param>        [iOSVersion(3.2)]        public UIPopoverController(UIViewController contentViewController) { }                /// <summary>        /// Displays the popover and anchors it to the specified location in the view.        /// </summary>        /// <param name="rect">The rectangle in view at which to anchor the popover window.</param>        /// <param name="inView">The view containing the anchor rectangle for the popover.</param>        /// <param name="permittedArrowDirections">The arrow directions the popover is permitted to use. You can use this value to force the popover to be positioned on a specific side of the rectangle. However, it is generally better to specify UIPopoverArrowDirectionAny and let the popover decide the best placement. You must not specify UIPopoverArrowDirectionUnknown for this parameter.</param>        /// <param name="animated">Specify true to animate the presentation of the popover or false to display it immediately.</param>        [iOSVersion(3.2)]        [Export("presentPopoverFromRect")]        public virtual void PresentPopoverFromRect(CGRect rect, UIView inView, UIPopoverArrowDirection permittedArrowDirections, bool animated) {  }                /// <summary>        /// Displays the popover and anchors it to the specified bar button item.        /// </summary>        /// <param name="item">The bar button item on which to anchor the popover.</param>        /// <param name="permittedArrowDirections">The arrow directions the popover is permitted to use. You can use this value to force the popover to be positioned on a specific side of the bar button item. However, it is generally better to specify UIPopoverArrowDirectionAny and let the popover decide the best placement. You must not specify UIPopoverArrowDirectionUnknown for this parameter.</param>        /// <param name="animated">Specify true to animate the presentation of the popover or false to display it immediately.</param>        [iOSVersion(3.2)]        [Export("presentPopoverFromBarButtonItem")]        public virtual void PresentPopoverFromBarButtonItem(UIBarButtonItem item, UIPopoverArrowDirection permittedArrowDirections, bool animated) {  }                /// <summary>        /// Dismisses the popover programmatically.        /// </summary>        /// <param name="animated">Specify true to animate the dismissal of the popover or false to dismiss it immediately.</param>        [iOSVersion(3.2)]        [Export("dismissPopoverAnimated")]        public virtual void DismissPopoverAnimated(bool animated) {  }                /// <summary>        /// Sets the view controller responsible for the content portion of the popover.        /// </summary>        /// <param name="viewController">The new view controller whose content should be displayed by the popover.</param>        /// <param name="animated">Specify true if the change of view controllers should be animated or false if the change should occur immediately.</param>        [iOSVersion(3.2)]        [Export("setContentViewController")]        public virtual void SetContentViewController(UIViewController viewController, bool animated) {  }                /// <summary>        /// Changes the size of the popover’s content view.        /// </summary>        /// <param name="size">The new size to apply to the content view.</param>        /// <param name="animated">Specify true if you want the change in size to be animated or false if you want the change to appear immediately.</param>        [iOSVersion(3.2)]        [Export("setPopoverContentSize")]        public virtual void SetPopoverContentSize(CGSize size, bool animated) {  }                /// <summary>        /// The view controller responsible for the content portion of the popover.        /// </summary>        [iOSVersion(3.2)]        [Export("contentViewController")]        public UIViewController ContentViewController { get; set; }                /// <summary>        /// The size of the popover’s content view.        /// </summary>        [iOSVersion(3.2)]        [Export("popoverContentSize")]        public CGSize PopoverContentSize { get; set; }                /// <summary>        /// An array of views that the user can interact with while the popover is visible.        /// </summary>        [iOSVersion(3.2)]        [Export("passthroughViews")]        public AnyObject[] PassthroughViews { get; set; }                /// <summary>        /// A Boolean value indicating whether the popover is currently visible. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("popoverVisible")]        public bool PopoverVisible { get; private set; }                /// <summary>        /// The direction of the popover’s arrow. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("popoverArrowDirection")]        public UIPopoverArrowDirection PopoverArrowDirection { get; private set; }                /// <summary>        /// The delegate you want to receive popover controller messages.        /// </summary>        [iOSVersion(3.2)]        [Export("delegate")]        public UIPopoverControllerDelegate Delegate { get; set; }                /// <summary>        /// The margins that define the portion of the screen in which it is permissible to display the popover.        /// </summary>        [iOSVersion(5)]        [Export("popoverLayoutMargins")]        public UIEdgeInsets PopoverLayoutMargins { get; set; }                /// <summary>        /// The class to use for displaying the popover background content.        /// </summary>        [iOSVersion(5)]        [Export("popoverBackgroundViewClass")]        public AnyClass PopoverBackgroundViewClass { get; set; }                /// <summary>        /// The color of the popover’s backdrop view.        /// </summary>        [iOSVersion(7)]        [Export("backgroundColor")]        public UIColor BackgroundColor { get; set; }    }    /// <summary>    /// Constants for specifying the direction of the popover arrow.    /// </summary>    [iOSVersion(3.2)]    public enum UIPopoverArrowDirection    {        /// <summary>        /// An arrow that points upward.        /// </summary>        [iOSVersion(3.2)]        Up,        /// <summary>        /// An arrow that points downward.        /// </summary>        [iOSVersion(3.2)]        Down,        /// <summary>        /// An arrow that points toward the left.        /// </summary>        [iOSVersion(3.2)]        Left,        /// <summary>        /// An arrow that points toward the right.        /// </summary>        [iOSVersion(3.2)]        Right,        /// <summary>        /// An arrow that points in any direction.        /// </summary>        [iOSVersion(3.2)]        Any,        /// <summary>        /// The status of the arrow is currently unknown.        /// </summary>        [iOSVersion(3.2)]        Unknown,    }}