using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UILabel class implements a read-only text view. You can use this class to draw one or multiple lines of static text, such as those you might use to identify other parts of your user interface. The base UILabel class provides support for both simple and complex styling of the label text. You can also control over aspects of appearance, such as whether the label uses a shadow or draws with a highlight. If needed, you can customize the appearance of your text further by subclassing.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UILabel_Class/index.html#//apple_ref/occ/cl/UILabel"/>    [iOSVersion(2)]    public class UILabel : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        public UILabel() : base(new CGRect()) { }        /// <summary>        /// Returns the drawing rectangle for the label’s text.        /// </summary>        /// <param name="bounds">The bounding rectangle of the receiver.</param>        /// <param name="limitedToNumberOfLines">The maximum number of lines to use for the label. The value 0 indicates there is no maximum number of lines and that the rectangle should encompass all of the text.</param>        [iOSVersion(2)]        [Export("textRectForBounds")]        public CGRect TextRectForBounds(CGRect bounds, int limitedToNumberOfLines) { return default(CGRect); }                /// <summary>        /// Draws the receiver’s text (or its shadow) in the specified rectangle.        /// </summary>        /// <param name="rect">The rectangle in which to draw the text.</param>        [iOSVersion(2)]        [Export("drawTextInRect")]        public void DrawTextInRect(CGRect rect) {  }                /// <summary>        /// The text displayed by the label.        /// </summary>        [iOSVersion(2)]        [Export("text")]        public string Text { get; set; }                /// <summary>        /// The styled text displayed by the label.        /// </summary>        [iOSVersion(6)]        [Export("attributedText")]        public NSAttributedString AttributedText { get; set; }                /// <summary>        /// The font of the text.        /// </summary>        [iOSVersion(2)]        [Export("font")]        public UIFont Font { get; set; }                /// <summary>        /// The color of the text.        /// </summary>        [iOSVersion(2)]        [Export("textColor")]        public UIColor TextColor { get; set; }                /// <summary>        /// The technique to use for aligning the text.        /// </summary>        [iOSVersion(2)]        [Export("textAlignment")]        public NSTextAlignment TextAlignment { get; set; }                /// <summary>        /// The technique to use for wrapping and truncating the label’s text.        /// </summary>        [iOSVersion(2)]        [Export("lineBreakMode")]        public NSLineBreakMode LineBreakMode { get; set; }                /// <summary>        /// The enabled state to use when drawing the label’s text.        /// </summary>        [iOSVersion(2)]        [Export("enabled")]        public bool Enabled { get; set; }                /// <summary>        /// A Boolean value indicating whether the font size should be reduced in order to fit the title string into the label’s bounding rectangle.        /// </summary>        [iOSVersion(2)]        [Export("adjustsFontSizeToFitWidth")]        public bool AdjustsFontSizeToFitWidth { get; set; }                /// <summary>        /// Controls how text baselines are adjusted when text needs to shrink to fit in the label.        /// </summary>        [iOSVersion(2)]        [Export("baselineAdjustment")]        public UIBaselineAdjustment BaselineAdjustment { get; set; }                /// <summary>        /// The minimum scale factor supported for the label’s text.        /// </summary>        [iOSVersion(6)]        [Export("minimumScaleFactor")]        public CGFloat MinimumScaleFactor { get; set; }                /// <summary>        /// The maximum number of lines to use for rendering text.        /// </summary>        [iOSVersion(2)]        [Export("numberOfLines")]        public int NumberOfLines { get; set; }                /// <summary>        /// The highlight color applied to the label’s text.        /// </summary>        [iOSVersion(2)]        [Export("highlightedTextColor")]        public UIColor HighlightedTextColor { get; set; }                /// <summary>        /// A Boolean value indicating whether the receiver should be drawn with a highlight.        /// </summary>        [iOSVersion(2)]        [Export("highlighted")]        public bool Highlighted { get; set; }                /// <summary>        /// The shadow color of the text.        /// </summary>        [iOSVersion(2)]        [Export("shadowColor")]        public UIColor ShadowColor { get; set; }                /// <summary>        /// The shadow offset (measured in points) for the text.        /// </summary>        [iOSVersion(2)]        [Export("shadowOffset")]        public CGSize ShadowOffset { get; set; }                /// <summary>        /// A Boolean value that determines whether user events are ignored and removed from the event queue.        /// </summary>        [iOSVersion(2)]        [Export("userInteractionEnabled")]        public bool UserInteractionEnabled { get; set; }                /// <summary>        /// The preferred maximum width (in points) for a multiline label.        /// </summary>        [iOSVersion(6)]        [Export("preferredMaxLayoutWidth")]        public CGFloat PreferredMaxLayoutWidth { get; set; }    }}