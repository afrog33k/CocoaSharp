/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIView.h>

@class UIKBBackdropView;

// Not exported
@interface UIKBInputBackdropView : UIView
{
    UIKBBackdropView *_inputBackdropFullView;
    UIKBBackdropView *_inputBackdropLeftView;
    UIKBBackdropView *_inputBackdropRightView;
    unsigned long long _innerCorners;
    _Bool _isTransitioning;
    double _transitionGap;
    double _transitionLeftOffset;
}

@property(retain, nonatomic) UIKBBackdropView *inputBackdropRightView; // @synthesize inputBackdropRightView=_inputBackdropRightView;
@property(retain, nonatomic) UIKBBackdropView *inputBackdropLeftView; // @synthesize inputBackdropLeftView=_inputBackdropLeftView;
@property(retain, nonatomic) UIKBBackdropView *inputBackdropFullView; // @synthesize inputBackdropFullView=_inputBackdropFullView;
- (void)_endSplitTransitionIfNeeded:(_Bool)arg1;
- (void)_beginSplitTransitionIfNeeded:(double)arg1 gapWidth:(double)arg2;
- (void)_setProgress:(double)arg1 boundedBy:(double)arg2;
- (void)_setLeftOffset:(double)arg1 gapWidth:(double)arg2 progress:(double)arg3 innerCorners:(unsigned long long)arg4;
- (void)_setLeftOffset:(double)arg1 gapWidth:(double)arg2 progress:(double)arg3;
- (void)layoutInputBackdropToFullWithRect:(struct CGRect)arg1;
- (void)layoutInputBackdropToSplitWithLeftViewRect:(struct CGRect)arg1 andRightViewRect:(struct CGRect)arg2 innerCorners:(int)arg3;
- (void)transitionToStyle:(long long)arg1 isSplit:(_Bool)arg2;
- (int)textEffectsVisibilityLevel;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1 primaryBackdrop:(_Bool)arg2;

@end

