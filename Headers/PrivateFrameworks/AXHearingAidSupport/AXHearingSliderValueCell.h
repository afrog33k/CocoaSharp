/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PSTableCell.h"

@class NSNumberFormatter, UILabel, UISlider, UIView;

@interface AXHearingSliderValueCell : PSTableCell
{
    UIView *_leftView;
    UISlider *_slider;
    UILabel *_valueLabel;
    NSNumberFormatter *_numberFormatter;
    double _sliderMargin;
    double _valueWidth;
}

- (id)description;
- (void)accessibilityDecrement;
- (void)accessibilityIncrement;
- (_Bool)isAccessibilityElement;
- (id)accessibilityLabel;
- (id)accessibilityHint;
- (id)accessibilityValue;
- (unsigned long long)accessibilityTraits;
- (void)layoutSubviews;
- (void)updateValue;
- (id)value;
- (void)setValue:(id)arg1;
- (void)sliderValueDidChange:(id)arg1;
- (void)willMoveToSuperview:(id)arg1;
- (void)dealloc;
- (id)initWithStyle:(long long)arg1 reuseIdentifier:(id)arg2 specifier:(id)arg3;

@end

