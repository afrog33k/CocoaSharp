/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/_UIModalItemContentView.h>

@class UIScrollView, UITableView, UIView, _UIModalItemTextFiledBGView;

@interface _UIModalItemAlertContentView : _UIModalItemContentView
{
    _UIModalItemTextFiledBGView *_textFieldBGView;
    _Bool _alertViewIsSetup;
    UITableView *_otherTableView;
    UIView *_2ButtonsSeparators;
    UIView *_tableViewTopSeparator;
    UIScrollView *_labelsScrollView;
    _Bool _itemWantsVerticalButtons;
    _Bool _itemNeedsTwoTableViews;
}

- (void)_reloadButtons;
- (void)setEnableFirstOtherButton:(_Bool)arg1;
- (void)tableView:(id)arg1 didSelectRowAtIndexPath:(id)arg2;
- (long long)tableView:(id)arg1 numberOfRowsInSection:(long long)arg2;
- (id)tableView:(id)arg1 cellForRowAtIndexPath:(id)arg2;
- (void)tableView:(id)arg1 willDisplayCell:(id)arg2 forRowAtIndexPath:(id)arg3;
- (void)layout;
- (void)_prepareViewIfNeeded;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

