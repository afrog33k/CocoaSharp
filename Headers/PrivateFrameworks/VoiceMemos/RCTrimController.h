/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "RCAVPreviewControllerObserver-Protocol.h"
#import "RCTrimControlDelegate-Protocol.h"

@class AVAssetExportSession, AVItem, NSString, RCAVPreviewController, RCSavedRecording, RCTrimControl, UIButton, UIView, UIWindow;

@interface RCTrimController : NSObject <RCTrimControlDelegate, RCAVPreviewControllerObserver>
{
    id _completionHandler;
    NSString *_confirmButtonTitle;
    UIButton *_confirmButton;
    UIButton *_cancelButton;
    UIButton *_playButton;
    UIView *_containerView;
    UIView *_dimmingView;
    AVAssetExportSession *_exportSession;
    AVItem *_recordingItem;
    NSString *_recordingPath;
    NSString *_remadeRecordingPath;
    _Bool _playing;
    RCAVPreviewController *_previewController;
    double _startTimeInterval;
    double _endTimeInterval;
    double _minTrimmedDuration;
    double _maxTrimmedDuration;
    UIWindow *_statusBarDimmingWindow;
    RCTrimControl *_trimControl;
    UIView *_view;
    id <RCTrimControllerDelegate> _delegate;
    RCSavedRecording *_recording;
}

@property(nonatomic) double maxTrimmedDuration; // @synthesize maxTrimmedDuration=_maxTrimmedDuration;
@property(nonatomic) double minTrimmedDuration; // @synthesize minTrimmedDuration=_minTrimmedDuration;
@property(nonatomic) double endTimeInterval; // @synthesize endTimeInterval=_endTimeInterval;
@property(nonatomic) double startTimeInterval; // @synthesize startTimeInterval=_startTimeInterval;
@property(readonly, nonatomic) NSString *recordingPath; // @synthesize recordingPath=_recordingPath;
@property(readonly, nonatomic) RCSavedRecording *recording; // @synthesize recording=_recording;
@property(nonatomic) __weak id <RCTrimControllerDelegate> delegate; // @synthesize delegate=_delegate;
- (void).cxx_destruct;
- (void)_applicationWillResignActive:(id)arg1;
- (void)previewController:(id)arg1 playbackTimeDidUpdateToCurrentTime:(double)arg2;
- (void)previewController:(id)arg1 playbackTimeDidJumpWithPreviousTime:(double)arg2;
- (void)previewController:(id)arg1 playbackDidStopPlayingWithError:(id)arg2;
- (void)previewController:(id)arg1 playbackDidBeginWithRate:(float)arg2;
- (void)_dismiss;
- (void)_resumePreview;
- (void)_pausePreview;
- (void)_endPreview;
- (void)_beginPreview;
- (void)_play:(id)arg1;
- (void)_cancel:(id)arg1;
- (void)_confirm:(id)arg1;
- (id)_recordingPath;
- (double)_recordingDuration;
- (id)_recordingAVItem;
- (id)_newButtonWithStyle:(long long)arg1;
- (id)_view;
@property(readonly, nonatomic) float trimmingProgress;
@property(readonly, nonatomic) _Bool isTrimming;
@property(copy, nonatomic) NSString *confirmButtonTitle;
- (void)presentInWindow:(id)arg1 completionHandler:(id)arg2;
- (void)trimControlDidEndScrubbing:(id)arg1;
- (void)trimControl:(id)arg1 didScrubToTimeInterval:(double)arg2;
- (void)trimControlDidBeginScrubbing:(id)arg1;
- (void)trimControlDidBeginTrimming:(id)arg1;
- (void)dealloc;
- (id)initWithRecordingPath:(id)arg1;
- (id)initWithSavedRecording:(id)arg1;
- (void)_initialize;
- (id)init;

@end

