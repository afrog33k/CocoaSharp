/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UICollectionViewLayoutAttributes.h"

@interface PUAbstractTransitionLayoutAttributes : UICollectionViewLayoutAttributes
{
    double _progress;
    struct CGPoint _extrapolationReferencePoint;
}

@property(nonatomic) double progress; // @synthesize progress=_progress;
@property(nonatomic) struct CGPoint extrapolationReferencePoint; // @synthesize extrapolationReferencePoint=_extrapolationReferencePoint;
- (struct CGPoint)rubberbandFromInitialPoint:(struct CGPoint)arg1 toPoint:(struct CGPoint)arg2 withExtrapolatedPoint:(struct CGPoint)arg3;
- (double)_rubberbandFromFloat:(double)arg1 toFloat:(double)arg2 withExtrapolatedFloat:(double)arg3;
- (struct CGPoint)extrapolatedPointFromReferencePointToPoint:(struct CGPoint)arg1 forProgress:(double)arg2;
- (void)updateForProgress;

@end

