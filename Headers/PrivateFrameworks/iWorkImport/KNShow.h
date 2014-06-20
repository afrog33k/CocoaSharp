/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSPObject.h>

@class KNRecording, KNSlideTree, KNSoundtrack, KNTheme, KNUIState, TSSStylesheet;

// Not exported
@interface KNShow : TSPObject
{
    KNUIState *mUIState;
    KNTheme *mTheme;
    KNSlideTree *mSlideTree;
    TSSStylesheet *mStylesheet;
    KNRecording *mRecording;
    struct CGSize mSize;
    double mAutoplayTransitionDelay;
    double mAutoplayBuildDelay;
    double mIdleTimerDelay;
    int mMode;
    _Bool mLoopPresentation;
    _Bool mIdleTimerActive;
    _Bool mAutomaticallyPlaysUponOpen;
    _Bool mNeedsToUpdateThumbnails;
    KNSoundtrack *mSoundtrack;
}

+ (id)showWithSize:(struct CGSize)arg1 context:(id)arg2;
@property(readonly, nonatomic) TSSStylesheet *stylesheet; // @synthesize stylesheet=mStylesheet;
@property(retain, nonatomic) KNTheme *theme; // @synthesize theme=mTheme;
@property(readonly, nonatomic) _Bool needsToUpdateThumbnails; // @synthesize needsToUpdateThumbnails=mNeedsToUpdateThumbnails;
@property(retain, nonatomic) KNUIState *uiState; // @synthesize uiState=mUIState;
- (id)slideNodeAtIndex:(unsigned long long)arg1;
- (unsigned long long)indexOfSlideNode:(id)arg1;
- (void)willModify;
- (struct CGPoint)center;
- (void)dealloc;
- (id)initWithSize:(struct CGSize)arg1 context:(id)arg2;
@property(readonly, nonatomic) _Bool slideNumbersVisible;
@property(retain, nonatomic) KNRecording *recording;
@property(retain, nonatomic) KNSoundtrack *soundtrack;
@property(nonatomic) _Bool automaticallyPlaysUponOpen;
@property(nonatomic) _Bool idleTimerActive;
@property(nonatomic) _Bool loopPresentation;
@property(nonatomic) int mode;
@property(nonatomic) double idleTimerDelay;
@property(nonatomic) double autoplayBuildDelay;
@property(nonatomic) double autoplayTransitionDelay;
@property(nonatomic) struct CGSize size;
@property(retain, nonatomic) KNSlideTree *slideTree;

@end
