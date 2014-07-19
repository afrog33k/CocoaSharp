using CoreGraphics;
using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPanGestureRecognizer_Class/index.html#//apple_ref/occ/cl/UIPanGestureRecognizer
    /// <summary>
    /// UIPanGestureRecognizer is a concrete subclass of UIGestureRecognizer that looks for panning (dragging) gestures. The user must be pressing one or more fingers on a view while they pan it. Clients implementing the action method for this gesture recognizer can ask it for the current translation and velocity of the gesture.
    /// </summary>
    [iOSVersion(3.2)]
    public class UIPanGestureRecognizer : UIGestureRecognizer
    {
        //TODO: UIPanGestureRecognizer
        public UIPanGestureRecognizer() : base(new AnyObject(), new Selector()) { }

        /// <summary>
        /// The maximum number of fingers that can be touching the view for this gesture to be recognized.
        /// </summary>
        [iOSVersion(3.2)]
        [Export("maximumNumberOfTouches")]
        public int MaximumNumberOfTouches { get; set; }
        
        /// <summary>
        /// The minimum number of fingers that can be touching the view for this gesture to be recognized.
        /// </summary>
        [iOSVersion(3.2)]
        [Export("minimumNumberOfTouches")]
        public int MinimumNumberOfTouches { get; set; }
        
        /// <summary>
        /// The translation of the pan gesture in the coordinate system of the specified view.
        /// </summary>
        /// <param name="view">The view in whose coordinate system the translation of the pan gesture should be computed. If you want to adjust a view's location to keep it under the user's finger, request the translation in that view's superview's coordinate system.</param>
        /// <returns>A point identifying the new location of a view in the coordinate system of its designated superview.</returns>
        [iOSVersion(3.2)]
        [Export("translationInView")]
        public CGPoint TranslationInView(UIView view) { return new CGPoint(); }
        
        /// <summary>
        /// Sets the translation value in the coordinate system of the specified view.
        /// </summary>
        /// <param name="translation">A point that identifies the new translation value.</param>
        /// <param name="inView">A view in whose coordinate system the translation is to occur.</param>
        [iOSVersion(3.2)]
        [Export("setTranslation")]
        public void SetTranslation(CGPoint translation, UIView inView) { }
        
        /// <summary>
        /// The velocity of the pan gesture in the coordinate system of the specified view.
        /// </summary>
        /// <param name="view">The view in whose coordinate system the velocity of the pan gesture is computed.</param>
        /// <returns>The velocity of the pan gesture, which is expressed in points per second. The velocity is broken into horizontal and vertical components.</returns>
        [iOSVersion(3.2)]
        [Export("velocityInView")]
        public CGPoint VelocityInView(UIView view) { return new CGPoint(); }
    }
}