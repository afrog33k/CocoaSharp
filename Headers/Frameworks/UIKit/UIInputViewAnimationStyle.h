/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableArray;

// Not exported
@interface UIInputViewAnimationStyle : NSObject
{
    _Bool animated;
    double duration;
    int outDirection;
    unsigned long long extraOptions;
    _Bool persistUntilComplete;
    _Bool ignoreNewAnimations;
    NSMutableArray *extraViews;
    _Bool placeholderKeyboard;
    _Bool force;
}

+ (id)animationStyleAnimated:(_Bool)arg1 duration:(double)arg2 outDirection:(int)arg3;
+ (id)animationStyleDefault;
+ (id)animationStyleImmediate;
@property(nonatomic) _Bool placeholderKeyboard; // @synthesize placeholderKeyboard;
@property(retain, nonatomic) NSMutableArray *extraViews; // @synthesize extraViews;
@property(nonatomic) _Bool ignoreNewAnimations; // @synthesize ignoreNewAnimations;
@property(nonatomic) _Bool persistUntilComplete; // @synthesize persistUntilComplete;
@property(nonatomic) unsigned long long extraOptions; // @synthesize extraOptions;
@property(nonatomic) _Bool force; // @synthesize force;
@property(nonatomic) int outDirection; // @synthesize outDirection;
@property(nonatomic) double duration; // @synthesize duration;
@property(nonatomic) _Bool animated; // @synthesize animated;
- (void)launchAnimation:(id)arg1 afterStarted:(void)arg2 completion:(id)arg3 forHost:(void)arg4 fromCurrentPosition:(id)arg5;
@property(readonly, nonatomic) _Bool useCustomTransition;
@property(readonly, nonatomic) _Bool isAnimationCompleted;
- (id)description;
- (_Bool)isEqual:(id)arg1;
- (void)dealloc;

@end
