/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"
#import "NSSecureCoding-Protocol.h"

@interface NSDateComponents : NSObject <NSCopying, NSSecureCoding>
{
}

+ (_Bool)supportsSecureCoding;
+ (id)allocWithZone:(struct _NSZone *)arg1;
- (id)description;
- (_Bool)isValidDateInCalendar:(id)arg1;
- (_Bool)isValidDate;
- (void)setValue:(long long)arg1 forComponent:(unsigned long long)arg2;
- (long long)valueForComponent:(unsigned long long)arg1;
- (id)date;
- (void)setLeapMonth:(_Bool)arg1;
- (void)setYearForWeekOfYear:(long long)arg1;
- (void)setWeekOfMonth:(long long)arg1;
- (void)setWeekOfYear:(long long)arg1;
- (void)setNanosecond:(long long)arg1;
- (void)setQuarter:(long long)arg1;
- (void)setWeekdayOrdinal:(long long)arg1;
- (void)setWeekday:(long long)arg1;
- (void)setWeek:(long long)arg1;
- (void)setSecond:(long long)arg1;
- (void)setMinute:(long long)arg1;
- (void)setHour:(long long)arg1;
- (void)setDay:(long long)arg1;
- (void)setMonth:(long long)arg1;
- (void)setYear:(long long)arg1;
- (void)setEra:(long long)arg1;
- (void)setTimeZone:(id)arg1;
- (void)setCalendar:(id)arg1;
- (_Bool)isLeapMonthSet;
- (_Bool)isLeapMonth;
- (long long)yearForWeekOfYear;
- (long long)weekOfMonth;
- (long long)weekOfYear;
- (long long)nanosecond;
- (long long)quarter;
- (long long)weekdayOrdinal;
- (long long)weekday;
- (long long)week;
- (long long)second;
- (long long)minute;
- (long long)hour;
- (long long)day;
- (long long)month;
- (long long)year;
- (long long)era;
- (id)timeZone;
- (id)calendar;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (_Bool)isEqual:(id)arg1;
- (unsigned long long)hash;
- (void)dealloc;
- (id)init;

@end

