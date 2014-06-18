/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "_UIViewServiceDeputy_UIViewServiceInterface-Protocol.h"
#import "_UIViewServiceUIBehaviorInterface-Protocol.h"

@protocol _UIViewServiceViewControllerOperator_RemoteViewControllerInterface <_UIViewServiceDeputy_UIViewServiceInterface, _UIViewServiceUIBehaviorInterface>
- (void)__restoreStateForSession:(id)arg1 restorationAnchor:(id)arg2;
- (void)__saveStateForSession:(id)arg1 restorationAnchor:(id)arg2 completionHandler:(id)arg3;
- (void)__dimmingViewWasTapped;
- (void)__textServiceDidDismiss;
- (void)__setHostTintColor:(id)arg1 tintAdjustmentMode:(long long)arg2;
- (void)__hostDidUpdateAppearanceWithSerializedRepresentations:(id)arg1 originalSource:(id)arg2 legacyAppearance:(_Bool)arg3;
- (void)__scrollToTopFromTouchAtViewLocation:(id)arg1 resultHandler:(id)arg2;
- (void)__hostedActionSheetDidDismissWithClickedButtonIndex:(long long)arg1;
- (void)__hostedActionSheetClickedButtonAtIndex:(long long)arg1;
- (void)__hostedActionSheetDidPresent;
- (void)__hostDidPromoteFirstResponder;
- (void)__hostDidRotateFromInterfaceOrientation:(long long)arg1 skipSelf:(_Bool)arg2;
- (void)__hostWillAnimateRotationToInterfaceOrientation:(long long)arg1 duration:(double)arg2 skipSelf:(_Bool)arg3;
- (void)__hostWillRotateToInterfaceOrientation:(long long)arg1 duration:(double)arg2 skipSelf:(_Bool)arg3;
- (void)__hostDidChangeStatusBarHeight:(double)arg1;
- (void)__hostDidChangeStatusBarOrientationToInterfaceOrientation:(long long)arg1;
- (void)__hostDidEnterBackground;
- (void)__hostWillEnterForeground;
- (void)__setContentSize:(id)arg1;
- (void)__setServiceInPopover:(_Bool)arg1;
- (void)__hostViewDidMoveToScreenWithIntegerDisplayID:(unsigned int)arg1 newHostingHandleReplyHandler:(id)arg2;
- (void)__hostViewDidDisappear:(_Bool)arg1;
- (void)__hostViewWillDisappear:(_Bool)arg1;
- (void)__hostViewDidAppear:(_Bool)arg1;
- (void)__hostViewWillAppear:(_Bool)arg1 inInterfaceOrientation:(long long)arg2 statusBarHeight:(double)arg3 completionHandler:(id)arg4;
- (void)__hostReadyToReceiveMessagesFromServiceViewController;
- (void)__createViewController:(id)arg1 withAppearanceSerializedRepresentations:(id)arg2 legacyAppearance:(_Bool)arg3 hostAccessibilityServerPort:(id)arg4 canShowTextServices:(_Bool)arg5 replyHandler:(id)arg6;
@end

