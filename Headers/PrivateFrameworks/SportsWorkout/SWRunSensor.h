/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <SportsWorkout/SWAccessory.h>

@interface SWRunSensor : SWAccessory
{
    id <SWRunSensorPacketObserver> _packetObserver;
}

+ (unsigned long long)remainingHoursConsideredToBeLowBattery;
- (void)setPacketObserver:(id)arg1;

// Remaining properties
@property(readonly, nonatomic) unsigned long long remainingBatteryLifetimeInHours; // @dynamic remainingBatteryLifetimeInHours;

@end

