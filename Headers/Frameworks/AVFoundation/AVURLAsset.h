/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AVFoundation/AVAsset.h>

@class AVURLAssetInternal, NSURL;

@interface AVURLAsset : AVAsset
{
    AVURLAssetInternal *_asset;
}

+ (id)URLAssetWithURL:(id)arg1 options:(id)arg2;
+ (_Bool)isPlayableExtendedMIMEType:(id)arg1;
+ (id)audiovisualMIMETypes;
+ (id)audiovisualTypes;
+ (id)_UTTypes;
+ (id)_fileUTTypes;
+ (id)_streamingUTTypes;
+ (id)_figMIMETypes;
+ (id)_figFilePathExtensions;
+ (id)_figFileMIMETypes;
+ (id)_figStreamingMIMETypes;
+ (id)_avfValidationPlist;
- (id)lyrics;
- (void)cancelLoading;
@property(readonly, nonatomic) NSURL *URL;
- (id)_absoluteURL;
- (void)_tracksDidChange;
- (id)tracks;
- (id)_tracks;
- (struct OpaqueFigFormatReader *)_formatReader;
- (id)_assetInspector;
- (void)_setAssetInspectorLoader:(id)arg1;
- (id)_assetInspectorLoader;
- (id)description;
- (void)finalize;
- (void)dealloc;
- (void)_removeFigAssetNotifications;
- (void)_addFigAssetNotifications;
- (id)_errorForFigNotificationPayload:(struct __CFDictionary *)arg1 key:(struct __CFString *)arg2;
- (id)initWithURL:(id)arg1 options:(id)arg2;
- (id)init;

@end

