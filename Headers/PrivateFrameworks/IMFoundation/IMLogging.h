/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@interface IMLogging : NSObject
{
}

+ (void)enableConsoleLoggingForLevel:(int)arg1;
+ (void)logString:(id)arg1 toFolder:(id)arg2 toFileNamed:(id)arg3;
+ (id)timeFormatter;
+ (id)dateFormatter;
+ (id)logFileDirectory;
+ (void)logAtLevel:(int)arg1 type:(id)arg2 category:(id)arg3 insertProcessInfo:(_Bool)arg4 simpleLogString:(id)arg5;
+ (void)logAtLevel:(int)arg1 type:(id)arg2 category:(id)arg3 insertProcessInfo:(_Bool)arg4 format:(id)arg5 arguments:(char *)arg6;
+ (void)logAtLevel:(int)arg1 type:(id)arg2 category:(id)arg3 insertProcessInfo:(_Bool)arg4 simpleLogString:(id)arg5 format:(id)arg6 arguments:(char *)arg7;
+ (void)logAtLevel:(int)arg1 type:(id)arg2 category:(id)arg3 format:(id)arg4 arguments:(char *)arg5;
+ (void)logAtLevel:(int)arg1 type:(id)arg2 category:(id)arg3 insertProcessInfo:(_Bool)arg4 format:(id)arg5;
+ (void)logAtLevel:(int)arg1 type:(id)arg2 category:(id)arg3 format:(id)arg4;
+ (id)stringForDate;
+ (_Bool)loggingEnabledForLevel:(int)arg1;

@end

