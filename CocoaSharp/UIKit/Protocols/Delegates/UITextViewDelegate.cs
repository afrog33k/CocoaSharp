using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UITextViewDelegate protocol defines a set of optional methods you can use to receive editing-related messages for UITextView objects. All of the methods in this protocol are optional. You can use them in situations where you might want to adjust the text being edited (such as in the case of a spell checker program) or modify the intended insertion point.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITextViewDelegate_Protocol/index.html#//apple_ref/occ/intf/UITextViewDelegate"/>    [iOSVersion(2)]    public interface UITextViewDelegate//: NSObjectProtocol, UIScrollViewDelegate    {        /// <summary>        /// Asks the delegate if editing should begin in the specified text view.        /// </summary>        /// <param name="textView">The text view for which editing is about to begin.</param>        //[iOSVersion(2)]        //[Export("textViewShouldBeginEditing")]        //[Optional]        bool TextViewShouldBeginEditing(UITextView textView);                /// <summary>        /// Tells the delegate that editing of the specified text view has begun.        /// </summary>        /// <param name="textView">The text view in which editing began.</param>        //[iOSVersion(2)]        //[Export("textViewDidBeginEditing")]        //[Optional]        void TextViewDidBeginEditing(UITextView textView);                /// <summary>        /// Asks the delegate if editing should stop in the specified text view.        /// </summary>        /// <param name="textView">The text view for which editing is about to end.</param>        //[iOSVersion(2)]        //[Export("textViewShouldEndEditing")]        //[Optional]        bool TextViewShouldEndEditing(UITextView textView);                /// <summary>        /// Tells the delegate that editing of the specified text view has ended.        /// </summary>        /// <param name="textView">The text view in which editing ended.</param>        //[iOSVersion(2)]        //[Export("textViewDidEndEditing")]        //[Optional]        void TextViewDidEndEditing(UITextView textView);                /// <summary>        /// Asks the delegate whether the specified text should be replaced in the text view.        /// </summary>        /// <param name="textView">The text view containing the changes.</param>        /// <param name="shouldChangeTextInRange">The current selection range. If the length of the range is 0, range reflects the current insertion point. If the user presses the Delete key, the length of the range is 1 and an empty string object replaces that single character.</param>        /// <param name="replacementText">The text to insert.</param>        //[iOSVersion(2)]        //[Export("textView")]        //[Optional]        bool TextView(UITextView textView, NSRange shouldChangeTextInRange, string replacementText);                /// <summary>        /// Tells the delegate that the text or attributes in the specified text view were changed by the user.        /// </summary>        /// <param name="textView">The text view containing the changes.</param>        //[iOSVersion(2)]        //[Export("textViewDidChange")]        //[Optional]        void TextViewDidChange(UITextView textView);                /// <summary>        /// Tells the delegate that the text selection changed in the specified text view.        /// </summary>        /// <param name="textView">The text view whose selection changed.</param>        //[iOSVersion(2)]        //[Export("textViewDidChangeSelection")]        //[Optional]        void TextViewDidChangeSelection(UITextView textView);                /// <summary>        /// Asks the delegate if the specified text view should allow user interaction with the provided text attachment in the given range of text.        /// </summary>        /// <param name="textView">The text view containing the text attachment.</param>        /// <param name="shouldInteractWithTextAttachment">The text attachment.</param>        /// <param name="inRange">The character range containing the text attachment.</param>        //[iOSVersion(7)]        //[Export("textView")]        //[Optional]        bool TextView(UITextView textView, NSTextAttachment shouldInteractWithTextAttachment, NSRange inRange);                /// <summary>        /// Asks the delegate if the specified text view should allow user interaction with the given URL in the given range of text.        /// </summary>        /// <param name="textView">The text view containing the text attachment.</param>        /// <param name="shouldInteractWithURL">The URL to be processed.</param>        /// <param name="inRange">The character range containing the URL.</param>        //[iOSVersion(7)]        //[Export("textView")]        //[Optional]        bool TextView(UITextView textView, NSURL shouldInteractWithURL, NSRange inRange);    }}