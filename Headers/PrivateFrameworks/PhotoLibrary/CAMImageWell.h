/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIButton.h"

@class NSMutableArray, NSString, UIImageView, UIView;

@interface CAMImageWell : UIButton
{
    long long _cameraOrientation;
    UIView *__containerView;
    UIImageView *__thumbnailImageView;
    UIImageView *__maskImageView;
    NSMutableArray *__dimmingViewQueue;
    NSString *__uuid;
}

@property(retain, nonatomic, setter=_setUuid:) NSString *_uuid; // @synthesize _uuid=__uuid;
@property(readonly, nonatomic) NSMutableArray *_dimmingViewQueue; // @synthesize _dimmingViewQueue=__dimmingViewQueue;
@property(readonly, nonatomic) UIImageView *_maskImageView; // @synthesize _maskImageView=__maskImageView;
@property(readonly, nonatomic) UIImageView *_thumbnailImageView; // @synthesize _thumbnailImageView=__thumbnailImageView;
@property(readonly, nonatomic) UIView *_containerView; // @synthesize _containerView=__containerView;
@property(nonatomic) long long cameraOrientation; // @synthesize cameraOrientation=_cameraOrientation;
- (id)_maskImage;
- (void)_removeFirstDimmingView;
- (void)_performEmitAnimationWithImage:(id)arg1 orientation:(long long)arg2 withCompletionBlock:(id)arg3;
- (struct CGAffineTransform)_affineTransformForImageOrientation:(long long)arg1;
- (void)_updateThumbnailTransformFromCameraOrientation;
- (void)recoverFromFailedThumbnailUpdate;
- (void)prepareForThumbnailUpdateFromCapture;
- (void)setThumbnailImage:(id)arg1 uuid:(id)arg2 animated:(_Bool)arg3;
- (void)setThumbnailImage:(id)arg1 animated:(_Bool)arg2;
- (void)setCameraOrientation:(long long)arg1 animated:(_Bool)arg2;
- (void)layoutSubviews;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;
- (void)dealloc;
- (id)initWithCoder:(id)arg1;
- (id)initWithFrame:(struct CGRect)arg1;
- (void)_commonCAMImageWellInitialization;

@end

