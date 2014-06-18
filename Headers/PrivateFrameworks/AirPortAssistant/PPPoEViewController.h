/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AirPortAssistant/AssistantSubUIViewController.h>

#import "TableViewManagerDelegate-Protocol.h"
#import "UINavigationControllerDelegate-Protocol.h"

@class PPPoEConnectionUIViewController, UIActivityIndicatorView, UILabel, UIView;

@interface PPPoEViewController : AssistantSubUIViewController <TableViewManagerDelegate, UINavigationControllerDelegate>
{
    UIView *tableHeaderContainerView;
    UIView *justTextContainerView;
    UILabel *justTextLabel;
    UIView *spinnerWithStatusAdjacentView;
    UIActivityIndicatorView *spinnerWithStatusAdjacentSpinner;
    UILabel *spinnerWithStatusAdjacentLabel;
    PPPoEConnectionUIViewController *pppoeConnectionUIViewController;
    id previousNavDelegate;
}

@property(nonatomic) UILabel *justTextLabel; // @synthesize justTextLabel;
@property(retain, nonatomic) UIView *spinnerWithStatusAdjacentView; // @synthesize spinnerWithStatusAdjacentView;
@property(retain, nonatomic) UIView *justTextContainerView; // @synthesize justTextContainerView;
@property(retain, nonatomic) UIView *tableHeaderContainerView; // @synthesize tableHeaderContainerView;
@property(retain) PPPoEConnectionUIViewController *pppoeConnectionUIViewController; // @synthesize pppoeConnectionUIViewController;
- (void)navigationController:(id)arg1 willShowViewController:(id)arg2 animated:(_Bool)arg3;
- (void)touchInCellAtIndexPath:(id)arg1;
- (_Bool)shouldChangeTextField:(id)arg1 atIndexPath:(id)arg2 forTextIndex:(unsigned long long)arg3 toString:(id)arg4;
- (id)valueForItemOfType:(id)arg1 atTypeIndex:(unsigned long long)arg2 inCellWithTag:(long long)arg3;
- (void)dealloc;
- (void)viewWillAppear:(_Bool)arg1;
- (void)viewDidLoad;
- (void)setupInitialTableHeaderConfiguration;

@end

