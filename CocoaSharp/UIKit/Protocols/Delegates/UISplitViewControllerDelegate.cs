using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UISplitViewControllerDelegate protocol defines methods that allow you to manage changes to a split view interface. Use the methods of this protocol to respond to changes in the current display mode and to the current interface orientation. When the split view interface collapses and expands, or when a new view controller is added to the interface, you can also use these methods to configure the child view controllers appropriately.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISplitViewControllerDelegate_protocol/index.html#//apple_ref/occ/intf/UISplitViewControllerDelegate"/>    [iOSVersion(3.2)]    public interface UISplitViewControllerDelegate//:    {        /// <summary>        /// Tells the delegate that the display mode for the split view controller is about to change.        /// </summary>        /// <param name="svc">The split view controller whose display mode is changing.</param>        /// <param name="willChangeToDisplayMode">The new display mode that is about to be applied to the split view controller.</param>        //[iOSVersion(8)]        //[Export("splitViewController")]        //[Optional]        void SplitViewController(UISplitViewController svc, UISplitViewControllerDisplayMode willChangeToDisplayMode);                /// <summary>        /// Asks the delegate to provide the display mode to apply when a split view controller action occurs.        /// </summary>        /// <param name="svc">The split view controller whose action may be triggered. Use this object to obtain the current display mode and configuration of the split view interface.</param>        //[iOSVersion(8)]        //[Export("targetDisplayModeForActionInSplitViewController")]        //[Optional]        UISplitViewControllerDisplayMode TargetDisplayModeForActionInSplitViewController(UISplitViewController svc);                /// <summary>        /// Asks the delegate for the orientation to use when presenting the split view controller.        /// </summary>        /// <param name="splitViewController">The split view controller that is about to be presented onscreen.</param>        //[iOSVersion(7)]        //[Export("splitViewControllerPreferredInterfaceOrientationForPresentation")]        //[Optional]        UIInterfaceOrientation SplitViewControllerPreferredInterfaceOrientationForPresentation(UISplitViewController splitViewController);                /// <summary>        /// Asks the delegate to specify the interface orientations that the split view controller supports.        /// </summary>        /// <param name="splitViewController">The split view controller.</param>        //[iOSVersion(7)]        //[Export("splitViewControllerSupportedInterfaceOrientations")]        //[Optional]        int SplitViewControllerSupportedInterfaceOrientations(UISplitViewController splitViewController);                /// <summary>        /// Asks the delegate to provide the single view controller to display after the split view interface collapses.        /// </summary>        /// <param name="splitViewController">The split view controller whose interface is collapsing.</param>        //[iOSVersion(8)]        //[Export("primaryViewControllerForCollapsingSplitViewController")]        //[Optional]        UIViewController PrimaryViewControllerForCollapsingSplitViewController(UISplitViewController splitViewController);                /// <summary>        /// Asks the delegate to adjust the primary view controller and to incorporate the secondary view controller into the collapsed interface.        /// </summary>        /// <param name="splitViewController">The split view controller whose interface is collapsing.</param>        /// <param name="collapseSecondaryViewController">The secondary view controller of the split view interface.</param>        /// <param name="ontoPrimaryViewController">The primary view controller of the split view interface. If you implement the primaryViewControllerForCollapsingSplitViewController: method in your delegate, this object is the one returned by that method.</param>        //[iOSVersion(8)]        //[Export("splitViewController")]        //[Optional]        bool SplitViewController(UISplitViewController splitViewController, UIViewController collapseSecondaryViewController, UIViewController ontoPrimaryViewController);                /// <summary>        /// Asks the delegate to provide the view controller to display in the primary position when the split view interface expands.        /// </summary>        /// <param name="splitViewController">The split view controller whose interface is expanding.</param>        //[iOSVersion(8)]        //[Export("primaryViewControllerForExpandingSplitViewController")]        //[Optional]        UIViewController PrimaryViewControllerForExpandingSplitViewController(UISplitViewController splitViewController);                /// <summary>        /// Asks the delegate to provide the new secondary view controller for the split view interface.        /// </summary>        /// <param name="splitViewController">The split view controller whose interface is expanding.</param>        /// <param name="separateSecondaryViewControllerFromPrimaryViewController">The primary view controller in the expanded split view interface. If you implement the primaryViewControllerForExpandingSplitViewController: method in your delegate, this object is the one returned by that method.</param>        //[iOSVersion(8)]        //[Export("splitViewController")]        //[Optional]        UIViewController SplitViewController(UISplitViewController splitViewController, UIViewController separateSecondaryViewControllerFromPrimaryViewController);                /// <summary>        /// Asks the delegate if it wants to do the work of displaying a view controller in the primary position of the split view interface.        /// </summary>        /// <param name="splitViewController">The split view controller whose primary view controller is being updated.</param>        /// <param name="showViewController">The view controller being displayed in the primary position.</param>        /// <param name="sender">The object that made the request.</param>        //[iOSVersion(8)]        //[Export("splitViewController")]        //[Optional]        bool SplitViewController(UISplitViewController splitViewController, UIViewController showViewController, AnyObject sender);                /// <summary>        /// Asks the delegate if it wants to do the work of displaying a view controller in the secondary position of the split view interface.        /// </summary>        /// <param name="splitViewController">The split view controller whose secondary view controller is being updated.</param>        /// <param name="showDetailViewController">The view controller being displayed in the secondary position.</param>        /// <param name="sender">The object that made the request.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(8)]        //[Export("splitViewController")]        //[Optional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        bool SplitViewController(UISplitViewController splitViewController, UIViewController showDetailViewController, AnyObject sender, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Asks the delegate whether the first view controller should be hidden for the specified orientation.        /// </summary>        /// <param name="svc">The split view controller that owns the first view controller.</param>        /// <param name="shouldHideViewController">The first view controller in the array of view controllers.</param>        /// <param name="inOrientation">The orientation being considered.</param>        //[iOSVersion(5)]        //[Export("splitViewController")]        //[Optional]        bool SplitViewController(UISplitViewController svc, UIViewController shouldHideViewController, UIInterfaceOrientation inOrientation);                /// <summary>        /// Tells the delegate that the specified view controller is about to be hidden.        /// </summary>        /// <param name="svc">The split view controller that owns the specified view controller.</param>        /// <param name="willHideViewController">The view controller being hidden.</param>        /// <param name="withBarButtonItem">A button you can add to your toolbar.</param>        /// <param name="forPopoverController">The popover controller that uses taps in barButtonItem to display the specified view controller.</param>        //[iOSVersion(2)]        //[Export("splitViewController")]        //[Optional]        void SplitViewController(UISplitViewController svc, UIViewController willHideViewController, UIBarButtonItem withBarButtonItem, UIPopoverController forPopoverController);                /// <summary>        /// Tells the delegate that the specified view controller is about to be shown again.        /// </summary>        /// <param name="svc">The split view controller that owns the specified view controller.</param>        /// <param name="willShowViewController">The view controller being hidden.</param>        /// <param name="invalidatingBarButtonItem">The button used to display the view controller while it was hidden.</param>        //[iOSVersion(2)]        //[Export("splitViewController")]        //[Optional]        void SplitViewController(UISplitViewController svc, UIViewController willShowViewController, UIBarButtonItem invalidatingBarButtonItem);                /// <summary>        /// Tells the delegate that the hidden view controller is about to be displayed in a popover.        /// </summary>        /// <param name="svc">The split view controller that owns the hidden view controller.</param>        /// <param name="popoverController">The popover controller that is about to display the view controller.</param>        /// <param name="willPresentViewController">The view controller to be displayed in the popover.</param>        //[iOSVersion(2)]        //[Export("splitViewController")]        //[Optional]        void SplitViewController(UISplitViewController svc, UIPopoverController popoverController, UIViewController willPresentViewController);    }}