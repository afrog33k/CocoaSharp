/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <VectorKit/VKDrawStyle.h>

// Not exported
@interface VKRoadDrawStyle : VKDrawStyle
{
    struct VKProfileSparseRamp<float> width;
    struct VKProfileSparseRamp<float> strokeWidth;
    struct VKProfileSparseRamp<float> labelHeight;
    struct VKProfileSparseRamp<float> widthDropoff;
    struct VKProfileSparseRamp<_VGLColor> fillColor;
    struct VKProfileSparseRamp<_VGLColor> strokeColor;
    struct VKProfileSparseRamp<bool> simpleLine;
    struct VKProfileSparseRamp<int> zIndices;
    struct VKProfileSparseRamp<int> fillZIndices;
    struct VKProfileSparseRamp<bool> strokeColorInterpolate;
    struct VKProfileSparseRamp<bool> fillColorInterpolate;
    long long railroadPattern;
    struct VKProfileSparseRamp<_VGLColor> alternateFillColor;
    struct VKProfileSparseRamp<float> patternScaler;
    struct VKProfileSparseRamp<float> patternScalerQuantizationFactor;
    struct VKProfileSparseRamp<bool> renderEndCaps;
    float trafficIncidentUnknownMinZ;
    float trafficIncidentAccidentMinZ;
    float trafficIncidentConstructionMinZ;
    float trafficIncidentRoadClosureMinZ;
    float trafficIncidentEventMinZ;
    float trafficIncidentHazardMinZ;
    float trafficIncidentLaneClosureMinZ;
    float trafficIncidentRampClosureMinZ;
}

- (id).cxx_construct;
- (void).cxx_destruct;
- (long long)railroadPattern;
- (void)takeFromZoomInvariantProperties:(id)arg1;
- (void)takeFromStyleProperties:(id)arg1 atZoom:(unsigned long long)arg2 globals:(id)arg3;
- (id)variant;

@end

