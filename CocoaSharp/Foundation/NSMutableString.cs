using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSMutableString class declares the programmatic interface to an object that manages a mutable string—that is, a string whose contents can be edited—that conceptually represents an array of Unicode characters. To construct and manage an immutable string—or a string that cannot be changed after it has been created—use an object of the NSString class.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableString_Class/index.html#//apple_ref/occ/cl/NSMutableString"/>	[iOSVersion(2)]	public class NSMutableString : NSString, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding, Reflectable, StringLiteralConvertible	{		/// <summary>		/// Returns an empty NSMutableString object with initial storage for a given number of characters.		/// </summary>		/// <param name="capacity">The number of characters the string is expected to initially contain.</param>		[iOSVersion(2)]		[Export("stringWithCapacity")]		public static NSMutableString StringWithCapacity(int capacity) { return default(NSMutableString); }				/// <summary>		/// Returns an NSMutableString object initialized with initial storage for a given number of characters,		/// </summary>		/// <param name="capacity">The number of characters the string is expected to initially contain.</param>		[iOSVersion(2)]		public NSMutableString(int capacity) { }				/// <summary>		/// Adds to the end of the receiver the characters of a given string.		/// </summary>		/// <param name="aString">The string to append to the receiver. aString must not be nil</param>		[iOSVersion(2)]		[Export("appendString")]		public void AppendString(string aString) {  }				/// <summary>		/// Removes from the receiver the characters in a given range.		/// </summary>		/// <param name="aRange">The range of characters to delete. aRange must not exceed the bounds of the receiver.		///     Important		///     Raises an NSRangeException if any part of aRange lies beyond the end of the string.</param>		[iOSVersion(2)]		[Export("deleteCharactersInRange")]		public void DeleteCharactersInRange(NSRange aRange) {  }				/// <summary>		/// Inserts into the receiver the characters of a given string at a given location.		/// </summary>		/// <param name="aString">The string to insert into the receiver. aString must not be nil.</param>		/// <param name="atIndex">The location at which aString is inserted. The location must not exceed the bounds of the receiver.		///     Important		///     Raises an NSRangeException if anIndex lies beyond the end of the string.</param>		[iOSVersion(2)]		[Export("insertString")]		public void InsertString(string aString, int atIndex) {  }				/// <summary>		/// Replaces the characters from aRange with those in aString.		/// </summary>		/// <param name="aRange">The range of characters to replace. aRange must not exceed the bounds of the receiver.		///     Important		///     Raises an NSRangeException if any part of aRange lies beyond the end of the receiver.</param>		/// <param name="withString">The string with which to replace the characters in aRange. aString must not be nil.</param>		[iOSVersion(2)]		[Export("replaceCharactersInRange")]		public void ReplaceCharactersInRange(NSRange aRange, string withString) {  }				/// <summary>		/// Replaces all occurrences of a given string in a given range with another given string, returning the number of replacements.		/// </summary>		/// <param name="target">The string to replace.		///     Important		///     Raises an NSInvalidArgumentException if target is nil.</param>		/// <param name="withString">The string with which to replace target.		///     Important		///     Raises an NSInvalidArgumentException if replacement is nil.</param>		/// <param name="options">A mask specifying search options. See String Programming Guide for details.		///   If opts is NSBackwardsSearch, the search is done from the end of the range. If opts is NSAnchoredSearch, only anchored (but potentially multiple) instances are replaced. NSLiteralSearch and NSCaseInsensitiveSearch also apply.</param>		/// <param name="range">The range of characters to replace. aRange must not exceed the bounds of the receiver. Specify searchRange as NSMakeRange(0, [receiver length]) to process the entire string.		///     Important		///     Raises an NSRangeException if any part of searchRange lies beyond the end of the receiver.</param>		[iOSVersion(2)]		[Export("replaceOccurrencesOfString")]		public int ReplaceOccurrencesOfString(string target, string withString, NSStringCompareOptions options, NSRange range) { return default(int); }				/// <summary>		/// Replaces the characters of the receiver with those in a given string.		/// </summary>		/// <param name="aString">The string with which to replace the receiver's content. aString must not be nil.</param>		[iOSVersion(2)]		[Export("setString")]		public void SetString(string aString) {  }	}}