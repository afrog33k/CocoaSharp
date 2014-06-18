/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@interface MKTrafficSupport : NSObject
{
}

+ (id)sharedTrafficSupport;
- (struct CGImage *)imageForIncidentType:(long long)arg1 contentScale:(double)arg2;
- (struct CGImage *)imageForGEOIncidentType:(int)arg1 contentScale:(double)arg2;
- (id)localizedSubtitleForStreet:(id)arg1 crossStreet:(id)arg2;
- (id)localizedTitleForIncidentType:(long long)arg1 laneType:(long long)arg2 laneCount:(unsigned long long)arg3;
- (id)localizedTitleForGEOIncidentType:(int)arg1 laneType:(int)arg2 laneCount:(unsigned long long)arg3;
- (long long)_convertType:(int)arg1;
- (void)setupTrafficIncidents;

@end

