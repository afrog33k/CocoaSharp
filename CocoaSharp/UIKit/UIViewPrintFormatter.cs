using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// An instance of the UIViewPrintFormatter class lays out the drawn content of a view for printing. The view’s content can span multiple pages.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIViewPrintFormatter_Class/index.html#//apple_ref/occ/cl/UIViewPrintFormatter"/>    [iOSVersion(4.2)]    public class UIViewPrintFormatter : UIPrintFormatter//, AnyObject, NSCopying, NSObjectProtocol    {        public UIViewPrintFormatter() { }        /// <summary>        /// The view from which the view print formatter was derived. (read-only)        /// </summary>        [iOSVersion(4.2)]        [Export("view")]        public UIView View { get; private set; }    }}