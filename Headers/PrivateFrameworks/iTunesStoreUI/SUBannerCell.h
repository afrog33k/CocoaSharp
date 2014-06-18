/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iTunesStoreUI/SUTableCell.h>

#import "SUCellConfigurationView-Protocol.h"

@class UIButton;

@interface SUBannerCell : SUTableCell <SUCellConfigurationView>
{
    UIButton *_leftButton;
    UIButton *_rightButton;
}

- (void)_reloadButtons;
- (id)_newButton;
- (void)_buttonAction:(id)arg1;
- (void)setHighlighted:(_Bool)arg1 animated:(_Bool)arg2;
- (void)setConfiguration:(id)arg1;
- (void)layoutSubviews;
- (void)reloadView;
- (void)dealloc;
- (id)initWithStyle:(long long)arg1 reuseIdentifier:(id)arg2;

@end

