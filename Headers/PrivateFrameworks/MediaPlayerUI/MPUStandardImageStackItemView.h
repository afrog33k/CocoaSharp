/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <MediaPlayerUI/MPUStackItemView.h>

@class UIColor, UIImage, UIImageView, _MPUBorderView;

@interface MPUStandardImageStackItemView : MPUStackItemView
{
    _MPUBorderView *_borderView;
    UIImageView *_imageView;
    double _dropShadowAlpha;
    UIColor *_dropShadowColor;
    unsigned long long _dropShadowEdges;
    double _dropShadowWidth;
    UIImage *_image;
    double _imageAlpha;
    double _overlayBorderWidth;
    double _overlayBorderAlpha;
    UIColor *_overlayBorderColor;
    double _overlayCenterAlpha;
    UIColor *_overlayCenterColor;
    struct CGRect _imageContentsRect;
    struct CGAffineTransform _imageTransform;
}

@property(retain, nonatomic) UIColor *overlayCenterColor; // @synthesize overlayCenterColor=_overlayCenterColor;
@property(nonatomic) double overlayCenterAlpha; // @synthesize overlayCenterAlpha=_overlayCenterAlpha;
@property(retain, nonatomic) UIColor *overlayBorderColor; // @synthesize overlayBorderColor=_overlayBorderColor;
@property(nonatomic) double overlayBorderAlpha; // @synthesize overlayBorderAlpha=_overlayBorderAlpha;
@property(nonatomic) double overlayBorderWidth; // @synthesize overlayBorderWidth=_overlayBorderWidth;
@property(nonatomic) struct CGAffineTransform imageTransform; // @synthesize imageTransform=_imageTransform;
@property(nonatomic) struct CGRect imageContentsRect; // @synthesize imageContentsRect=_imageContentsRect;
@property(nonatomic) double imageAlpha; // @synthesize imageAlpha=_imageAlpha;
@property(retain, nonatomic) UIImage *image; // @synthesize image=_image;
@property(nonatomic) double dropShadowWidth; // @synthesize dropShadowWidth=_dropShadowWidth;
@property(nonatomic) unsigned long long dropShadowEdges; // @synthesize dropShadowEdges=_dropShadowEdges;
@property(retain, nonatomic) UIColor *dropShadowColor; // @synthesize dropShadowColor=_dropShadowColor;
@property(nonatomic) double dropShadowAlpha; // @synthesize dropShadowAlpha=_dropShadowAlpha;
- (void).cxx_destruct;
- (void)_updateForBorderViewChange;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;
- (void)layoutSubviews;
- (id)initWithFrame:(struct CGRect)arg1;

@end

