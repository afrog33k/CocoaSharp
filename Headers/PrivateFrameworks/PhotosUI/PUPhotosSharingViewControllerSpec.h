/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@interface PUPhotosSharingViewControllerSpec : NSObject
{
    _Bool _maximizeImageHeight;
    int _fastImageFormat;
    int _qualityImageFormat;
    int _zoomingImageFormat;
    double _interItemSpacing;
}

@property(readonly, nonatomic) _Bool maximizeImageHeight; // @synthesize maximizeImageHeight=_maximizeImageHeight;
@property(readonly, nonatomic) double interItemSpacing; // @synthesize interItemSpacing=_interItemSpacing;
@property(readonly, nonatomic) int zoomingImageFormat; // @synthesize zoomingImageFormat=_zoomingImageFormat;
@property(readonly, nonatomic) int qualityImageFormat; // @synthesize qualityImageFormat=_qualityImageFormat;
@property(readonly, nonatomic) int fastImageFormat; // @synthesize fastImageFormat=_fastImageFormat;
- (_Bool)allowsInterfaceRotation;
- (_Bool)embedsActivityViewForOrientation:(long long)arg1;
- (struct UIEdgeInsets)collectionViewLayoutContentInsetForOrientation:(long long)arg1;
@property(readonly, nonatomic) unsigned long long selectionBadgeCorner;
@property(readonly, nonatomic) struct UIOffset selectionBadgeOffset;
@property(readonly, nonatomic) struct CGSize selectionBadgeSize;

@end

