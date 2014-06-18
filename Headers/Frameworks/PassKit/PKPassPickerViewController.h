/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIViewController.h"

#import "UIScrollViewDelegate-Protocol.h"
#import "WLCardViewDelegate-Protocol.h"

@class NSArray, NSLayoutConstraint, PKPassLibrary, UINavigationBar, UIPageControl, UIScrollView;

@interface PKPassPickerViewController : UIViewController <UIScrollViewDelegate, WLCardViewDelegate>
{
    PKPassLibrary *_library;
    UINavigationBar *_navigationBar;
    UIScrollView *_passScrollView;
    NSArray *_passViews;
    NSLayoutConstraint *_scrollViewYConstraint;
    UIPageControl *_pageControl;
    long long _oldStatusBarStyle;
    NSArray *_passes;
    id <PKPassPickerViewControllerDelegate> _delegate;
}

+ (_Bool)_preventsAppearanceProxyCustomization;
@property(nonatomic) id <PKPassPickerViewControllerDelegate> delegate; // @synthesize delegate=_delegate;
@property(retain, nonatomic) NSArray *passes; // @synthesize passes=_passes;
- (_Bool)hidesBottomBarWhenPushed;
- (unsigned long long)supportedInterfaceOrientations;
- (long long)modalPresentationStyle;
- (void)_updatePageControl;
- (unsigned long long)_displayIndex;
- (_Bool)_passBacksAreTall;
- (_Bool)passViewBackGrowsCentered:(id)arg1;
- (void)passView:(id)arg1 flipButtonPressedForPass:(id)arg2;
- (void)scrollViewDidEndScrollingAnimation:(id)arg1;
- (void)scrollViewDidEndDecelerating:(id)arg1;
- (void)_setupPassViews;
- (void)_setupScrollViewYConstraintForTallPass:(_Bool)arg1;
- (double)_scrollViewYOffsetWithTallPass:(_Bool)arg1;
- (void)_pageControlChanged;
- (void)_handleHideNoDelegate;
- (void)cancel;
- (void)use;
- (void)viewWillDisappear:(_Bool)arg1;
- (void)viewWillAppear:(_Bool)arg1;
- (void)viewDidLoad;
- (void)dealloc;
- (id)initWithNibName:(id)arg1 bundle:(id)arg2;
- (id)init;
- (id)initWithPasses:(id)arg1;

@end

