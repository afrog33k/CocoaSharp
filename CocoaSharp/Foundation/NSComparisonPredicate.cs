using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSComparisonPredicate is a subclass of NSPredicate that you use to compare expressions.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSComparisonPredicate_Class/index.html#//apple_ref/occ/cl/NSComparisonPredicate"/>	[iOSVersion(3)]	public class NSComparisonPredicate : NSPredicate, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Initializes a predicate formed by combining given left and right expressions using a given selector.		/// </summary>		/// <param name="leftExpression">The left hand expression.</param>		/// <param name="rightExpression">The right hand expression.</param>		/// <param name="customSelector">The selector to use. The method defined by the selector must take a single argument and return a BOOL value.</param>		[iOSVersion(3)]		public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, Selector customSelector) { }				/// <summary>		/// Initializes a predicate to a given type formed by combining given left and right expressions using a given modifier and options.		/// </summary>		/// <param name="leftExpression">The left hand expression.</param>		/// <param name="rightExpression">The right hand expression.</param>		/// <param name="modifier">The modifier to apply.</param>		/// <param name="type">The predicate operator type.</param>		/// <param name="options">The options to apply (see NSComparisonPredicate Options). For no options, pass 0.</param>		[iOSVersion(3)]		public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier modifier, NSPredicateOperatorType type, NSComparisonPredicateOptions options) { }				/// <summary>		/// Returns the comparison predicate modifier for the receiver.		/// </summary>		[iOSVersion(3)]		[Export("comparisonPredicateModifier")]		public NSComparisonPredicateModifier ComparisonPredicateModifier { get; private set; }				/// <summary>		/// Returns the selector for the receiver.		/// </summary>		[iOSVersion(3)]		[Export("customSelector")]		public Selector CustomSelector { get; private set; }				/// <summary>		/// Returns the left expression for the receiver.		/// </summary>		[iOSVersion(3)]		[Export("leftExpression")]		public NSExpression LeftExpression { get; private set; }				/// <summary>		/// Returns the options that are set for the receiver.		/// </summary>		[iOSVersion(3)]		[Export("options")]		public NSComparisonPredicateOptions Options { get; private set; }				/// <summary>		/// Returns the predicate type for the receiver.		/// </summary>		[iOSVersion(3)]		[Export("predicateOperatorType")]		public NSPredicateOperatorType PredicateOperatorType { get; private set; }				/// <summary>		/// Returns the right expression for the receiver.		/// </summary>		[iOSVersion(3)]		[Export("rightExpression")]		public NSExpression RightExpression { get; private set; }	}	/// <summary>	/// These constants describe the possible types of string comparison for NSComparisonPredicate. These options are supported for LIKE as well as all of the equality/comparison operators.	/// </summary>	[iOSVersion(5)]	public enum NSComparisonPredicateOptions	{		/// <summary>		/// A case-insensitive predicate.		/// You represent this option in a predicate format string using a [c] following a string operation (for example, &quot;NeXT&quot; like[c] &quot;next&quot;).		/// </summary>		[iOSVersion(3)]		CaseInsensitivePredicateOption,		/// <summary>		/// A diacritic-insensitive predicate.		/// You represent this option in a predicate format string using a [d] following a string operation (for example, &quot;naïve&quot; like[d] &quot;naive&quot;).		/// </summary>		[iOSVersion(3)]		DiacriticInsensitivePredicateOption,		/// <summary>		/// Indicates that the strings to be compared have been preprocessed.		/// This option supersedes NSCaseInsensitivePredicateOption and NSDiacriticInsensitivePredicateOption, and is intended as a performance optimization option.		/// You represent this option in a predicate format string using a [n] following a string operation (for example, &quot;WXYZlan&quot; matches[n] &quot;.lan&quot;).		/// </summary>		[iOSVersion(4)]		NormalizedPredicateOption,	}}