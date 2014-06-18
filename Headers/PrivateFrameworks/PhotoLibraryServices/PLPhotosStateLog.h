/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSObject<OS_dispatch_group>, PLPhotoLibrary;

@interface PLPhotosStateLog : NSObject
{
    NSObject<OS_dispatch_group> *_group;
    PLPhotoLibrary *_photoLibrary;
}

@property(readonly, nonatomic) NSObject<OS_dispatch_group> *group; // @synthesize group=_group;
- (_Bool)createSnapshot;
- (_Bool)copyFilesMatching:(id)arg1 andExcluding:(id)arg2 fromPath:(id)arg3 toPath:(id)arg4 usingCompression:(_Bool)arg5;
- (_Bool)compressFileFromPath:(id)arg1 toPath:(id)arg2;
- (void)logDescription:(id)arg1;
- (void)_logAssets:(id)arg1 forAlbum:(id)arg2 indent:(unsigned long long)arg3;
- (void)logAssetCounts;
- (void)logAllAlbums;
- (void)logAlbumLists;
- (void)logAlbum:(id)arg1 index:(unsigned long long)arg2 indent:(unsigned long long)arg3 completeMetadata:(_Bool)arg4 printAssets:(_Bool)arg5;
- (void)logMoments;
@property(readonly, nonatomic) PLPhotoLibrary *photoLibrary;
- (void)dealloc;
- (id)init;
- (id)initWithPhotoLibrary:(id)arg1;

@end

