using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIColor object represents color and sometimes opacity (alpha value). You can use UIColor objects to store color data, and during drawing you can use them to set the current fill and stroke colors.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIColor_Class/index.html#//apple_ref/occ/cl/UIColor"/>    [iOSVersion(2)]    [Export("")]    public class UIColor : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable    {        public UIColor() { }        /// <summary>        /// Creates and returns a color object that has the same color space and component values as the receiver, but has the specified alpha component.        /// </summary>        /// <param name="alpha">The opacity value of the new UIColor object.</param>        [iOSVersion(2)]        [Export("colorWithAlphaComponent")]        public virtual UIColor ColorWithAlphaComponent(CGFloat alpha) { return default(UIColor); }                /// <summary>        /// Initializes and returns a color object using the specified opacity and grayscale values.        /// </summary>        /// <param name="white">The grayscale value of the color object, specified as a value from 0.0 to 1.0.</param>        /// <param name="alpha">The opacity value of the color object, specified as a value from 0.0 to 1.0.</param>        [iOSVersion(2)]        public UIColor(CGFloat white, CGFloat alpha) { }                /// <summary>        /// Initializes and returns a color object using the specified opacity and HSB color space component values.        /// </summary>        /// <param name="hue">The hue component of the color object in the HSB color space, specified as a value from 0.0 to 1.0.</param>        /// <param name="saturation">The saturation component of the color object in the HSB color space, specified as a value from 0.0 to 1.0.</param>        /// <param name="brightness">The brightness (or value) component of the color object in the HSB color space, specified as a value from 0.0 to 1.0.</param>        /// <param name="alpha">The opacity value of the color object, specified as a value from 0.0 to 1.0.</param>        [iOSVersion(2)]        public UIColor(CGFloat hue, CGFloat saturation, CGFloat brightness, CGFloat alpha) { }                /// <summary>        /// Initializes and returns a color object using the specified opacity and RGB component values.        /// </summary>        /// <param name="red">The red component of the color object, specified as a value from 0.0 to 1.0.</param>        /// <param name="green">The green component of the color object, specified as a value from 0.0 to 1.0.</param>        /// <param name="blue">The blue component of the color object, specified as a value from 0.0 to 1.0.</param>        /// <param name="alpha">The opacity value of the color object, specified as a value from 0.0 to 1.0.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public UIColor(CGFloat red, CGFloat green, CGFloat blue, CGFloat alpha, bool NAME_YOUR_PARAMS = false) { }                /// <summary>        /// Initializes and returns a color object using the specified Quartz color reference.        /// </summary>        /// <param name="CGColor">A reference to a Quartz color.</param>        [iOSVersion(2)]        public UIColor([Unwrapped] CGColor CGColor) { }                /// <summary>        /// Initializes and returns a color object using the specified Quartz color reference.        /// </summary>        /// <param name="patternImage">The image to use when creating the pattern color.</param>        [iOSVersion(2)]        public UIColor(UIImage patternImage) { }                /// <summary>        /// Initializes and returns a color object using the specified Core Image color.        /// </summary>        /// <param name="CIColor">The Core Image color to convert.</param>        [iOSVersion(5)]        public UIColor(CIColor CIColor) { }                /// <summary>        /// Returns a color object whose grayscale value is 0.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("blackColor")]        public static UIColor BlackColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose grayscale value is 1/3 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("darkGrayColor")]        public static UIColor DarkGrayColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose grayscale value is 2/3 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("lightGrayColor")]        public static UIColor LightGrayColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose grayscale value is 1.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("whiteColor")]        public static UIColor WhiteColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose grayscale value is 0.5 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("grayColor")]        public static UIColor GrayColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 1.0, 0.0, and 0.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("redColor")]        public static UIColor RedColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 0.0, 1.0, and 0.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("greenColor")]        public static UIColor GreenColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 0.0, 0.0, and 1.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("blueColor")]        public static UIColor BlueColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 0.0, 1.0, and 1.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("cyanColor")]        public static UIColor CyanColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 1.0, 1.0, and 0.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("yellowColor")]        public static UIColor YellowColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 1.0, 0.0, and 1.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("magentaColor")]        public static UIColor MagentaColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 1.0, 0.5, and 0.0 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("orangeColor")]        public static UIColor OrangeColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 0.5, 0.0, and 0.5 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("purpleColor")]        public static UIColor PurpleColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose RGB values are 0.6, 0.4, and 0.2 and whose alpha value is 1.0.        /// </summary>        [iOSVersion(2)]        [Export("brownColor")]        public static UIColor BrownColor() { return default(UIColor); }                /// <summary>        /// Returns a color object whose grayscale and alpha values are both 0.0.        /// </summary>        [iOSVersion(2)]        [Export("clearColor")]        public static UIColor ClearColor() { return default(UIColor); }                /// <summary>        /// Returns the system color used for displaying text on a dark background.        /// </summary>        [iOSVersion(2)]        [Export("lightTextColor")]        public static UIColor LightTextColor() { return default(UIColor); }                /// <summary>        /// Returns the system color used for displaying text on a light background.        /// </summary>        [iOSVersion(2)]        [Export("darkTextColor")]        public static UIColor DarkTextColor() { return default(UIColor); }                /// <summary>        /// Returns the system color used for the background of a grouped table.        /// </summary>        [iOSVersion(2)]        [Export("groupTableViewBackgroundColor")]        public static UIColor GroupTableViewBackgroundColor() { return default(UIColor); }                /// <summary>        /// Returns the components that make up the color in the HSB color space.        /// </summary>        /// <param name="hue">On return, the hue component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="saturation">On return, the saturation component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="brightness">On return, the brightness component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="alpha">On return, the opacity component of the color object, specified as a value between 0.0 and 1.0.</param>        [iOSVersion(5)]        [Export("getHue")]        public virtual bool GetHue(UnsafeMutablePointer<CGFloat> hue, UnsafeMutablePointer<CGFloat> saturation, UnsafeMutablePointer<CGFloat> brightness, UnsafeMutablePointer<CGFloat> alpha) { return default(bool); }                /// <summary>        /// Returns the components that make up the color in the RGB color space.        /// </summary>        /// <param name="red">On return, the red component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="green">On return, the green component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="blue">On return, the blue component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="alpha">On return, the opacity component of the color object, specified as a value between 0.0 and 1.0.</param>        [iOSVersion(5)]        [Export("getRed")]        public virtual bool GetRed(UnsafeMutablePointer<CGFloat> red, UnsafeMutablePointer<CGFloat> green, UnsafeMutablePointer<CGFloat> blue, UnsafeMutablePointer<CGFloat> alpha) { return default(bool); }                /// <summary>        /// Returns the grayscale components of the color.        /// </summary>        /// <param name="white">On return, the grayscale component of the color object, specified as a value between 0.0 and 1.0.</param>        /// <param name="alpha">On return, the opacity component of the color object, specified as a value between 0.0 and 1.0.</param>        [iOSVersion(5)]        [Export("getWhite")]        public virtual bool GetWhite(UnsafeMutablePointer<CGFloat> white, UnsafeMutablePointer<CGFloat> alpha) { return default(bool); }                /// <summary>        /// Sets the color of subsequent stroke and fill operations to the color that the receiver represents.        /// </summary>        [iOSVersion(2)]        [Export("set")]        public virtual void Set() {  }                /// <summary>        /// Sets the color of subsequent fill operations to the color that the receiver represents.        /// </summary>        [iOSVersion(2)]        [Export("setFill")]        public virtual void SetFill() {  }                /// <summary>        /// Sets the color of subsequent stroke operations to the color that the receiver represents.        /// </summary>        [iOSVersion(2)]        [Export("setStroke")]        public virtual void SetStroke() {  }                /// <summary>        /// The Quartz color reference that corresponds to the receiver’s color. (read-only)        /// </summary>        [iOSVersion(2)]        [Unwrapped]        public CGColor CGColor { get; private set; }                /// <summary>        /// The Core Image color associated with the receiver. (read-only)        /// </summary>        [iOSVersion(5)]        public CIColor CIColor { get; private set; }    }}