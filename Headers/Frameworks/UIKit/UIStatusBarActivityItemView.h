/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIStatusBarItemView.h>

@class UIActivityIndicatorView;

// Not exported
@interface UIStatusBarActivityItemView : UIStatusBarItemView
{
    UIActivityIndicatorView *_activityIndicator;
    _Bool _slowActivity;
    _Bool _syncActivity;
    _Bool _newsstandActivity;
}

- (double)shadowPadding;
- (double)updateContentsAndWidth;
- (void)setVisible:(_Bool)arg1;
- (void)_stopAnimating;
- (void)_startAnimating;
- (long long)_activityIndicatorStyle;
- (void)dealloc;
- (_Bool)updateForNewData:(id)arg1 actions:(int)arg2;

@end

