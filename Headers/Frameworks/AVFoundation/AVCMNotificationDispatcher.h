/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class AVCallbackRegistry, NSMutableDictionary, NSObject<OS_dispatch_queue>;

@interface AVCMNotificationDispatcher : NSObject
{
    struct opaqueCMNotificationCenter *_cmNotificationCenter;
    AVCallbackRegistry *_callbackRegistry;
    NSMutableDictionary *_listenerObjectsPassedToFig;
    NSObject<OS_dispatch_queue> *_listenerObjectsQueue;
}

+ (id)notificationDispatcherForCMNotificationCenter:(struct opaqueCMNotificationCenter *)arg1;
+ (void)initialize;
- (id)_copyAndRemoveListenerAndCallbackForWeakReferenceToListener:(id)arg1 callback:(void *)arg2 name:(struct __CFString *)arg3 object:(const void *)arg4;
- (void)_addListenerAndCallback:(id)arg1 forWeakReferenceToListener:(id)arg2 callback:(void *)arg3 name:(struct __CFString *)arg4 object:(const void *)arg5;
- (void)removeListenerWithWeakReference:(id)arg1 callback:(void *)arg2 name:(struct __CFString *)arg3 object:(const void *)arg4;
- (void)addListenerWithWeakReference:(id)arg1 callback:(void *)arg2 name:(struct __CFString *)arg3 object:(const void *)arg4 flags:(unsigned int)arg5;
@property(readonly, nonatomic) struct opaqueCMNotificationCenter *CMNotificationCenter;
@property(readonly, nonatomic, getter=_callbackRegistry) AVCallbackRegistry *callbackRegistry;
- (void)finalize;
- (void)dealloc;
- (id)initWithCMNotificationCenter:(struct opaqueCMNotificationCenter *)arg1;

@end

