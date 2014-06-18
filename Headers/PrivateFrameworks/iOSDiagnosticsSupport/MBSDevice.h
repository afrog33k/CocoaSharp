/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSData, NSMutableDictionary, NSString;

@interface MBSDevice : NSObject
{
    NSMutableDictionary *_deviceInfoDictionary;
    NSData *_logData;
    NSString *_logFileName;
}

@property(retain) NSString *logFileName; // @synthesize logFileName=_logFileName;
@property(retain) NSData *logData; // @synthesize logData=_logData;
@property(retain) NSMutableDictionary *deviceInfoDictionary; // @synthesize deviceInfoDictionary=_deviceInfoDictionary;
- (_Bool)copyLogsToTempDirectory:(unsigned long long)arg1;
- (_Bool)copyPowerLogsToDir:(id)arg1;
- (_Bool)archiveLogFile:(id)arg1 toFile:(id)arg2 atDir:(id)arg3;
- (_Bool)createTempDirectory:(unsigned long long)arg1;
- (_Bool)collectLogs:(unsigned long long)arg1;
- (id)collectUbiquityData;
- (id)collectAggdData;
- (id)collectGasGaugeData;
- (id)collectBasicDeviceData;
- (_Bool)collectAllDeviceInformation;
- (void)dealloc;

@end

