using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCalendar_Class/index.html#//apple_ref/occ/cl/NSCalendar
    /// <summary>
    /// Calendars encapsulate information about systems of reckoning time in which the beginning, length, and divisions of a year are defined. They provide information about the calendar and support for calendrical computations such as determining the range of a given calendrical unit and adding units to a given absolute time.
    /// </summary>
    [iOSVersion(2)]
    public class NSCalendar : NSObject
    {
        /// <summary>
        /// Returns the logical calendar for the current user.
        /// </summary>
        /// <returns>The logical calendar for the current user.</returns>
        [iOSVersion(2)]
        [Export("currentCalendar")]
        public static NSCalendar CurrentCalendar() { return null; }
        
        /// <summary>
        /// Returns the current logical calendar for the current user.
        /// </summary>
        /// <returns>The current logical calendar for the current user.</returns>
        [iOSVersion(2)]
        [Export("autoupdatingCurrentCalendar")]
        public static NSCalendar AutoupdatingCurrentCalendar() { return null; }
        
        /// <summary>
        /// Initializes a newly-allocated NSCalendar object for the calendar specified by a given identifier.
        /// </summary>
        /// <param name="calendarIdentifier">The identifier for the new calendar. For valid identifiers, see NSLocale.</param>
        /// <returns>The initialized calendar, or nil if the identifier is unknown (if, for example, it is either an unrecognized string or the calendar is not supported by the current version of the operating system).</returns>
        [iOSVersion(2)]
        public NSCalendar(string calendarIdentifier) { }
        
        /// <summary>
        /// Sets or returns the index of the first weekday for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("firstWeekday")]
        public int FirstWeekday { get; set; }
        
        /// <summary>
        /// Sets or returns the locale for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("locale")]
        public NSLocale Locale { get; set; }
        
        /// <summary>
        /// Sets or returns the minimum number of days in the first week of the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("minimumDaysInFirstWeek")]
        public int MinimumDaysInFirstWeek { get; set; }
        
        /// <summary>
        /// Sets or returns the time zone for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("timeZone")]
        public NSTimeZone TimeZone { get; set; }
        
        /// <summary>
        /// Returns the identifier for the receiver.
        /// </summary>
        /// <returns>The identifier for the receiver. For valid identifiers, see NSLocale.</returns>
        [iOSVersion(2)]
        [Export("calendarIdentifier")]
        public string CalendarIdentifier { get; private set; }
        
        /// <summary>
        /// The maximum range limits of the values that a given unit can take on in the receive
        /// </summary>
        /// <param name="unit">The unit for which the maximum range is returned.</param>
        /// <returns>The maximum range limits of the values that the unit specified by unit can take on in the receiver.</returns>
        [iOSVersion(2)]
        [Export("maximumRangeOfUnit")]
        public NSRange MaximumRangeOfUnit(NSCalendarUnit unit) { return new NSRange(); }
        
        /// <summary>
        /// Returns the minimum range limits of the values that a given unit can take on in the receiver.
        /// </summary>
        /// <param name="unit">The unit for which the maximum range is returned.</param>
        /// <returns>The minimum range limits of the values that the unit specified by unit can take on in the receiver.</returns>
        [iOSVersion(2)]
        [Export("minimumRangeOfUnit")]
        public NSRange MinimumRangeOfUnit(NSCalendarUnit unit) { return new NSRange(); }
        
        /// <summary>
        /// Returns, for a given absolute time, the ordinal number of a smaller calendar unit (such as a day) within a specified larger calendar unit (such as a week).
        /// </summary>
        /// <param name="smaller">The smaller calendar unit</param>
        /// <param name="inUnit">The larger calendar unit</param>
        /// <param name="forDate">The absolute time for which the calculation is performed</param>
        /// <returns>The ordinal number of smaller within larger at the time specified by date. Returns NSNotFound if larger is not logically bigger than smaller in the calendar, or the given combination of units does not make sense (or is a computation which is undefined).</returns>
        [iOSVersion(2)]
        [Export("ordinalityOfUnit")]
        public int OrdinalityOfUnit(NSCalendarUnit smaller, NSCalendarUnit inUnit, NSDate forDate) { return 0; }
        
        /// <summary>
        /// Returns the range of absolute time values that a smaller calendar unit (such as a day) can take on in a larger calendar unit (such as a month) that includes a specified absolute time.
        /// </summary>
        /// <param name="smaller">The smaller calendar unit.</param>
        /// <param name="inUnit">The larger calendar unit.</param>
        /// <param name="forDate">The absolute time for which the calculation is performed.</param>
        /// <returns>The range of absolute time values smaller can take on in larger at the time specified by date. Returns {NSNotFound, NSNotFound} if larger is not logically bigger than smaller in the calendar, or the given combination of units does not make sense (or is a computation which is undefined).</returns>
        [iOSVersion(2)]
        [Export("rangeOfUnit")]
        public NSRange RangeOfUnit(NSCalendarUnit smaller, NSCalendarUnit inUnit, NSDate forDate) { return new NSRange(); }
        
        /// <summary>
        /// Returns by reference the starting time and duration of a given calendar unit that contains a given date.
        /// </summary>
        /// <param name="unit">A calendar unit (see Calendar Units for possible values).</param>
        /// <param name="startDate">Upon return, contains the starting time of the calendar unit unit that contains the date date</param>
        /// <param name="interval">Upon return, contains the duration of the calendar unit unit that contains the date date</param>
        /// <param name="forDate">A date.</param>
        /// <returns>true if the starting time and duration of a unit could be calculated, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("rangeOfUnit")]
        public bool RangeOfUnit(NSCalendarUnit unit, AutoreleasingUnsafePointer<NSDate> startDate, CMutablePointer<NSTimeinterval> interval, NSDate forDate) { return false; }
        
        /// <summary>
        /// Returns a NSDateComponents object containing a given date decomposed into specified components.
        /// </summary>
        /// <param name="unitFlags">The components into which to decompose date—a bitwise OR of NSCalendarUnit constants.</param>
        /// <param name="fromDate">The date for which to perform the calculation.</param>
        /// <returns>An NSDateComponents object containing date decomposed into the components specified by unitFlags. Returns nil if date falls outside of the defined range of the receiver or if the computation cannot be performed</returns>
        [iOSVersion(2)]
        [Export("components")]
        public NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate) { return null; }
        
        /// <summary>
        /// Returns, as an NSDateComponents object using specified components, the difference between two supplied dates.
        /// </summary>
        /// <param name="unitFlags">Specifies the components for the returned NSDateComponents object—a bitwise OR of NSCalendarUnit constants.</param>
        /// <param name="fromDate">The start date for the calculation.</param>
        /// <param name="toDate">The end date for the calculation.</param>
        /// <param name="options">Options for the calculation.   If you specify a “wrap” option (NSWrapCalendarComponents), the specified components are incremented and wrap around to zero/one on overflow, but do not cause higher units to be incremented. When the wrap option is false, overflow in a unit carries into the higher units, as in typical addition.</param>
        /// <returns>An NSDateComponents object whose components are specified by unitFlags and calculated from the difference between the resultDate and startDate using the options specified by opts. Returns nil if either date falls outside the defined range of the receiver or if the computation cannot be performed.</returns>
        [iOSVersion(2)]
        [Export("components")]
        public NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate, NSDate toDate, NSCalendarOptions options) { return null; }
        
        /// <summary>
        /// Returns a new NSDate object representing the absolute time calculated by adding given components to a given date.
        /// </summary>
        /// <param name="comps">The components to add to date.</param>
        /// <param name="toDate">The date to which comps are added.</param>
        /// <param name="options">Options for the calculation. See “NSDateComponents wrapping behavior” for possible values. Pass 0 to specify no options.   If you specify no options (you pass 0), overflow in a unit carries into the higher units (as in typical addition).</param>
        /// <returns>A new NSDate object representing the absolute time calculated by adding to date the calendrical components specified by comps using the options specified by opts. Returns nil if date falls outside the defined range of the receiver or if the computation cannot be performed.</returns>
        [iOSVersion(2)]
        [Export("dateByAddingComponents")]
        public NSDate DateByAddingComponents(NSDateComponents comps, NSDate toDate, NSCalendarOptions options) { return null; }
        
        /// <summary>
        /// Returns a new NSDate object representing the absolute time calculated from given components.
        /// </summary>
        /// <param name="comps">The components from which to calculate the returned date.</param>
        /// <returns>A new NSDate object representing the absolute time calculated from comps. Returns nil if the receiver cannot convert the components given in comps into an absolute time. The method also returns nil and for out-of-range values.</returns>
        [iOSVersion(2)]
        [Export("dateFromComponents")]
        public NSDate DateFromComponents(NSDateComponents comps) { return null; }
        /// <summary>
        /// The wrapping option specifies wrapping behavior for calculations involving NSDateComponents objects.
        /// </summary>
        [Export("NSWrapCalendarComponents")]
        public int NSWrapCalendarComponents { get; private set; }
    }

    public enum NSCalendarOptions
    {
        //TODO: Check later for NSCalendarOptions
    }

    /// <summary>
    /// Specify calendrical units such as day and month.
    /// </summary>
    public enum NSCalendarUnit
    {
        CalendarUnitEra,
        CalendarUnitYear,
        CalendarUnitMonth,
        CalendarUnitDay,
        CalendarUnitHour,
        CalendarUnitMinute,
        CalendarUnitSecond,
        CalendarUnitWeekday,
        CalendarUnitWeekdayOrdinal,
        CalendarUnitQuarter,
        CalendarUnitWeekOfMonth,
        CalendarUnitWeekOfYear,
        CalendarUnitYearForWeekOfYear,
        CalendarUnitNanosecond,
        CalendarUnitCalendar,
        CalendarUnitTimeZone,

        /// <summary>
        /// Specifies the era unit.
        /// </summary>
        [iOSVersion(8)]
        EraCalendarUnit,

        /// <summary>
        /// Specifies the year unit.
        /// </summary>
        [iOSVersion(8)]
        YearCalendarUnit,

        /// <summary>
        /// Specifies the month unit.
        /// </summary>
        [iOSVersion(8)]
        MonthCalendarUnit,

        /// <summary>
        /// Specifies the day unit.
        /// </summary>
        [iOSVersion(8)]
        DayCalendarUnit,

        /// <summary>
        /// Specifies the hour unit.
        /// </summary>
        [iOSVersion(8)]
        HourCalendarUnit,

        /// <summary>
        /// Specifies the minute unit.
        /// </summary>
        [iOSVersion(8)]
        MinuteCalendarUnit,

        /// <summary>
        /// Specifies the second unit.
        /// </summary>
        [iOSVersion(8)]
        SecondCalendarUnit,

        /// <summary>
        /// Specifies the week unit.
        /// </summary>
        [iOSVersion(8)]
        WeekCalendarUnit,

        /// <summary>
        /// Specifies the weekday unit.
        /// </summary>
        [iOSVersion(8)]
        WeekdayCalendarUnit,

        /// <summary>
        /// Specifies the ordinal weekday unit.
        /// </summary>
        [iOSVersion(8)]
        WeekdayOrdinalCalendarUnit,

        /// <summary>
        /// Specifies the quarter of the calendar as an kCFCalendarUnitSecond.
        /// </summary>
        [iOSVersion(8)]
        QuarterCalendarUnit,

        /// <summary>
        /// Specifies the original week of a month calendar unit.
        /// </summary>
        [iOSVersion(8)]
        WeekOfMonthCalendarUnit,

        /// <summary>
        /// Specifies the original week of the year calendar unit.
        /// </summary>
        [iOSVersion(8)]
        WeekOfYearCalendarUnit,

        /// <summary>
        /// Specifies the year when the calendar is being interpreted as a week-based calendar.
        /// </summary>
        [iOSVersion(8)]
        YearForWeekOfYearCalendarUnit,

        /// <summary>
        /// Specifies the calendar of the calendar.
        /// </summary>
        [iOSVersion(8)]
        CalendarCalendarUnit,

        /// <summary>
        /// Specifies the time zone of the calendar as an NSTimeZone.
        /// </summary>
        [iOSVersion(8)]
        TimeZoneCalendarUnit,
    }
}