using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The NSTextAttachmentContainer protocol defines the interface to text attachment objects from NSLayoutManager.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSTextAttachmentContainer_Protocol/index.html#//apple_ref/occ/intf/NSTextAttachmentContainer"/>    [iOSVersion(7)]    [Export("")]    public interface NSTextAttachmentContainer//: NSObjectProtocol    {        /// <summary>        /// Returns the layout bounds of the text attachment to the layout manager. (required)        /// </summary>        /// <param name="textContainer">The text container for the text being laid out.</param>        /// <param name="proposedLineFragment">The line fragment containing the text attachment.</param>        /// <param name="glyphPosition">The glyph location inside lineFrag which is the origin of the returned bounds rectangle.</param>        /// <param name="characterIndex">The character location inside the text storage for the attachment character.</param>        [iOSVersion(7)]        [Export("attachmentBoundsForTextContainer")]        CGRect AttachmentBoundsForTextContainer(NSTextContainer textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, int characterIndex);                /// <summary>        /// Returns the image object rendered by the layout manager in the given image bounds rectangle inside the text container. (required)        /// </summary>        /// <param name="imageBounds">The rectangle in which the image is laid out.</param>        /// <param name="textContainer">The text container in which the image is laid out.</param>        /// <param name="characterIndex">The character location inside the text storage for the attachment character.</param>        [iOSVersion(7)]        [Export("imageForBounds")]        [return:Unwrapped]        UIImage ImageForBounds(CGRect imageBounds, NSTextContainer textContainer, int characterIndex);    }}