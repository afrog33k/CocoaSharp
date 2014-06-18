/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class AVCaptureInputPort, AVCaptureOutput, AVCaptureVideoPreviewLayer, NSArray, NSMutableArray;

@interface AVCaptureConnectionInternal : NSObject
{
    NSMutableArray *inputPorts;
    AVCaptureOutput *output;
    AVCaptureVideoPreviewLayer *videoPreviewLayer;
    _Bool active;
    _Bool enabled;
    int outputChangeSeedOnDisable;
    AVCaptureInputPort *audioInputPort;
    NSMutableArray *audioChannels;
    NSArray *audioChannelLevels;
    long long lastGetAudioLevelsTime;
    AVCaptureInputPort *videoInputPort;
    _Bool videoMirroringSupported;
    _Bool automaticallyAdjustsVideoMirroring;
    _Bool videoMirrored;
    _Bool videoOrientationSupported;
    long long videoOrientation;
    CDStruct_1b6d18a9 videoMinFrameDuration;
    CDStruct_1b6d18a9 videoMaxFrameDuration;
    double videoMaxScaleAndCropFactor;
    double videoScaleAndCropFactor;
    int videoRetainedBufferCountHint;
    _Bool enablesVideoStabilizationWhenAvailable;
    _Bool videoStabilizationEnabled;
}

@end

