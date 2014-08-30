using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// Instances of the UISimpleTextPrintFormatter class lay out plain text for printing, possibly over multiple pages. The class allows you to specify global font, color, and text alignment properties for the printed text.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISimpleTextPrintFormatter_Class/index.html#//apple_ref/occ/cl/UISimpleTextPrintFormatter"/>    [iOSVersion(4.2)]    public class UISimpleTextPrintFormatter : UIPrintFormatter//, AnyObject, NSCopying, NSObjectProtocol    {        public UISimpleTextPrintFormatter() { }        /// <summary>        /// Returns a simple-text print formatter initialized with attributed text.        /// </summary>        /// <param name="attributedText">A string of attributed text or nil if you intend to assign the text later.</param>        [iOSVersion(7)]        public UISimpleTextPrintFormatter(NSAttributedString attributedText) { }                /// <summary>        /// Returns a simple-text print formatter initialized with plain text.        /// </summary>        /// <param name="text">A string of plain text or nil if you intend to assign the text later.</param>        [iOSVersion(4.2)]        public UISimpleTextPrintFormatter(string text) { }                /// <summary>        /// A string of attributed text.        /// </summary>        [iOSVersion(7)]        [Export("attributedText")]        public NSAttributedString AttributedText { get; set; }                /// <summary>        /// A string of plain text.        /// </summary>        [iOSVersion(4.2)]        [Export("text")]        public string Text { get; set; }                /// <summary>        /// The font of the printed text.        /// </summary>        [iOSVersion(4.2)]        [Export("font")]        public UIFont Font { get; set; }                /// <summary>        /// The color of the printed text.        /// </summary>        [iOSVersion(4.2)]        [Export("color")]        public UIColor Color { get; set; }                /// <summary>        /// The alignment of the printed text.        /// </summary>        [iOSVersion(4.2)]        [Export("textAlignment")]        public NSTextAlignment TextAlignment { get; set; }    }}