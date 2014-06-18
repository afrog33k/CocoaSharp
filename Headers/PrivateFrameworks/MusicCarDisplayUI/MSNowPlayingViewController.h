/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIViewController.h"

#import "AFContextProvider-Protocol.h"
#import "MSNowPlayingViewDelegate-Protocol.h"
#import "MSTransportControlViewControllerDelegate-Protocol.h"
#import "UIPageViewControllerDataSource-Protocol.h"
#import "UIPageViewControllerDelegate-Protocol.h"

@class MPAVController, MSNowPlayingView, MSPlayModeControlViewController, MSTransportControlViewController, NSArray, UIButton, UIPageViewController, UITapGestureRecognizer;

@interface MSNowPlayingViewController : UIViewController <AFContextProvider, MSNowPlayingViewDelegate, UIPageViewControllerDataSource, UIPageViewControllerDelegate, MSTransportControlViewControllerDelegate>
{
    id <MSCarDisplayServiceProvider> _serviceProvider;
    MPAVController *_player;
    MSNowPlayingView *_nowPlayingView;
    MSTransportControlViewController *_transportControlViewController;
    MSPlayModeControlViewController *_playModeControlViewController;
    UIButton *_pageLeftButton;
    UIButton *_pageRightButton;
    UITapGestureRecognizer *_knobPressRecognizer;
    UITapGestureRecognizer *_knobBackPressRecognizer;
    double _wheelScrubVelocity;
    _Bool _viewAppeared;
    int _viewMode;
    UIPageViewController *_pageViewController;
    NSArray *_controlPages;
    unsigned long long _currentPageIndex;
}

@property(nonatomic) int viewMode; // @synthesize viewMode=_viewMode;
@property(nonatomic) unsigned long long currentPageIndex; // @synthesize currentPageIndex=_currentPageIndex;
@property(retain, nonatomic) NSArray *controlPages; // @synthesize controlPages=_controlPages;
@property(retain, nonatomic) UIPageViewController *pageViewController; // @synthesize pageViewController=_pageViewController;
- (void).cxx_destruct;
- (void)updateTrackInformation;
- (void)updatePageArrows;
- (void)_refreshSubViewsAndViewControllers;
- (void)_endWheelScrub;
- (void)_cancelWheelScrubEndTimer;
- (void)_restartWheelScrubEndTimer;
- (void)_wheelChangedWithEvent:(id)arg1;
- (void)_moveWithEvent:(id)arg1;
- (void)knobBackPressed:(id)arg1;
- (void)knobPressed:(id)arg1;
- (void)_pageLeftButtonTouchUpInside:(id)arg1;
- (void)_pageRightButtonTouchUpInside:(id)arg1;
- (void)nowPlayingView:(id)arg1 menuButtonTapped:(id)arg2;
- (void)nowPlayingView:(id)arg1 backButtonTapped:(id)arg2;
- (void)transportControlViewController:(id)arg1 infoButtonTapped:(id)arg2;
- (long long)presentationIndexForPageViewController:(id)arg1;
- (long long)presentationCountForPageViewController:(id)arg1;
- (id)pageViewController:(id)arg1 viewControllerAfterViewController:(id)arg2;
- (id)pageViewController:(id)arg1 viewControllerBeforeViewController:(id)arg2;
- (void)pageViewController:(id)arg1 didFinishAnimating:(_Bool)arg2 previousViewControllers:(id)arg3 transitionCompleted:(_Bool)arg4;
- (void)_playbackContentsChanged:(id)arg1;
- (void)_itemChanged:(id)arg1;
- (id)getCurrentContext;
- (_Bool)allowContextProvider:(id)arg1;
- (void)viewDidLayoutSubviews;
- (void)viewWillDisappear:(_Bool)arg1;
- (void)viewDidAppear:(_Bool)arg1;
- (void)viewWillAppear:(_Bool)arg1;
- (void)viewDidLoad;
- (void)dealloc;
- (id)initWithRadioStation:(id)arg1 player:(id)arg2 serviceProvider:(id)arg3;
- (id)initWithGeniusMixPlaylist:(id)arg1 player:(id)arg2 serviceProvider:(id)arg3;
- (id)initWithQueryToShuffle:(id)arg1 player:(id)arg2 serviceProvider:(id)arg3;
- (id)initWithQuery:(id)arg1 startingAtIndex:(unsigned long long)arg2 player:(id)arg3 serviceProvider:(id)arg4;
- (id)initWithPlayer:(id)arg1 serviceProvider:(id)arg2 startPlay:(_Bool)arg3;

@end

