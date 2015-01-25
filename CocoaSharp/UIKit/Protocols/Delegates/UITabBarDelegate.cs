using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UITabBarDelegate protocol defines optional methods for a delegate of a UITabBar object. The UITabBar class provides the ability for the user to reorder, remove, and add items to the tab bar; this process is referred to as customizing the tab bar. The tab bar delegate receives messages when customizing occurs.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITabBarDelegate_Protocol/index.html#//apple_ref/occ/intf/UITabBarDelegate"/>    [iOSVersion(2)]    [Export("")]    public interface UITabBarDelegate//: NSObjectProtocol    {        /// <summary>        /// Sent to the delegate before the customizing modal view is displayed.        /// </summary>        /// <param name="tabBar">The tab bar that is being customized.</param>        /// <param name="willBeginCustomizingItems">The items on the customizing modal view.</param>        //[iOSVersion(2)]        //[Export("tabBar")]        //[InheritOptional]        //void TabBar(UITabBar tabBar, AnyObject[] willBeginCustomizingItems);                /// <summary>        /// Sent to the delegate after the customizing modal view is displayed.        /// </summary>        /// <param name="tabBar">The tab bar that is being customized.</param>        /// <param name="didBeginCustomizingItems">The items on the customizing modal view.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(2)]        //[Export("tabBar")]        //[InheritOptional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        //void TabBar(UITabBar tabBar, AnyObject[] didBeginCustomizingItems, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent to the delegate before the customizing modal view is dismissed.        /// </summary>        /// <param name="tabBar">The tab bar that is being customized.</param>        /// <param name="willEndCustomizingItems">The items on the customizing modal view.</param>        /// <param name="changed">true if the visible set of items on the tab bar changed; otherwise, false.</param>        //[iOSVersion(2)]        //[Export("tabBar")]        //[InheritOptional]        //void TabBar(UITabBar tabBar, AnyObject[] willEndCustomizingItems, bool changed);                /// <summary>        /// Sent to the delegate after the customizing modal view is dismissed.        /// </summary>        /// <param name="tabBar">The tab bar that is being customized.</param>        /// <param name="didEndCustomizingItems">The items on the customizing modal view.</param>        /// <param name="changed">true if the visible set of items on the tab bar changed; otherwise, false.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(2)]        //[Export("tabBar")]        //[InheritOptional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        //void TabBar(UITabBar tabBar, AnyObject[] didEndCustomizingItems, bool changed, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent to the delegate when the user selects a tab bar item. (required)        /// </summary>        /// <param name="tabBar">The tab bar that is being customized.</param>        /// <param name="didSelectItem">The tab bar item that was selected.</param>        //[iOSVersion(2)]        //[Export("tabBar")]        //[InheritOptional]        //void TabBar(UITabBar tabBar, [Unwrapped] UITabBarItem didSelectItem);    }}