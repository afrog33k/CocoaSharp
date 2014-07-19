using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSDateComponents encapsulates the components of a date in an extendable, object-oriented manner. It is used to specify a date by providing the temporal components that make up a date and time: hour, minutes, seconds, day, month, year, and so on. It can also be used to specify a duration of time, for example, 5 hours and 16 minutes. An NSDateComponents object is not required to define all the component fields. When a new instance of NSDateComponents is created the date components are set to NSUndefinedDateComponent.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDateComponents_Class/index.html#//apple_ref/occ/cl/NSDateComponents"/>	[iOSVersion(2)]	public class NSDateComponents : NSObject, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Returns the number of era units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("era")]		public int Era { get; set; }				/// <summary>		/// Returns the number of year units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("year")]		public int Year { get; set; }				/// <summary>		/// Returns the number of month units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("month")]		public int Month { get; set; }				/// <summary>		/// Returns the date of the receiver.		/// </summary>		[iOSVersion(4)]		[Export("date")]		public NSDate Date { get; private set; }				/// <summary>		/// Returns the number of day units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("day")]		public int Day { get; set; }				/// <summary>		/// Returns the number of hour units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("hour")]		public int Hour { get; set; }				/// <summary>		/// Returns the number of minute units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("minute")]		public int Minute { get; set; }				/// <summary>		/// Returns the number of second units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("second")]		public int Second { get; set; }				/// <summary>		/// Returns the number of weekday units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("weekday")]		public int Weekday { get; set; }				/// <summary>		/// Returns the ordinal number of weekday units for the receiver.		/// </summary>		[iOSVersion(2)]		[Export("weekdayOrdinal")]		public int WeekdayOrdinal { get; set; }				/// <summary>		/// Returns the number of quarters in the calendar.		/// </summary>		[iOSVersion(4)]		[Export("quarter")]		public int Quarter { get; set; }				/// <summary>		/// Returns the calendar of the receiver.		/// </summary>		[iOSVersion(4)]		[Export("calendar")]		public NSCalendar Calendar { get; set; }				/// <summary>		/// Returns the receiver’s time zone.		/// </summary>		[iOSVersion(4)]		[Export("timeZone")]		public NSTimeZone TimeZone { get; set; }				/// <summary>		/// Returns the week of the month.		/// </summary>		[iOSVersion(5)]		[Export("weekOfMonth")]		public int WeekOfMonth { get; set; }				/// <summary>		/// Returns the week of the year.		/// </summary>		[iOSVersion(5)]		[Export("weekOfYear")]		public int WeekOfYear { get; set; }				/// <summary>		/// Returns the year for the week of the year.		/// </summary>		[iOSVersion(5)]		[Export("yearForWeekOfYear")]		public int YearForWeekOfYear { get; set; }				/// <summary>		/// Sets the month as a leap month.		/// </summary>		[iOSVersion(6)]		[Export("leapMonth")]		public bool LeapMonth { get; set; }				/// <summary>		/// This constant specifies that an NSDateComponents component is undefined.		/// </summary>		public int NSUndefinedDateComponent { get; set; }	}}