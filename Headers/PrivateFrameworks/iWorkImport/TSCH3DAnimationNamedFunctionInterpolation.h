/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCH3DAnimationInterpolation.h>

@class NSString;

// Not exported
@interface TSCH3DAnimationNamedFunctionInterpolation : TSCH3DAnimationInterpolation
{
    NSString *mName;
    void *mFunction;
    NSString *mShaderFunction;
}

+ (id)functionWithName:(id)arg1 function:(void *)arg2 shaderFunction:(id)arg3;
@property(readonly, nonatomic) NSString *shaderFunction; // @synthesize shaderFunction=mShaderFunction;
- (id)name;
- (float)interpolate:(float)arg1 index:(const tvec2_3b141483 *)arg2;
- (box_e9f23397)rangeForIndex:(const tvec2_3b141483 *)arg1;
- (id)description;
- (void)dealloc;
- (id)initWithName:(id)arg1 function:(void *)arg2 shaderFunction:(id)arg3;

@end

