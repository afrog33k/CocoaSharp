using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// Instances of the UIMarkupTextPrintFormatter class lay out HTML markup text for a multipage print job.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMarkupTextPrintFormatter_Class/index.html#//apple_ref/occ/cl/UIMarkupTextPrintFormatter"/>    [iOSVersion(4.2)]    public class UIMarkupTextPrintFormatter : UIPrintFormatter//, AnyObject, NSCopying, NSObjectProtocol    {        public UIMarkupTextPrintFormatter() { }        /// <summary>        /// Returns a markup-text print formatter initialized with an HTML string.        /// </summary>        /// <param name="markupText">A string of HTML markup text or nil if you want to add the markup text later.</param>        [iOSVersion(4.2)]        public UIMarkupTextPrintFormatter(string markupText) { }                /// <summary>        /// The HTML markup text for the print formatter.        /// </summary>        [iOSVersion(4.2)]        [Export("markupText")]        public string MarkupText { get; set; }    }}