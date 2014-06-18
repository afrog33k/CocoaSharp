/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSDMediaLayout.h>

#import "TSDShapeControlLayout-Protocol.h"

@class TSDBezierPath, TSDImageAdjustments, TSDInfoGeometry, TSDLayoutGeometry, TSDMaskLayout, TSDPathSource<TSDSmartPathSource>;

// Not exported
@interface TSDImageLayout : TSDMediaLayout <TSDShapeControlLayout>
{
    TSDLayoutGeometry *mImageGeometry;
    TSDMaskLayout *mMaskLayout;
    struct CGPath *mPathToStroke;
    struct CGAffineTransform mLayoutToImageTransform;
    struct CGAffineTransform mLayoutToMaskTransform;
    _Bool mMaskIntersectsImage;
    TSDBezierPath *mTracedPath;
    int mHasAlpha;
    TSDLayoutGeometry *mBaseImageLayoutGeometry;
    TSDInfoGeometry *mDynamicInfoGeometry;
    TSDInfoGeometry *mBaseInfoGeometry;
    int mMaskEditMode;
    _Bool mScalingInMaskMode;
    _Bool mInInstantAlphaMode;
    _Bool mIsUpdatingImageAdjustments;
    TSDImageAdjustments *mDynamicImageAdjustments;
}

@property(readonly, nonatomic, getter=isInInstantAlphaMode) _Bool inInstantAlphaMode; // @synthesize inInstantAlphaMode=mInInstantAlphaMode;
@property(readonly, nonatomic, getter=isInMaskScaleMode) _Bool inMaskScaleMode; // @synthesize inMaskScaleMode=mScalingInMaskMode;
@property(readonly, nonatomic) int maskEditMode; // @synthesize maskEditMode=mMaskEditMode;
- (void)p_destroyDynamicCopies;
- (void)p_setDynamicInfoGeometry:(id)arg1;
- (void)p_createDynamicCopies;
- (_Bool)supportsRotation;
- (id)i_computeWrapPath;
- (struct CGRect)boundsInfluencingExteriorWrap;
- (void)dynamicImageAdjustmentsChangeDidEnd;
- (void)dynamicImageAdjustmentsUpdateToValue:(id)arg1;
- (void)dynamicImageAdjustmentsChangeDidBegin;
- (_Bool)isDynamicallyChangingImageAdjustments;
- (id)imageAdjustments;
- (id)maskLayout;
- (struct CGAffineTransform)imageDataToVisualSizeTransform;
- (struct CGAffineTransform)layoutToMaskTransform;
- (struct CGAffineTransform)layoutToImageTransform;
- (struct CGSize)sizeOfFrameRectIncludingCoverage;
- (struct CGPath *)pathToStroke;
- (_Bool)hasMaskingPath;
- (id)inspectorGeometry;
- (id)imageGeometryInRoot;
- (id)originalImageGeometry;
- (id)imageGeometry;
- (id)imageInfo;
- (void)endInstantAlphaMode;
- (void)beginInstantAlphaMode;
- (void)maskModeScaleDidEnd;
- (void)maskModeScaleDidBegin;
@property(readonly, nonatomic) int maskEditModeForLayoutState;
@property(readonly, nonatomic) int maskEditModeForResizing;
@property(readonly, nonatomic) int maskEditModeForRotating;
@property(readonly, nonatomic) int maskEditModeForDragging;
@property(readonly, nonatomic) _Bool isResizingInMaskEditMode;
@property(readonly, nonatomic) _Bool isRotatingInMaskEditMode;
@property(readonly, nonatomic) _Bool isDraggingInMaskEditMode;
@property(readonly, nonatomic, getter=isInMaskEditMode) _Bool inMaskEditMode;
- (void)endMaskEditMode;
- (void)beginEditingMaskInMaskEditMode;
- (void)beginEditingImageInMaskEditMode;
- (void)maskWasApplied;
- (void)maskWasReset;
- (struct CGRect)pathBoundsWithoutStroke;
@property(readonly, nonatomic) TSDPathSource<TSDSmartPathSource> *smartPathSource;
- (void)takeScaledImageGeometry:(id)arg1 maskGeometry:(id)arg2;
- (void)takeSizeFromTracker:(id)arg1;
- (void)resizeWithTransform:(struct CGAffineTransform)arg1 asChild:(_Bool)arg2;
- (_Bool)resizeMayChangeAspectRatio;
- (_Bool)canAspectRatioLockBeChangedByUser;
- (struct CGPoint)centerForConnecting;
- (struct CGPoint)centerForRotationInMaskMode;
- (struct CGPoint)centerForRotation;
- (void)takeRotationFromTracker:(id)arg1;
- (struct CGAffineTransform)layoutTransformInInfoSpace:(struct CGAffineTransform)arg1;
- (void)endDrag;
- (_Bool)i_useBaseCapturedAlignmentFrameOriginForInline;
- (void)dragBy:(struct CGPoint)arg1;
- (void)beginDrag;
- (void)beginResize;
- (void)endDynamicOperation;
- (void)beginDynamicOperation;
- (_Bool)maskIntersectsImage;
- (_Bool)shouldRenderFrameStroke;
- (_Bool)shouldDisplayGuides;
- (_Bool)isInvisible;
- (_Bool)hasAlpha;
- (void)offsetGeometryBy:(struct CGPoint)arg1;
- (struct CGRect)alignmentFrameForProvidingGuidesInRoot;
- (struct CGRect)computeAlignmentFrameInRoot:(_Bool)arg1;
- (void)updateChildrenFromInfo;
- (void)processChangedProperty:(int)arg1;
- (id)computeLayoutGeometry;
- (id)layoutGeometryFromInfo;
- (id)currentInfoGeometry;
- (id)visibleGeometries;
- (id)geometryForTransforming;
- (void)dealloc;
- (id)initWithInfo:(id)arg1;

@end

