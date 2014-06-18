/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCHChartLayout.h>

@class NSDictionary, NSValue, TSCHChartRootLayoutItem;

// Not exported
@interface TSCH2DChartLayout : TSCHChartLayout
{
    TSCHChartRootLayoutItem *mLayoutTreeRoot;
    struct CGSize mLastChartBodySize;
    struct CGSize mStartingSize;
    struct CGRect mStartingLegendInnerFrame;
    struct CGRect mStartingChartInnerFrame;
    NSValue *mCachedOriginRelativeToChartAreaFrame;
}

+ (id)propertiesThatInvalidateLayout;
- (id)mutationTuplesToApplyDuringResize;
- (struct CGPath *)newDragAndDropHighlightPathForSelection:(id)arg1;
- (id)subselectionHaloPositionsForSelections:(id)arg1;
- (id)subselectionKnobPositionsForSelection:(id)arg1;
- (id)hitChartElements:(struct CGPoint)arg1 passingTest:(id)arg2;
- (id)renderersWithRep:(id)arg1;
- (void)setDataSetIndex:(unsigned long long)arg1;
- (unsigned long long)dataSetIndex;
- (id)model;
@property(copy, nonatomic) NSDictionary *seriesIndexedPieWedgeExplosions;
- (void)endResize;
- (void)takeSizeFromTracker:(id)arg1;
- (void)beginResize;
- (void)endDynamicOperation;
- (void)beginDynamicOperation;
- (void)p_ensureValidForCircumscribingSizeLayout;
- (void)invalidate;
- (void)p_layoutNowForChartBodySize:(struct CGSize)arg1;
- (void)p_layoutNowForCircumscribingSize:(struct CGSize)arg1;
- (void)layoutForChartBodySize:(struct CGSize)arg1;
- (void)layoutForCircumscribingSize:(struct CGSize)arg1;
- (void)processChanges:(id)arg1;
@property(readonly) TSCHChartRootLayoutItem *p_layoutTree;
- (void)setLayoutSettings:(CDStruct_9aa9521f)arg1;
- (struct CGRect)chartBodyFrame;
- (void)setLegendModelGeometryFrame:(struct CGRect)arg1;
- (struct CGRect)legendModelGeometryFrame;
- (void)setLegendGeometryFrame:(struct CGRect)arg1;
- (struct CGRect)legendGeometryFrame;
- (struct CGPoint)p_cachedOriginRelativeToChartAreaFrame;
- (struct CGRect)legendDrawingFrame;
- (struct CGRect)legendFrame;
- (struct CGRect)chartAreaFrame;
- (struct CGRect)outerShadowFrame;
- (struct CGRect)outerLayoutFrame;
- (void)dealloc;
- (id)initWithChartInfo:(id)arg1;

@end

