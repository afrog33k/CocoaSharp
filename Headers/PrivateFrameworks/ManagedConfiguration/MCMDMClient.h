/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class CPDistributedMessagingCenter;

@interface MCMDMClient : NSObject
{
    CPDistributedMessagingCenter *_messageCenter;
}

+ (id)sharedClient;
- (void).cxx_destruct;
- (_Bool)isActivationLockAllowed;
- (_Bool)isManagedByMDM;
- (void)removeManagedAppsAccordingToFlags;
- (void)simulatePush;
- (void)retryNotNowResponse;
- (void)scheduleTokenUpdate;
- (void)notifyNewConfiguration;
- (_Bool)checkOutCheckInURL:(id)arg1 identity:(struct __SecIdentity *)arg2 topic:(id)arg3 signMessage:(_Bool)arg4 outError:(id *)arg5;
- (_Bool)authenticateWithCheckInURL:(id)arg1 identity:(struct __SecIdentity *)arg2 topic:(id)arg3 useDevelopmentAPNS:(_Bool)arg4 signMessage:(_Bool)arg5 outError:(id *)arg6;
- (id)init;

@end

