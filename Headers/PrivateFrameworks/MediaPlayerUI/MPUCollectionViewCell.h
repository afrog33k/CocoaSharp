/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UICollectionViewCell.h"

@class MPImageCache, MPImageCacheRequest;

@interface MPUCollectionViewCell : UICollectionViewCell
{
    MPImageCache *_imageCache;
    MPImageCacheRequest *_imageRequest;
}

@property(retain, nonatomic) MPImageCacheRequest *imageRequest; // @synthesize imageRequest=_imageRequest;
@property(retain, nonatomic) MPImageCache *imageCache; // @synthesize imageCache=_imageCache;
- (void).cxx_destruct;
- (void)setArtworkImage:(id)arg1;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

