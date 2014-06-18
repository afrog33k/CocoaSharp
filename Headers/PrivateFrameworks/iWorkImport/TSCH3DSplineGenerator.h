/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

// Not exported
@interface TSCH3DSplineGenerator : NSObject
{
    float mDetail;
    float mTension;
    float mAdaptiveThreshold;
    vector_35283da1 mControlPts;
    vector_b5bccc4d mSplineExclude;
}

+ (id)generator;
@property(nonatomic) float adaptiveThreshold; // @synthesize adaptiveThreshold=mAdaptiveThreshold;
@property(nonatomic) float tension; // @synthesize tension=mTension;
@property(nonatomic) float detail; // @synthesize detail=mDetail;
- (id).cxx_construct;
- (void).cxx_destruct;
- (void)generatePoints:(vector_35283da1 *)arg1;
- (void)calcControlMatrix:(tmat4x4_3074befe *)arg1 pointNum:(long long)arg2;
- (vector_b5bccc4d *)splineExclude;
- (vector_35283da1 *)controlPts;
- (_Bool)isClosed;
- (id)init;

@end

