/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSData, NSObject<OS_dispatch_queue>, NSObject<OS_dispatch_semaphore>, NSString, _TRUserNotfication;

@interface TRDeviceSetupPeripheral : NSObject
{
    _TRUserNotfication *_activeUserNotification;
    NSString *_authenticationAppleID;
    unsigned long long _authenticationAttemptCount;
    NSData *_dataToSend;
    NSObject<OS_dispatch_semaphore> *_dataToSendSemaphore;
    NSString *_deviceGUID;
    _Bool _performingSetup;
    _Bool _preparingForSetup;
    NSObject<OS_dispatch_queue> *_queue;
    NSString *_userAgent;
    id <TRDeviceSetupPeripheralDelegate> _delegate;
}

@property(nonatomic) __weak id <TRDeviceSetupPeripheralDelegate> delegate; // @synthesize delegate=_delegate;
- (void).cxx_destruct;
- (void)_startAuthentication;
- (_Bool)_showUserNotificationForRememberPasswordForAppleID:(id)arg1;
- (void)_showUserNotificationForErrorWithTitle:(id)arg1 message:(id)arg2;
- (_Bool)_showUserNotificationForDiagnosticSubmission;
- (void)_showUserNotificationForAuthenticationFailure:(id)arg1;
- (_Bool)_showUserNotificationForAppleID:(id)arg1 returningAppleID:(id *)arg2 password:(id *)arg3;
- (void)_setupDidFailWithError:(id)arg1;
- (void)_setupDidComplete;
- (void)_sendSetupDataWithAuthInfo:(id)arg1 diagnosticSubmissionEnabled:(_Bool)arg2 rememberPasswordEnabled:(_Bool)arg3;
- (_Bool)_canPerformSetupReturningHasWiFiNetwork:(_Bool *)arg1;
- (void)_authenticateWithParameters:(id)arg1;
- (id)_didTap;
- (id)_didReceiveData:(id)arg1;
- (void)_didDisconnect;
- (void)cancelSetupForTimeout;
- (void)cancelSetupForStateChange;
- (_Bool)performSetup;
- (id)init;

@end

