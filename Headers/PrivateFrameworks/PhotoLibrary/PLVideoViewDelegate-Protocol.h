/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol PLVideoViewDelegate <NSObject>

@optional
- (id)videoViewRequestsPickedAirplayRoute:(id)arg1;
- (_Bool)videoViewCanCreateMetadata:(id)arg1;
- (_Bool)videoViewShouldRespondToPlayOverlayTap:(id)arg1;
- (void)videoView:(id)arg1 displayPlayOverlay:(id)arg2;
- (void)videoViewDidCancelEditing:(id)arg1;
- (void)videoViewDidBeginEditing:(id)arg1;
- (void)videoViewWillBeginEditing:(id)arg1;
- (void)videoView:(id)arg1 remakingProgressDidChange:(float)arg2;
- (void)videoViewDidEndRemaking:(id)arg1 didSucceed:(_Bool)arg2;
- (void)videoViewDidBeginRemaking:(id)arg1;
- (void)videoViewDidEndScrubbing:(id)arg1;
- (void)videoViewDidBeginScrubbing:(id)arg1;
- (void)videoViewDidEndPlayback:(id)arg1 didFinish:(_Bool)arg2;
- (void)videoViewDidPausePlayback:(id)arg1;
- (void)videoViewDidBeginPlayback:(id)arg1;
- (void)videoViewPlaybackDidFail:(id)arg1;
- (void)videoViewIsReadyToBeginPlayback:(id)arg1;
- (_Bool)videoViewCanBeginPlayback:(id)arg1;
- (double)videoViewScrubberWidth:(id)arg1;
- (double)videoViewScrubberYOrigin:(id)arg1 forOrientation:(long long)arg2;
- (void)videoViewDidCreateAttachments:(id)arg1;
@end

