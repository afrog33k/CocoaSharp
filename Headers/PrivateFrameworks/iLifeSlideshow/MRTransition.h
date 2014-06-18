/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "MRLoadable-Protocol.h"
#import "MRRenderable-Protocol.h"

@class MRImage, MRLayer, NSDictionary, NSString;

@interface MRTransition : NSObject <MRLoadable, MRRenderable>
{
    NSDictionary *mDescription;
    id mTransitioner;
    MRLayer *mSourceLayer;
    MRLayer *mTargetLayer;
    MRImage *mSourceLayerImage;
    MRImage *mTargetLayerImage;
    MRImage *mOutputImage;
    NSString *mTransitionID;
    NSString *mPresetID;
    NSDictionary *mAttributes;
    NSDictionary *mFlattenedAttributes;
    _Bool mNeedsToUpdateAttributes;
    struct CGSize mPixelSize;
}

+ (id)retainedTransitionWithTransitionID:(id)arg1 forTransitioner:(id)arg2;
@property(nonatomic) struct CGSize pixelSize; // @synthesize pixelSize=mPixelSize;
@property(retain, nonatomic) NSDictionary *attributes; // @synthesize attributes=mAttributes;
@property(copy) NSString *presetID; // @synthesize presetID=mPresetID;
@property(readonly) NSString *transitionID; // @synthesize transitionID=mTransitionID;
@property(retain, nonatomic) MRImage *targetLayerImage; // @synthesize targetLayerImage=mTargetLayerImage;
@property(retain, nonatomic) MRImage *sourceLayerImage; // @synthesize sourceLayerImage=mSourceLayerImage;
@property(retain) MRLayer *targetLayer; // @synthesize targetLayer=mTargetLayer;
@property(retain) MRLayer *sourceLayer; // @synthesize sourceLayer=mSourceLayer;
- (id)patchworkAtTime:(double)arg1 inContext:(id)arg2 withArguments:(id)arg3;
- (id)retainedByUserRenderedImageAtTime:(double)arg1 inContext:(id)arg2 withArguments:(id)arg3;
- (void)renderAtTime:(double)arg1 inContext:(id)arg2 withArguments:(id)arg3;
- (_Bool)prerenderForTime:(double)arg1 inContext:(id)arg2 withArguments:(id)arg3;
@property(readonly, nonatomic) _Bool isInfinite;
@property(readonly, nonatomic) _Bool isAlphaFriendly;
@property(readonly, nonatomic) _Bool isOpaque;
@property(readonly, nonatomic) _Bool isNative3D;
- (void)cancelLoading;
- (void)unload;
- (void)loadForTime:(double)arg1 inContext:(id)arg2 withArguments:(id)arg3 now:(_Bool)arg4;
- (_Bool)isLoadedForTime:(double)arg1;
@property(readonly, nonatomic) _Bool needsTargetLayerImageForPrecomputing;
@property(readonly, nonatomic) _Bool needsSourceLayerImageForPrecomputing;
@property(readonly, nonatomic) _Bool noContentsMotion;
- (_Bool)isRetainedByTransitioner;
- (void)releaseByTransitioner:(id)arg1;
- (void)retainByTransitioner:(id)arg1;
- (void)cleanup;
- (void)finalize;
- (void)dealloc;
- (id)initWithTransitionID:(id)arg1;

@end

