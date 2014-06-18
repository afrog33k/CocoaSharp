/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@class NSLayoutConstraint, NSMutableArray, TKVibrationRecorderProgressDotImageView, UIImage;

@interface TKVibrationRecorderProgressView : UIView
{
    int _roundedCornersCompensationDelayMode;
    double _currentTimeInterval;
    double _maximumTimeInterval;
    double _currentVibrationComponentDidBeginTimeInterval;
    double _previousPauseDidBeginTimeInterval;
    id <TKVibrationRecorderStyleProvider> _styleProvider;
    UIView *_progressView;
    NSLayoutConstraint *_progressViewWidthConstraint;
    TKVibrationRecorderProgressDotImageView *_dotForCurrentVibrationComponent;
    NSLayoutConstraint *_dotForCurrentVibrationComponentLeftConstraint;
    NSLayoutConstraint *_dotForCurrentVibrationComponentRightConstraint;
    NSMutableArray *_dots;
}

@property(retain, nonatomic, setter=_setDots:) NSMutableArray *_dots; // @synthesize _dots;
@property(retain, nonatomic, setter=_setDotForCurrentVibrationComponentRightConstraint:) NSLayoutConstraint *_dotForCurrentVibrationComponentRightConstraint; // @synthesize _dotForCurrentVibrationComponentRightConstraint;
@property(retain, nonatomic, setter=_setDotForCurrentVibrationComponentLeftConstraint:) NSLayoutConstraint *_dotForCurrentVibrationComponentLeftConstraint; // @synthesize _dotForCurrentVibrationComponentLeftConstraint;
@property(retain, nonatomic, setter=_setDotForCurrentVibrationComponent:) TKVibrationRecorderProgressDotImageView *_dotForCurrentVibrationComponent; // @synthesize _dotForCurrentVibrationComponent;
@property(retain, nonatomic, setter=_setProgressViewWidthConstraint:) NSLayoutConstraint *_progressViewWidthConstraint; // @synthesize _progressViewWidthConstraint;
@property(retain, nonatomic, setter=_setProgressView:) UIView *_progressView; // @synthesize _progressView;
@property(retain, nonatomic, setter=_setStyleProvider:) id <TKVibrationRecorderStyleProvider> _styleProvider; // @synthesize _styleProvider;
@property(nonatomic, setter=_setPreviousPauseDidBeginTimeInterval:) double _previousPauseDidBeginTimeInterval; // @synthesize _previousPauseDidBeginTimeInterval;
@property(nonatomic, setter=_setCurrentVibrationComponentDidBeginTimeInterval:) double _currentVibrationComponentDidBeginTimeInterval; // @synthesize _currentVibrationComponentDidBeginTimeInterval;
@property(nonatomic, setter=_setMaximumTimeInterval:) double _maximumTimeInterval; // @synthesize _maximumTimeInterval;
@property(nonatomic, setter=_setCurrentTimeInterval:) double _currentTimeInterval; // @synthesize _currentTimeInterval;
@property(nonatomic) int roundedCornersCompensationDelayMode; // @synthesize roundedCornersCompensationDelayMode=_roundedCornersCompensationDelayMode;
- (struct CGRect)accessibilityFrame;
- (id)accessibilityValue;
- (id)accessibilityLabel;
- (_Bool)isAccessibilityElement;
- (double)_cappedValueForTimeInterval:(double)arg1;
- (void)didMoveToWindow;
- (void)didMoveToSuperview;
- (struct CGRect)_frameForDotAtTimeInterval:(double)arg1 duration:(double)arg2;
- (void)_updateHorizontalConstraintsOfDotForCurrentVibrationComponent:(id)arg1 withFrame:(struct CGRect)arg2;
- (struct CGSize)intrinsicContentSize;
- (void)clearAllVibrationComponents;
- (void)vibrationComponentDidEnd;
- (void)vibrationComponentDidStart;
@property(readonly, nonatomic) struct UIOffset _dotInsets;
@property(readonly, nonatomic) struct CGSize _dotSize;
@property(readonly, nonatomic) UIImage *_resizableDotImage;
- (void)_updateProgressViewBackgroundColor;
@property(nonatomic) double currentTimeInterval;
- (void)dealloc;
- (id)initWithMaximumTimeInterval:(double)arg1 styleProvider:(id)arg2;
- (id)initWithFrame:(struct CGRect)arg1;

@end

