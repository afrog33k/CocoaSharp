/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <PhotoLibraryServices/PLAssetContainerChangeNotification.h>

@class NSMutableSet, NSOrderedSet, PLInFlightAssetsAlbum;

@interface PLInFlightAssetsAlbumChangeNotification : PLAssetContainerChangeNotification
{
    PLInFlightAssetsAlbum *_album;
    PLAssetContainerChangeNotification *_backingNotification;
    NSOrderedSet *_oldOIDs;
    NSMutableSet *_uniquedOIDs;
    _Bool _keyAssetDidChange;
}

+ (id)notificationForDerivedObject:(id)arg1 priorChangeState:(id)arg2 forBackingObjectNotification:(id)arg3;
@property(readonly, nonatomic) NSOrderedSet *oldOIDs; // @synthesize oldOIDs=_oldOIDs;
@property(readonly, nonatomic) PLAssetContainerChangeNotification *backingNotification; // @synthesize backingNotification=_backingNotification;
@property(readonly, nonatomic) PLInFlightAssetsAlbum *album; // @synthesize album=_album;
- (id)_changedObjects;
- (_Bool)_getOldSet:(id *)arg1 newSet:(id *)arg2;
- (id)_diffDescription;
- (id)description;
- (_Bool)keyAssetDidChange;
- (_Bool)titleDidChange;
- (id)object;
- (void)dealloc;
- (id)initWithInFlightAssetsAlbum:(id)arg1 priorChangeState:(id)arg2 albumChangeNotification:(id)arg3;

@end
