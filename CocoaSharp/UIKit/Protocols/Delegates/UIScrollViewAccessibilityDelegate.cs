using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIScrollViewAccessibilityDelegate protocol defines methods you can implement to provide accessibility information for a scrollview.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIScrollViewAccessibilityDelegate_Protocol/index.html#//apple_ref/occ/intf/UIScrollViewAccessibilityDelegate"/>    [iOSVersion(6)]    public interface UIScrollViewAccessibilityDelegate//: NSObjectProtocol, UIScrollViewDelegate    {        /// <summary>        /// Returns a custom status string for the current offset.        /// </summary>        /// <param name="scrollView"></param>        //[iOSVersion(6)]        //[Export("accessibilityScrollStatusForScrollView")]        //[Optional]        string AccessibilityScrollStatusForScrollView(UIScrollView scrollView);    }}