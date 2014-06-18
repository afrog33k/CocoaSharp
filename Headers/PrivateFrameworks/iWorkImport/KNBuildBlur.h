/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/KNAnimationEffect.h>

#import "KNAnimationPluginArchiving-Protocol.h"
#import "KNFrameBuildAnimator-Protocol.h"

@class KNAnimParameterGroup, NSMapTable, TSDGLShader;

// Not exported
@interface KNBuildBlur : KNAnimationEffect <KNFrameBuildAnimator, KNAnimationPluginArchiving>
{
    KNAnimParameterGroup *_parameterGroup;
    TSDGLShader *_shader;
    NSMapTable *_blurTextures;
    NSMapTable *_dataBuffers;
    struct CATransform3D _projectionMatrix;
    struct CGRect _drawableFrame;
    struct CGRect _animationRect;
}

+ (void)downgradeAttributes:(id *)arg1 animationName:(id *)arg2 warning:(id *)arg3 type:(int)arg4 isToClassic:(_Bool)arg5 version:(unsigned long long)arg6;
+ (void)upgradeAttributes:(id *)arg1 animationName:(id)arg2 warning:(id *)arg3 type:(int)arg4 isFromClassic:(_Bool)arg5 version:(unsigned long long)arg6;
+ (id)thumbnailImageNameForType:(int)arg1;
+ (_Bool)requiresSingleTexturePerStage;
+ (id)defaultAttributes;
+ (void)fillLocalizedDirectionMenu:(id)arg1 forType:(int)arg2;
+ (unsigned long long)directionType;
+ (id)localizedMenuString:(int)arg1;
+ (id)supportedTypes;
+ (id)animationFilter;
+ (int)animationCategory;
+ (id)animationName;
- (void)animationDidEndWithContext:(id)arg1;
- (void)renderFrameWithContext:(id)arg1;
- (void)animationWillBeginWithContext:(id)arg1;
- (void)p_setupShaders;
- (void)p_setupMVPMatrices;
- (void)p_setupBlurTexturesWithContext:(id)arg1;
- (struct CGRect)frameOfEffectWithFrame:(struct CGRect)arg1 context:(id)arg2;
- (void)dealloc;
- (void)teardown;
- (id)initWithAnimationContext:(id)arg1;

@end

