/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <YouTube/YTVideoDataSource.h>

@class NSMutableArray, YTSearchRequest;

@interface YTBookmarksVideoDataSource : YTVideoDataSource
{
    NSMutableArray *_bookmarkedShortIDs;
    YTSearchRequest *_bookmarksSearchRequest;
    _Bool _lastReloadWasAccountsFavorites;
}

- (void)addVideo:(id)arg1;
- (void)searchRequest:(id)arg1 foundBatchURL:(id)arg2;
- (void)searchRequest:(id)arg1 receivedVideos:(id)arg2 startIndex:(unsigned int)arg3 videosRemaining:(unsigned int)arg4;
- (_Bool)isLoading;
- (unsigned int)maxVideosToSave;
- (void)reloadData;
- (void)_nextBatch;
- (void)dealloc;
- (id)init;

@end
