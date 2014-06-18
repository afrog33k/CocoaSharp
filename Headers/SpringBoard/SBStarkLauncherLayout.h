/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UICollectionViewLayout.h"

@class NSArray;

@interface SBStarkLauncherLayout : UICollectionViewLayout
{
    id <SBStarkLauncherLayoutDelegate> _delegate;
    unsigned long long _numberOfItems;
    struct CGSize _itemSize;
    NSArray *_attributesByItem;
    _Bool _layoutForScrollButtons;
    struct UIEdgeInsets _scrollButtonInsets;
}

+ (Class)layoutAttributesClass;
+ (double)desiredItemHeightForWidth:(double)arg1;
@property(readonly, nonatomic) struct UIEdgeInsets scrollButtonInsets; // @synthesize scrollButtonInsets=_scrollButtonInsets;
@property(nonatomic) id <SBStarkLauncherLayoutDelegate> delegate; // @synthesize delegate=_delegate;
- (struct CGSize)collectionViewContentSize;
- (id)layoutAttributesForItemAtIndexPath:(id)arg1;
- (id)layoutAttributesForElementsInRect:(struct CGRect)arg1;
- (void)prepareLayout;
@property(nonatomic) _Bool layoutForScrollButtons;
@property(nonatomic) double itemHeight;
- (void)dealloc;

@end

