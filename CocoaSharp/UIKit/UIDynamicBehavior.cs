using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// A dynamic behavior confers a behavioral configuration on one or more dynamic items for their participation in two-dimensional animation.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDynamicBehavior_Class/index.html#//apple_ref/occ/cl/UIDynamicBehavior"/>    [iOSVersion(7)]    public class UIDynamicBehavior : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Adds a dynamic behavior, as a child, to a custom dynamic behavior.        /// </summary>        /// <param name="behavior">The dynamic behavior you want to add as a child.        ///   The parent behavior ignores your use of this method if you:        ///   Provide a nil value        ///   Provide a behavior instance that you’ve already added to the behavior</param>        [iOSVersion(7)]        [Export("addChildBehavior")]        public void AddChildBehavior(UIDynamicBehavior behavior) {  }                /// <summary>        /// Removes a child dynamic behavior from a custom dynamic behavior.        /// </summary>        /// <param name="behavior">The child dynamic behavior you want to remove.        ///   The parent behavior ignores your use of this method if you:        ///   Provide a nil value        ///   Provide a behavior instance that is not a child of the parent behavior</param>        [iOSVersion(7)]        [Export("removeChildBehavior")]        public void RemoveChildBehavior(UIDynamicBehavior behavior) {  }                /// <summary>        /// Called when the dynamic behavior is added to, or removed from, a dynamic animator.        /// </summary>        /// <param name="dynamicAnimator">The dynamic animator that the behavior is being added to, or nil if being removed from an animator.</param>        [iOSVersion(7)]        [Export("willMoveToAnimator")]        public void WillMoveToAnimator(UIDynamicAnimator dynamicAnimator) {  }                /// <summary>        /// The block you want to execute during dynamic animation.        /// </summary>        [iOSVersion(7)]        [Export("action")]        public Action Action { get; set; }                /// <summary>        /// Returns the array of dynamic behaviors that are children of a custom dynamic behavior. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("childBehaviors")]        public AnyObject[] ChildBehaviors { get; private set; }                /// <summary>        /// The dynamic animator that the dynamic behavior is associated with. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("dynamicAnimator")]        public UIDynamicAnimator DynamicAnimator { get; private set; }    }}