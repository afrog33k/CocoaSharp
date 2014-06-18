/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITableViewCell.h"

@class SUCellConfiguration, SUItemOfferButton, SUTableCellContentView, UIBezierPath, UIColor;

@interface SUTableCell : UITableViewCell
{
    UIColor *_bottomBorderColor;
    SUTableCellContentView *_configurationView;
    unsigned int _hideHighlight:1;
    SUItemOfferButton *_itemOfferButton;
    CDStruct_3e55db63 _position;
    UIColor *_topBorderColor;
    long long _editState;
}

@property(nonatomic) long long editState; // @synthesize editState=_editState;
@property(retain, nonatomic) UIColor *topBorderColor; // @synthesize topBorderColor=_topBorderColor;
@property(nonatomic) CDStruct_3e55db63 position; // @synthesize position=_position;
@property(retain, nonatomic) UIColor *bottomBorderColor; // @synthesize bottomBorderColor=_bottomBorderColor;
@property(nonatomic) _Bool usesSubviews;
@property(nonatomic) _Bool showHighlight;
@property(nonatomic) _Bool highlightsOnlyContentView;
@property(nonatomic) _Bool drawAsDisabled;
@property(retain, nonatomic) SUCellConfiguration *configuration;
@property(nonatomic) int clipCorners;
@property(readonly, nonatomic) SUItemOfferButton *itemOfferButton;
@property(readonly, nonatomic) UIBezierPath *clippingPath;
- (void)setShowingDeleteConfirmation:(_Bool)arg1;
- (void)setSelected:(_Bool)arg1 animated:(_Bool)arg2;
- (void)setHighlighted:(_Bool)arg1 animated:(_Bool)arg2;
- (void)setEditing:(_Bool)arg1 animated:(_Bool)arg2;
- (void)layoutSubviews;
- (id)hitTest:(struct CGPoint)arg1 withEvent:(id)arg2;
- (void)drawRect:(struct CGRect)arg1;
- (_Bool)_canDrawContent;
- (id)copyPurchaseAnimationView;
- (void)dealloc;
- (id)initWithStyle:(long long)arg1 reuseIdentifier:(id)arg2;

@end

