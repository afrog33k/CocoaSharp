/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "UITableViewDataSource-Protocol.h"

@class ABModel, ACAccountStore, NSArray, NSDictionary;

@interface ABStarkGroupsDataSource : NSObject <UITableViewDataSource>
{
    ABModel *_model;
    NSArray *_accountIdentifiers;
    NSArray *_accountDisplayNames;
    NSDictionary *_groupsByAccountIdentifier;
    ACAccountStore *_accountStore;
}

@property(retain, nonatomic) ACAccountStore *accountStore; // @synthesize accountStore=_accountStore;
@property(retain, nonatomic) ABModel *model; // @synthesize model=_model;
- (void)cancelScheduledRefresh;
- (void)scheduleRefresh;
- (long long)numberOfGroupsForAccountIdentifier:(id)arg1;
- (id)tableView:(id)arg1 cellForRowAtIndexPath:(id)arg2;
- (id)accountDisplayNameAtIndex:(long long)arg1;
- (long long)numberOfSectionsInTableView:(id)arg1;
- (long long)tableView:(id)arg1 numberOfRowsInSection:(long long)arg2;
- (long long)numberOfAccounts;
- (long long)numberOfGroupsInAccountAtIndex:(long long)arg1;
- (id)newContactsFilterForIndexPath:(id)arg1;
- (id)titleForIndexPath:(id)arg1;
- (id)groupWrapperForIndexPath:(id)arg1;
- (void)reloadData;
- (void)reloadDataIncludingAccountStore:(_Bool)arg1 usingArchivedState:(_Bool)arg2;
- (void)dealloc;

@end

