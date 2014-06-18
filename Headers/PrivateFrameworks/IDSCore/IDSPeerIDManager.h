/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class FTMessageDelivery, IDSPushHandler, NSMutableArray, NSMutableDictionary;

@interface IDSPeerIDManager : NSObject
{
    FTMessageDelivery *_idQueryMessageDelivery;
    IDSPushHandler *_pushHandler;
    NSMutableArray *_queryQueue;
    NSMutableDictionary *_peerMap;
    NSMutableDictionary *_completionBlocksToURIsMap;
    NSMutableDictionary *_extraCompletionBlocks;
    NSMutableDictionary *_clientDataUpdateBlocks;
    NSMutableDictionary *_purgeClientDataBlocks;
    NSMutableDictionary *_disasterModeTokens;
    _Bool _isInServerBackoffMode;
}

+ (int)serverBackoffModeReceiverRetryInterval;
+ (int)serverBackoffModeMaxSenderRetries;
+ (_Bool)isServerBackoffModeActive;
+ (_Bool)shouldUseSelfTokens;
+ (double)timeToCacheResultsForIDStatus:(unsigned int)arg1 forService:(id)arg2;
+ (double)timeToCacheUnknownResultsForService:(id)arg1;
+ (double)timeToCacheNegativeResultsForService:(id)arg1;
+ (double)timeToCachePositiveResultsForService:(id)arg1;
+ (id)sharedInstance;
- (void)removePurgeClientDataBlockForToken:(id)arg1;
- (void)addPurgeClientDataBlock:(id)arg1 forToken:(void)arg2;
- (void)removeClientDataUpdateBlockForToken:(id)arg1;
- (void)addClientDataUpdateBlock:(id)arg1 forToken:(void)arg2;
- (void)removeCompletionBlockForToken:(id)arg1;
- (void)addCompletionBlock:(id)arg1 forToken:(void)arg2;
- (id)activeURIsFromURI:(id)arg1 service:(id)arg2;
- (_Bool)hasPeerTokensForURIs:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (_Bool)hasPeerTokensForURI:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (void)forgetSessionTokensForURIs:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (void)forgetPeerTokensForURI:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (void)forgetSessionTokensForURI:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (void)clearCache;
- (void)notePeerToken:(id)arg1 forURI:(id)arg2 fromURI:(id)arg3 service:(id)arg4;
- (_Bool)startQueryForURIs:(id)arg1 fromIdentity:(id)arg2 fromURI:(id)arg3 fromService:(id)arg4;
- (_Bool)startQueryForURIs:(id)arg1 fromIdentity:(id)arg2 fromURI:(id)arg3 fromService:(id)arg4 forSending:(_Bool)arg5 completionBlock:(id)arg6;
- (void)_dequeuePendingQueryIfPossible;
- (void)_startQueryForURIs:(id)arg1 fromIdentity:(id)arg2 fromURI:(id)arg3 fromService:(id)arg4 forSending:(_Bool)arg5 completionBlock:(id)arg6;
- (_Bool)shouldShowPeerErrorsFor:(id)arg1 pushToken:(id)arg2 fromURI:(id)arg3 service:(id)arg4;
- (id)sessionTokenForURI:(id)arg1 pushToken:(id)arg2 fromURI:(id)arg3 service:(id)arg4 expireEarly:(_Bool)arg5;
- (id)peerTokensForURI:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (id)_peerTokensForURI:(id)arg1 fromURI:(id)arg2 service:(id)arg3;
- (_Bool)_setIdentityInfo:(id)arg1 sessionTokens:(id)arg2 forURI:(id)arg3 fromURI:(id)arg4 service:(id)arg5;
- (void)_purgeMapFromURI:(id)arg1 service:(id)arg2;
- (_Bool)_sessionExpiredForURI:(id)arg1 inPeerMap:(id)arg2 service:(id)arg3;
- (_Bool)_sessionExpiredForURI:(id)arg1 inPeerMap:(id)arg2 service:(id)arg3 expireEarly:(_Bool)arg4;
- (id)_existingPeerMapFromURI:(id)arg1 service:(id)arg2;
- (id)_peerMapFromURI:(id)arg1 service:(id)arg2;
- (void)_setDisasterModeToken:(id)arg1 forURI:(id)arg2;
- (id)_disasterModeTokenForURI:(id)arg1;
- (void)_removeCompletionBlocksForURIs:(id)arg1 fromURI:(id)arg2 fromService:(id)arg3;
- (id)_completionBlocksForURIs:(id)arg1 fromURI:(id)arg2 fromService:(id)arg3;
- (_Bool)_addCompletionBlock:(id)arg1 forURIs:(void)arg2 fromURI:(id)arg3 fromService:(id)arg4;
- (void)_bagLoaded:(id)arg1;
- (void)dealloc;
- (id)init;

@end

