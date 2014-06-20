/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "SBAlertItem.h"

@class NSString, NSURL, SBApplication;

@interface SBVideoPermissionAlertItem : SBAlertItem
{
    NSURL *_url;
    SBApplication *_appHandlingURL;
    NSString *_sender;
}

- (_Bool)allowMenuButtonDismissal;
- (_Bool)dismissOnLock;
- (_Bool)shouldShowInLockScreen;
- (void)configure:(_Bool)arg1 requirePasscodeForActions:(_Bool)arg2;
- (void)alertView:(id)arg1 clickedButtonAtIndex:(long long)arg2;
- (void)dealloc;
- (id)initWithURL:(id)arg1 applicationHandlingURL:(id)arg2 sender:(id)arg3;

@end
