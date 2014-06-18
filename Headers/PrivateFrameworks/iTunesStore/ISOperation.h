/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSOperation.h"

@class NSArray, NSError, NSLock, NSMutableArray, NSRunLoop, NSString, SSOperationProgress;

@interface ISOperation : NSOperation
{
    id <ISOperationDelegate> _delegate;
    NSError *_error;
    NSLock *_lock;
    NSRunLoop *_operationRunLoop;
    ISOperation *_parentOperation;
    SSOperationProgress *_progress;
    _Bool _shouldMessageMainThread;
    NSString *_powerAssertionIdentifier;
    NSArray *_serializationLockIdentifiers;
    NSMutableArray *_subOperations;
    _Bool _shouldRunWithBackgroundPriority;
    _Bool _stopped;
    _Bool _success;
    id _threadSafeDelegate;
}

@property _Bool success; // @synthesize success=_success;
@property _Bool shouldRunWithBackgroundPriority; // @synthesize shouldRunWithBackgroundPriority=_shouldRunWithBackgroundPriority;
@property(retain) NSString *powerAssertionIdentifier; // @synthesize powerAssertionIdentifier=_powerAssertionIdentifier;
@property(retain) ISOperation *parentOperation; // @synthesize parentOperation=_parentOperation;
@property(retain) NSRunLoop *operationRunLoop; // @synthesize operationRunLoop=_operationRunLoop;
@property(retain) NSError *error; // @synthesize error=_error;
- (void)_sendWillStartToDelegate;
- (void)_sendSuccessToDelegate;
- (void)_sendErrorToDelegate:(id)arg1;
- (void)_removeSubOperation:(id)arg1;
- (void)_main:(_Bool)arg1;
- (void)_keepAliveTimer:(id)arg1;
- (void)_failAfterException;
- (void)_addSubOperation:(id)arg1;
- (void)unlock;
@property(copy) NSArray *serializationLockIdentifiers;
- (void)sendProgressToDelegate;
- (void)sendDidTakeSerializationLocks;
- (void)run:(_Bool)arg1;
- (void)releasePowerAssertionsDuringBlock:(id)arg1;
- (void)lock;
- (void)dispatchCompletionBlock;
- (id)copySerializationLocks;
- (id)copyActivePowerAssertionIdentifiers;
- (void)main;
- (void)cancel;
@property(readonly) NSString *uniqueKey;
@property(readonly) id threadSafeDelegate;
@property _Bool shouldMessageMainThread;
- (_Bool)shouldFailAfterUniquePredecessorError:(id)arg1;
@property id <ISOperationDelegate> delegate;
- (_Bool)stopRunLoop;
- (_Bool)runSubOperation:(id)arg1 onQueue:(id)arg2 error:(id *)arg3;
- (_Bool)runSubOperation:(id)arg1 returningError:(id *)arg2;
- (int)runRunLoopUntilStopped;
- (void)run;
@property(readonly) long long progressWeight;
@property(readonly, nonatomic) SSOperationProgress *progress;
- (void)dealloc;
- (id)init;

@end

