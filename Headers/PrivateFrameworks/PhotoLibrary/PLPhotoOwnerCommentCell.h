/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITableViewCell.h"

@class NSAttributedString, UILabel, UIView;

@interface PLPhotoOwnerCommentCell : UITableViewCell
{
    NSAttributedString *_ownerString;
    UILabel *_ownerContentLabel;
    UIView *_styledSeparatorView;
}

+ (double)heightOfOwnerCellWithAsset:(id)arg1 forWidth:(double)arg2 forInterfaceOrientation:(long long)arg3;
+ (id)_ownerStringForAsset:(id)arg1;
@property(readonly, nonatomic) UIView *styledSeparatorView; // @synthesize styledSeparatorView=_styledSeparatorView;
@property(readonly, nonatomic) UILabel *ownerContentLabel; // @synthesize ownerContentLabel=_ownerContentLabel;
@property(copy, nonatomic) NSAttributedString *ownerString; // @synthesize ownerString=_ownerString;
- (void)layoutSubviews;
- (void)updateContentFromAsset:(id)arg1;
- (void)prepareForReuse;
- (void)dealloc;
- (id)initWithStyle:(long long)arg1 reuseIdentifier:(id)arg2;

@end

