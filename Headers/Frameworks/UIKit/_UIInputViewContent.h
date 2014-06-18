/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIView.h>

@class UIInputView;

// Not exported
@interface _UIInputViewContent : UIView
{
    double _contentHeight;
    double _contentWidth;
    UIInputView *_inputView;
    int _unclippableCorners;
}

@property(nonatomic) int _unclippableCorners; // @synthesize _unclippableCorners;
- (void)_updateCornerClipping;
- (struct CGSize)_contentSize;
- (void)addSubview:(id)arg1;
- (struct CGSize)_sizeFittingContentViews;
- (void)_setToolbarBackgroundView:(id)arg1;
- (void)_setToolbarBackgroundImage:(id)arg1;
- (_Bool)_isToolbar;
- (id)initWithFrame:(struct CGRect)arg1 inputView:(id)arg2;

@end

