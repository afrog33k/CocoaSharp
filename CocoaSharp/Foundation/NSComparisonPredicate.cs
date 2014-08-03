using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSComparisonPredicate is a subclass of NSPredicate that you use to compare expressions.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSComparisonPredicate_Class/index.html#//apple_ref/occ/cl/NSComparisonPredicate"/>    [iOSVersion(3)]    public class NSComparisonPredicate : NSPredicate//, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding    {        /// <summary>        /// Initializes a predicate formed by combining given left and right expressions using a given selector.        /// </summary>        /// <param name="leftExpression">The left hand expression.</param>        /// <param name="rightExpression">The right hand expression.</param>        /// <param name="customSelector">The selector to use. The method defined by the selector must take a single argument and return a BOOL value.</param>        [iOSVersion(3)]        public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, Selector customSelector) : base(false) { }                /// <summary>        /// Initializes a predicate to a given type formed by combining given left and right expressions using a given modifier and options.        /// </summary>        /// <param name="leftExpression">The left hand expression.</param>        /// <param name="rightExpression">The right hand expression.</param>        /// <param name="modifier">The modifier to apply.</param>        /// <param name="type">The predicate operator type.</param>        /// <param name="options">The options to apply (see NSComparisonPredicate Options). For no options, pass 0.</param>        [iOSVersion(3)]        public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier modifier, NSPredicateOperatorType type, NSComparisonPredicateOptions options) : base(false) { }                /// <summary>        /// The comparison predicate modifier for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("comparisonPredicateModifier")]        public NSComparisonPredicateModifier ComparisonPredicateModifier { get; private set; }                /// <summary>        /// The selector for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("customSelector")]        public Selector CustomSelector { get; private set; }                /// <summary>        /// The right expression for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("rightExpression")]        public NSExpression RightExpression { get; private set; }                /// <summary>        /// The left expression for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("leftExpression")]        public NSExpression LeftExpression { get; private set; }                /// <summary>        /// The options that are set for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("options")]        public NSComparisonPredicateOptions Options { get; private set; }                /// <summary>        /// The predicate type for the receiver. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("predicateOperatorType")]        public NSPredicateOperatorType PredicateOperatorType { get; private set; }    }    /// <summary>    /// These constants describe the possible types of modifier for NSComparisonPredicate.    /// </summary>    [iOSVersion(3)]    public enum NSComparisonPredicateModifier    {        /// <summary>        /// A predicate to compare directly the left and right hand sides.        /// </summary>        [iOSVersion(3)]        DirectPredicateModifier,        /// <summary>        /// A predicate to compare all entries in the destination of a to-many relationship.        /// The left hand side must be a collection. The corresponding predicate compares each value in the left hand side with the right hand side, and returns false when it finds the first mismatch—or true if all match.        /// </summary>        [iOSVersion(3)]        AllPredicateModifier,        /// <summary>        /// A predicate to match with any entry in the destination of a to-many relationship.        /// The left hand side must be a collection. The corresponding predicate compares each value in the left hand side against the right hand side and returns true when it finds the first match—or false if no match is found        /// </summary>        [iOSVersion(3)]        AnyPredicateModifier,    }    /// <summary>    /// These constants describe the possible types of string comparison for NSComparisonPredicate. These options are supported for LIKE as well as all of the equality/comparison operators.    /// </summary>    [iOSVersion(5)]    public enum NSComparisonPredicateOptions    {        /// <summary>        /// A case-insensitive predicate.        /// You represent this option in a predicate format string using a [c] following a string operation (for example, &quot;NeXT&quot; like[c] &quot;next&quot;).        /// </summary>        [iOSVersion(3)]        CaseInsensitivePredicateOption,        /// <summary>        /// A diacritic-insensitive predicate.        /// You represent this option in a predicate format string using a [d] following a string operation (for example, &quot;naïve&quot; like[d] &quot;naive&quot;).        /// </summary>        [iOSVersion(3)]        DiacriticInsensitivePredicateOption,        /// <summary>        /// Indicates that the strings to be compared have been preprocessed.        /// This option supersedes NSCaseInsensitivePredicateOption and NSDiacriticInsensitivePredicateOption, and is intended as a performance optimization option.        /// You represent this option in a predicate format string using a [n] following a string operation (for example, &quot;WXYZlan&quot; matches[n] &quot;.lan&quot;).        /// </summary>        [iOSVersion(4)]        NormalizedPredicateOption,    }    /// <summary>    /// Defines the type of comparison for NSComparisonPredicate.    /// </summary>    [iOSVersion(3)]    public enum NSPredicateOperatorType    {        /// <summary>        /// A less-than predicate.        /// </summary>        [iOSVersion(3)]        LessThanPredicateOperatorType,        /// <summary>        /// A less-than-or-equal-to predicate.        /// </summary>        [iOSVersion(3)]        LessThanOrEqualToPredicateOperatorType,        /// <summary>        /// A greater-than predicate.        /// </summary>        [iOSVersion(3)]        GreaterThanPredicateOperatorType,        /// <summary>        /// A greater-than-or-equal-to predicate.        /// </summary>        [iOSVersion(3)]        GreaterThanOrEqualToPredicateOperatorType,        /// <summary>        /// An equal-to predicate.        /// </summary>        [iOSVersion(3)]        EqualToPredicateOperatorType,        /// <summary>        /// A not-equal-to predicate.        /// </summary>        [iOSVersion(3)]        NotEqualToPredicateOperatorType,        /// <summary>        /// A full regular expression matching predicate.        /// </summary>        [iOSVersion(3)]        MatchesPredicateOperatorType,        /// <summary>        /// A simple subset of the MATCHES predicate, similar in behavior to SQL LIKE.        /// </summary>        [iOSVersion(3)]        LikePredicateOperatorType,        /// <summary>        /// A begins-with predicate.        /// </summary>        [iOSVersion(3)]        BeginsWithPredicateOperatorType,        /// <summary>        /// An ends-with predicate.        /// </summary>        [iOSVersion(3)]        EndsWithPredicateOperatorType,        /// <summary>        /// A predicate to determine if the left hand side is in the right hand side.        /// For strings, returns true if the left hand side is a substring of the right hand side . For collections, returns true if the left hand side is in the right hand side .        /// </summary>        [iOSVersion(3)]        InPredicateOperatorType,        /// <summary>        /// A predicate that uses a custom selector that takes a single argument and returns a BOOL value.        /// The selector is invoked on the left hand side with the right hand side as the argument.        /// </summary>        [iOSVersion(3)]        CustomSelectorPredicateOperatorType,        /// <summary>        /// A predicate to determine if the left hand side contains the right hand side.        /// Returns true if [lhs contains rhs]; the left hand side must be an NSExpression object that evaluates to a collection        /// </summary>        [iOSVersion(3)]        ContainsPredicateOperatorType,        /// <summary>        /// A predicate to determine if the right hand side lies at or between bounds specified by the left hand side.        /// Returns true if [lhs between rhs]; the right hand side must be an array in which the first element sets the lower bound and the second element the upper, inclusive. Comparison is performed using compare: or the class-appropriate equivalent.        /// </summary>        [iOSVersion(3)]        BetweenPredicateOperatorType,    }}