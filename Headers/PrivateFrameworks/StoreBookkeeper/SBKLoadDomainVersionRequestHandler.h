/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <StoreBookkeeper/SBKSyncRequestHandler.h>

#import "SBKSyncTransactionProcessing-Protocol.h"

@class NSString, SBKSyncBagContext, SBKSyncTransaction, SBKTransactionController;

@interface SBKLoadDomainVersionRequestHandler : SBKSyncRequestHandler <SBKSyncTransactionProcessing>
{
    _Bool _loadsRemoteItemCount;
    unsigned long long _responseItemCount;
    unsigned long long _itemCount;
    SBKSyncTransaction *_transaction;
}

+ (long long)conflictDetectionType;
@property(retain) SBKSyncTransaction *transaction; // @synthesize transaction=_transaction;
@property unsigned long long itemCount; // @synthesize itemCount=_itemCount;
@property(readonly) unsigned long long responseItemCount; // @synthesize responseItemCount=_responseItemCount;
@property _Bool loadsRemoteItemCount; // @synthesize loadsRemoteItemCount=_loadsRemoteItemCount;
- (void).cxx_destruct;
- (void)runWithCompletionHandler:(id)arg1;

// Remaining properties
@property(retain) SBKSyncBagContext *bagContext;
@property(copy) NSString *responseDomainVersion;
@property(retain) SBKTransactionController *transactionController;

@end

