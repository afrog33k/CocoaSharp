/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@interface NSOperation : NSObject
{
    id _private;
    int _private1;
    int _private1b;
}

+ (_Bool)automaticallyNotifiesObserversForKey:(id)arg1;
- (id)__;
- (void)start;
- (void)main;
- (id)dependencies;
- (void)removeDependency:(id)arg1;
- (void)addDependency:(id)arg1;
- (void)waitUntilFinishedOrTimeout:(double)arg1;
- (void)waitUntilFinished;
- (void)setCompletionBlock:(id)arg1;
- (id)completionBlock;
- (void)setThreadPriority:(double)arg1;
- (double)threadPriority;
- (void)setQueuePriority:(long long)arg1;
- (long long)queuePriority;
- (_Bool)isReady;
- (_Bool)isAsynchronous;
- (_Bool)isConcurrent;
- (_Bool)isFinished;
- (_Bool)isExecuting;
- (void)cancel;
- (_Bool)isCancelled;
- (void)finalize;
- (void)dealloc;
- (id)init;
- (void)setObservationInfo:(void *)arg1;
- (void *)observationInfo;
- (id)_implicitObservationInfo;

@end

