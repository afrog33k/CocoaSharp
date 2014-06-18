/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <CoreImage/CIEnhancementCalculation.h>

// Not exported
@interface CIEnhancementCalculator : CIEnhancementCalculation
{
    _Bool faceBalanceEnabled;
    _Bool vibranceEnabled;
    _Bool curvesEnabled;
    _Bool shadowsEnabled;
}

@property _Bool shadowsEnabled; // @synthesize shadowsEnabled;
@property _Bool curvesEnabled; // @synthesize curvesEnabled;
@property _Bool vibranceEnabled; // @synthesize vibranceEnabled;
@property _Bool faceBalanceEnabled; // @synthesize faceBalanceEnabled;
- (void)setupFaceColorFromImage:(id)arg1 usingContext:(id)arg2 features:(id)arg3;
- (id)setupFaceColorFromImage:(id)arg1 usingContext:(id)arg2 detectorOpts:(id)arg3;
- (void)analyzeFeatures:(id)arg1 usingContext:(id)arg2 baseImage:(id)arg3;
- (void)setupHistogramsUsing:(id)arg1 redIndex:(int)arg2 greenIndex:(int)arg3 blueIndex:(int)arg4;
- (id)histogramFromRows:(id)arg1 componentOffset:(unsigned int)arg2;
- (void)dealloc;
- (id)init;

@end

