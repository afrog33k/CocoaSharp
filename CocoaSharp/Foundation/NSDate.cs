using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSDate objects represent a single point in time. NSDate is a class cluster; its single public superclass, NSDate, declares the programmatic interface for specific and relative time values. The objects you create using NSDate are referred to as date objects. They are immutable objects. Because of the nature of class clusters, objects returned by the NSDate class are instances not of that abstract class but of one of its private subclasses. Although a date object’s class is private, its interface is public, as declared by the abstract superclass NSDate. Generally, you instantiate a suitable date object by invoking one of the date... class methods.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDate_Class/index.html#//apple_ref/occ/cl/NSDate"/>    [iOSVersion(2)]    [Export("")]    public class NSDate : NSObject//, AnyObject, CKRecordValue, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable, Reflectable    {        /// <summary>        /// Returns an NSDate object initialized to the current date and time.        /// </summary>        [iOSVersion(2)]        public NSDate() { }                /// <summary>        /// Returns an NSDate object initialized relative to the current date and time by a given number of seconds.        /// </summary>        /// <param name="timeIntervalSinceNow">The number of seconds from relative to the current date and time to which the receiver should be initialized. A negative value means the returned object will represent a date in the past.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSDate(NSTimeInterval timeIntervalSinceNow) { }                /// <summary>        /// Returns an NSDate object initialized relative to another given date by a given number of seconds.        /// </summary>        /// <param name="timeInterval">The number of seconds to add to refDate. A negative value means the receiver will be earlier than refDate.</param>        /// <param name="sinceDate">The reference date.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSDate(NSTimeInterval timeInterval, NSDate sinceDate) { }                /// <summary>        /// Returns an NSDate object initialized relative the first instant of 1 January 2001, GMT by a given number of seconds.        /// </summary>        /// <param name="timeIntervalSinceReferenceDate">The number of seconds to add to the reference date (the first instant of 1 January 2001, GMT). A negative value means the receiver will be earlier than the reference date.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSDate(NSTimeInterval timeIntervalSinceReferenceDate, bool NAME_YOUR_PARAMS = false) { }                /// <summary>        /// Returns an NSDate object set to the given number of seconds from the first instant of 1 January 1970, GMT.        /// </summary>        /// <param name="timeIntervalSince1970">The number of seconds from the reference date, 1 January 1970, GMT, for the new date. Use a negative argument to specify a date before this date.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(4)]        [Export("convenience init")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSDate(NSTimeInterval timeIntervalSince1970, int NAME_YOUR_PARAMS = 0) { }                /// <summary>        /// Creates and returns an NSDate object representing a date in the distant future.        /// </summary>        [iOSVersion(2)]        [Export("distantFuture")]        public static AnyObject DistantFuture() { return default(AnyObject); }                /// <summary>        /// Creates and returns an NSDate object representing a date in the distant past.        /// </summary>        [iOSVersion(2)]        [Export("distantPast")]        public static AnyObject DistantPast() { return default(AnyObject); }                /// <summary>        /// Returns a Boolean value that indicates whether a given object is an NSDate object and exactly equal the receiver.        /// </summary>        /// <param name="anotherDate">The date to compare with the receiver.</param>        [iOSVersion(2)]        [Export("isEqualToDate")]        public virtual bool IsEqualToDate(NSDate anotherDate) { return default(bool); }                /// <summary>        /// Returns the earlier of the receiver and another given date.        /// </summary>        /// <param name="anotherDate">The date with which to compare the receiver.</param>        [iOSVersion(2)]        [Export("earlierDate")]        public virtual NSDate EarlierDate(NSDate anotherDate) { return default(NSDate); }                /// <summary>        /// Returns the later of the receiver and another given date.        /// </summary>        /// <param name="anotherDate">The date with which to compare the receiver.</param>        [iOSVersion(2)]        [Export("laterDate")]        public virtual NSDate LaterDate(NSDate anotherDate) { return default(NSDate); }                /// <summary>        /// Returns an NSComparisonResult value that indicates the temporal ordering of the receiver and another given date.        /// </summary>        /// <param name="anotherDate">The date with which to compare the receiver.        ///   This value must not be nil. If the value is nil, the behavior is undefined and may change in future versions of OS X.</param>        [iOSVersion(2)]        [Export("compare")]        public virtual NSComparisonResult Compare(NSDate anotherDate) { return default(NSComparisonResult); }                /// <summary>        /// Returns the interval between the receiver and another given date.        /// </summary>        /// <param name="anotherDate">The date with which to compare the receiver. You must pass a non-nil date object.</param>        [iOSVersion(2)]        [Export("timeIntervalSinceDate")]        public virtual NSTimeInterval TimeIntervalSinceDate(NSDate anotherDate) { return default(NSTimeInterval); }                /// <summary>        /// Returns the interval between January 1, 2001, at 12:00 a.m. GMT and the current date and time.        /// </summary>        [iOSVersion(2)]        [Export("timeIntervalSinceReferenceDate")]        public static NSTimeInterval TimeIntervalSinceReferenceDate() { return default(NSTimeInterval); }                /// <summary>        /// Returns a new NSDate object that is set to a given number of seconds relative to the receiver.        /// </summary>        /// <param name="seconds">The number of seconds to add to the receiver. Use a negative value for seconds to have the returned object specify a date before the receiver.</param>        [iOSVersion(2)]        [Export("dateByAddingTimeInterval")]        [return:Unwrapped]        public virtual NSDate DateByAddingTimeInterval(NSTimeInterval seconds) { return default(NSDate); }                /// <summary>        /// Returns a string representation of the receiver using the given locale.        /// </summary>        /// <param name="locale">An NSLocale object.        ///   If you pass nil, NSDate formats the date in the same way as the description property.         ///   On OS X v10.4 and earlier, this parameter was an NSDictionary object. If you pass in an NSDictionary object on OS X v10.5, NSDate uses the default user locale—the same as if you passed in [NSLocale currentLocale].</param>        [iOSVersion(4)]        [Export("descriptionWithLocale")]        [return:Optional]        public virtual string DescriptionWithLocale([Optional] AnyObject locale) { return default(string); }                /// <summary>        /// The time interval between the date object and the current date and time. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("timeIntervalSinceNow")]        public NSTimeInterval TimeIntervalSinceNow { get; private set; }                /// <summary>        /// Returns the interval between the date object and January 1, 2001, at 12:00 a.m. GMT. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("timeIntervalSinceReferenceDate")]        public NSTimeInterval InstanceTimeIntervalSinceReferenceDate { get; private set; }                /// <summary>        /// The interval between the date object and January 1, 1970 at 12:00 a.m. GMT. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("timeIntervalSince1970")]        public NSTimeInterval TimeIntervalSince1970 { get; private set; }                /// <summary>        /// A string representation of the date object. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("description")]        public string Description { get; private set; }                /// <summary>        /// NSDate provides a constant that specifies the number of seconds from 1 January 1970 to the reference date, 1 January 2001.        /// </summary>        public Double NSTimeIntervalSince1970 { get; private set; }    }    /// <summary>    /// Posted whenever the system clock is changed. This can be initiated by a call to settimeofday() or the user changing values in the Date and Time Preference panel. The notification object is null. This notification does not contain a userInfo dictionary.    /// </summary>    public class NSSystemClockDidChangeNotification : NSNotification    {        public NSSystemClockDidChangeNotification() : base("", null) { }    }}