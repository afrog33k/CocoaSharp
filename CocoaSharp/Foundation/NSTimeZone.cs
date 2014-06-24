using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSTimeZone_Class/index.html#//apple_ref/occ/cl/NSTimeZone
    /// <summary>
    /// NSTimeZone is an abstract class that defines the behavior of time zone objects. Time zone objects represent geopolitical regions. Consequently, these objects have names for these regions. Time zone objects also represent a temporal offset, either plus or minus, from Greenwich Mean Time (GMT) and an abbreviation (such as PST for Pacific Standard Time).
    /// </summary>
    [iOSVersion(2)]
    public class NSTimeZone : NSObject
    {
        /// <summary>
        /// !! IMPORTANT !! Name the parameter you're using!
        /// 
        /// Returns the time zone object identified by a given abbreviation.
        /// Returns a time zone initialized with a given ID.
        /// </summary>
        /// <param name="abbreviation">An abbreviation for a time zone.</param>
        /// <param name="name">The ID for the time zone. Must not be nil.</param>
        /// <returns>The time zone object identified by abbreviation determined by resolving the abbreviation to a name using the abbreviation dictionary and then returning the time zone for that name. Returns nil if there is no match for abbreviation.</returns>
        /// <returns>A time zone object initialized with the ID tzName.</returns>
        [iOSVersion(2)]
        public NSTimeZone(string abbreviation = "", string name = "") { }
        
        /// <summary>
        /// Returns a time zone object offset from Greenwich Mean Time by a given number of seconds.
        /// </summary>
        /// <param name="forSecondsFromGMT">The number of seconds by which the new time zone is offset from GMT.</param>
        /// <returns>A time zone object offset from Greenwich Mean Time by seconds.</returns>
        [iOSVersion(2)]
        public NSTimeZone(int forSecondsFromGMT) { }
        
        /// <summary>
        /// Initializes a time zone with a given ID and time zone data.
        /// </summary>
        /// <param name="name">The ID for the time zone. Must not be nil.</param>
        /// <param name="data">The data from the time-zone files located at /usr/share/zoneinfo.</param>
        [iOSVersion(2)]
        public NSTimeZone(string name, NSData data) { }
        
        /// <summary>
        /// Returns the time zone data version.
        /// </summary>
        /// <returns>A string containing the time zone data version.</returns>
        [iOSVersion(4)]
        [Export("timeZoneDataVersion")]
        public static string TimeZoneDataVersion() { return ""; }
        
        /// <summary>
        /// Returns an object that forwards all messages to the default time zone for the current application.
        /// </summary>
        /// <returns>An object that forwards all messages to the default time zone for the current application.</returns>
        [iOSVersion(2)]
        [Export("localTimeZone")]
        public static NSTimeZone LocalTimeZone() { return null; }
        
        /// <summary>
        /// Returns the default time zone for the current application.
        /// </summary>
        /// <returns>The default time zone for the current application. If no default time zone has been set, this method invokes systemTimeZone and returns the system time zone.</returns>
        [iOSVersion(2)]
        [Export("defaultTimeZone")]
        public static NSTimeZone DefaultTimeZone() { return null; }
        
        /// <summary>
        /// Sets the default time zone for the current application to a given time zone.
        /// </summary>
        /// <param name="aTimeZone">The new default time zone for the current application.</param>
        [iOSVersion(2)]
        [Export("setDefaultTimeZone")]
        public static void SetDefaultTimeZone(NSTimeZone aTimeZone) { }
        
        /// <summary>
        /// Resets the system time zone object cached by the application, if any.
        /// </summary>
        [iOSVersion(2)]
        [Export("resetSystemTimeZone")]
        public static void ResetSystemTimeZone() { }
        
        /// <summary>
        /// Returns the time zone currently used by the system.
        /// </summary>
        /// <returns>The time zone currently used by the system. If the current time zone cannot be determined, returns the GMT time zone.</returns>
        [iOSVersion(2)]
        [Export("systemTimeZone")]
        public static NSTimeZone SystemTimeZone() { return null; }
        
        /// <summary>
        /// Returns a dictionary holding the mappings of time zone abbreviations to time zone names.
        /// </summary>
        /// <returns>A dictionary holding the mappings of time zone abbreviations to time zone names.</returns>
        [iOSVersion(2)]
        [Export("abbreviationDictionary")]
        public static NSDictionary AbbreviationDictionary() { return null; }
        
        /// <summary>
        /// Returns an array of strings listing the IDs of all the time zones known to the system.
        /// </summary>
        /// <returns>An array of strings listing the IDs of all the time zones known to the system.</returns>
        [iOSVersion(2)]
        [Export("knownTimeZoneNames")]
        public static AnyObject[] KnownTimeZoneNames() { return null; }
        
        /// <summary>
        /// Sets the abbreviation dictionary to the specified dictionary.
        /// </summary>
        /// <param name="dict">A dictionary containing key-value pairs for looking up time zone names given their abbreviations. The keys should be NSString objects containing the abbreviations; the values should be NSString objects containing their corresponding geopolitical region names.</param>
        [iOSVersion(4)]
        [Export("setAbbreviationDictionary")]
        public static void SetAbbreviationDictionary(NSDictionary dict) { }
        
        /// <summary>
        /// Returns the abbreviation for the receiver.
        /// </summary>
        /// <returns>The abbreviation for the receiver, such as “EDT” (Eastern Daylight Time).</returns>
        [iOSVersion(2)]
        [Export("abbreviation")]
        public string Abbreviation { get; private set; }
        
        /// <summary>
        /// Returns the abbreviation for the receiver at a given date.
        /// </summary>
        /// <param name="aDate">The date for which to get the abbreviation for the receiver.</param>
        /// <returns>The abbreviation for the receiver at aDate.</returns>
        [iOSVersion(2)]
        [Export("abbreviationForDate")]
        public string AbbreviationForDate(NSDate aDate) { return ""; }
        
        /// <summary>
        /// Returns the geopolitical region ID that identifies the receiver.
        /// </summary>
        /// <returns>The geopolitical region ID that identifies the receiver.</returns>
        [iOSVersion(2)]
        [Export("name")]
        public string Name { get; private set; }
        
        /// <summary>
        /// Returns the current difference in seconds between the receiver and Greenwich Mean Time.
        /// </summary>
        /// <returns>The current difference in seconds between the receiver and Greenwich Mean Time.</returns>
        [iOSVersion(2)]
        [Export("secondsFromGMT")]
        public int SecondsFromGMT { get; private set; }
        
        /// <summary>
        /// Returns the difference in seconds between the receiver and Greenwich Mean Time at a given date.
        /// </summary>
        /// <param name="aDate">The date against which to test the receiver.</param>
        /// <returns>The difference in seconds between the receiver and Greenwich Mean Time at aDate.</returns>
        [iOSVersion(2)]
        [Export("secondsFromGMTForDate")]
        public int SecondsFromGMTForDate(NSDate aDate) { return 0; }
        
        /// <summary>
        /// Returns the data that stores the information used by the receiver.
        /// </summary>
        /// <returns>The data that stores the information used by the receiver.</returns>
        [iOSVersion(2)]
        [Export("data")]
        public NSData Data { get; private set; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver has the same name and data as another given time zone.
        /// </summary>
        /// <param name="aTimeZone">The time zone to compare with the receiver.</param>
        /// <returns>true if aTimeZone and the receiver have the same name and data, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("isEqualToTimeZone")]
        public bool IsEqualToTimeZone(NSTimeZone aTimeZone) { return false; }
        
        /// <summary>
        /// Returns the description of the receiver.
        /// </summary>
        /// <returns>The description of the receiver, including the name, abbreviation, offset from GMT, and whether or not daylight savings time is currently in effect.</returns>
        [iOSVersion(2)]
        [Export("description")]
        public string Description { get; private set; }
        
        /// <summary>
        /// Returns the name of the receiver localized for a given locale.
        /// </summary>
        /// <param name="style">The format style for the returned string.</param>
        /// <param name="locale">The locale for which to format the name.</param>
        /// <returns>The name of the receiver localized for locale using style.</returns>
        [iOSVersion(2)]
        [Export("localizedName")]
        public string LocalizedName(NSTimeZoneNameStyle style, NSLocale locale) { return ""; }
        
        /// <summary>
        /// Returns the current daylight saving time offset of the receiver.
        /// </summary>
        /// <returns>The daylight current saving time offset of the receiver.</returns>
        [iOSVersion(2)]
        [Export("daylightSavingTimeOffset")]
        public NSTimeinterval DaylightSavingTimeOffset { get; private set; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver uses daylight savings time at a given date.
        /// </summary>
        /// <param name="aDate">The date against which to test the receiver.</param>
        /// <returns>true if the receiver uses daylight savings time at aDate, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("isDaylightSavingTimeForDate")]
        public bool IsDaylightSavingTimeForDate(NSDate aDate) { return false; }
        
        /// <summary>
        /// Returns the daylight saving time offset for a given date.
        /// </summary>
        /// <param name="aDate">A date.</param>
        /// <returns>The daylight saving time offset for aDate.</returns>
        [iOSVersion(2)]
        [Export("daylightSavingTimeOffsetForDate")]
        public NSTimeinterval DaylightSavingTimeOffsetForDate(NSDate aDate) { return null; }
        
        /// <summary>
        /// Returns the date of the next daylight saving time transition for the receiver.
        /// </summary>
        /// <returns>The date of the next (after the current instant) daylight saving time transition for the receiver.</returns>
        [iOSVersion(2)]
        [Export("nextDaylightSavingTimeTransition")]
        public NSDate NextDaylightSavingTimeTransition { get; private set; }
        
        /// <summary>
        /// Returns the next daylight saving time transition after a given date.
        /// </summary>
        /// <param name="aDate">A date.</param>
        /// <returns>The next daylight saving time transition after aDate.</returns>
        [iOSVersion(2)]
        [Export("nextDaylightSavingTimeTransitionAfterDate")]
        public NSDate NextDaylightSavingTimeTransitionAfterDate(NSDate aDate) { return null; }
    }

    /// <summary>
    /// Sent when the time zone changed.
    /// </summary>
    [iOSVersion(2)]
    public class NSSystemTimeZoneDidChangeNotification : NSNotification
    {
        public NSSystemTimeZoneDidChangeNotification() : base("", null) { }
    }

    /// <summary>
    /// Specify styles for presenting time zone names.
    /// </summary>
    [iOSVersion(2)]
    public enum NSTimeZoneNameStyle
    {
        /// <summary>
        /// Specifies a standard name style. For example, “Central Standard Time” for Central Time.
        /// </summary>
        [iOSVersion(2)]
        Standard,

        /// <summary>
        /// Specifies a short name style. For example, “CST” for Central Time.
        /// </summary>
        [iOSVersion(2)]
        ShortStandard,

        /// <summary>
        /// Specifies a daylight saving name style. For example, “Central Daylight Time” for Central Time.
        /// </summary>
        [iOSVersion(2)]
        DaylightSaving,

        /// <summary>
        /// Specifies a short daylight saving name style. For example, “CDT” for Central Time.
        /// </summary>
        [iOSVersion(2)]
        ShortDaylightSaving,

        /// <summary>
        /// Specifies a generic name style. For example, “Central Time” for Central Time.
        /// </summary>
        [iOSVersion(4)]
        Generic,

        /// <summary>
        /// Specifies a generic time zone name. For example, “CT” for Central Time.
        /// </summary>
        [iOSVersion(4)]
        ShortGeneric,
    }
}