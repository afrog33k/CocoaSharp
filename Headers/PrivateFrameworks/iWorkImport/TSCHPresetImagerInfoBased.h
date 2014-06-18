/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCHPresetImager.h>

@class TSCHChartType;

// Not exported
@interface TSCHPresetImagerInfoBased : TSCHPresetImager
{
    TSCHChartType *mChartType;
}

+ (id)presetImagerForChartType:(id)arg1;
- (id)imageWithPreset:(id)arg1 imageSize:(struct CGSize)arg2 imageScale:(double)arg3 swatchFrame:(struct CGRect)arg4 documentRoot:(id)arg5;
- (struct UIEdgeInsets)swatchImageEdgeInsetsForSize:(struct CGSize)arg1;
- (id)p_rectAdjustmentForChartType:(id)arg1;
- (id)p_chartType;
- (void)dealloc;
- (id)initWithChartType:(id)arg1;

@end

