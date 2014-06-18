/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class GEOTileLoader;

// Not exported
@interface AltTileFetcher : NSObject
{
    GEOTileLoader *_geoTileLoader;
    struct KaroMapImp<_GEOTileKey, std::__1::shared_ptr<altitude::GeoServicesLoadJob>, GEOTileKeyComp> _keyToJobMap;
    struct Mutex _mutex;
    unsigned int _numDownloads;
}

- (id).cxx_construct;
- (void).cxx_destruct;
- (_Bool)isDownloading;
- (void)purgeExpired:(double)arg1;
- (void)reportCorruptTile:(const struct _GEOTileKey *)arg1;
- (void)cancelRequests;
- (void)updateJobPriority:(shared_ptr_3813db34 *)arg1;
- (void)cancelJob:(shared_ptr_3813db34 *)arg1;
- (void)fetchDataForJob:(shared_ptr_3813db34 *)arg1;
- (shared_ptr_3813db34)getJobForKey:(const struct _GEOTileKey *)arg1;
- (void)dealloc;
- (id)init;

@end

