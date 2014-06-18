/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AVFoundation/AVAsset.h>

#import "NSMutableCopying-Protocol.h"

@class AVCompositionInternal, NSArray;

@interface AVComposition : AVAsset <NSMutableCopying>
{
    AVCompositionInternal *_priv;
}

+ (void)initialize;
- (void)_setNaturalSize:(struct CGSize)arg1;
@property(readonly, nonatomic) struct CGSize naturalSize;
@property(readonly, nonatomic) NSArray *tracks;
- (id)_mutableTracks;
- (id)_newTrackForIndex:(long long)arg1;
- (id)mutableCopyWithZone:(struct _NSZone *)arg1;
- (struct OpaqueFigFormatReader *)_formatReader;
- (id)_assetInspector;
- (struct OpaqueFigMutableComposition *)_mutableComposition;
- (id)description;
- (void)finalize;
- (void)dealloc;
- (id)init;
- (id)_initWithComposition:(id)arg1;
- (int)_createEmptyMutableCompositionIfNeeded;

@end

