using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIMotionEffectGroup class manages a collection of motion effects that you want to apply to a view at the same time. This class behaves similarly to the CAAnimationGroup class in Core Animation. The key paths and values returned by each motion effect object are applied simultaneously and with the same timing.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMotionEffectGroup_class/index.html#//apple_ref/occ/cl/UIMotionEffectGroup"/>    [iOSVersion(7)]    public class UIMotionEffectGroup : UIMotionEffect//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// An array of motion effect objects to apply as a group to the view.        /// </summary>        [iOSVersion(7)]        [Export("motionEffects")]        public AnyObject[] MotionEffects { get; set; }    }}