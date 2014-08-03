using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// Instances of NSNumberFormatter format the textual representation of cells that contain NSNumber objects and convert textual representations of numeric values into NSNumber objects. The representation encompasses integers, floats, and doubles; floats and doubles can be formatted to a specified decimal position. NSNumberFormatter objects can also impose ranges on the numeric values cells can accept.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNumberFormatter_Class/index.html#//apple_ref/occ/cl/NSNumberFormatter"/>    [iOSVersion(2)]    public class NSNumberFormatter : NSFormatter//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// Sets the default formatter behavior for new instances of NSNumberFormatter .        /// </summary>        /// <param name="behavior">An NSNumberFormatterBehavior constant that indicates the revision of the class providing the default behavior.</param>        [iOSVersion(2)]        [Export("setDefaultFormatterBehavior")]        public static void SetDefaultFormatterBehavior(NSNumberFormatterBehavior behavior) {  }                /// <summary>        /// Returns an NSNumberFormatterBehavior constant that indicates default formatter behavior for new instances of NSNumberFormatter.        /// </summary>        [iOSVersion(2)]        [Export("defaultFormatterBehavior")]        public static NSNumberFormatterBehavior DefaultFormatterBehavior() { return default(NSNumberFormatterBehavior); }                /// <summary>        /// Returns by reference a cell-content object after creating it from a range of characters in a given string.        /// </summary>        /// <param name="anObject">On return, contains an instance of NSDecimalNumber or NSNumber based on the current value of generatesDecimalNumbers. The default is to return NSDecimalNumber instances</param>        /// <param name="forString">A string object with the range of characters specified in rangep that is used to create anObject.</param>        /// <param name="range">A range of characters in aString. On return, contains the actual range of characters used to create the object.</param>        /// <param name="error">If an error occurs, upon return contains an NSError object that explains why the conversion failed. If you pass in nil for error you are indicating that you are not interested in error information.</param>        [iOSVersion(2)]        [Export("getObjectValue")]        public bool GetObjectValue(AutoreleasingUnsafePointer<AnyObject> anObject, string forString, UnsafePointer<NSRange> range, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns an NSNumber object created by parsing a given string.        /// </summary>        /// <param name="@string">An NSString object that is parsed to generate the returned number object.</param>        [iOSVersion(2)]        [Export("numberFromString")]        public NSNumber NumberFromString(string @string) { return default(NSNumber); }                /// <summary>        /// Returns a string containing the formatted value of the provided number object.        /// </summary>        /// <param name="number">An NSNumber object that is parsed to create the returned string object.</param>        [iOSVersion(2)]        [Export("stringFromNumber")]        public string StringFromNumber(NSNumber number) { return default(string); }                /// <summary>        /// Returns a localized number string with the specified style.        /// </summary>        /// <param name="num">The number to localize</param>        /// <param name="numberStyle">The localization style to use. See NSNumberFormatterStyle for the supported values.</param>        [iOSVersion(4)]        [Export("localizedStringFromNumber")]        public static string LocalizedStringFromNumber(NSNumber num, NSNumberFormatterStyle numberStyle) { return default(string); }                /// <summary>        /// The formatter behavior of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("formatterBehavior")]        public NSNumberFormatterBehavior FormatterBehavior { get; set; }                /// <summary>        /// The number style used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("numberStyle")]        public NSNumberFormatterStyle NumberStyle { get; set; }                /// <summary>        /// Determines whether the receiver creates instances of NSDecimalNumber when it converts strings to number objects.        /// </summary>        [iOSVersion(2)]        [Export("generatesDecimalNumbers")]        public bool GeneratesDecimalNumbers { get; set; }                /// <summary>        /// The locale of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("locale")]        public NSLocale Locale { get; set; }                /// <summary>        /// The rounding increment used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("roundingIncrement")]        public NSNumber RoundingIncrement { get; set; }                /// <summary>        /// The rounding mode used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("roundingMode")]        public NSNumberFormatterRoundingMode RoundingMode { get; set; }                /// <summary>        /// The capitalization formatting context used when formatting a number.        /// </summary>        [iOSVersion(8)]        [Export("formattingContext")]        public NSFormattingContext FormattingContext { get; set; }                /// <summary>        /// The format width used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("formatWidth")]        public int FormatWidth { get; set; }                /// <summary>        /// The format the receiver uses to display negative values.        /// </summary>        [iOSVersion(2)]        [Export("negativeFormat")]        public string NegativeFormat { get; set; }                /// <summary>        /// The format the receiver uses to display positive values.        /// </summary>        [iOSVersion(2)]        [Export("positiveFormat")]        public string PositiveFormat { get; set; }                /// <summary>        /// The multiplier of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("multiplier")]        public NSNumber Multiplier { get; set; }                /// <summary>        /// The string used by the receiver to represent the percent symbol.        /// </summary>        [iOSVersion(2)]        [Export("percentSymbol")]        public string PercentSymbol { get; set; }                /// <summary>        /// The string used by the receiver to represent the per-mill (per-thousand) symbol.        /// </summary>        [iOSVersion(2)]        [Export("perMillSymbol")]        public string PerMillSymbol { get; set; }                /// <summary>        /// The string used by the receiver for the minus sign.        /// </summary>        [iOSVersion(2)]        [Export("minusSign")]        public string MinusSign { get; set; }                /// <summary>        /// The string used by the receiver to represent the plus sign.        /// </summary>        [iOSVersion(2)]        [Export("plusSign")]        public string PlusSign { get; set; }                /// <summary>        /// The string used by the receiver to represent the exponent symbol.        /// </summary>        [iOSVersion(2)]        [Export("exponentSymbol")]        public string ExponentSymbol { get; set; }                /// <summary>        /// The string the receiver uses as the symbol to show the value zero.        /// </summary>        [iOSVersion(2)]        [Export("zeroSymbol")]        public string ZeroSymbol { get; set; }                /// <summary>        /// The string the receiver uses to represent nil values.        /// </summary>        [iOSVersion(2)]        [Export("nilSymbol")]        public string NilSymbol { get; set; }                /// <summary>        /// The string the receiver uses to represent NaN (“not a number”).        /// </summary>        [iOSVersion(2)]        [Export("notANumberSymbol")]        public string NotANumberSymbol { get; set; }                /// <summary>        /// The string used by the receiver for the negative infinity symbol.        /// </summary>        [iOSVersion(2)]        [Export("negativeInfinitySymbol")]        public string NegativeInfinitySymbol { get; set; }                /// <summary>        /// The string used by the receiver for the positive infinity symbol.        /// </summary>        [iOSVersion(2)]        [Export("positiveInfinitySymbol")]        public string PositiveInfinitySymbol { get; set; }                /// <summary>        /// The string used by the receiver as a local currency symbol.        /// </summary>        [iOSVersion(2)]        [Export("currencySymbol")]        public string CurrencySymbol { get; set; }                /// <summary>        /// The receiver’s currency code.        /// </summary>        [iOSVersion(2)]        [Export("currencyCode")]        public string CurrencyCode { get; set; }                /// <summary>        /// The international currency symbol used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("internationalCurrencySymbol")]        public string InternationalCurrencySymbol { get; set; }                /// <summary>        /// The currency grouping separator for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("currencyGroupingSeparator")]        public string CurrencyGroupingSeparator { get; set; }                /// <summary>        /// The string the receiver uses as the prefix for positive values.        /// </summary>        [iOSVersion(2)]        [Export("positivePrefix")]        public string PositivePrefix { get; set; }                /// <summary>        /// The string the receiver uses as the suffix for positive values.        /// </summary>        [iOSVersion(2)]        [Export("positiveSuffix")]        public string PositiveSuffix { get; set; }                /// <summary>        /// The string the receiver uses as a prefix for negative values.        /// </summary>        [iOSVersion(2)]        [Export("negativePrefix")]        public string NegativePrefix { get; set; }                /// <summary>        /// The string the receiver uses as a suffix for negative values.        /// </summary>        [iOSVersion(2)]        [Export("negativeSuffix")]        public string NegativeSuffix { get; set; }                /// <summary>        /// The text attributes to be used in displaying negative values.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForNegativeValues")]        public Dictionary<NSObject, AnyObject> TextAttributesForNegativeValues { get; set; }                /// <summary>        /// The text attributes to be used in displaying positive values.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForPositiveValues")]        public Dictionary<NSObject, AnyObject> TextAttributesForPositiveValues { get; set; }                /// <summary>        /// The text attributes used to display a zero value.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForZero")]        public Dictionary<NSObject, AnyObject> TextAttributesForZero { get; set; }                /// <summary>        /// The text attributes used to display the nil symbol.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForNil")]        public Dictionary<NSObject, AnyObject> TextAttributesForNil { get; set; }                /// <summary>        /// The text attributes used to display the NaN (“not a number”) string.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForNotANumber")]        public Dictionary<NSObject, AnyObject> TextAttributesForNotANumber { get; set; }                /// <summary>        /// The text attributes used to display the positive infinity symbol.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForPositiveInfinity")]        public Dictionary<NSObject, AnyObject> TextAttributesForPositiveInfinity { get; set; }                /// <summary>        /// The text attributes used to display the negative infinity symbol.        /// </summary>        [iOSVersion(2)]        [Export("textAttributesForNegativeInfinity")]        public Dictionary<NSObject, AnyObject> TextAttributesForNegativeInfinity { get; set; }                /// <summary>        /// The string used by the receiver for a grouping separator.        /// </summary>        [iOSVersion(2)]        [Export("groupingSeparator")]        public string GroupingSeparator { get; set; }                /// <summary>        /// Determines whether the receiver displays the group separator.        /// </summary>        [iOSVersion(2)]        [Export("usesGroupingSeparator")]        public bool UsesGroupingSeparator { get; set; }                /// <summary>        /// The character the receiver uses as a decimal separator.        /// </summary>        [iOSVersion(2)]        [Export("decimalSeparator")]        public string DecimalSeparator { get; set; }                /// <summary>        /// Determines whether the receiver always shows the decimal separator, even for integer numbers.        /// </summary>        [iOSVersion(2)]        [Export("alwaysShowsDecimalSeparator")]        public bool AlwaysShowsDecimalSeparator { get; set; }                /// <summary>        /// The string used by the receiver as a currency decimal separator.        /// </summary>        [iOSVersion(2)]        [Export("currencyDecimalSeparator")]        public string CurrencyDecimalSeparator { get; set; }                /// <summary>        /// The grouping size of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("groupingSize")]        public int GroupingSize { get; set; }                /// <summary>        /// The secondary grouping size of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("secondaryGroupingSize")]        public int SecondaryGroupingSize { get; set; }                /// <summary>        /// The string that the receiver uses to pad numbers in the formatted string representation.        /// </summary>        [iOSVersion(2)]        [Export("paddingCharacter")]        public string PaddingCharacter { get; set; }                /// <summary>        /// The padding position used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("paddingPosition")]        public NSNumberFormatterPadPosition PaddingPosition { get; set; }                /// <summary>        /// Determines whether the receiver allows as input floating-point values (that is, values that include the period character [.]).        /// </summary>        [iOSVersion(2)]        [Export("allowsFloats")]        public bool AllowsFloats { get; set; }                /// <summary>        /// The lowest number allowed as input by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("minimum")]        public NSNumber Minimum { get; set; }                /// <summary>        /// The highest number allowed as input by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("maximum")]        public NSNumber Maximum { get; set; }                /// <summary>        /// The number of integer digits allowed as input and output by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("minimumIntegerDigits")]        public int MinimumIntegerDigits { get; set; }                /// <summary>        /// The minimum number of digits after the decimal separator allowed as input and output by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("minimumFractionDigits")]        public int MinimumFractionDigits { get; set; }                /// <summary>        /// The maximum number of integer digits allowed as input and output by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("maximumIntegerDigits")]        public int MaximumIntegerDigits { get; set; }                /// <summary>        /// The maximum number of digits after the decimal separator allowed as input and output by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("maximumFractionDigits")]        public int MaximumFractionDigits { get; set; }                /// <summary>        /// Determines whether the receiver uses minimum and maximum significant digits properties.        /// </summary>        [iOSVersion(2)]        [Export("usesSignificantDigits")]        public bool UsesSignificantDigits { get; set; }                /// <summary>        /// The minimum number of significant digits for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("minimumSignificantDigits")]        public int MinimumSignificantDigits { get; set; }                /// <summary>        /// The maximum number of significant digits for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("maximumSignificantDigits")]        public int MaximumSignificantDigits { get; set; }                /// <summary>        /// Determines whether the receiver will use heuristics to guess at the number which is intended by a string.        /// </summary>        [iOSVersion(2)]        [Export("lenient")]        public bool Lenient { get; set; }                /// <summary>        /// Determines whether partial string validation is enabled for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("partialStringValidationEnabled")]        public bool PartialStringValidationEnabled { get; set; }    }    /// <summary>    /// These constants specify predefined number format styles. These constants are used by the numberStyle property.    /// </summary>    [iOSVersion(2)]    public enum NSNumberFormatterStyle    {        /// <summary>        /// Specifies no style.        /// </summary>        [iOSVersion(2)]        NoStyle,        /// <summary>        /// Specifies a decimal style format.        /// </summary>        [iOSVersion(2)]        DecimalStyle,        /// <summary>        /// Specifies a currency style format.        /// </summary>        [iOSVersion(2)]        CurrencyStyle,        /// <summary>        /// Specifies a percent style format.        /// </summary>        [iOSVersion(2)]        PercentStyle,        /// <summary>        /// Specifies a scientific style format.        /// </summary>        [iOSVersion(2)]        ScientificStyle,        /// <summary>        /// Specifies a spell-out format; for example, “23” becomes “twenty-three”.        /// </summary>        [iOSVersion(2)]        SpellOutStyle,    }    /// <summary>    /// These constants specify the behavior of a number formatter. These constants are returned by the defaultFormatterBehavior class method and the formatterBehavior instance methods; you set them with the setDefaultFormatterBehavior: class method and the setFormatterBehavior: instance method.    /// </summary>    [iOSVersion(2)]    public enum NSNumberFormatterBehavior    {        /// <summary>        /// The number-formatter behavior set as the default for new instances. You can set the default formatter behavior with the class method setDefaultFormatterBehavior:.        /// </summary>        [iOSVersion(2)]        BehaviorDefault,        /// <summary>        /// The number-formatter behavior since OS X v10.4.        /// </summary>        [iOSVersion(2)]        Behavior10_4,    }    /// <summary>    /// These constants are used to specify how numbers should be padded. These constants are used by the paddingPosition property.    /// </summary>    [iOSVersion(2)]    public enum NSNumberFormatterPadPosition    {        /// <summary>        /// Specifies that the padding should occur before the prefix.        /// </summary>        [iOSVersion(2)]        BeforePrefix,        /// <summary>        /// Specifies that the padding should occur after the prefix.        /// </summary>        [iOSVersion(2)]        AfterPrefix,        /// <summary>        /// Specifies that the padding should occur before the suffix.        /// </summary>        [iOSVersion(2)]        BeforeSuffix,        /// <summary>        /// Specifies that the padding should occur after the suffix.        /// </summary>        [iOSVersion(2)]        AfterSuffix,    }    /// <summary>    /// These constants are used to specify how numbers should be rounded. These constants are used by the roundingMode property.    /// </summary>    [iOSVersion(2)]    public enum NSNumberFormatterRoundingMode    {        /// <summary>        /// Round towards positive infinity.        /// </summary>        [iOSVersion(2)]        RoundCeiling,        /// <summary>        /// Round towards negative infinity.        /// </summary>        [iOSVersion(2)]        RoundFloor,        /// <summary>        /// Round towards zero.        /// </summary>        [iOSVersion(2)]        RoundDown,        /// <summary>        /// Round away from zero.        /// </summary>        [iOSVersion(2)]        RoundUp,        /// <summary>        /// Round towards the nearest integer, or towards an even number if equidistant.        /// </summary>        [iOSVersion(2)]        RoundHalfEven,        /// <summary>        /// Round towards the nearest integer, or towards zero if equidistant.        /// </summary>        [iOSVersion(2)]        RoundHalfDown,        /// <summary>        /// Round towards the nearest integer, or away from zero if equidistant.        /// </summary>        [iOSVersion(2)]        RoundHalfUp,    }}