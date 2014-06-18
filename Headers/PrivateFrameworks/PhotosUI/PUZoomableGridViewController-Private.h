/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <PhotosUI/PUZoomableGridViewController.h>

#import "PUMagnfiedViewControllerDelegate-Protocol.h"

@class PUZoomableGridTransition;

@interface PUZoomableGridViewController (Private) <PUMagnfiedViewControllerDelegate>
- (id)bestTransitionReferenceItemIndexPathOutIsFromLastTransition:(_Bool *)arg1 outIsExplicit:(_Bool *)arg2;
- (void)gridZoomTransitionDidFinish:(_Bool)arg1;
- (_Bool)isTransitionAutoAdjustContentOffsetEnabled;
- (void)prepareForTransitionToZoomableViewController:(id)arg1 anchorItemIndexPath:(id)arg2 anchorShiftsColumns:(_Bool)arg3 animated:(_Bool)arg4 interactive:(_Bool)arg5;

// Remaining properties
@property(readonly, nonatomic) PUZoomableGridTransition *currentGridZoomTransitionInfo;
@end

