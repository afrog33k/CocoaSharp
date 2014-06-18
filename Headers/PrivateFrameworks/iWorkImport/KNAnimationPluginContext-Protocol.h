/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@class KNAnimatedBuild, NSArray, NSDictionary;

@protocol KNAnimationPluginContext <NSObject>
@property(readonly, nonatomic) _Bool isFrameRenderer;
@property(readonly, nonatomic) _Bool isMagicMove;
@property(readonly, nonatomic) _Bool isTransition;
@property(readonly, nonatomic) _Bool isBuild;
@property(readonly, nonatomic) NSArray *magicMoveMatches;
@property(readonly, nonatomic) NSDictionary *transitionAttributes;
@property(readonly, nonatomic) KNAnimatedBuild *animatedBuild;
@property(readonly, nonatomic) double percent;
@property(readonly, nonatomic) double duration;
@property(readonly, nonatomic) unsigned long long direction;
@property(readonly, nonatomic) NSArray *textures;
@end

