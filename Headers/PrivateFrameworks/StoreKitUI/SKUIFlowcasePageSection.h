/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <StoreKitUI/SKUIStorePageSection.h>

#import "SKUIFlowcaseDelegate-Protocol.h"
#import "SKUIMissingItemDelegate-Protocol.h"

@class SKUIFlowcaseArtworkLoader, SKUIFlowcaseComponent, SKUIFlowcaseViewController, SKUIMissingItemLoader;

@interface SKUIFlowcasePageSection : SKUIStorePageSection <SKUIFlowcaseDelegate, SKUIMissingItemDelegate>
{
    SKUIFlowcaseArtworkLoader *_artworkLoader;
    SKUIFlowcaseViewController *_flowCaseViewController;
    SKUIMissingItemLoader *_missingItemLoader;
    _Bool _pinned;
    long long _rotationInterfaceOrientation;
}

- (void).cxx_destruct;
- (id)_missingItemLoader;
- (void)_loadMissingItemsFromIndex:(long long)arg1 withReason:(long long)arg2;
- (id)_flowCaseViewController;
- (id)_artworkLoader;
- (void)_addVisibleImpressionsToSession:(id)arg1;
- (void)missingItemLoader:(id)arg1 didLoadItems:(id)arg2;
- (void)flowcaseDidChangeVisibleViews:(id)arg1;
- (id)flowcase:(id)arg1 imageForItem:(id)arg2 index:(long long)arg3 orientation:(long long)arg4;
- (void)flowcase:(id)arg1 didSelectItem:(id)arg2 atIndex:(long long)arg3;
- (void)willRotateToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)restorePinnedHeaderView:(id)arg1;
- (void)prefetchResourcesWithReason:(long long)arg1;
- (id)popPinnedHeaderView;
- (long long)numberOfCells;
- (void)didRotateFromInterfaceOrientation:(long long)arg1;
- (struct CGSize)cellSizeForIndexPath:(id)arg1;
- (id)cellForIndexPath:(id)arg1;
- (void)willAppearInContext:(id)arg1;
- (void)addImpressionsForIndexPath:(id)arg1 toSession:(id)arg2;
- (void)dealloc;
- (id)initWithPageComponent:(id)arg1;

// Remaining properties
@property(readonly, nonatomic) SKUIFlowcaseComponent *pageComponent; // @dynamic pageComponent;

@end

