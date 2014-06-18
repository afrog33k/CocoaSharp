/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <GeoServices/GEOTileRequester.h>

#import "GEOResourceManifestTileGroupObserver-Protocol.h"
#import "GEOTileRequesterDelegate-Protocol.h"
#import "GEOVoltaireMultiTileDownloaderDelegate-Protocol.h"

@class GEOVoltaireSimpleTileRequester, NSMutableArray, NSThread, NSTimer;

@interface GEOVoltaireTileRequester : GEOTileRequester <GEOVoltaireMultiTileDownloaderDelegate, GEOTileRequesterDelegate, GEOResourceManifestTileGroupObserver>
{
    NSMutableArray *_activeDownloads;
    NSThread *_startThread;
    NSTimer *_activeTileGroupTimeoutTimer;
    NSMutableArray *_errors;
    GEOVoltaireSimpleTileRequester *_simpleRequester;
}

+ (Class)multiDownloaderClass;
+ (Class)simpleRequesterClass;
+ (_Bool)skipNetworkForKeysWhenPreloading:(id)arg1;
+ (CDStruct_e4886f83 *)newExpiringTilesets;
+ (unsigned long long)expiringTilesetsCount;
+ (unsigned char)tileProviderIdentifier;
- (void)tileRequesterFinished:(id)arg1;
- (void)tileRequester:(id)arg1 receivedError:(id)arg2;
- (void)tileRequester:(id)arg1 receivedData:(id)arg2 tileEdition:(unsigned int)arg3 tileSet:(unsigned int)arg4 forKey:(struct _GEOTileKey)arg5 userInfo:(id)arg6;
- (void)tileDownload:(id)arg1 didFailWithError:(id)arg2;
- (void)tileDownloadFinished:(id)arg1;
- (void)tileDownload:(id)arg1 didReceiveData:(id)arg2 edition:(unsigned int)arg3 forKey:(struct _GEOTileKey)arg4;
- (void)tryFinish;
- (void)cancel;
- (void)cleanup;
- (void)_startWithTileKeys:(id)arg1;
- (id)multiTileURLStringForTileKey:(struct _GEOTileKey *)arg1 useStatusCodes:(_Bool *)arg2;
- (void)resourceManifestManagerDidChangeActiveTileGroup:(id)arg1;
- (void)resourceManifestManagerWillChangeActiveTileGroup:(id)arg1;
- (void)_failedToReceiveActiveTileGroup:(id)arg1;
- (void)start;
- (unsigned int)tileSetForKey:(const struct _GEOTileKey *)arg1;
- (void)dealloc;

@end

