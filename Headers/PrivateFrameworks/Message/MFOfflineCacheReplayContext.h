/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableDictionary, NSString;

@interface MFOfflineCacheReplayContext : NSObject
{
    NSString *_selectedMailboxID;
    NSMutableDictionary *_translatedIDsByTemporaryID;
    NSMutableDictionary *_failureSnapshotsByTemporaryID;
}

@property(readonly, nonatomic) NSMutableDictionary *failureSnapshotsByTemporaryID; // @synthesize failureSnapshotsByTemporaryID=_failureSnapshotsByTemporaryID;
@property(readonly, nonatomic) NSMutableDictionary *translatedIDsByTemporaryID; // @synthesize translatedIDsByTemporaryID=_translatedIDsByTemporaryID;
@property(copy, nonatomic) NSString *selectedMailboxID; // @synthesize selectedMailboxID=_selectedMailboxID;
- (void)dealloc;
- (id)init;

@end

