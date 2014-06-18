/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <RTCReporting/DashboardBackend.h>

@interface DashboardBackend (PrivateMethods)
- (id)writeLocalLog:(struct tagReportingPacket *)arg1;
- (void)tryToSendMsg:(struct tagReportingPacket *)arg1 length:(unsigned short)arg2 eventNumber:(unsigned short)arg3;
- (id)sanitize:(id)arg1;
- (id)descriptionForObject:(id)arg1;
- (void)processSocketRead;
- (void)myPeriodicTask;
- (void)cleanupSources;
- (void)useReliableUDP;
@end

