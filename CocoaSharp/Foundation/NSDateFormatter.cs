using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// Instances of NSDateFormatter create string representations of NSDate objects, and convert textual representations of dates and times into NSDate objects. You can express the representation of dates and times flexibly using pre-set format styles or custom format strings.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDateFormatter_Class/index.html#//apple_ref/occ/cl/NSDateFormatter"/>    [iOSVersion(2)]    public class NSDateFormatter : NSFormatter//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// Returns a date representation of a given string interpreted using the receiver’s current settings.        /// </summary>        /// <param name="@string">The string to parse.</param>        [iOSVersion(2)]        [Export("dateFromString")]        public NSDate DateFromString(string @string) { return default(NSDate); }                /// <summary>        /// Returns a string representation of a given date formatted using the receiver’s current settings.        /// </summary>        /// <param name="date">The date to format.</param>        [iOSVersion(2)]        [Export("stringFromDate")]        public string StringFromDate(NSDate date) { return default(string); }                /// <summary>        /// Returns string representation of a given date formatted for the current locale using the specified date and time styles.        /// </summary>        /// <param name="date">A date.</param>        /// <param name="dateStyle">A format style for the date. For possible values, see NSDateFormatterStyle.</param>        /// <param name="timeStyle">A format style for the time. For possible values, see NSDateFormatterStyle.</param>        [iOSVersion(4)]        [Export("localizedStringFromDate")]        public static string LocalizedStringFromDate(NSDate date, NSDateFormatterStyle dateStyle, NSDateFormatterStyle timeStyle) { return default(string); }                /// <summary>        /// Returns by reference a date representation of a given string and the range of the string used, and returns a Boolean value that indicates whether the string could be parsed.        /// </summary>        /// <param name="obj">If the receiver is able to parse string, upon return contains a date representation of string.</param>        /// <param name="forString">The string to parse.</param>        /// <param name="range">If the receiver is able to parse string, upon return contains the range of string used to create the date.</param>        /// <param name="error">If the receiver is unable to create a date by parsing string, upon return contains an NSError object that describes the problem.</param>        [iOSVersion(2)]        [Export("getObjectValue")]        public bool GetObjectValue(AutoreleasingUnsafePointer<AnyObject> obj, string forString, UnsafePointer<NSRange> range, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns a localized date format string representing the given date format components arranged appropriately for the specified locale.        /// </summary>        /// <param name="template">A string containing date format patterns (such as “MM” or “h”).        ///   For full details, see Date and Time Programming Guide.</param>        /// <param name="options">No options are currently defined—pass 0.</param>        /// <param name="locale">The locale for which the template is required.</param>        [iOSVersion(4)]        [Export("dateFormatFromTemplate")]        public static string DateFormatFromTemplate(string template, int options, NSLocale locale) { return default(string); }                /// <summary>        /// Returns the default formatting behavior for instances of the class.        /// </summary>        [iOSVersion(2)]        [Export("defaultFormatterBehavior")]        public static NSDateFormatterBehavior DefaultFormatterBehavior() { return default(NSDateFormatterBehavior); }                /// <summary>        /// Sets the default formatting behavior for instances of the class.        /// </summary>        /// <param name="behavior">The default formatting behavior for instances of the class. For possible values, see NSDateFormatterBehavior.</param>        [iOSVersion(2)]        [Export("setDefaultFormatterBehavior")]        public static void SetDefaultFormatterBehavior(NSDateFormatterBehavior behavior) {  }                /// <summary>        /// You should not use this property.        /// </summary>        [iOSVersion(2)]        [Export("generatesCalendarDates")]        public bool GeneratesCalendarDates { get; set; }                /// <summary>        /// The date format string used by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("dateFormat")]        public string DateFormat { get; set; }                /// <summary>        /// The date style of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("dateStyle")]        public NSDateFormatterStyle DateStyle { get; set; }                /// <summary>        /// The time style of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("timeStyle")]        public NSDateFormatterStyle TimeStyle { get; set; }                /// <summary>        /// The calendar for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("calendar")]        public NSCalendar Calendar { get; set; }                /// <summary>        /// The default date for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("defaultDate")]        public NSDate DefaultDate { get; set; }                /// <summary>        /// The locale for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("locale")]        public NSLocale Locale { get; set; }                /// <summary>        /// The time zone for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("timeZone")]        public NSTimeZone TimeZone { get; set; }                /// <summary>        /// The earliest date that can be denoted by a two-digit year specifier.        /// </summary>        [iOSVersion(2)]        [Export("twoDigitStartDate")]        public NSDate TwoDigitStartDate { get; set; }                /// <summary>        /// The start date of the Gregorian calendar for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("gregorianStartDate")]        public NSDate GregorianStartDate { get; set; }                /// <summary>        /// The formatter behavior for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("formatterBehavior")]        public NSDateFormatterBehavior FormatterBehavior { get; set; }                /// <summary>        /// A Boolean value that indicates whether the receiver uses heuristics when parsing a string.        /// </summary>        [iOSVersion(8)]        [Export("lenient")]        public bool Lenient { get; set; }                /// <summary>        /// A Boolean value that indicates whether the receiver uses phrases such as “today” and “tomorrow” for the date component.        /// </summary>        [iOSVersion(4)]        [Export("doesRelativeDateFormatting")]        public bool DoesRelativeDateFormatting { get; set; }                /// <summary>        /// The AM symbol for the receiver.        /// </summary>        [iOSVersion(2)]        public string AMSymbol { get; set; }                /// <summary>        /// The PM symbol for the receiver.        /// </summary>        [iOSVersion(2)]        public string PMSymbol { get; set; }                /// <summary>        /// The array of weekday symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("weekdaySymbols")]        public AnyObject[] WeekdaySymbols { get; set; }                /// <summary>        /// The array of short weekday symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("shortWeekdaySymbols")]        public AnyObject[] ShortWeekdaySymbols { get; set; }                /// <summary>        /// The array of very short weekday symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("veryShortWeekdaySymbols")]        public AnyObject[] VeryShortWeekdaySymbols { get; set; }                /// <summary>        /// The array of standalone weekday symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("standaloneWeekdaySymbols")]        public AnyObject[] StandaloneWeekdaySymbols { get; set; }                /// <summary>        /// The array of short standalone weekday symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("shortStandaloneWeekdaySymbols")]        public AnyObject[] ShortStandaloneWeekdaySymbols { get; set; }                /// <summary>        /// The array of very short standalone weekday symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("veryShortStandaloneWeekdaySymbols")]        public AnyObject[] VeryShortStandaloneWeekdaySymbols { get; set; }                /// <summary>        /// The month symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("monthSymbols")]        public AnyObject[] MonthSymbols { get; set; }                /// <summary>        /// The array of short month symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("shortMonthSymbols")]        public AnyObject[] ShortMonthSymbols { get; set; }                /// <summary>        /// The very short month symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("veryShortMonthSymbols")]        public AnyObject[] VeryShortMonthSymbols { get; set; }                /// <summary>        /// The standalone month symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("standaloneMonthSymbols")]        public AnyObject[] StandaloneMonthSymbols { get; set; }                /// <summary>        /// The short standalone month symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("shortStandaloneMonthSymbols")]        public AnyObject[] ShortStandaloneMonthSymbols { get; set; }                /// <summary>        /// The very short month symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("veryShortStandaloneMonthSymbols")]        public AnyObject[] VeryShortStandaloneMonthSymbols { get; set; }                /// <summary>        /// The quarter symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("quarterSymbols")]        public AnyObject[] QuarterSymbols { get; set; }                /// <summary>        /// The short quarter symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("shortQuarterSymbols")]        public AnyObject[] ShortQuarterSymbols { get; set; }                /// <summary>        /// The standalone quarter symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("standaloneQuarterSymbols")]        public AnyObject[] StandaloneQuarterSymbols { get; set; }                /// <summary>        /// The short standalone quarter symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("shortStandaloneQuarterSymbols")]        public AnyObject[] ShortStandaloneQuarterSymbols { get; set; }                /// <summary>        /// The era symbols for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("eraSymbols")]        public AnyObject[] EraSymbols { get; set; }                /// <summary>        /// The long era symbols for the receiver        /// </summary>        [iOSVersion(2)]        [Export("longEraSymbols")]        public AnyObject[] LongEraSymbols { get; set; }    }    /// <summary>    /// The following constants specify predefined format styles for dates and times.    /// </summary>    [iOSVersion(2)]    public enum NSDateFormatterStyle    {        /// <summary>        /// Specifies no style.        /// Equal to kCFDateFormatterNoStyle.        /// </summary>        [iOSVersion(2)]        NoStyle,        /// <summary>        /// Specifies a short style, typically numeric only, such as “11/23/37” or “3:30 PM”.        /// Equal to kCFDateFormatterShortStyle.        /// </summary>        [iOSVersion(2)]        ShortStyle,        /// <summary>        /// Specifies a medium style, typically with abbreviated text, such as “Nov 23, 1937” or “3:30:32 PM”.        /// Equal to kCFDateFormatterMediumStyle.        /// </summary>        [iOSVersion(2)]        MediumStyle,        /// <summary>        /// Specifies a long style, typically with full text, such as “November 23, 1937” or “3:30:32 PM PST”.        /// Equal to kCFDateFormatterLongStyle.        /// </summary>        [iOSVersion(2)]        LongStyle,        /// <summary>        /// Specifies a full style with complete details, such as “Tuesday, April 12, 1952 AD” or “3:30:42 PM Pacific Standard Time”.        /// Equal to kCFDateFormatterFullStyle.        /// </summary>        [iOSVersion(2)]        FullStyle,    }    /// <summary>    /// Constants that specify the behavior NSDateFormatter should exhibit.    /// </summary>    [iOSVersion(2)]    public enum NSDateFormatterBehavior    {        /// <summary>        /// Specifies default formatting behavior.        /// </summary>        [iOSVersion(2)]        BehaviorDefault,        /// <summary>        /// Specifies formatting behavior equivalent for OS X v10.4.        /// </summary>        [iOSVersion(2)]        Behavior10_4,    }}