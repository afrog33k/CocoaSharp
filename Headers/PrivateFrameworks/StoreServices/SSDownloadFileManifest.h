/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class SSXPCConnection;

@interface SSDownloadFileManifest : NSObject
{
    SSXPCConnection *_connection;
    long long _manifestType;
}

- (void)_removeItemsWithAssetPaths:(id)arg1 completionBlock:(id)arg2;
- (void)removeItemsWithAssetPaths:(id)arg1 completionBlock:(id)arg2;
- (void)removeItemWithAssetPath:(id)arg1 completionBlock:(id)arg2;
- (void)rebuildManifestWithCompletionBlock:(id)arg1;
@property(readonly) long long manifestType;
- (void)getPathsForFilesWithClass:(long long)arg1 completionBlock:(id)arg2;
- (void)dealloc;
- (id)initWithManifestType:(long long)arg1;
- (id)init;

@end

