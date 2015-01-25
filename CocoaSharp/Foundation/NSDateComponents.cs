using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSDateComponents encapsulates the components of a date in an extendable, object-oriented manner. It is used to specify a date by providing the temporal components that make up a date and time: hour, minutes, seconds, day, month, year, and so on. It can also be used to specify a duration of time, for example, 5 hours and 16 minutes. An NSDateComponents object is not required to define all the component fields. When a new instance of NSDateComponents is created the date components are set to NSUndefinedDateComponent.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDateComponents_Class/index.html#//apple_ref/occ/cl/NSDateComponents"/>    [iOSVersion(2)]    [Export("")]    public class NSDateComponents : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable    {        public NSDateComponents() { }        /// <summary>        /// The date of the receiver. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("date")]        [Optional]        public NSDate Date { get; private set; }                /// <summary>        /// The calendar used to interpret the components of the receiver.        /// </summary>        [iOSVersion(4)]        [Export("calendar")]        [Optional]        public NSCalendar Calendar { get; set; }                /// <summary>        /// The time zone used to interpret the components of the receiver.        /// </summary>        [iOSVersion(4)]        [Export("timeZone")]        [Optional]        public NSTimeZone TimeZone { get; set; }                /// <summary>        /// The number of era units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("era")]        public int Era { get; set; }                /// <summary>        /// The number of year units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("year")]        public int Year { get; set; }                /// <summary>        /// The number of month units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("month")]        public int Month { get; set; }                /// <summary>        /// The number of day units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("day")]        public int Day { get; set; }                /// <summary>        /// The number of hour units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("hour")]        public int Hour { get; set; }                /// <summary>        /// The number of minute units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("minute")]        public int Minute { get; set; }                /// <summary>        /// The number of second units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("second")]        public int Second { get; set; }                /// <summary>        /// The number of nanosecond units for the receiver.        /// </summary>        [iOSVersion(5)]        [Export("nanosecond")]        public int Nanosecond { get; set; }                /// <summary>        /// The number of the weekday unit for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("weekday")]        public int Weekday { get; set; }                /// <summary>        /// The ordinal number of weekday units for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("weekdayOrdinal")]        public int WeekdayOrdinal { get; set; }                /// <summary>        /// The number of quarters for the receiver.        /// </summary>        [iOSVersion(4)]        [Export("quarter")]        public int Quarter { get; set; }                /// <summary>        /// The week number of the month for the receiver.        /// </summary>        [iOSVersion(5)]        [Export("weekOfMonth")]        public int WeekOfMonth { get; set; }                /// <summary>        /// The week of the year for the receiver.        /// </summary>        [iOSVersion(5)]        [Export("weekOfYear")]        public int WeekOfYear { get; set; }                /// <summary>        /// The year for the week of the year.        /// </summary>        [iOSVersion(5)]        [Export("yearForWeekOfYear")]        public int YearForWeekOfYear { get; set; }                /// <summary>        /// Boolean value that indicates whether the month is a leap month.        /// </summary>        [iOSVersion(6)]        [Export("leapMonth")]        public bool LeapMonth { get; set; }                /// <summary>        /// This constant specifies that an NSDateComponents component is undefined.        /// </summary>        public int NSUndefinedDateComponent { get; private set; }    }}