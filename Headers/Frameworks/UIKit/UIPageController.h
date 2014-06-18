/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIViewController.h>

@class NSMutableArray, UIPageControl, UIScrollView, UIView;

@interface UIPageController : UIViewController
{
    NSMutableArray *_viewControllers;
    UIView *_wrapperViews[3];
    int _notificationState[3];
    UIScrollView *_scrollView;
    UIPageControl *_pageControl;
    id <UIPageControllerDelegate> _delegate;
    int _pageSpacing;
    long long _visibleIndex;
    long long _pageCount;
    struct {
        unsigned int delegateViewControllerAtIndex:1;
        unsigned int delegateWillBeginPaging:1;
        unsigned int delegateDidEndPaging:1;
        unsigned int displaysPageControl:1;
        unsigned int wraps:1;
    } _pageControllerFlags;
}

@property(nonatomic) id <UIPageControllerDelegate> delegate; // @synthesize delegate=_delegate;
- (void)viewDidDisappear:(_Bool)arg1;
- (void)viewWillDisappear:(_Bool)arg1;
- (void)viewDidAppear:(_Bool)arg1;
- (void)viewWillAppear:(_Bool)arg1;
- (void)didRotateFromInterfaceOrientation:(long long)arg1;
- (void)willAnimateSecondHalfOfRotationFromInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)didAnimateFirstHalfOfRotationToInterfaceOrientation:(long long)arg1;
- (void)willAnimateFirstHalfOfRotationToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)willAnimateRotationToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)willRotateToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)_getRotationContentSettings:(CDStruct_010f855d *)arg1;
- (_Bool)_shouldUseOnePartRotation;
- (id)rotatingFooterView;
- (id)rotatingHeaderView;
- (_Bool)_isSupportedInterfaceOrientation:(long long)arg1;
- (_Bool)shouldAutorotateToInterfaceOrientation:(long long)arg1;
- (_Bool)_doesVisibleViewControllerSupportInterfaceOrientation:(long long)arg1;
- (_Bool)_allowsAutorotation;
- (long long)indexOfViewController:(id)arg1;
@property(nonatomic) _Bool displaysPageControl;
- (void)_createPageControl;
- (void)_pageChanged:(id)arg1;
@property(nonatomic) _Bool wraps;
@property(nonatomic) long long pageCount;
@property(nonatomic) long long visibleIndex;
- (void)setVisibleIndex:(long long)arg1 animated:(_Bool)arg2;
- (struct CGRect)_scrollViewFrame;
- (void)_scrollViewDidScroll:(id)arg1 forceUpdate:(_Bool)arg2;
- (void)_scrollView:(id)arg1 boundsDidChangeToSize:(struct CGSize)arg2;
- (void)_adjustScrollViewContentInsets;
- (void)_scrollViewDidEndPaging;
- (void)_scrollViewWillBeginPaging;
- (void)_notifyNextViewController:(int)arg1 animated:(_Bool)arg2;
- (void)_notifyVisibleViewController:(int)arg1 animated:(_Bool)arg2;
- (void)_notifyPreviousViewController:(int)arg1 animated:(_Bool)arg2;
- (int)_nextViewControllerNotificationState;
- (int)_visibleViewControllerNotificationState;
- (int)_previousViewControllerNotificationState;
- (void)_setNextViewControllerNotificationState:(int)arg1;
- (void)_setVisibleViewControllerNotificationState:(int)arg1;
- (void)_setPreviousViewControllerNotificationState:(int)arg1;
- (void)_notifyViewController:(id)arg1 ofState:(int)arg2 previousState:(int)arg3 animated:(_Bool)arg4;
@property(readonly, nonatomic) UIViewController *visibleViewController;
- (_Bool)_hasNextViewController;
- (_Bool)_hasVisibleViewController;
- (_Bool)_hasPreviousViewController;
- (id)_nextViewController;
- (id)_visibleViewController;
- (id)_previousViewController;
- (id)_loadNextViewController;
- (id)_loadVisibleViewControllerAndNotify:(_Bool)arg1;
- (id)_loadPreviousViewController;
- (_Bool)_needToLoadNext;
- (_Bool)_needToLoadVisible;
- (_Bool)_needToLoadPrevious;
- (void)_setNextViewController:(id)arg1;
- (void)_setVisibleViewController:(id)arg1;
- (void)_setPreviousViewController:(id)arg1;
- (void)_replaceViewControllerAtIndex:(long long)arg1 withViewController:(id)arg2;
- (_Bool)_isViewControllerBeingUnloaded:(id)arg1 atIndex:(long long)arg2;
- (id)_scrollView;
@property(nonatomic) double pageSpacing;
- (void)viewDidUnload;
- (void)loadView;
- (void)dealloc;

@end

