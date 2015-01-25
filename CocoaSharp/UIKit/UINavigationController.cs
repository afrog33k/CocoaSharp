using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UINavigationController class implements a specialized view controller that manages the navigation of hierarchical content. This navigation interface makes it possible to present your data efficiently and makes it easier for the user to navigate that content. You generally use this class as-is but in iOS 6 and later you may subclass to customize the class behavior.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UINavigationController_Class/index.html#//apple_ref/occ/cl/UINavigationController"/>    [iOSVersion(2)]    [Export("")]    public class UINavigationController : UIViewController//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSExtensionRequestHandling, NSObjectProtocol, Printable, UIAppearanceContainer, UIContentContainer, UIStateRestoring, UITraitEnvironment    {        public UINavigationController() { }        /// <summary>        /// Initializes and returns a newly created navigation controller.        /// </summary>        /// <param name="rootViewController">The view controller that resides at the bottom of the navigation stack. This object cannot be an instance of the UITabBarController class.</param>        [iOSVersion(2)]        public UINavigationController(UIViewController rootViewController) { }                /// <summary>        /// Initializes and returns a newly created navigation controller that uses your custom bar subclasses.        /// </summary>        /// <param name="navigationBarClass">Specify the custom UINavigationBar subclass you want to use, or specify nil to use the standard UINavigationBar class.</param>        /// <param name="toolbarClass">Specify the custom UIToolbar subclass you want to use, or specify nil to use the standard UIToolbar class.</param>        [iOSVersion(5)]        public UINavigationController([Unwrapped] AnyClass navigationBarClass, [Unwrapped] AnyClass toolbarClass) { }                /// <summary>        /// Replaces the view controllers currently managed by the navigation controller with the specified items.        /// </summary>        /// <param name="viewControllers">The view controllers to place in the stack. The front-to-back order of the controllers in this array represents the new bottom-to-top order of the controllers in the navigation stack. Thus, the last item added to the array becomes the top item of the navigation stack.</param>        /// <param name="animated">If true, animate the pushing or popping of the top view controller. If false, replace the view controllers without any animations.</param>        [iOSVersion(3)]        [Export("setViewControllers")]        public virtual void SetViewControllers(AnyObject[] viewControllers, bool animated) {  }                /// <summary>        /// Pushes a view controller onto the receiver’s stack and updates the display.        /// </summary>        /// <param name="viewController">The view controller to push onto the stack. This object cannot be a tab bar controller. If the view controller is already on the navigation stack, this method throws an exception.</param>        /// <param name="animated">Specify true to animate the transition or false if you do not want the transition to be animated. You might specify false if you are setting up the navigation controller at launch time.</param>        [iOSVersion(2)]        [Export("pushViewController")]        public virtual void PushViewController(UIViewController viewController, bool animated) {  }                /// <summary>        /// Pops the top view controller from the navigation stack and updates the display.        /// </summary>        /// <param name="animated">Set this value to true to animate the transition. Pass false if you are setting up a navigation controller before its view is displayed.</param>        [iOSVersion(2)]        [Export("popViewControllerAnimated")]        [return:Optional]        public virtual UIViewController PopViewControllerAnimated(bool animated) { return default(UIViewController); }                /// <summary>        /// Pops all the view controllers on the stack except the root view controller and updates the display.        /// </summary>        /// <param name="animated">Set this value to true to animate the transition. Pass false if you are setting up a navigation controller before its view is displayed.</param>        [iOSVersion(2)]        [Export("popToRootViewControllerAnimated")]        public virtual AnyObject[] PopToRootViewControllerAnimated(bool animated) { return default(AnyObject[]); }                /// <summary>        /// Pops view controllers until the specified view controller is at the top of the navigation stack.        /// </summary>        /// <param name="viewController">The view controller that you want to be at the top of the stack. This view controller must currently be on the navigation stack.</param>        /// <param name="animated">Set this value to true to animate the transition. Pass false if you are setting up a navigation controller before its view is displayed.</param>        [iOSVersion(2)]        [Export("popToViewController")]        public virtual AnyObject[] PopToViewController(UIViewController viewController, bool animated) { return default(AnyObject[]); }                /// <summary>        /// Sets whether the navigation bar is hidden.        /// </summary>        /// <param name="hidden">Specify true to hide the navigation bar or false to show it.</param>        /// <param name="animated">Specify true if you want to animate the change in visibility or false if you want the navigation bar to appear immediately.</param>        [iOSVersion(2)]        [Export("setNavigationBarHidden")]        public virtual void SetNavigationBarHidden(bool hidden, bool animated) {  }                /// <summary>        /// Changes the visibility of the navigation controller’s built-in toolbar.        /// </summary>        /// <param name="hidden">Specify true to hide the toolbar or false to show it.</param>        /// <param name="animated">Specify true if you want the toolbar to be animated on or off the screen.</param>        [iOSVersion(3)]        [Export("setToolbarHidden")]        public virtual void SetToolbarHidden(bool hidden, bool animated) {  }                /// <summary>        /// Presents the specified view controller in the navigation interface.        /// </summary>        /// <param name="vc">The view controller to display.</param>        /// <param name="sender">The object that made the request to show the view controller.</param>        [iOSVersion(8)]        [Export("showViewController")]        public virtual void ShowViewController(UIViewController vc, [Unwrapped] AnyObject sender) {  }                /// <summary>        /// The view controller at the top of the navigation stack. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("topViewController")]        [Unwrapped]        public UIViewController TopViewController { get; private set; }                /// <summary>        /// The view controller associated with the currently visible view in the navigation interface. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("visibleViewController")]        [Unwrapped]        public UIViewController VisibleViewController { get; private set; }                /// <summary>        /// The view controllers currently on the navigation stack.        /// </summary>        [iOSVersion(2)]        [Export("viewControllers")]        public AnyObject[] ViewControllers { get; set; }                /// <summary>        /// The gesture recognizer responsible for popping the top view controller off the navigation stack. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("interactivePopGestureRecognizer")]        [Unwrapped]        public UIGestureRecognizer InteractivePopGestureRecognizer { get; private set; }                /// <summary>        /// The navigation bar managed by the navigation controller. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("navigationBar")]        public UINavigationBar NavigationBar { get; private set; }                /// <summary>        /// A Boolean value indicating whether the navigation controller allows hiding of its bars using a tap gesture.        /// </summary>        [iOSVersion(8)]        [Export("hidesBarsOnTap")]        public bool HidesBarsOnTap { get; set; }                /// <summary>        /// A Boolean value indicating whether the navigation bar hides its bars in response to a swipe gesture.        /// </summary>        [iOSVersion(8)]        [Export("hidesBarsOnSwipe")]        public bool HidesBarsOnSwipe { get; set; }                /// <summary>        /// A Boolean value indicating whether the navigation controller hides its bars in a vertically compact environment.        /// </summary>        [iOSVersion(8)]        [Export("hidesBarsWhenVerticallyCompact")]        public bool HidesBarsWhenVerticallyCompact { get; set; }                /// <summary>        /// A Boolean value indicating whether the navigation controller hides its bars when the keyboard appears.        /// </summary>        [iOSVersion(8)]        [Export("hidesBarsWhenKeyboardAppears")]        public bool HidesBarsWhenKeyboardAppears { get; set; }                /// <summary>        /// A Boolean value that indicates whether the navigation bar is hidden.        /// </summary>        [iOSVersion(2)]        [Export("navigationBarHidden")]        public bool NavigationBarHidden { get; set; }                /// <summary>        /// The gesture recognizer used to hide and show the navigation and toolbar. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("barHideOnTapGestureRecognizer")]        public UITapGestureRecognizer BarHideOnTapGestureRecognizer { get; private set; }                /// <summary>        /// The gesture recognizer used to hide the navigation bar and toolbar. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("barHideOnSwipeGestureRecognizer")]        public UIPanGestureRecognizer BarHideOnSwipeGestureRecognizer { get; private set; }                /// <summary>        /// The delegate of the navigation controller object.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        [Optional]        public UINavigationControllerDelegate Delegate { get; set; }                /// <summary>        /// The custom toolbar associated with the navigation controller. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("toolbar")]        [Unwrapped]        public UIToolbar Toolbar { get; private set; }                /// <summary>        /// A Boolean indicating whether the navigation controller’s built-in toolbar is visible.        /// </summary>        [iOSVersion(3)]        [Export("toolbarHidden")]        public bool ToolbarHidden { get; set; }    }}