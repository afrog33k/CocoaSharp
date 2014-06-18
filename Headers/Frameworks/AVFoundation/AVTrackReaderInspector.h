/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AVFoundation/AVAssetTrackInspector.h>

@class AVWeakReference;

@interface AVTrackReaderInspector : AVAssetTrackInspector
{
    struct OpaqueFigFormatReader *_formatReader;
    struct OpaqueFigTrackReader *_trackReader;
    int _trackID;
    unsigned int _mediaType;
    AVWeakReference *_weakReferenceToAsset;
}

- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (_Bool)isExcludedFromAutoselectionInTrackGroup;
- (id)metadataForFormat:(id)arg1;
- (id)availableMetadataFormats;
- (id)commonMetadata;
- (id)segmentForTrackTime:(CDStruct_1b6d18a9)arg1;
- (id)segments;
- (CDStruct_1b6d18a9)minSampleDuration;
- (float)nominalFrameRate;
- (id)loudnessInfo;
- (float)preferredVolume;
- (long long)layer;
- (struct CGAffineTransform)preferredTransform;
- (struct CGSize)dimensions;
- (struct CGSize)naturalSize;
- (id)extendedLanguageTag;
- (id)languageCode;
- (float)estimatedDataRate;
- (int)naturalTimeScale;
- (CDStruct_e83c9415)timeRange;
- (long long)totalSampleDataLength;
- (_Bool)isSelfContained;
- (_Bool)isEnabled;
- (id)formatDescriptions;
- (void *)_valueAsCFTypeForProperty:(struct __CFString *)arg1;
- (struct OpaqueFigTrackReader *)_trackReader;
- (id)mediaType;
- (unsigned int)_figMediaType;
- (int)trackID;
- (id)asset;
- (void)finalize;
- (void)dealloc;
- (id)_initWithAsset:(id)arg1 trackID:(int)arg2 trackIndex:(long long)arg3;

@end

