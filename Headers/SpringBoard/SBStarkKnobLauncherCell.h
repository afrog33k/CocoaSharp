/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITableViewCell.h"

#import "SBIconObserver-Protocol.h"

@class SBIcon, UIView<SBIconAccessoryView>;

@interface SBStarkKnobLauncherCell : UITableViewCell <SBIconObserver>
{
    SBIcon *_icon;
    UIView<SBIconAccessoryView> *_accessoryView;
    _Bool _showsDisclosureIndicator;
    id <SBStarkKnobLauncherCellDelegate> _delegate;
}

@property(nonatomic) id <SBStarkKnobLauncherCellDelegate> delegate; // @synthesize delegate=_delegate;
@property(nonatomic) _Bool showsDisclosureIndicator; // @synthesize showsDisclosureIndicator=_showsDisclosureIndicator;
- (void)iconAccessoriesDidUpdate:(id)arg1;
- (void)iconImageDidUpdate:(id)arg1;
- (void)setHighlighted:(_Bool)arg1 animated:(_Bool)arg2;
- (void)prepareForReuse;
- (void)layoutSubviews;
- (struct CGRect)_accessoryFrameInBounds:(struct CGRect)arg1;
@property(retain, nonatomic) SBIcon *icon;
- (void)dealloc;
- (id)initWithStyle:(long long)arg1 reuseIdentifier:(id)arg2;

@end
