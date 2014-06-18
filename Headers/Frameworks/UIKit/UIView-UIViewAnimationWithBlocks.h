/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIView.h>

@interface UIView (UIViewAnimationWithBlocks)
+ (void)performSystemAnimation:(unsigned long long)arg1 onViews:(id)arg2 options:(unsigned long long)arg3 animations:(id)arg4 completion:(void)arg5;
+ (void)transitionFromView:(id)arg1 toView:(id)arg2 duration:(double)arg3 options:(unsigned long long)arg4 completion:(id)arg5;
+ (void)transitionWithView:(id)arg1 duration:(double)arg2 options:(unsigned long long)arg3 animations:(id)arg4 completion:(void)arg5;
+ (void)animateWithDuration:(double)arg1 animations:(id)arg2;
+ (void)animateWithDuration:(double)arg1 animations:(id)arg2 completion:(void)arg3;
+ (void)animateWithDuration:(double)arg1 delay:(double)arg2 options:(unsigned long long)arg3 animations:(id)arg4 completion:(void)arg5;
+ (void)_animateWithDuration:(double)arg1 delay:(double)arg2 options:(unsigned long long)arg3 animations:(id)arg4 start:(void)arg5 completion:(id)arg6;
+ (void)animateWithDuration:(double)arg1 delay:(double)arg2 usingSpringWithDamping:(double)arg3 initialSpringVelocity:(double)arg4 options:(unsigned long long)arg5 animations:(id)arg6 completion:(void)arg7;
+ (void)_animateWithDuration:(double)arg1 delay:(double)arg2 options:(unsigned long long)arg3 factory:(id)arg4 animations:(id)arg5 completion:(void)arg6;
+ (void)_setupAnimationWithDuration:(double)arg1 delay:(double)arg2 view:(id)arg3 options:(unsigned long long)arg4 animations:(id)arg5 start:(void)arg6 completion:(id)arg7;
+ (void)_setupAnimationWithDuration:(double)arg1 delay:(double)arg2 view:(id)arg3 options:(unsigned long long)arg4 factory:(id)arg5 animations:(id)arg6 start:(void)arg7 animationStateGenerator:(id)arg8 completion:(void)arg9;
@end

