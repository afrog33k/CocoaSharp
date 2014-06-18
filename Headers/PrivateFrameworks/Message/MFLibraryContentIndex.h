/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableArray, NSMutableIndexSet, NSObject<OS_dispatch_group>, NSObject<OS_dispatch_queue>, NSString, _MFContentIndexWrapper, _MFLibraryContentIndexResultsCache;

@interface MFLibraryContentIndex : NSObject
{
    NSObject<OS_dispatch_queue> *_queue;
    NSString *_path;
    NSString *_indexName;
    double _startNonIdle;
    long long _state;
    NSMutableArray *_pendingIndexableItems;
    NSMutableIndexSet *_pendingRemovals;
    NSObject<OS_dispatch_group> *_group;
    NSObject<OS_dispatch_queue> *_indexingQueue;
    unsigned long long _throttledBatchSize;
    id <MFLibraryContentIndexDataSource> _dataSource;
    NSObject<OS_dispatch_queue> *_dataSourceQueue;
    _MFContentIndexWrapper *_contentIndexWrapper;
    int _invalidated;
    _MFLibraryContentIndexResultsCache *_resultsCache;
    unsigned int _refreshing:1;
    unsigned int _processPendingChangesScheduled:1;
}

- (void)removeItemsWithDocumentIdentifiers:(id)arg1;
- (void)indexItems:(id)arg1;
- (void)_processRefreshRequest;
- (void)_processRemovals:(struct __CXIndex *)arg1;
- (void)_processIndexingBatch:(struct __CXIndex *)arg1;
- (unsigned int)_addItem:(id)arg1 toContentIndex:(struct __CXIndex *)arg2;
- (id)_consumeBatchOfSize:(unsigned long long)arg1;
- (void)_transitionToNextState;
- (void)_dataSourceIndexItemsNeedingRefreshWithLimit:(unsigned long long)arg1;
- (void)_dataSourceInvalidateItemsGreaterThanTransactionId:(unsigned int)arg1;
- (void)_dataSourceAssignTransactionIdentifier:(unsigned int)arg1 forDocumentIdentifiers:(id)arg2;
- (id)_copyContentIndex_indexingQueue;
- (id)_copyContentIndex;
- (id)documentIdentifiersMatchingCriterion:(id)arg1 mailboxIDs:(id)arg2;
- (struct __CXQuery *)_createQueryFromCriterion:(id)arg1 mailboxIDs:(id)arg2 contentIndex:(struct __CXIndex *)arg3;
- (struct __CXQueryNode *)_createQueryNodeFromMailboxIDs:(id)arg1;
- (struct __CXQueryNode *)_createQueryNodeFromCriterion:(id)arg1;
- (_Bool)isSearchable;
- (void)refresh;
- (void)resume;
- (void)suspend;
- (void)scheduleProcessPendingItems;
- (void)_transitionToNextStatePaused:(_Bool)arg1;
- (void)_invalidateResultsCache;
- (void)wait;
- (void)invalidateAndWait;
- (void)_markInvalidated;
- (id)_indexFullPath;
- (void)setTargetQueue:(id)arg1;
- (void)dealloc;
- (id)initWithPath:(id)arg1 indexName:(id)arg2 dataSource:(id)arg3;

@end

