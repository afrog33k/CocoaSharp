/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@class UIColor;

@interface RCAcousticAnnotationView : UIView
{
    struct CGGradient *_decibelMarkerBackgroundGradient;
    _Bool _backgroundMaskingEnabled;
    float _minimumDecibelRange;
    float _maximumDecibelRange;
    long long _numberOfDecibelMarkers;
    UIColor *_boundaryKeylinesColor;
    UIColor *_centerKeylineColor;
    UIColor *_borderColor;
}

@property(nonatomic) _Bool backgroundMaskingEnabled; // @synthesize backgroundMaskingEnabled=_backgroundMaskingEnabled;
@property(retain, nonatomic) UIColor *borderColor; // @synthesize borderColor=_borderColor;
@property(retain, nonatomic) UIColor *centerKeylineColor; // @synthesize centerKeylineColor=_centerKeylineColor;
@property(retain, nonatomic) UIColor *boundaryKeylinesColor; // @synthesize boundaryKeylinesColor=_boundaryKeylinesColor;
@property(nonatomic) long long numberOfDecibelMarkers; // @synthesize numberOfDecibelMarkers=_numberOfDecibelMarkers;
@property(nonatomic) float maximumDecibelRange; // @synthesize maximumDecibelRange=_maximumDecibelRange;
@property(nonatomic) float minimumDecibelRange; // @synthesize minimumDecibelRange=_minimumDecibelRange;
- (void).cxx_destruct;
- (id)_zeroMarkerAttributes;
- (id)_decibelMarkersAttributes;
- (void)drawRect:(struct CGRect)arg1;
- (struct CGRect)annotationBoundaryRect;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

