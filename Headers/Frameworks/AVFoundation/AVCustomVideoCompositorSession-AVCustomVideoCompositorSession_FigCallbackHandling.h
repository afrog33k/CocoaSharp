/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AVFoundation/AVCustomVideoCompositorSession.h>

@interface AVCustomVideoCompositorSession (AVCustomVideoCompositorSession_FigCallbackHandling)
- (void)_cleanupFigCallbacks;
- (int)_setupFigCallbacks;
- (void)_customCompositorFigPropertyDidChange;
- (int)_customCompositorShouldCancelPendingFrames;
- (int)_compositionFrame:(struct OpaqueFigVideoCompositorFrame *)arg1 atTime:(CDStruct_1b6d18a9)arg2 requiresRenderUsingSources:(id)arg3 withInstruction:(void *)arg4;
@end

