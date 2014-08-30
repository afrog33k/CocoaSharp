using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A toolbar is a control that displays one or more buttons, called toolbar items. A toolbar momentarily highlights or does not change the appearance of an item when tapped.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIToolbar_Class/index.html#//apple_ref/occ/cl/UIToolbar"/>    [iOSVersion(2)]    public class UIToolbar : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UIBarPositioning, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        public UIToolbar() { }        /// <summary>        /// Sets the items on the toolbar by animating the changes.        /// </summary>        /// <param name="items">The items to display on the toolbar.</param>        /// <param name="animated">A Boolean value if set to true animates the transition to the items; otherwise, does not.</param>        [iOSVersion(2)]        [Export("setItems")]        public virtual void SetItems(AnyObject[] items, bool animated) {  }                /// <summary>        /// Returns the image to use for the background in a given position and with given metrics.        /// </summary>        /// <param name="topOrBottom">The location the bar is being drawn in.</param>        /// <param name="barMetrics">The metrics being used to draw the bar.</param>        [iOSVersion(5)]        [Export("backgroundImageForToolbarPosition")]        public virtual UIImage BackgroundImageForToolbarPosition(UIBarPosition topOrBottom, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the image to use for the background in a given position and with given metrics.        /// </summary>        /// <param name="backgroundImage">The image to use for the toolbar background in the position specified by topOrBottom and with the metrics specified by barMetrics.</param>        /// <param name="forToolbarPosition">A toolbar position constant.</param>        /// <param name="barMetrics">A bar metrics constant.</param>        [iOSVersion(5)]        [Export("setBackgroundImage")]        public virtual void SetBackgroundImage(UIImage backgroundImage, UIBarPosition forToolbarPosition, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the image to use for the toolbar shadow in a given position.        /// </summary>        /// <param name="topOrBottom">A toolbar position constant. You can use this parameter to indicate whether the shadow image returned is intended for use in a toolbar at the top or bottom of the view.</param>        [iOSVersion(6)]        [Export("shadowImageForToolbarPosition")]        public virtual UIImage ShadowImageForToolbarPosition(UIBarPosition topOrBottom) { return default(UIImage); }                /// <summary>        /// Sets the image to use for the toolbar shadow in a given position.        /// </summary>        /// <param name="shadowImage">The image to use for the toolbar shadow in the position specified by topOrBottom.</param>        /// <param name="forToolbarPosition">A toolbar position constant. You can use this parameter to indicate whether the shadowImage is intended for a toolbar at the top or bottom of the view.</param>        [iOSVersion(6)]        [Export("setShadowImage")]        public virtual void SetShadowImage(UIImage shadowImage, UIBarPosition forToolbarPosition) {  }                /// <summary>        /// The items displayed on the toolbar.        /// </summary>        [iOSVersion(2)]        [Export("items")]        public AnyObject[] Items { get; set; }                /// <summary>        /// The toolbar style that specifies its appearance.        /// </summary>        [iOSVersion(2)]        [Export("barStyle")]        public UIBarStyle BarStyle { get; set; }                /// <summary>        /// The tint color to apply to the toolbar background.        /// </summary>        [iOSVersion(7)]        [Export("barTintColor")]        public UIColor BarTintColor { get; set; }                /// <summary>        /// The tint color to apply to the bar button items.        /// </summary>        [iOSVersion(2)]        [Export("tintColor")]        public UIColor TintColor { get; set; }                /// <summary>        /// A Boolean value that indicates whether the toolbar is translucent (true) or not (false).        /// </summary>        [iOSVersion(3)]        [Export("translucent")]        public bool Translucent { get; set; }                /// <summary>        /// The toolbar’s delegate object.        /// </summary>        [iOSVersion(7)]        [Export("delegate")]        public UIToolbarDelegate Delegate { get; set; }    }}