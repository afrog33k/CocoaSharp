/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@interface CalibrationBallView : UIView
{
    double _currentAngle;
    UIView *_ballView;
    double _ballRadius;
    double _trackRadius;
}

@property(nonatomic, setter=setAngle:) double currentAngle; // @synthesize currentAngle=_currentAngle;
@property(nonatomic) double trackRadius; // @synthesize trackRadius=_trackRadius;
- (void)dealloc;
- (void)layoutSubviews;
- (id)ballView;
- (id)initWithFrame:(struct CGRect)arg1 ballRadius:(double)arg2;

@end

