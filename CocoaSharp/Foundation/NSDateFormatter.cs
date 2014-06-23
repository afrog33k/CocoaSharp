using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDateFormatter_Class/index.html#//apple_ref/occ/cl/NSDateFormatter	/// <summary>	/// Instances of NSDateFormatter create string representations of NSDate objects, and convert textual representations of dates and times into NSDate objects. You can express the representation of dates and times flexibly using pre-set format styles or custom format strings.	/// </summary>	[iOSVersion(2)]	public class NSDateFormatter : NSFormatter	{		/// <summary>		/// Returns a date representation of a given string interpreted using the receiver’s current settings.		/// </summary>		/// <param name="string">The string to parse.</param>		/// <returns>A date representation of string interpreted using the receiver’s current settings. If dateFromString: can not parse the string, returns nil.</returns>		[iOSVersion(2)]		[Export("dateFromString")]		public NSDate DateFromString(string @string) { return null; }				/// <summary>		/// Returns a string representation of a given date formatted using the receiver’s current settings.		/// </summary>		/// <param name="date">The date to format.</param>		/// <returns>A string representation of date formatted using the receiver’s current settings.</returns>		[iOSVersion(2)]		[Export("stringFromDate")]		public string StringFromDate(NSDate date) { return ""; }				/// <summary>		/// Returns string representation of a given date formatted for the current locale using the specified date and time styles.		/// </summary>		/// <param name="date">A date.</param>		/// <param name="dateStyle">A format style for the date. For possible values, see NSDateFormatterStyle.</param>		/// <param name="timeStyle">A format style for the time. For possible values, see NSDateFormatterStyle.</param>		/// <returns>A localized string representation of date using the specified date and time styles</returns>		[iOSVersion(4)]		[Export("localizedStringFromDate")]		public static string LocalizedStringFromDate(NSDate date, NSDateFormatterStyle dateStyle, NSDateFormatterStyle timeStyle) { return ""; }				/// <summary>		/// Returns by reference a date representation of a given string and the range of the string used, and returns a Boolean value that indicates whether the string could be parsed.		/// </summary>		/// <param name="obj">If the receiver is able to parse string, upon return contains a date representation of string.</param>		/// <param name="forString">The string to parse.</param>		/// <param name="range">If the receiver is able to parse string, upon return contains the range of string used to create the date.</param>		/// <param name="error">If the receiver is unable to create a date by parsing string, upon return contains an NSError object that describes the problem.</param>		/// <returns>true if the receiver can create a date by parsing string, otherwise false.</returns>		[iOSVersion(2)]		[Export("getObjectValue")]		public bool GetObjectValue(AutoreleasingUnsafePointer<AnyObject?> obj, string forString, CMutablePointer<NSRange> range, NSErrorPointer error) { return false; }				/// <summary>		/// You should not use this method.		/// </summary>		/// <returns>true if the receiver generates calendar dates, otherwise false.</returns>		[iOSVersion(2)]		[Export("generatesCalendarDates")]		public bool GeneratesCalendarDates { get; set; }				/// <summary>		/// You should not use this method.		/// </summary>		/// <param name="b">A Boolean value that specifies whether the receiver generates calendar dates.</param>		[iOSVersion(2)]		[Export("generatesCalendarDates")]		public bool GeneratesCalendarDates { get; set; }				/// <summary>		/// Returns the date format string used by the receiver.		/// </summary>		/// <returns>The date format string used by the receiver.</returns>		[iOSVersion(2)]		[Export("dateFormat")]		public string DateFormat { get; set; }				/// <summary>		/// Sets the date format for the receiver.		/// </summary>		/// <param name="string">The date format for the receiver. See Data Formatting Guide for a list of the conversion specifiers permitted in date format strings.</param>		[iOSVersion(2)]		[Export("dateFormat")]		public string DateFormat { get; set; }				/// <summary>		/// Returns the date style of the receiver.		/// </summary>		/// <returns>The date style of the receiver. For possible values, see NSDateFormatterStyle.</returns>		[iOSVersion(2)]		[Export("dateStyle")]		public NSDateFormatterStyle DateStyle { get; set; }				/// <summary>		/// Sets the date style of the receiver.		/// </summary>		/// <param name="style">The date style of the receiver. For possible values, see NSDateFormatterStyle.</param>		[iOSVersion(2)]		[Export("dateStyle")]		public NSDateFormatterStyle DateStyle { get; set; }				/// <summary>		/// Returns the time style of the receiver.		/// </summary>		/// <returns>The time style of the receiver. For possible values, see NSDateFormatterStyle.</returns>		[iOSVersion(2)]		[Export("timeStyle")]		public NSDateFormatterStyle TimeStyle { get; set; }				/// <summary>		/// Sets the time style of the receiver.		/// </summary>		/// <param name="style">The time style for the receiver. For possible values, see NSDateFormatterStyle.</param>		[iOSVersion(2)]		[Export("timeStyle")]		public NSDateFormatterStyle TimeStyle { get; set; }				/// <summary>		/// Returns a localized date format string representing the given date format components arranged appropriately for the specified locale.		/// </summary>		/// <param name="template">A string containing date format patterns (such as “MM” or “h”).   For full details, see Date and Time Programming Guide.</param>		/// <param name="options">No options are currently defined—pass 0.</param>		/// <param name="locale">The locale for which the template is required.</param>		/// <returns>A localized date format string representing the date format components given in template, arranged appropriately for the locale specified by locale.</returns>		[iOSVersion(4)]		[Export("dateFormatFromTemplate")]		public static string DateFormatFromTemplate(string template, int options, NSLocale locale) { return ""; }				/// <summary>		/// Returns the calendar for the receiver.		/// </summary>		/// <returns>The calendar for the receiver.</returns>		[iOSVersion(2)]		[Export("calendar")]		public NSCalendar Calendar { get; set; }				/// <summary>		/// Sets the calendar for the receiver.		/// </summary>		/// <param name="calendar">The calendar for the receiver.</param>		[iOSVersion(2)]		[Export("calendar")]		public NSCalendar Calendar { get; set; }				/// <summary>		/// Returns the default date for the receiver.		/// </summary>		/// <returns>The default date for the receiver.</returns>		[iOSVersion(2)]		[Export("defaultDate")]		public NSDate DefaultDate { get; set; }				/// <summary>		/// Sets the default date for the receiver.		/// </summary>		/// <param name="date">The default date for the receiver.</param>		[iOSVersion(2)]		[Export("defaultDate")]		public NSDate DefaultDate { get; set; }				/// <summary>		/// Returns the locale for the receiver.		/// </summary>		/// <returns>The locale for the receiver.</returns>		[iOSVersion(2)]		[Export("locale")]		public NSLocale Locale { get; set; }				/// <summary>		/// Sets the locale for the receiver.		/// </summary>		/// <param name="locale">The locale for the receiver.</param>		[iOSVersion(2)]		[Export("locale")]		public NSLocale Locale { get; set; }				/// <summary>		/// Returns the time zone for the receiver.		/// </summary>		/// <returns>The time zone for the receiver.</returns>		[iOSVersion(2)]		[Export("timeZone")]		public NSTimeZone TimeZone { get; set; }				/// <summary>		/// Sets the time zone for the receiver.		/// </summary>		/// <param name="tz">The time zone for the receiver.</param>		[iOSVersion(2)]		[Export("timeZone")]		public NSTimeZone TimeZone { get; set; }				/// <summary>		/// Returns the earliest date that can be denoted by a two-digit year specifier.		/// </summary>		/// <returns>The earliest date that can be denoted by a two-digit year specifier.</returns>		[iOSVersion(2)]		[Export("twoDigitStartDate")]		public NSDate TwoDigitStartDate { get; set; }				/// <summary>		/// Sets the two-digit start date for the receiver.		/// </summary>		/// <param name="date">The earliest date that can be denoted by a two-digit year specifier.</param>		[iOSVersion(2)]		[Export("twoDigitStartDate")]		public NSDate TwoDigitStartDate { get; set; }				/// <summary>		/// Returns the start date of the Gregorian calendar for the receiver.		/// </summary>		/// <returns>The start date of the Gregorian calendar for the receiver.</returns>		[iOSVersion(2)]		[Export("gregorianStartDate")]		public NSDate GregorianStartDate { get; set; }				/// <summary>		/// Sets the start date of the Gregorian calendar for the receiver.		/// </summary>		/// <param name="date">The start date of the Gregorian calendar for the receiver.</param>		[iOSVersion(2)]		[Export("gregorianStartDate")]		public NSDate GregorianStartDate { get; set; }				/// <summary>		/// Returns the formatter behavior for the receiver.		/// </summary>		/// <returns>The formatter behavior for the receiver. For possible values, see NSDateFormatterBehavior.</returns>		[iOSVersion(2)]		[Export("formatterBehavior")]		public NSDateFormatterBehavior FormatterBehavior { get; set; }				/// <summary>		/// Sets the formatter behavior for the receiver.		/// </summary>		/// <param name="behavior">The formatter behavior for the receiver. For possible values, see NSDateFormatterBehavior.</param>		[iOSVersion(2)]		[Export("formatterBehavior")]		public NSDateFormatterBehavior FormatterBehavior { get; set; }				/// <summary>		/// Returns the default formatting behavior for instances of the class.		/// </summary>		/// <returns>The default formatting behavior for instances of the class. For possible values, see NSDateFormatterBehavior.</returns>		[iOSVersion(2)]		[Export("defaultFormatterBehavior")]		public static NSDateFormatterBehavior DefaultFormatterBehavior() { return null; }				/// <summary>		/// Sets the default formatting behavior for instances of the class.		/// </summary>		/// <param name="behavior">The default formatting behavior for instances of the class. For possible values, see NSDateFormatterBehavior.</param>		[iOSVersion(2)]		[Export("setDefaultFormatterBehavior")]		public static void SetDefaultFormatterBehavior(NSDateFormatterBehavior behavior) { }				/// <summary>		/// Sets whether the receiver uses heuristics when parsing a string.		/// </summary>		/// <param name="b">true to use heuristics when parsing a string to guess at the date which is intended, otherwise false.</param>		[iOSVersion(2)]		[Export("lenient")]		public bool Lenient { get; set; }				/// <summary>		/// Returns a Boolean value that indicates whether the receiver uses phrases such as “today” and “tomorrow” for the date component.		/// </summary>		/// <returns>true if the receiver uses relative date formatting, otherwise false.</returns>		[iOSVersion(4)]		[Export("doesRelativeDateFormatting")]		public bool DoesRelativeDateFormatting { get; set; }				/// <summary>		/// Specifies whether the receiver uses phrases such as “today” and “tomorrow” for the date component.		/// </summary>		/// <param name="b">true to specify that the receiver should use relative date formatting, otherwise false.</param>		[iOSVersion(4)]		[Export("doesRelativeDateFormatting")]		public bool DoesRelativeDateFormatting { get; set; }				/// <summary>		/// Returns the AM symbol for the receiver.		/// </summary>		/// <returns>The AM symbol for the receiver.</returns>		[iOSVersion(2)]		[Export("AMSymbol")]		public string AMSymbol { get; set; }				/// <summary>		/// Returns the PM symbol for the receiver.		/// </summary>		/// <returns>The PM symbol for the receiver.</returns>		[iOSVersion(2)]		[Export("PMSymbol")]		public string PMSymbol { get; set; }				/// <summary>		/// Returns the array of weekday symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the weekday symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("weekdaySymbols")]		public AnyObject[] WeekdaySymbols { get; set; }				/// <summary>		/// Sets the weekday symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the weekday symbols for the receiver.</param>		[iOSVersion(2)]		[Export("weekdaySymbols")]		public AnyObject[] WeekdaySymbols { get; set; }				/// <summary>		/// Returns the array of short weekday symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the short weekday symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("shortWeekdaySymbols")]		public AnyObject[] ShortWeekdaySymbols { get; set; }				/// <summary>		/// Sets the short weekday symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the short weekday symbols for the receiver.</param>		[iOSVersion(2)]		[Export("shortWeekdaySymbols")]		public AnyObject[] ShortWeekdaySymbols { get; set; }				/// <summary>		/// Returns the array of very short weekday symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the very short weekday symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("veryShortWeekdaySymbols")]		public AnyObject[] VeryShortWeekdaySymbols { get; set; }				/// <summary>		/// Sets the vert short weekday symbols for the receiver		/// </summary>		/// <param name="array">An array of NSString objects that specify the very short weekday symbols for the receiver.</param>		[iOSVersion(2)]		[Export("veryShortWeekdaySymbols")]		public AnyObject[] VeryShortWeekdaySymbols { get; set; }				/// <summary>		/// Returns the array of standalone weekday symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the standalone weekday symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("standaloneWeekdaySymbols")]		public AnyObject[] StandaloneWeekdaySymbols { get; set; }				/// <summary>		/// Sets the standalone weekday symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the standalone weekday symbols for the receiver.</param>		[iOSVersion(2)]		[Export("standaloneWeekdaySymbols")]		public AnyObject[] StandaloneWeekdaySymbols { get; set; }				/// <summary>		/// Returns the array of short standalone weekday symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the short standalone weekday symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("shortStandaloneWeekdaySymbols")]		public AnyObject[] ShortStandaloneWeekdaySymbols { get; set; }				/// <summary>		/// Sets the short standalone weekday symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the short standalone weekday symbols for the receiver.</param>		[iOSVersion(2)]		[Export("shortStandaloneWeekdaySymbols")]		public AnyObject[] ShortStandaloneWeekdaySymbols { get; set; }				/// <summary>		/// Returns the array of very short standalone weekday symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the very short standalone weekday symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("veryShortStandaloneWeekdaySymbols")]		public AnyObject[] VeryShortStandaloneWeekdaySymbols { get; set; }				/// <summary>		/// Sets the very short standalone weekday symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the very short standalone weekday symbols for the receiver.</param>		[iOSVersion(2)]		[Export("veryShortStandaloneWeekdaySymbols")]		public AnyObject[] VeryShortStandaloneWeekdaySymbols { get; set; }				/// <summary>		/// Returns the month symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the month symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("monthSymbols")]		public AnyObject[] MonthSymbols { get; set; }				/// <summary>		/// Sets the month symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the month symbols for the receiver.</param>		[iOSVersion(2)]		[Export("monthSymbols")]		public AnyObject[] MonthSymbols { get; set; }				/// <summary>		/// Returns the array of short month symbols for the receiver.		/// </summary>		/// <returns>An array containing NSString objects representing the short month symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("shortMonthSymbols")]		public AnyObject[] ShortMonthSymbols { get; set; }				/// <summary>		/// Sets the short month symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the short month symbols for the receiver.</param>		[iOSVersion(2)]		[Export("shortMonthSymbols")]		public AnyObject[] ShortMonthSymbols { get; set; }				/// <summary>		/// Returns the very short month symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the very short month symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("veryShortMonthSymbols")]		public AnyObject[] VeryShortMonthSymbols { get; set; }				/// <summary>		/// Sets the very short month symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the very short month symbols for the receiver.</param>		[iOSVersion(2)]		[Export("veryShortMonthSymbols")]		public AnyObject[] VeryShortMonthSymbols { get; set; }				/// <summary>		/// Returns the standalone month symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the standalone month symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("standaloneMonthSymbols")]		public AnyObject[] StandaloneMonthSymbols { get; set; }				/// <summary>		/// Sets the standalone month symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the standalone month symbols for the receiver.</param>		[iOSVersion(2)]		[Export("standaloneMonthSymbols")]		public AnyObject[] StandaloneMonthSymbols { get; set; }				/// <summary>		/// Returns the short standalone month symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the short standalone month symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("shortStandaloneMonthSymbols")]		public AnyObject[] ShortStandaloneMonthSymbols { get; set; }				/// <summary>		/// Sets the short standalone month symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the short standalone month symbols for the receiver.</param>		[iOSVersion(2)]		[Export("shortStandaloneMonthSymbols")]		public AnyObject[] ShortStandaloneMonthSymbols { get; set; }				/// <summary>		/// Returns the very short month symbols for the receiver.		/// </summary>		/// <returns>An array of NSString objects that specify the very short standalone month symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("veryShortStandaloneMonthSymbols")]		public AnyObject[] VeryShortStandaloneMonthSymbols { get; set; }				/// <summary>		/// Sets the very short standalone month symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the very short standalone month symbols for the receiver.</param>		[iOSVersion(2)]		[Export("veryShortStandaloneMonthSymbols")]		public AnyObject[] VeryShortStandaloneMonthSymbols { get; set; }				/// <summary>		/// Returns the quarter symbols for the receiver.		/// </summary>		/// <returns>An array containing NSString objects representing the quarter symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("quarterSymbols")]		public AnyObject[] QuarterSymbols { get; set; }				/// <summary>		/// Sets the quarter symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the quarter symbols for the receiver.</param>		[iOSVersion(2)]		[Export("quarterSymbols")]		public AnyObject[] QuarterSymbols { get; set; }				/// <summary>		/// Returns the short quarter symbols for the receiver.		/// </summary>		/// <returns>An array containing NSString objects representing the short quarter symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("shortQuarterSymbols")]		public AnyObject[] ShortQuarterSymbols { get; set; }				/// <summary>		/// Sets the short quarter symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the short quarter symbols for the receiver.</param>		[iOSVersion(2)]		[Export("shortQuarterSymbols")]		public AnyObject[] ShortQuarterSymbols { get; set; }				/// <summary>		/// Returns the standalone quarter symbols for the receiver.		/// </summary>		/// <returns>An array containing NSString objects representing the standalone quarter symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("standaloneQuarterSymbols")]		public AnyObject[] StandaloneQuarterSymbols { get; set; }				/// <summary>		/// Sets the standalone quarter symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the standalone quarter symbols for the receiver.</param>		[iOSVersion(2)]		[Export("standaloneQuarterSymbols")]		public AnyObject[] StandaloneQuarterSymbols { get; set; }				/// <summary>		/// Returns the short standalone quarter symbols for the receiver.		/// </summary>		/// <returns>An array containing NSString objects representing the short standalone quarter symbols for the receiver.</returns>		[iOSVersion(2)]		[Export("shortStandaloneQuarterSymbols")]		public AnyObject[] ShortStandaloneQuarterSymbols { get; set; }				/// <summary>		/// Sets the short standalone quarter symbols for the receiver.		/// </summary>		/// <param name="array">An array of NSString objects that specify the short standalone quarter symbols for the receiver.</param>		[iOSVersion(2)]		[Export("shortStandaloneQuarterSymbols")]		public AnyObject[] ShortStandaloneQuarterSymbols { get; set; }				/// <summary>		/// Returns the era symbols for the receiver.		/// </summary>		/// <returns>An array containing NSString objects representing the era symbols for the receiver (for example, {“B.C.E.”, “C.E.”}).</returns>		[iOSVersion(2)]		[Export("eraSymbols")]		public AnyObject[] EraSymbols { get; set; }				/// <summary>		/// Sets the era symbols for the receiver.		/// </summary>		/// <param name="array">An array containing NSString objects representing the era symbols for the receiver (for example, {“B.C.E.”, “C.E.”}).</param>		[iOSVersion(2)]		[Export("eraSymbols")]		public AnyObject[] EraSymbols { get; set; }				/// <summary>		/// Returns the long era symbols for the receiver		/// </summary>		/// <returns>An array containing NSString objects representing the era symbols for the receiver (for example, {“Before Common Era”, “Common Era”}).</returns>		[iOSVersion(2)]		[Export("longEraSymbols")]		public AnyObject[] LongEraSymbols { get; set; }				/// <summary>		/// Sets the long era symbols for the receiver.		/// </summary>		/// <param name="array">An array containing NSString objects representing the era symbols for the receiver (for example, {“Before Common Era”, “Common Era”}).</param>		[iOSVersion(2)]		[Export("longEraSymbols")]		public AnyObject[] LongEraSymbols { get; set; }				/// <summary>		/// The following constants specify predefined format styles for dates and times.		/// </summary>		[iOSVersion(2)]		public 		//enum NSDateFormatterStyle : Uint {			  case NoStyle			  case ShortStyle			  case MediumStyle			  case LongStyle			  case FullStyle		}				/// <summary>		/// Constants that specify the behavior NSDateFormatter should exhibit.		/// </summary>		[iOSVersion(2)]		public 		//enum NSDateFormatterBehavior : Uint {			  case BehaviorDefault			  case Behavior10_4		}	}}