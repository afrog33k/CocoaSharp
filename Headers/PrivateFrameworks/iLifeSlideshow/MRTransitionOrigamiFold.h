/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iLifeSlideshow/MRTransition.h>

@class MROrigamiAnimationPath;

@interface MRTransitionOrigamiFold : MRTransition
{
    MROrigamiAnimationPath *mBigSwing;
    MROrigamiAnimationPath *mSideSwing;
}

- (void)renderAtTime:(double)arg1 inContext:(id)arg2 withArguments:(id)arg3;
- (void)_cleanupSwingTimings;
- (void)_setupSwingTimings;
- (void)cleanup;
- (id)initWithTransitionID:(id)arg1;

@end

