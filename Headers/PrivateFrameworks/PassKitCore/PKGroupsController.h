/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "PKPassLibraryDelegate-Protocol.h"

@class NSArray, NSMutableArray, NSMutableDictionary, PKCatalog, PKPassLibrary;

@interface PKGroupsController : NSObject <PKPassLibraryDelegate>
{
    PKPassLibrary *_passLibrary;
    NSMutableArray *_groups;
    NSMutableDictionary *_passesByUniqueID;
    NSMutableDictionary *_groupsByGroupID;
    NSMutableDictionary *_indicesByGroupID;
    NSMutableDictionary *_groupIDsByPassUniqueID;
    _Bool _suppressRemoteUpdates;
    _Bool _enqueueRemoteUpdates;
    PKCatalog *_catalogBeforeReordering;
    NSMutableArray *_enqueuedUpdates;
    NSArray *_localPasses;
    _Bool _limitedMode;
    id <PKGroupsControllerDelegate> _delegate;
}

@property(nonatomic) id <PKGroupsControllerDelegate> delegate; // @synthesize delegate=_delegate;
- (void)_insertLocalGroupsIntoCatalog:(id)arg1;
- (id)_copyRemoteCatalog;
- (void)_removeGroup:(id)arg1 notify:(_Bool)arg2;
- (void)_moveGroup:(id)arg1 fromIndex:(unsigned long long)arg2 toIndex:(unsigned long long)arg3 notify:(_Bool)arg4;
- (void)_insertGroup:(id)arg1 atIndex:(unsigned long long)arg2 notify:(_Bool)arg3;
- (void)_placeGroup:(id)arg1 atIndex:(unsigned long long)arg2 notify:(_Bool)arg3;
- (id)_updateAndCreateGroupsWithCatalog:(id)arg1 passes:(id)arg2 notify:(_Bool)arg3;
- (unsigned long long)_destinationIndexForGroupID:(id)arg1 catalogGroups:(id)arg2 skippingNewGroupsAfterIndex:(unsigned long long)arg3;
- (void)_updateStateWithCatalog:(id)arg1 passes:(id)arg2 notify:(_Bool)arg3;
- (_Bool)_groupIDIsNew:(id)arg1;
- (void)_fixIndicesFrom:(unsigned long long)arg1 through:(unsigned long long)arg2;
- (void)_fixIndicesFrom:(unsigned long long)arg1;
- (void)_fixIndex:(unsigned long long)arg1;
- (id)_passesDictionaryFromSet:(id)arg1;
- (unsigned long long)_indexOfGroupID:(id)arg1;
- (void)_performEnqueuedUpdates;
- (void)_performOrEnqueueUpdate:(id)arg1;
- (void)passLibrary:(id)arg1 receivedUpdatedCatalog:(id)arg2 passes:(id)arg3;
- (void)reloadGroupsAndNotify:(_Bool)arg1 completion:(id)arg2;
- (void)reloadGroupsWithCompletion:(id)arg1;
- (void)addLocalPasses:(id)arg1;
- (void)enableRemoteUpdates;
- (void)moveGroupAtIndex:(unsigned long long)arg1 toIndex:(unsigned long long)arg2;
- (void)suppressRemoteUpdates:(_Bool)arg1;
- (void)handleUserPassDelete:(id)arg1;
- (void)handleUserPassIngestionWithData:(id)arg1 completion:(id)arg2;
- (unsigned long long)groupIndexForPassUniqueID:(id)arg1;
- (unsigned long long)indexOfGroup:(id)arg1;
- (id)groupAtIndex:(unsigned long long)arg1;
- (unsigned long long)groupCount;
- (void)reloadGroups;
- (void)loadGroupsSynchronously;
- (void)loadGroupsWithCompletion:(id)arg1;
- (void)dealloc;
- (id)initLimited;
- (id)init;

@end

