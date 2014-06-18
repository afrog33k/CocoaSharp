/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class UIImage;

@interface SBDefaultImageInfo : NSObject
{
    _Bool _hasSnapshot;
    long long _launchingInterfaceOrientation;
    double _launchingScale;
    long long _originalOrientation;
    long long _currentOrientation;
    UIImage *_image;
    struct CGSize _launchingScreenSize;
}

@property(retain, nonatomic) UIImage *image; // @synthesize image=_image;
@property(nonatomic) _Bool hasSnapshot; // @synthesize hasSnapshot=_hasSnapshot;
@property(nonatomic) long long currentOrientation; // @synthesize currentOrientation=_currentOrientation;
@property(nonatomic) long long originalOrientation; // @synthesize originalOrientation=_originalOrientation;
@property(nonatomic) double launchingScale; // @synthesize launchingScale=_launchingScale;
@property(nonatomic) long long launchingInterfaceOrientation; // @synthesize launchingInterfaceOrientation=_launchingInterfaceOrientation;
@property(nonatomic) struct CGSize launchingScreenSize; // @synthesize launchingScreenSize=_launchingScreenSize;
- (id)description;
- (void)dealloc;

@end

