/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@class UIImageView;

@interface _MPAnisotropicDetailThumbView : UIView
{
    UIImageView *_darkReflectionView;
    double _filteredX;
    double _filteredY;
    double _magSqr;
    id _motionManagerObserver;
    UIImageView *_leftLightReflectionView;
    UIImageView *_rightLightReflectionView;
}

- (void).cxx_destruct;
- (void)_updateAccelerometerX:(double)arg1 Y:(double)arg2;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

