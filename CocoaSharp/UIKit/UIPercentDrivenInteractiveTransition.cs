using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A percent-driven interactive transition object drives the custom animation between the disappearance of one view controller and the appearance of another. It relies on a transition animator delegate—a custom object that adopts the UIViewControllerAnimatorTransitioning protocol—to set up and perform the animations.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPercentDrivenInteractiveTransition_class/index.html#//apple_ref/occ/cl/UIPercentDrivenInteractiveTransition"/>    [iOSVersion(7)]    public class UIPercentDrivenInteractiveTransition : NSObject//, AnyObject, NSObjectProtocol, UIViewControllerInteractiveTransitioning    {        public UIPercentDrivenInteractiveTransition() { }        /// <summary>        /// Updates the completion percentage of the transition.        /// </summary>        /// <param name="percentComplete">The percentage of the transition that is currently complete, specified as a floating-point number in the range 0.0 to 1.0. If you specify a value less than 0.0, this method changes it to 0.0. Specifying a value greater than 1.0 would cause the animation to appear complete already.</param>        [iOSVersion(7)]        [Export("updateInteractiveTransition")]        public virtual void UpdateInteractiveTransition(CGFloat percentComplete) {  }                /// <summary>        /// Notifies the system that user interactions canceled the transition.        /// </summary>        [iOSVersion(7)]        [Export("cancelInteractiveTransition")]        public virtual void CancelInteractiveTransition() {  }                /// <summary>        /// Notifies the system that user interactions signaled the completion of the transition.        /// </summary>        [iOSVersion(7)]        [Export("finishInteractiveTransition")]        public virtual void FinishInteractiveTransition() {  }                /// <summary>        /// Indicates the animation completion curve for an interactive transition.        /// </summary>        [iOSVersion(7)]        [Export("completionCurve")]        public UIViewAnimationCurve CompletionCurve { get; set; }                /// <summary>        /// The overall duration (in seconds) of the transition animation. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("duration")]        public CGFloat Duration { get; private set; }                /// <summary>        /// The amount of the transition (specified as a percentage of the overall duration) that is complete. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("percentComplete")]        public CGFloat PercentComplete { get; private set; }                /// <summary>        /// The speed of the transition animation.        /// </summary>        [iOSVersion(7)]        [Export("completionSpeed")]        public CGFloat CompletionSpeed { get; set; }    }}