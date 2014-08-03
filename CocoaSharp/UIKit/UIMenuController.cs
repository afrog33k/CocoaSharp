using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The singleton UIMenuController instance presents the menu interface for the Cut, Copy, Paste, Select, Select All, and Delete commands.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/iPhone/Reference/UIMenuController_Class/index.html#//apple_ref/occ/cl/UIMenuController"/>    [iOSVersion(3)]    public class UIMenuController : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Returns the menu controller.        /// </summary>        [iOSVersion(3)]        [Export("sharedMenuController")]        public static UIMenuController SharedMenuController() { return default(UIMenuController); }                /// <summary>        /// Shows or hides the editing menu, optionally animating the action.        /// </summary>        /// <param name="menuVisible">true if the menu should be shown, false if it should be hidden.</param>        /// <param name="animated">true if the showing or hiding of the menu should be animated, otherwise false.</param>        [iOSVersion(3)]        [Export("setMenuVisible")]        public void SetMenuVisible(bool menuVisible, bool animated) {  }                /// <summary>        /// Sets the area in a view above or below which the editing menu is positioned.        /// </summary>        /// <param name="targetRect">A rectangle that defines the area that is to be the target of the menu commands.</param>        /// <param name="inView">The view in which targetRect appears.</param>        [iOSVersion(3)]        [Export("setTargetRect")]        public void SetTargetRect(CGRect targetRect, UIView inView) {  }                /// <summary>        /// Updates the appearance and enabled state of menu commands.        /// </summary>        [iOSVersion(3)]        [Export("update")]        public void Update() {  }                /// <summary>        /// The visibility of the editing menu.        /// </summary>        [iOSVersion(3)]        [Export("menuVisible")]        public bool MenuVisible { get; set; }                /// <summary>        /// Returns the frame of the editing menu. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("menuFrame")]        public CGRect MenuFrame { get; private set; }                /// <summary>        /// The direction the arrow of the editing menu is pointing.        /// </summary>        [iOSVersion(3.2)]        [Export("arrowDirection")]        public UIMenuControllerArrowDirection ArrowDirection { get; set; }                /// <summary>        /// The custom menu items for the editing menu.        /// </summary>        [iOSVersion(3.2)]        [Export("menuItems")]        public AnyObject[] MenuItems { get; set; }    }    /// <summary>    /// The direction the arrow of the editing menu is pointing.    /// </summary>    [iOSVersion(3.2)]    public enum UIMenuControllerArrowDirection    {        /// <summary>        /// The arrow is pointing up or down at the object of focus based on its location in the screen.        /// </summary>        [iOSVersion(3.2)]        Default,        /// <summary>        /// The arrow is pointing up at the object of focus.        /// </summary>        [iOSVersion(3.2)]        Up,        /// <summary>        /// The arrow is pointing down at the object of focus.        /// </summary>        [iOSVersion(3.2)]        Down,        /// <summary>        /// The arrow is pointing left at the object of focus.        /// </summary>        [iOSVersion(3.2)]        Left,        /// <summary>        /// The arrow is pointing right at the object of focus.        /// </summary>        [iOSVersion(3.2)]        Right,    }    /// <summary>    /// There is no userInfo dictionary.    /// </summary>    [iOSVersion(3)]    public class UIMenuControllerWillShowMenuNotification : NSNotification    {        public UIMenuControllerWillShowMenuNotification() : base("", null) { }    }    /// <summary>    /// There is no userInfo dictionary.    /// </summary>    [iOSVersion(3)]    public class UIMenuControllerDidShowMenuNotification : NSNotification    {        public UIMenuControllerDidShowMenuNotification() : base("", null) { }    }    /// <summary>    /// There is no userInfo dictionary.    /// </summary>    [iOSVersion(3)]    public class UIMenuControllerWillHideMenuNotification : NSNotification    {        public UIMenuControllerWillHideMenuNotification() : base("", null) { }    }    /// <summary>    /// There is no userInfo dictionary.    /// </summary>    [iOSVersion(3)]    public class UIMenuControllerDidHideMenuNotification : NSNotification    {        public UIMenuControllerDidHideMenuNotification() : base("", null) { }    }    /// <summary>    /// There is no userInfo dictionary.    /// </summary>    [iOSVersion(3)]    public class UIMenuControllerMenuFrameDidChangeNotification : NSNotification    {        public UIMenuControllerMenuFrameDidChangeNotification() : base("", null) { }    }}