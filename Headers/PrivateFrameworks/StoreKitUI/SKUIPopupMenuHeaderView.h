/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

#import "SKUIMenuViewControllerDelegate-Protocol.h"
#import "UIPopoverControllerDelegate-Protocol.h"

@class NSArray, NSString, SKUIMenuViewController, UIButton, UILabel, UIPopoverController;

@interface SKUIPopupMenuHeaderView : UIView <SKUIMenuViewControllerDelegate, UIPopoverControllerDelegate>
{
    id <SKUIPopupMenuDelegate> _delegate;
    UIButton *_menuButton;
    UILabel *_menuLabel;
    NSString *_menuLabelTitle;
    NSArray *_menuItemTitles;
    SKUIMenuViewController *_menuViewController;
    UIPopoverController *_menuPopoverController;
    long long _selectedMenuItemIndex;
    UILabel *_titleLabel;
}

@property(nonatomic) long long selectedMenuItemIndex; // @synthesize selectedMenuItemIndex=_selectedMenuItemIndex;
@property(copy, nonatomic) NSString *menuLabelTitle; // @synthesize menuLabelTitle=_menuLabelTitle;
@property(copy, nonatomic) NSArray *menuItemTitles; // @synthesize menuItemTitles=_menuItemTitles;
@property(nonatomic) __weak id <SKUIPopupMenuDelegate> delegate; // @synthesize delegate=_delegate;
- (void).cxx_destruct;
- (id)_titleLabel;
- (void)_reloadMenuButton;
- (void)_menuButtonAction:(id)arg1;
- (void)popoverControllerDidDismissPopover:(id)arg1;
- (void)menuViewController:(id)arg1 didSelectItemAtIndex:(long long)arg2;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;
- (void)setBackgroundColor:(id)arg1;
- (void)layoutSubviews;
@property(copy, nonatomic) NSString *title;
- (void)setColoringWithColorScheme:(id)arg1;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

