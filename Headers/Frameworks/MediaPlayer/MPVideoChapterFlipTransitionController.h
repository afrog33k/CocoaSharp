/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <MediaPlayer/MPFlipTransitionController.h>

@class UINavigationBar, UINavigationItem, UITextLabel;

@interface MPVideoChapterFlipTransitionController : MPFlipTransitionController
{
    UINavigationBar *_navigationBar;
    UINavigationItem *_originalNavigationItem;
    UITextLabel *_chapterGuideTitleLabel;
    _Bool _shouldPlayAfterFlip;
    _Bool _tvOutEnabled;
}

@property(nonatomic) _Bool TVOutEnabled; // @synthesize TVOutEnabled=_tvOutEnabled;
@property(nonatomic) _Bool playAfterFlip; // @synthesize playAfterFlip=_shouldPlayAfterFlip;
@property(retain, nonatomic) UINavigationBar *navigationBar; // @synthesize navigationBar=_navigationBar;
- (void).cxx_destruct;
- (void)_showChapterGuideNavigationViews;
- (void)_restoreOriginalNavigationViewsDidStop:(id)arg1;
- (void)_restoreOriginalNavigationViews:(_Bool)arg1;
- (long long)_interfaceOrientation;
- (void)_hideNavigationAndStatusBars;
- (id)_copySwizzledNavigationViews;
- (id)_chapterGuideTitleLabel;
- (void)_done:(id)arg1;
- (void)performTransition:(unsigned long long)arg1;
- (void)dealloc;

@end

