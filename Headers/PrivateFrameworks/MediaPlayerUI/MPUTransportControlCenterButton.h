/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "SBUIControlCenterButton.h"

#import "SBUIControlCenterButtonDelegate-Protocol.h"

@class NSObject<OS_dispatch_source>;

@interface MPUTransportControlCenterButton : SBUIControlCenterButton <SBUIControlCenterButtonDelegate>
{
    NSObject<OS_dispatch_source> *_longPressTimer;
    _Bool _longPress;
    double _minimumPressDuration;
}

- (void).cxx_destruct;
- (void)buttonTapped:(id)arg1;
- (void)_clearLongPressTimer;
- (void)_longPressTimerAction;
- (void)endTrackingWithTouch:(id)arg1 withEvent:(id)arg2;
- (void)cancelTrackingWithEvent:(id)arg1;
- (_Bool)beginTrackingWithTouch:(id)arg1 withEvent:(id)arg2;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

