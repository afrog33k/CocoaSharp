/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol BKSWorkspaceDelegate <NSObject>
- (void)workspace:(id)arg1 applicationDebugStateChanged:(id)arg2 newState:(_Bool)arg3;
- (void)workspace:(id)arg1 handleStatusBarReturnActionFromApplication:(id)arg2 statusBarStyle:(id)arg3;
- (void)workspace:(id)arg1 applicationSuspensionSettingsUpdated:(id)arg2 withSettings:(id)arg3;
- (void)workspace:(id)arg1 applicationExited:(id)arg2 withInfo:(id)arg3;
- (void)workspace:(id)arg1 applicationSuspended:(id)arg2 withSettings:(id)arg3;
- (void)workspace:(id)arg1 applicationActivated:(id)arg2;
- (void)workspace:(id)arg1 applicationDidFailToLaunch:(id)arg2;
- (void)workspace:(id)arg1 applicationDidFinishLaunching:(id)arg2 withInfo:(id)arg3;
- (void)workspace:(id)arg1 applicationDidStartLaunching:(id)arg2;
- (void)workspaceDidResume:(id)arg1;
- (void)workspaceWillResume:(id)arg1;
- (void)workspaceDidSuspend:(id)arg1;
- (void)workspaceWillSuspend:(id)arg1;
- (void)workspace:(id)arg1 applicationDidBecomeReceiver:(id)arg2 fromApplication:(id)arg3;
- (id)workspace:(id)arg1 applicationWillBecomeReceiver:(id)arg2 fromApplication:(id)arg3;

@optional
- (void)workspace:(id)arg1 applicationDidFailToActivate:(id)arg2;
- (void)workspace:(id)arg1 applicationDidRemainReceiver:(id)arg2 fromApplication:(id)arg3;
- (void)workspace:(id)arg1 applicationFinishedBackgroundContentFetching:(id)arg2 withInfo:(id)arg3;
- (void)workspace:(id)arg1 handleOpenURLRequest:(id)arg2 application:(id)arg3 withOptions:(id)arg4 origin:(id)arg5 withResult:(id)arg6;
- (void)workspace:(id)arg1 handleOpenApplicationRequest:(id)arg2 withOptions:(id)arg3 origin:(id)arg4 withResult:(id)arg5;
- (int)workspace:(id)arg1 canOpenApplication:(id)arg2;
@end

