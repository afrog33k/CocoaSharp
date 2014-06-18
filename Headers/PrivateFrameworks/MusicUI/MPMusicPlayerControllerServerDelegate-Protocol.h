/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol MPMusicPlayerControllerServerDelegate <NSObject>
- (void)musicPlayerServer:(id)arg1 prepareQueueWithRadioStation:(id)arg2;
- (void)musicPlayerServer:(id)arg1 prepareQueueWithGeniusMixPlaylist:(id)arg2;
- (void)musicPlayerServer:(id)arg1 prepareQueueWithQuery:(id)arg2;
- (void)musicPlayerServer:(id)arg1 setShuffleMode:(long long)arg2;
- (void)musicPlayerServer:(id)arg1 setFirstItem:(id)arg2;
- (id)currentRadioStationForMusicPlayerServer:(id)arg1;
- (id)currentMediaQueryForMusicPlayerServer:(id)arg1;
- (_Bool)isNowPlayingItemFromGeniusMixForMusicPlayerServer:(id)arg1;
- (unsigned long long)unshuffledIndexOfNowPlayingItemForMusicPlayerServer:(id)arg1;
- (unsigned long long)indexOfNowPlayingItemForMusicPlayerServer:(id)arg1;
- (void)musicPlayerServer:(id)arg1 setNowPlayingItem:(id)arg2;
- (id)nowPlayingItemForMusicPlayerServer:(id)arg1;
- (void)musicPlayerServer:(id)arg1 setPlaybackSpeed:(long long)arg2;
- (long long)playbackSpeedForMusicPlayerServer:(id)arg1;
- (id)playerForMusicPlayerServer:(id)arg1 usingApplicationSpecificQueue:(_Bool)arg2;
- (void)musicPlayerServer:(id)arg1 registerForShuffleModeChangesWithChangeHandler:(id)arg2;
- (void)musicPlayerServer:(id)arg1 registerForRepeatModeChangesWithChangeHandler:(id)arg2;
@end

