/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@interface CMDeviceOrientationManager : NSObject
{
    id _internal;
}

+ (void)dummySelector:(id)arg1;
+ (void)initialize;
- (id)deviceOrientationBlocking;
- (void)onDeviceOrientation:(const struct Sample *)arg1;
- (void)stopDeviceOrientationUpdatesPrivate;
- (void)startDeviceOrientationUpdatesPrivateToQueue:(id)arg1 withHandler:(id)arg2;
- (void)stopDeviceOrientationUpdates;
- (void)startDeviceOrientationUpdatesToQueue:(id)arg1 withHandler:(id)arg2;
- (_Bool)isDeviceOrientationActive;
- (_Bool)isDeviceOrientationAvailable;
- (void)deallocPrivate;
- (void)dealloc;
- (id)initPrivate;
- (id)init;

@end

