using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// UIFontDescriptor objects provide a mechanism to describe a font with a dictionary of attributes. This font descriptor can be used later to create or modify a UIFont object. Font descriptors can be archived and unarchived. Font descriptors have a font matching capability, so that you can partially describe a font by creating a font descriptor with, for example, just a family name. You can then find all the available fonts on the system with a matching family name using matchingFontDescriptorsWithMandatoryKeys:.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIFontDescriptor_Class/index.html#//apple_ref/occ/cl/UIFontDescriptor"/>    [iOSVersion(7)]    public class UIFontDescriptor : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        public UIFontDescriptor() { }        /// <summary>        /// Returns a font descriptor containing the given text style and the user's selected content size category.        /// </summary>        /// <param name="style">The text style for which to return a font descriptor. See Text Styles for valid values.</param>        [iOSVersion(7)]        [Export("preferredFontDescriptorWithTextStyle")]        public virtual static UIFontDescriptor PreferredFontDescriptorWithTextStyle(string style) { return default(UIFontDescriptor); }                /// <summary>        /// Returns a font descriptor with the UIFontDescriptorNameAttribute and UIFontDescriptorMatrixAttribute dictionary attributes set to the given values.        /// </summary>        /// <param name="name">The value for UIFontDescriptorNameAttribute.</param>        /// <param name="matrix">The value for UIFontDescriptorMatrixAttribute.</param>        [iOSVersion(7)]        public UIFontDescriptor(string name, CGAffineTransform matrix) { }                /// <summary>        /// Returns a font descriptor with the UIFontDescriptorNameAttribute and UIFontDescriptorSizeAttribute dictionary attributes set to the given values.        /// </summary>        /// <param name="name">The value for UIFontDescriptorNameAttribute.</param>        /// <param name="size">The value for UIFontDescriptorSizeAttribute.</param>        [iOSVersion(7)]        public UIFontDescriptor(string name, CGFloat size) { }                /// <summary>        /// Returns a new font descriptor that is the same as the receiver but with the specified attributes taking precedence over the existing ones.        /// </summary>        /// <param name="attributes">The new attributes.</param>        [iOSVersion(7)]        [Export("fontDescriptorByAddingAttributes")]        public virtual UIFontDescriptor FontDescriptorByAddingAttributes(Dictionary<NSObject, AnyObject> attributes) { return default(UIFontDescriptor); }                /// <summary>        /// Returns a new font descriptor that is the same as the receiver but with the specified face.        /// </summary>        /// <param name="newFace">The new font face.</param>        [iOSVersion(7)]        [Export("fontDescriptorWithFace")]        public virtual UIFontDescriptor FontDescriptorWithFace(string newFace) { return default(UIFontDescriptor); }                /// <summary>        /// Returns a new font descriptor whose attributes are the same as the receiver but from the specified family.        /// </summary>        /// <param name="newFamily">The new font family.</param>        [iOSVersion(7)]        [Export("fontDescriptorWithFamily")]        public virtual UIFontDescriptor FontDescriptorWithFamily(string newFamily) { return default(UIFontDescriptor); }                /// <summary>        /// Returns a new font descriptor that is the same as the receiver but with the specified matrix.        /// </summary>        /// <param name="matrix">The new font matrix.</param>        [iOSVersion(7)]        [Export("fontDescriptorWithMatrix")]        public virtual UIFontDescriptor FontDescriptorWithMatrix(CGAffineTransform matrix) { return default(UIFontDescriptor); }                /// <summary>        /// Returns a new font descriptor that is the same as the receiver but with the specified point size.        /// </summary>        /// <param name="newPointSize">The new point size.</param>        [iOSVersion(7)]        [Export("fontDescriptorWithSize")]        public virtual UIFontDescriptor FontDescriptorWithSize(CGFloat newPointSize) { return default(UIFontDescriptor); }                /// <summary>        /// Returns a new font descriptor that is the same as the receiver but with the specified symbolic traits taking precedence over the existing ones.        /// </summary>        /// <param name="symbolicTraits">The new symbolic traits.</param>        [iOSVersion(7)]        [Export("fontDescriptorWithSymbolicTraits")]        public virtual UIFontDescriptor FontDescriptorWithSymbolicTraits(UIFontDescriptorSymbolicTraits symbolicTraits) { return default(UIFontDescriptor); }                /// <summary>        /// Initializes and returns a new font descriptor with the specified attributes.        /// </summary>        /// <param name="fontAttributes">The attributes for the new font descriptor. If nil, the font descriptor’s attribute dictionary will be empty.</param>        [iOSVersion(7)]        public UIFontDescriptor(Dictionary<NSObject, AnyObject> fontAttributes) { }                /// <summary>        /// Returns all the fonts available on the system whose specified attributes match those of the receiver.        /// </summary>        /// <param name="mandatoryKeys">Keys that must be identical to be matched. Can be nil.</param>        [iOSVersion(7)]        [Export("matchingFontDescriptorsWithMandatoryKeys")]        public virtual AnyObject[] MatchingFontDescriptorsWithMandatoryKeys(NSSet mandatoryKeys) { return default(AnyObject[]); }                /// <summary>        /// Returns the receiver’s dictionary of attributes.        /// </summary>        [iOSVersion(7)]        [Export("fontAttributes")]        public virtual Dictionary<NSObject, AnyObject> FontAttributes() { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Returns the font attribute specified by the given key.        /// </summary>        /// <param name="anAttribute">The font attribute key.</param>        [iOSVersion(7)]        [Export("objectForKey")]        public virtual AnyObject ObjectForKey(string anAttribute) { return default(AnyObject); }                /// <summary>        /// The current transform matrix of the receiver. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("matrix")]        public CGAffineTransform Matrix { get; private set; }                /// <summary>        /// The point size of the receiver. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("pointSize")]        public CGFloat PointSize { get; private set; }                /// <summary>        /// The PostScript name of the receiver. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("postscriptName")]        public string PostscriptName { get; private set; }                /// <summary>        /// A bit mask that describes the traits of the receiver. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("symbolicTraits")]        public UIFontDescriptorSymbolicTraits SymbolicTraits { get; private set; }    }    /// <summary>    /// UIFontDescriptorSymbolicTraits symbolically describes stylistic aspects of a font. The lower 16 bits represent the typeface, and the upper 16 bits describe appearance of the font.    /// </summary>    [iOSVersion(7)]    public enum UIFontDescriptorSymbolicTraits    {        /// <summary>        /// The font’s typestyle is italic.        /// </summary>        [iOSVersion(7)]        TraitItalic,        /// <summary>        /// The font’s typestyle is boldface.        /// </summary>        [iOSVersion(7)]        TraitBold,        /// <summary>        /// The font’s typestyle is expanded. Expanded and condensed traits are mutually exclusive.        /// </summary>        [iOSVersion(7)]        TraitExpanded,        /// <summary>        /// The font’s typestyle is condensed. Expanded and condensed traits are mutually exclusive.        /// </summary>        [iOSVersion(7)]        TraitCondensed,        /// <summary>        /// The font uses fixed-pitch glyphs if available. The font may have multiple glyph advances (many CJK glyphs contain two spaces).        /// </summary>        [iOSVersion(7)]        TraitMonoSpace,        /// <summary>        /// The font uses vertical glyph variants and metrics.        /// </summary>        [iOSVersion(7)]        TraitVertical,        /// <summary>        /// The font synthesizes appropriate attributes for user interface rendering, such as control titles, if necessary.        /// </summary>        [iOSVersion(7)]        TraitUIOptimized,        /// <summary>        /// The font uses tighter leading values.        /// </summary>        [iOSVersion(7)]        TraitTightLeading,        /// <summary>        /// The font uses looser leading values.        /// </summary>        [iOSVersion(7)]        TraitLooseLeading,        /// <summary>        /// The font family class mask used to access UIFontDescriptorClass values.        /// </summary>        [iOSVersion(7)]        ClassMask,        /// <summary>        /// The font has no design classification.        /// </summary>        [iOSVersion(7)]        ClassUnknown,        /// <summary>        /// The font’s style is based on the Latin printing style of the 15th to 17th century.        /// </summary>        [iOSVersion(7)]        ClassOldStyleSerifs,        /// <summary>        /// The font’s style is based on the Latin printing style of the 18th to 19th century.        /// </summary>        [iOSVersion(7)]        ClassTransitionalSerifs,        /// <summary>        /// The font’s style is based on the Latin printing style of the 20th century.        /// </summary>        [iOSVersion(7)]        ClassModernSerifs,        /// <summary>        /// The font’s style is a variation of the Oldstyle Serifs and the Transitional Serifs.        /// </summary>        [iOSVersion(7)]        ClassClarendonSerifs,        /// <summary>        /// The font’s style is characterized by serifs with a square transition between the strokes and the serifs (no brackets).        /// </summary>        [iOSVersion(7)]        ClassSlabSerifs,        /// <summary>        /// The font’s style includes serifs, but it expresses a design freedom that does not generally fit within the other serif design classifications.        /// </summary>        [iOSVersion(7)]        ClassFreeformSerifs,        /// <summary>        /// The font’s style includes most basic letter forms (excluding Scripts and Ornamentals) that do not have serifs on the strokes.        /// </summary>        [iOSVersion(7)]        ClassSansSerif,        /// <summary>        /// The font’s style includes highly decorated or stylized character shapes such as those typically used in headlines.        /// </summary>        [iOSVersion(7)]        ClassOrnamentals,        /// <summary>        /// The font’s style is among those typefaces designed to simulate handwriting.        /// </summary>        [iOSVersion(7)]        ClassScripts,        /// <summary>        /// The font’s style is generally design independent, making it suitable for special characters (icons, dingbats, technical symbols, and so on) that may be used equally well with any font.        /// </summary>        [iOSVersion(7)]        ClassSymbolic,    }    /// <summary>    /// UIFontDescriptorClass classifies certain stylistic qualities of the font.    /// </summary>    [iOSVersion(7)]    public struct UIFontDescriptorClass    {        static public implicit operator UIFontDescriptorClass(int value)        {            return default(UIFontDescriptorClass);        }        static public implicit operator int(UIFontDescriptorClass value)        {            return default(int);        }    }}