/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "IDSDaemonListenerProtocol-Protocol.h"

@class NSMapTable, NSMutableDictionary, NSObject<OS_dispatch_queue>, NSObject<OS_xpc_object>, NSString;

@interface _IDSIDQueryController : NSObject <IDSDaemonListenerProtocol>
{
    NSMutableDictionary *_listeners;
    NSMutableDictionary *_idStatusCache;
    NSMutableDictionary *_transactionIDToBlockMap;
    NSString *_rerouteService;
    NSObject<OS_xpc_object> *_connection;
    NSObject<OS_dispatch_queue> *_connectionQueue;
    NSObject<OS_dispatch_queue> *_queue;
    NSString *_serviceToken;
    NSMapTable *_delegateToInfo;
    NSMutableDictionary *_listenerIDToServicesMap;
    id _delegateContext;
}

- (void)removeDelegate:(id)arg1 forService:(id)arg2 listenerID:(id)arg3;
- (void)addDelegate:(id)arg1 forService:(id)arg2 listenerID:(id)arg3 queue:(id)arg4;
- (_Bool)_flushQueryCacheForService:(id)arg1;
- (_Bool)_warmupQueryCacheForService:(id)arg1;
- (long long)_currentCachedIDStatusForDestination:(id)arg1 service:(id)arg2 listenerID:(id)arg3;
- (_Bool)_hasCacheForService:(id)arg1;
- (_Bool)currentIDStatusForDestination:(id)arg1 service:(id)arg2 listenerID:(id)arg3 queue:(id)arg4 completionBlock:(id)arg5;
- (_Bool)currentIDStatusForDestinations:(id)arg1 service:(id)arg2 listenerID:(id)arg3 queue:(id)arg4 completionBlock:(id)arg5;
- (_Bool)refreshIDStatusForDestination:(id)arg1 service:(id)arg2 listenerID:(id)arg3 queue:(id)arg4 completionBlock:(id)arg5;
- (_Bool)refreshIDStatusForDestinations:(id)arg1 service:(id)arg2 listenerID:(id)arg3 queue:(id)arg4 completionBlock:(id)arg5;
- (_Bool)_refreshIDStatusForDestinations:(id)arg1 service:(id)arg2 listenerID:(id)arg3 allowRefresh:(_Bool)arg4 queue:(id)arg5 completionBlock:(id)arg6;
- (void)_idStatusForDestinations:(id)arg1 service:(id)arg2 listenerID:(id)arg3 allowRenew:(_Bool)arg4 completionBlock:(id)arg5;
- (id)_delegateMapForListenerID:(id)arg1 service:(id)arg2;
- (void)_callDelegatesWithBlock:(id)arg1 delegateMap:(void)arg2;
- (id)_reroutedPrototypeService:(id)arg1;
- (void)_purgeIDStatusCache;
- (void)_purgeIDStatusCacheAfter:(double)arg1;
- (void)_updateCacheWithDictionary:(id)arg1 service:(id)arg2;
- (id)_cachedStatusForDestination:(id)arg1 service:(id)arg2;
- (id)_cacheForService:(id)arg1;
- (id)_squishFromURIFromIDStatusCache:(id)arg1 service:(id)arg2;
- (_Bool)_isListenerWithID:(id)arg1 listeningToService:(id)arg2;
- (void)dealloc;
- (id)initWithDelegateContext:(id)arg1 queue:(id)arg2;
- (id)init;

@end

