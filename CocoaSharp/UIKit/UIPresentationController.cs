using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIPresentationController object provides advanced view and transition management for presented view controllers. From the time a view controller is presented until the time it is dismissed, UIKit uses a presentation controller to manage various aspects of the presentation process for that view controller. The presentation controller can add its own animations on top of those provided by animator objects, it can respond to size changes, and it can manage other aspects of how the view controller is presented onscreen.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPresentationController_class/index.html#//apple_ref/occ/cl/UIPresentationController"/>    [iOSVersion(8)]    [Export("")]    public class UIPresentationController : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable, UIAppearanceContainer, UIContentContainer, UITraitEnvironment    {        public UIPresentationController() { }        /// <summary>        /// Initializes and returns a presentation controller for transitioning between the specified view controllers        /// </summary>        /// <param name="presentedViewController">The view controller being presented modally.</param>        /// <param name="presentingViewController">The view controller whose content represents the starting point of the transition.</param>        [iOSVersion(8)]        public UIPresentationController([Unwrapped] UIViewController presentedViewController, [Unwrapped] UIViewController presentingViewController) { }                /// <summary>        /// The view to be animated during the presentation.        /// </summary>        [iOSVersion(8)]        [Export("presentedView")]        [return:Unwrapped]        public virtual UIView PresentedView() { return default(UIView); }                /// <summary>        /// The frame rectangle to assign to the presented view at the end of the animations.        /// </summary>        [iOSVersion(8)]        [Export("frameOfPresentedViewInContainerView")]        public virtual CGRect FrameOfPresentedViewInContainerView() { return default(CGRect); }                /// <summary>        /// Notifies the presentation controller that layout is about to begin on the views of the container view.        /// </summary>        [iOSVersion(8)]        [Export("containerViewWillLayoutSubviews")]        public virtual void ContainerViewWillLayoutSubviews() {  }                /// <summary>        /// Called to notify the presentation controller that layout ended on the views of the container view.        /// </summary>        [iOSVersion(8)]        [Export("containerViewDidLayoutSubviews")]        public virtual void ContainerViewDidLayoutSubviews() {  }                /// <summary>        /// Notifies the presentation controller that the presentation animations are about to start.        /// </summary>        [iOSVersion(8)]        [Export("presentationTransitionWillBegin")]        public virtual void PresentationTransitionWillBegin() {  }                /// <summary>        /// Notifies the presentation controller that the presentation animations finished.        /// </summary>        /// <param name="completed">true if the animations completed and the presented view controller is now visible or false if the animations were canceled and the presenting view controller is still visible.</param>        [iOSVersion(8)]        [Export("presentationTransitionDidEnd")]        public virtual void PresentationTransitionDidEnd(bool completed) {  }                /// <summary>        /// Notifies the presentation controller that the dismissal animations are about to start.        /// </summary>        [iOSVersion(8)]        [Export("dismissalTransitionWillBegin")]        public virtual void DismissalTransitionWillBegin() {  }                /// <summary>        /// Notifies the presentation controller that the dismissal animations finished.        /// </summary>        /// <param name="completed">true if the animations completed and the presented view controller was dismissed or false if the animations were canceled and the presented view controller is still visible.</param>        [iOSVersion(8)]        [Export("dismissalTransitionDidEnd")]        public virtual void DismissalTransitionDidEnd(bool completed) {  }                /// <summary>        /// Returns the presentation style to use when the presented view controller becomes horizontally compact.        /// </summary>        [iOSVersion(8)]        [Export("adaptivePresentationStyle")]        public virtual UIModalPresentationStyle AdaptivePresentationStyle() { return default(UIModalPresentationStyle); }                /// <summary>        /// A Boolean value indicating whether the presentation covers the entire screen.        /// </summary>        [iOSVersion(8)]        [Export("shouldPresentInFullscreen")]        public virtual bool ShouldPresentInFullscreen() { return default(bool); }                /// <summary>        /// A Boolean value indicating whether the presenting view controller’s view should be removed when the presentation animations finish.        /// </summary>        [iOSVersion(8)]        [Export("shouldRemovePresentersView")]        public virtual bool ShouldRemovePresentersView() { return default(bool); }                /// <summary>        /// The view controller that is the starting point for the presentation. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("presentingViewController")]        public UIViewController PresentingViewController { get; private set; }                /// <summary>        /// The view controller being presented. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("presentedViewController")]        public UIViewController PresentedViewController { get; private set; }                /// <summary>        /// The view in which the presentation occurs. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("containerView")]        [Unwrapped]        public UIView ContainerView { get; private set; }                /// <summary>        /// Additional traits to apply to the managed view controllers.        /// </summary>        [iOSVersion(8)]        [Export("overrideTraitCollection")]        [Optional]        public UITraitCollection OverrideTraitCollection { get; set; }                /// <summary>        /// The presentation style of the presented view controller. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("presentationStyle")]        public UIModalPresentationStyle PresentationStyle { get; private set; }                /// <summary>        /// The delegate object for managing adaptive presentations.        /// </summary>        [iOSVersion(8)]        [Export("delegate")]        [Optional]        public UIAdaptivePresentationControllerDelegate Delegate { get; set; }    }}