/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UINavigationController.h"

#import "PSController-Protocol.h"
#import "UINavigationControllerDelegate-Protocol.h"

@class NSMutableSet, PSSpecifier;

@interface PSRootController : UINavigationController <PSController, UINavigationControllerDelegate>
{
    PSSpecifier *_specifier;
    NSMutableSet *_tasks;
    _Bool _deallocating;
    unsigned char _hasTelephony;
}

+ (_Bool)processedBundle:(id)arg1 parentController:(id)arg2 parentSpecifier:(id)arg3 bundleControllers:(id *)arg4 settings:(id)arg5;
+ (id)readPreferenceValue:(id)arg1;
+ (void)setPreferenceValue:(id)arg1 specifier:(id)arg2;
+ (void)writePreference:(id)arg1;
+ (id)domainForSpecifier:(id)arg1;
- (void)navigationController:(id)arg1 willShowViewController:(id)arg2 animated:(_Bool)arg3;
- (void)setViewControllers:(id)arg1 animated:(_Bool)arg2;
- (id)popToRootViewControllerAnimated:(_Bool)arg1;
- (id)popToViewController:(id)arg1 animated:(_Bool)arg2;
- (id)popViewControllerAnimated:(_Bool)arg1;
- (void)_delayedControllerReleaseAfterPop:(id)arg1;
- (_Bool)canBeShownFromSuspendedState;
- (void)didDismissFormSheetView;
- (void)willDismissFormSheetView;
- (void)didDismissPopupView;
- (void)willDismissPopupView;
- (id)aggregateDictionaryPath;
- (id)rootController;
- (void)setRootController:(id)arg1;
- (id)parentController;
- (void)dealloc;
- (_Bool)deallocating;
- (void)didWake;
- (void)didUnlock;
- (void)willUnlock;
- (void)didLock;
- (void)suspend;
- (unsigned long long)supportedInterfaceOrientations;
- (void)sendWillBecomeActive;
- (void)sendWillResignActive;
- (void)willBecomeActive;
- (void)willResignActive;
- (void)statusBarWillChangeHeight:(id)arg1;
- (void)showLeftButton:(id)arg1 withStyle:(long long)arg2 rightButton:(id)arg3 withStyle:(long long)arg4;
- (void)handleURL:(id)arg1;
- (void)pushController:(id)arg1;
- (id)specifier;
- (void)setSpecifier:(id)arg1;
- (void)setParentController:(id)arg1;
- (void)statusBarWillAnimateByHeight:(double)arg1;
- (id)specifiers;
- (id)contentViewForTopController;
- (_Bool)busy;
- (void)taskFinished:(id)arg1;
- (void)addTask:(id)arg1;
- (_Bool)taskIsRunning:(id)arg1;
- (id)tasksDescription;
- (id)initWithTitle:(id)arg1 identifier:(id)arg2;
- (id)readPreferenceValue:(id)arg1;
- (void)setPreferenceValue:(id)arg1 specifier:(id)arg2;

@end
