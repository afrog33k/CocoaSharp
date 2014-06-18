/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIViewController.h"

@interface UIViewController (PhotosUI)
- (void)_pu_setTabBarVisible:(_Bool)arg1 withAnimation:(long long)arg2 duration:(double)arg3;
- (void)_pu_setToolbarVisible:(_Bool)arg1 withAnimation:(long long)arg2 duration:(double)arg3;
- (void)_pu_setNavigationBarVisible:(_Bool)arg1 withAnimation:(long long)arg2 duration:(double)arg3;
- (void)_pu_setStatusBarVisible:(_Bool)arg1 withAnimation:(long long)arg2 duration:(double)arg3;
- (void)pu_performBarsVisibilityUpdatesWithAnimation:(long long)arg1 duration:(double)arg2;
- (void)pu_performBarsVisibilityUpdatesWithAnimation:(long long)arg1;
- (void)pu_setupInitialBarsVisibilityOnViewWillAppearAnimated:(_Bool)arg1;
@property(readonly, nonatomic) _Bool pu_wantsTabBarVisible;
@property(readonly, nonatomic) _Bool pu_wantsToolbarVisible;
@property(readonly, nonatomic) _Bool pu_wantsNavigationBarVisible;
@property(readonly, nonatomic) _Bool pu_wantsStatusBarVisible;
- (_Bool)pu_isViewVisible;
@end

