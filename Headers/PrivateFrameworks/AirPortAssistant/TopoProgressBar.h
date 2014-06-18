/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "CALayer.h"

@interface TopoProgressBar : CALayer
{
    id _owningView;
    float _progressValue;
}

+ (void)deallocImageCache;
+ (int)initImageCache;
@property(nonatomic) float progressValue; // @synthesize progressValue=_progressValue;
- (struct CGImage *)composeProgressBar;
- (void)layoutSublayers;
- (void)dealloc;
- (struct CGSize)preferredFrameSize;
@property(nonatomic) id owningView;
- (id)initWithOwningView:(id)arg1;

@end

