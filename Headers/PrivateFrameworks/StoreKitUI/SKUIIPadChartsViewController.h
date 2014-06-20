/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIViewController.h"

#import "SKUIItemListTableDelegate-Protocol.h"

@class NSArray, NSOperationQueue, SKUIClientContext, SKUIIPadChartsView, SKUIResourceLoader;

@interface SKUIIPadChartsViewController : UIViewController <SKUIItemListTableDelegate>
{
    SKUIResourceLoader *_artworkLoader;
    NSArray *_charts;
    SKUIIPadChartsView *_chartsView;
    NSArray *_chartViewControllers;
    SKUIClientContext *_clientContext;
    struct UIEdgeInsets _contentInset;
    id <SKUIChartsViewControllerDelegate> _delegate;
    _Bool _delegateWantsWillDisplay;
    NSOperationQueue *_operationQueue;
    long long _selectedChartIndex;
    long long _selectedItemIndex;
}

@property(nonatomic) __weak id <SKUIChartsViewControllerDelegate> delegate; // @synthesize delegate=_delegate;
@property(nonatomic) struct UIEdgeInsets contentInset; // @synthesize contentInset=_contentInset;
@property(retain, nonatomic) SKUIClientContext *clientContext; // @synthesize clientContext=_clientContext;
@property(copy, nonatomic) NSArray *charts; // @synthesize charts=_charts;
@property(retain, nonatomic) SKUIResourceLoader *artworkLoader; // @synthesize artworkLoader=_artworkLoader;
- (void).cxx_destruct;
- (id)_artworkContextForChart:(id)arg1;
- (long long)_visibleColumnCountForOrientation:(long long)arg1;
- (void)_setSuspended:(_Bool)arg1;
- (void)_reloadChartsView;
- (id)_itemListWithChart:(id)arg1;
- (void)itemList:(id)arg1 willDisplayCellForItem:(id)arg2 atIndexPath:(id)arg3;
- (void)itemList:(id)arg1 didSelectItem:(id)arg2 atIndexPath:(id)arg3;
- (id)itemList:(id)arg1 didConfirmItemOfferForItem:(id)arg2 atIndexPath:(id)arg3;
- (void)willRotateToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)viewWillAppear:(_Bool)arg1;
- (void)viewWillDisappear:(_Bool)arg1;
- (unsigned long long)supportedInterfaceOrientations;
- (void)loadView;
- (void)didRotateFromInterfaceOrientation:(long long)arg1;
- (void)unhideAllImages;
- (id)popImageViewForItemIndex:(long long)arg1 chartIndex:(long long)arg2;
- (void)loadNextPageOfArtworkWithReason:(long long)arg1;
- (struct CGRect)frameForItemIndex:(long long)arg1 chartIndex:(long long)arg2;
- (void)enumerateVisibleItemsUsingBlock:(id)arg1;
- (void)dealloc;
- (id)initWithNibName:(id)arg1 bundle:(id)arg2;

@end
