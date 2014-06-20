/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIGestureRecognizer.h>

@class NSMutableArray;

@interface UISwipeGestureRecognizer : UIGestureRecognizer
{
    double _maximumDuration;
    double _minimumPrimaryMovement;
    double _maximumPrimaryMovement;
    double _minimumSecondaryMovement;
    double _maximumSecondaryMovement;
    double _rateOfMinimumMovementDecay;
    double _rateOfMaximumMovementDecay;
    unsigned long long _numberOfTouchesRequired;
    NSMutableArray *_touches;
    unsigned long long _direction;
    struct CGPoint _startLocation;
    struct CGPoint *_startLocations;
    double _startTime;
    unsigned int _failed:1;
}

@property(nonatomic) unsigned long long direction; // @synthesize direction=_direction;
@property(nonatomic) unsigned long long numberOfTouchesRequired; // @synthesize numberOfTouchesRequired=_numberOfTouchesRequired;
@property(nonatomic) double rateOfMaximumMovementDecay; // @synthesize rateOfMaximumMovementDecay=_rateOfMaximumMovementDecay;
@property(nonatomic) double rateOfMinimumMovementDecay; // @synthesize rateOfMinimumMovementDecay=_rateOfMinimumMovementDecay;
@property(nonatomic) double maximumSecondaryMovement; // @synthesize maximumSecondaryMovement=_maximumSecondaryMovement;
@property(nonatomic) double minimumSecondaryMovement; // @synthesize minimumSecondaryMovement=_minimumSecondaryMovement;
@property(nonatomic) double maximumPrimaryMovement; // @synthesize maximumPrimaryMovement=_maximumPrimaryMovement;
@property(nonatomic) double minimumPrimaryMovement; // @synthesize minimumPrimaryMovement=_minimumPrimaryMovement;
@property(nonatomic) double maximumDuration; // @synthesize maximumDuration=_maximumDuration;
- (void)_appendSubclassDescription:(id)arg1;
- (struct CGPoint)locationOfTouch:(unsigned long long)arg1 inView:(id)arg2;
- (unsigned long long)numberOfTouches;
- (struct CGPoint)locationInView:(id)arg1;
- (void)touchesCancelled:(id)arg1 withEvent:(id)arg2;
- (void)touchesEnded:(id)arg1 withEvent:(id)arg2;
- (void)touchesMoved:(id)arg1 withEvent:(id)arg2;
- (_Bool)_checkForSwipeWithDelta:(struct CGPoint)arg1 time:(double)arg2;
- (void)touchesBegan:(id)arg1 withEvent:(id)arg2;
- (void)_resetGestureRecognizer;
@property(readonly, nonatomic) struct CGPoint startPoint;
- (void)dealloc;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)initWithTarget:(id)arg1 action:(SEL)arg2;

@end
