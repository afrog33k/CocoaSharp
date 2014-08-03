using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UIMotionEffect class is an abstract superclass for defining motion-based modifiers for views. Subclasses are responsible for defining the behavior to apply to a view when motion is detected. They do this by overriding the keyPathsAndRelativeValuesForViewerOffset: method and returning one or more key paths representing the view properties to modify.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMotionEffect_class/index.html#//apple_ref/occ/cl/UIMotionEffect"/>    [iOSVersion(7)]    public class UIMotionEffect : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// For a given set of offset values, returns the view properties (and corresponding values) to update.        /// </summary>        /// <param name="viewerOffset">The direction that the device is facing relative to the viewer. The range of each offset value is -1 to 1. When the device’s screen is pointed directly at the user, the offset values are (0, 0). Rotating the phone so that the screen points down or to the right of the viewer yields a positive value. Rotating the phone so that the screen points above the user or to the user’s left yields a negative value.</param>        [iOSVersion(7)]        [Export("keyPathsAndRelativeValuesForViewerOffset")]        public Dictionary<NSObject, AnyObject> KeyPathsAndRelativeValuesForViewerOffset(UIOffset viewerOffset) { return default(Dictionary<NSObject, AnyObject>); }    }}