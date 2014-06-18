/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "SWFakeRunSensorDelegate-Protocol.h"

@class NSTimer;

@interface SWBasicFakeRunSensorDelegate : NSObject <SWFakeRunSensorDelegate>
{
    NSTimer *_packetTimer;
    _Bool _firstPacketDelivered;
    unsigned char _payload[28];
    struct SDARunState _runState;
}

- (void)_fakeNextPacketForTimer:(id)arg1;
- (void)_updatePayload;
- (void)_schedulePacketTimerForFakeSensor:(id)arg1;
- (void)cancelSearchingForFakeSensor:(id)arg1;
- (void)beginSearchingForFakeSensor:(id)arg1;
- (void)cancelLinkingForFakeSensor:(id)arg1;
- (void)beginLinkingForFakeSensor:(id)arg1;
- (unsigned long long)remainingBatteryLifetimeInHoursForFakeSensor:(id)arg1;
- (void)dealloc;
- (id)init;

@end

