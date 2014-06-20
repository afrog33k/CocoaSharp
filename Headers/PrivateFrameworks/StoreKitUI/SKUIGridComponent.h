/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <StoreKitUI/SKUIPageComponent.h>

@class NSArray;

@interface SKUIGridComponent : SKUIPageComponent
{
    NSArray *_children;
    struct SKUIEditorialStyle _editorialStyle;
    long long _gridType;
    struct SKUILockupStyle _lockupStyle;
    long long _missingItemCount;
    _Bool _showsIndexNumbers;
}

@property(readonly, nonatomic) struct SKUIEditorialStyle editorialStyle; // @synthesize editorialStyle=_editorialStyle;
@property(readonly, nonatomic) _Bool showsIndexNumbers; // @synthesize showsIndexNumbers=_showsIndexNumbers;
@property(readonly, nonatomic) struct SKUILockupStyle lockupStyle; // @synthesize lockupStyle=_lockupStyle;
@property(readonly, nonatomic) long long gridType; // @synthesize gridType=_gridType;
@property(readonly, nonatomic) NSArray *children; // @synthesize children=_children;
- (void).cxx_destruct;
- (id)description;
- (void)_reloadMissingItemCount;
- (id)_updateWithMissingItems:(id)arg1;
- (id)metricsElementName;
- (_Bool)isMissingItemData;
- (void)enumerateMissingItemIdentifiersFromIndex:(long long)arg1 usingBlock:(id)arg2;
- (long long)componentType;
- (id)initWithGridItems:(id)arg1;
- (id)initWithFeaturedContentContext:(id)arg1 kind:(long long)arg2;
- (id)initWithLockups:(id)arg1;
- (id)initWithCustomPageContext:(id)arg1;
- (id)initWithBrickItems:(id)arg1;

@end
