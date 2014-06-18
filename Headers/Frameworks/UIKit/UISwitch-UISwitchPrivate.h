/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UISwitch.h>

@class UIColor;

@interface UISwitch (UISwitchPrivate)
- (void)_setKnobBounceMass:(double)arg1;
- (double)_knobBounceMass;
- (void)_setKnobBounceStiffness:(double)arg1;
- (double)_knobBounceStiffness;
- (void)_setKnobBounceDamping:(double)arg1;
- (double)_knobBounceDamping;
- (void)_setKnobBounceDuration:(double)arg1;
- (double)_knobBounceDuration;
- (void)_setPressed:(_Bool)arg1 on:(_Bool)arg2 animated:(_Bool)arg3 completion:(id)arg4;
- (void)setAlternateColors:(_Bool)arg1;

// Remaining properties
@property(nonatomic, getter=_alwaysShowOnOffLabel, setter=_setAlwaysShowsOnOffLabel:) _Bool alwaysShowOnOffLabel;
@property(retain, nonatomic, getter=_onColor, setter=_setOnColor:) UIColor *onColor;
@end

