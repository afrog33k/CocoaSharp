/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <MediaPlayer/MPAVItem.h>

@class MPMediaItem, NSCache;

@interface MPMediaQueryNowPlayingItem : MPAVItem
{
    MPMediaItem *_mediaItem;
    NSCache *_cache;
}

+ (void)setShouldAlwaysAirplayFromCloud:(_Bool)arg1;
+ (void)applyVolumeNormalizationWithSoundCheckEnabled:(_Bool)arg1 forQueuedItems:(id)arg2 currentQuery:(id)arg3;
- (void).cxx_destruct;
- (void)_updateBookmarkTimeIfNecessary:(double)arg1 isCheckpoint:(_Bool)arg2;
- (id)_newTimeMarkersForChapterType:(long long)arg1;
- (void)_handlePlaybackFinishedTime:(double)arg1 finishedByHittingEnd:(_Bool)arg2;
- (id)_chapterTitleForTime:(double)arg1;
- (void)_applyLoudnessInfo;
- (float)userRating;
- (_Bool)useEmbeddedChapterData;
- (id)urlTimeMarkers;
- (unsigned long long)type;
- (id)titlesForTime:(double)arg1;
- (_Bool)supportsRewindAndFastForward15Seconds;
- (_Bool)supportsAddStation;
- (void)setRating:(float)arg1;
- (void)setPlaybackStoppedTime:(double)arg1;
- (void)setPlaybackFinishedTime:(double)arg1;
- (void)setPlaybackCheckpointCurrentTime:(double)arg1;
- (void)setLoudnessInfoVolumeNormalization:(float)arg1;
- (void)setAlternateAudioTrackID:(int)arg1;
- (void)reevaluateType;
- (double)playbackCheckpointCurrentTime;
- (unsigned long long)persistentID;
- (void)notePlaybackFinishedByHittingEnd;
@property(readonly, nonatomic) MPMediaItem *mediaItem; // @synthesize mediaItem=_mediaItem;
- (id)mainTitle;
- (id)imageCacheRequestWithSize:(struct CGSize)arg1 time:(double)arg2 usePlaceholderAsFallback:(_Bool)arg3;
- (id)imageCache;
- (_Bool)hasDataForItemArtwork;
- (_Bool)hasAlternatesForTypes:(unsigned long long)arg1;
- (void)handlePlaybackFinishedTime:(double)arg1 finishedByHittingEnd:(_Bool)arg2;
- (id)genre;
- (_Bool)allowsEQ;
- (long long)customAVEQPreset;
- (_Bool)isStreamable;
- (_Bool)isSupportedDefaultPlaybackSpeed:(unsigned long long)arg1;
- (_Bool)isAssetURLValid;
- (_Bool)isPlaceholderForItem:(id)arg1;
- (_Bool)isValidPlayerSubstituteForItem:(id)arg1;
- (_Bool)isExplicitTrack;
- (double)durationFromExternalMetadata;
- (id)displayableText;
- (unsigned long long)discCount;
- (unsigned long long)discNumber;
- (id)composer;
- (id)chapterTimeMarkers;
- (_Bool)canSeedGenius;
- (id)artworkTimeMarkers;
- (id)artworkMIMEType;
- (id)artworkImageData;
- (unsigned long long)albumTrackCount;
- (unsigned long long)albumTrackNumber;
- (id)albumArtist;
- (id)artist;
- (id)album;
- (void)loadAssetAndPlayerItem;
- (id)description;
- (id)initWithMediaItem:(id)arg1;

@end

