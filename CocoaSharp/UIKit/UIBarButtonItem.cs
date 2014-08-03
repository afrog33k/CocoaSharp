using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// A bar button item is a button specialized for placement on a UIToolbar or UINavigationBar object. It inherits basic button behavior from its abstract superclass, UIBarItem. The UIBarButtonItem defines additional initialization methods and properties for use on toolbars and navigation bars.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIBarButtonItem_Class/index.html#//apple_ref/occ/cl/UIBarButtonItem"/>    [iOSVersion(2)]    public class UIBarButtonItem : UIBarItem//, AnyObject, NSCoding, NSObjectProtocol, UIAccessibilityIdentification, UIAppearance    {        /// <summary>        /// Initializes a new item containing the specified system item.        /// </summary>        /// <param name="barButtonSystemItem">The system item to use as the first item on the bar. One of the constants defined in UIBarButtonSystemItem.</param>        /// <param name="target">The object that receives the action message.</param>        /// <param name="action">The action to send to target when this item is selected.</param>        [iOSVersion(2)]        public UIBarButtonItem(UIBarButtonSystemItem barButtonSystemItem, AnyObject target, Selector action) { }                /// <summary>        /// Initializes a new item using the specified custom view.        /// </summary>        /// <param name="customView">A custom view representing the item.</param>        [iOSVersion(2)]        public UIBarButtonItem(UIView customView) { }                /// <summary>        /// Initializes a new item using the specified image and other properties.        /// </summary>        /// <param name="image">The item’s image. If nil an image is not displayed.        ///   The images displayed on the bar are derived from this image. If this image is too large to fit on the bar, it is scaled to fit. Typically, the size of a toolbar and navigation bar image is 20 x 20 points. The alpha values in the source image are used to create the images—opaque values are ignored.</param>        /// <param name="style">The style of the item. One of the constants defined in UIBarButtonItemStyle.</param>        /// <param name="target">The object that receives the action message.</param>        /// <param name="action">The action to send to target when this item is selected.</param>        [iOSVersion(2)]        public UIBarButtonItem(UIImage image, UIBarButtonItemStyle style, AnyObject target, Selector action) { }                /// <summary>        /// Initializes a new item using the specified title and other properties.        /// </summary>        /// <param name="title">The item’s title. If nil a title is not displayed.</param>        /// <param name="style">The style of the item. One of the constants defined in UIBarButtonItemStyle.</param>        /// <param name="target">The object that receives the action message.</param>        /// <param name="action">The action to send to target when this item is selected.</param>        [iOSVersion(2)]        public UIBarButtonItem(string title, UIBarButtonItemStyle style, AnyObject target, Selector action) { }                /// <summary>        /// Initializes a new item using the specified images and other properties.        /// </summary>        /// <param name="image">The item’s image. If nil an image is not displayed.</param>        /// <param name="landscapeImagePhone">The image to be used for the item in landscape bars in the UIUserInterfaceIdiomPhone idiom.</param>        /// <param name="style">The style of the item. One of the constants defined in UIBarButtonItemStyle.</param>        /// <param name="target">The object that receives the action message.</param>        /// <param name="action">The action to send to target when this item is selected.</param>        [iOSVersion(5)]        public UIBarButtonItem(UIImage image, UIImage landscapeImagePhone, UIBarButtonItemStyle style, AnyObject target, Selector action) { }                /// <summary>        /// Returns the back button background image for a given control state and bar metrics.        /// </summary>        /// <param name="state">A control state.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("backButtonBackgroundImageForState")]        public UIImage BackButtonBackgroundImageForState(UIControlState state, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the back button background image for a given control state and bar metrics        /// </summary>        /// <param name="backgroundImage">The image to use for the back button’s background.</param>        /// <param name="forState">A control state.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setBackButtonBackgroundImage")]        public void SetBackButtonBackgroundImage(UIImage backgroundImage, UIControlState forState, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the back button title offset for given bar metrics.        /// </summary>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("backButtonTitlePositionAdjustmentForBarMetrics")]        public UIOffset BackButtonTitlePositionAdjustmentForBarMetrics(UIBarMetrics barMetrics) { return default(UIOffset); }                /// <summary>        /// Sets the back button title offset for given bar metrics        /// </summary>        /// <param name="adjustment">The back button title offset for barMetrics.</param>        /// <param name="forBarMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setBackButtonTitlePositionAdjustment")]        public void SetBackButtonTitlePositionAdjustment(UIOffset adjustment, UIBarMetrics forBarMetrics) {  }                /// <summary>        /// Returns the back button vertical position offset for given bar metrics.        /// </summary>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics")]        public CGFloat BackButtonBackgroundVerticalPositionAdjustmentForBarMetrics(UIBarMetrics barMetrics) { return default(CGFloat); }                /// <summary>        /// Sets the back button vertical position offset for given bar metrics.        /// </summary>        /// <param name="adjustment">The back button vertical position offset for barMetrics.</param>        /// <param name="forBarMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setBackButtonBackgroundVerticalPositionAdjustment")]        public void SetBackButtonBackgroundVerticalPositionAdjustment(CGFloat adjustment, UIBarMetrics forBarMetrics) {  }                /// <summary>        /// Returns the background vertical position offset for given bar metrics.        /// </summary>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("backgroundVerticalPositionAdjustmentForBarMetrics")]        public CGFloat BackgroundVerticalPositionAdjustmentForBarMetrics(UIBarMetrics barMetrics) { return default(CGFloat); }                /// <summary>        /// Sets the background vertical position offset for given bar metrics.        /// </summary>        /// <param name="adjustment">The background vertical position offset for barMetrics.</param>        /// <param name="forBarMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setBackgroundVerticalPositionAdjustment")]        public void SetBackgroundVerticalPositionAdjustment(CGFloat adjustment, UIBarMetrics forBarMetrics) {  }                /// <summary>        /// Returns the background image for a given state and bar metrics.        /// </summary>        /// <param name="state">A control state.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("backgroundImageForState")]        public UIImage BackgroundImageForState(UIControlState state, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the background image for a given state and bar metrics.        /// </summary>        /// <param name="backgroundImage">The background image for the specified state and metrics.</param>        /// <param name="forState">A control state.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage backgroundImage, UIControlState forState, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the background image for the specified state, style, and metrics.        /// </summary>        /// <param name="state">The bar button state.</param>        /// <param name="style">The bar button style.</param>        /// <param name="barMetrics">The bar button metrics.</param>        [iOSVersion(6)]        [Export("backgroundImageForState")]        public UIImage BackgroundImageForState(UIControlState state, UIBarButtonItemStyle style, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the background image for the specified state, style, and metrics.        /// </summary>        /// <param name="backgroundImage">The background image to use for the specified state, style, and metrics.</param>        /// <param name="forState">The bar button state.</param>        /// <param name="style">The bar button style.</param>        /// <param name="barMetrics">The bar button metrics.</param>        [iOSVersion(6)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage backgroundImage, UIControlState forState, UIBarButtonItemStyle style, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the title offset for given bar metrics.        /// </summary>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("titlePositionAdjustmentForBarMetrics")]        public UIOffset TitlePositionAdjustmentForBarMetrics(UIBarMetrics barMetrics) { return default(UIOffset); }                /// <summary>        /// Sets the title offset for given bar metrics.        /// </summary>        /// <param name="adjustment">The title offset for barMetrics.</param>        /// <param name="forBarMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setTitlePositionAdjustment")]        public void SetTitlePositionAdjustment(UIOffset adjustment, UIBarMetrics forBarMetrics) {  }                /// <summary>        /// The object that receives an action when the item is selected.        /// </summary>        [iOSVersion(2)]        [Export("target")]        public AnyObject Target { get; set; }                /// <summary>        /// The selector defining the action message to send to the target object when the user taps this bar button item.        /// </summary>        [iOSVersion(2)]        [Export("action")]        public Selector Action { get; set; }                /// <summary>        /// The style of the item.        /// </summary>        [iOSVersion(2)]        [Export("style")]        public UIBarButtonItemStyle Style { get; set; }                /// <summary>        /// The set of possible titles to display on the bar button.        /// </summary>        [iOSVersion(2)]        [Export("possibleTitles")]        public NSSet PossibleTitles { get; set; }                /// <summary>        /// The width of the item.        /// </summary>        [iOSVersion(2)]        [Export("width")]        public CGFloat Width { get; set; }                /// <summary>        /// A custom view representing the item.        /// </summary>        [iOSVersion(2)]        [Export("customView")]        public UIView CustomView { get; set; }                /// <summary>        /// The tint color to apply to the button item.        /// </summary>        [iOSVersion(5)]        [Export("tintColor")]        public UIColor TintColor { get; set; }    }    /// <summary>    /// Specifies the style of a item.    /// </summary>    [iOSVersion(2)]    public enum UIBarButtonItemStyle    {        /// <summary>        /// Glows when tapped. The default item style.        /// </summary>        [iOSVersion(2)]        Plain,        /// <summary>        /// A simple button style with a border.        /// Available in iOS 2.0 and later.        /// Deprecated in iOS 8.0.        /// </summary>        [Obsolete]        Bordered,        /// <summary>        /// The style for a done button—for example, a button that completes some task and returns to the previous view.        /// </summary>        [iOSVersion(2)]        Done,    }    /// <summary>    /// Defines system-supplied images for bar button items.    /// </summary>    [iOSVersion(2)]    public enum UIBarButtonSystemItem    {        /// <summary>        /// The system Done button. Localized.        /// </summary>        [iOSVersion(2)]        Done,        /// <summary>        /// The system Cancel button. Localized.        /// </summary>        [iOSVersion(2)]        Cancel,        /// <summary>        /// The system Edit button. Localized.        /// </summary>        [iOSVersion(2)]        Edit,        /// <summary>        /// The system Save button. Localized.        /// </summary>        [iOSVersion(2)]        Save,        /// <summary>        /// The system plus button containing an icon of a plus sign.        /// </summary>        [iOSVersion(2)]        Add,        /// <summary>        /// Blank space to add between other items. The space is distributed equally between the other items. Other item properties are ignored when this value is set.        /// </summary>        [iOSVersion(2)]        FlexibleSpace,        /// <summary>        /// Blank space to add between other items. Only the width property is used when this value is set.        /// </summary>        [iOSVersion(2)]        FixedSpace,        /// <summary>        /// The system compose button.        /// </summary>        [iOSVersion(2)]        Compose,        /// <summary>        /// The system reply button.        /// </summary>        [iOSVersion(2)]        Reply,        /// <summary>        /// The system action button.        /// </summary>        [iOSVersion(2)]        Action,        /// <summary>        /// The system organize button.        /// </summary>        [iOSVersion(2)]        Organize,        /// <summary>        /// The system bookmarks button.        /// </summary>        [iOSVersion(2)]        Bookmarks,        /// <summary>        /// The system search button.        /// </summary>        [iOSVersion(2)]        Search,        /// <summary>        /// The system refresh button.        /// </summary>        [iOSVersion(2)]        Refresh,        /// <summary>        /// The system stop button.        /// </summary>        [iOSVersion(2)]        Stop,        /// <summary>        /// The system camera button.        /// </summary>        [iOSVersion(2)]        Camera,        /// <summary>        /// The system trash button.        /// </summary>        [iOSVersion(2)]        Trash,        /// <summary>        /// The system play button.        /// </summary>        [iOSVersion(2)]        Play,        /// <summary>        /// The system pause button.        /// </summary>        [iOSVersion(2)]        Pause,        /// <summary>        /// The system rewind button.        /// </summary>        [iOSVersion(2)]        Rewind,        /// <summary>        /// The system fast forward button.        /// </summary>        [iOSVersion(2)]        FastForward,        /// <summary>        /// The system undo button.        /// </summary>        [iOSVersion(3)]        Undo,        /// <summary>        /// The system redo button.        /// </summary>        [iOSVersion(3)]        Redo,        /// <summary>        /// The system page curl button.        /// This bar button image can be used only for bar button items placed on toolbars.        /// </summary>        [iOSVersion(4)]        PageCurl,    }}