/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <ScreenReaderCore/SCRCPhotoEvaluatorResult.h>

// Not exported
@interface SCRCPhotoEvaluatorResultColor : SCRCPhotoEvaluatorResult
{
    double _redLevel;
    double _blueLevel;
    double _greenLevel;
}

@property(readonly, nonatomic) double greenLevel; // @synthesize greenLevel=_greenLevel;
@property(readonly, nonatomic) double blueLevel; // @synthesize blueLevel=_blueLevel;
@property(readonly, nonatomic) double redLevel; // @synthesize redLevel=_redLevel;
- (id)humanReadableResult;
- (id)initWithRedLevel:(double)arg1 blueLevel:(double)arg2 greenLevel:(double)arg3;

@end

