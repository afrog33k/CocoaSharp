/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/_UISettings.h>

// Not exported
@interface _UIScreenEdgePanRecognizerEdgeSettings : _UISettings
{
    double _hysteresis;
    double _edgeRegionSize;
    double _bottomEdgeRegionSize;
    double _backProjectionTime;
    double _edgeAngleWindow;
    double _edgeAngleWindowDecayTime;
    double _restrictedEdgeRegionTimeInterval;
    double _restrictedEdgeRegionMinimumWeight;
    double _maximumSwipeDuration;
}

+ (id)settingsControllerModule;
+ (id)keyPathsForValuesAffectingEdgeAngleWindowDegreees;
@property(nonatomic) double maximumSwipeDuration; // @synthesize maximumSwipeDuration=_maximumSwipeDuration;
@property(nonatomic) double restrictedEdgeRegionMinimumWeight; // @synthesize restrictedEdgeRegionMinimumWeight=_restrictedEdgeRegionMinimumWeight;
@property(nonatomic) double restrictedEdgeRegionTimeInterval; // @synthesize restrictedEdgeRegionTimeInterval=_restrictedEdgeRegionTimeInterval;
@property(nonatomic) double edgeAngleWindowDecayTime; // @synthesize edgeAngleWindowDecayTime=_edgeAngleWindowDecayTime;
@property(nonatomic) double edgeAngleWindow; // @synthesize edgeAngleWindow=_edgeAngleWindow;
@property(nonatomic) double backProjectionTime; // @synthesize backProjectionTime=_backProjectionTime;
@property(nonatomic) double bottomEdgeRegionSize; // @synthesize bottomEdgeRegionSize=_bottomEdgeRegionSize;
@property(nonatomic) double edgeRegionSize; // @synthesize edgeRegionSize=_edgeRegionSize;
@property(nonatomic) double hysteresis; // @synthesize hysteresis=_hysteresis;
@property(nonatomic) double edgeAngleWindowDegreees;
- (void)setDefaultValues;

@end

