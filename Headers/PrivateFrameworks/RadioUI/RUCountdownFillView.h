/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@class UIColor, UIImage;

@interface RUCountdownFillView : UIView
{
    double _value;
    struct CGSize _shadowOffset;
}

+ (Class)layerClass;
@property(nonatomic) double value; // @synthesize value=_value;
@property(nonatomic) struct CGSize shadowOffset; // @synthesize shadowOffset=_shadowOffset;
@property(retain, nonatomic) UIColor *shadowColor;
@property(nonatomic) double shadowBlur;
- (void)setValue:(double)arg1 animated:(_Bool)arg2;
@property(retain, nonatomic) UIImage *fillImage;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;

@end
