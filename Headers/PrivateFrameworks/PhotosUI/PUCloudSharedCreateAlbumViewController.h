/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIViewController.h"

@class NSArray, NSString, PUPhotoStreamRecipientViewController, UINavigationItem;

@interface PUCloudSharedCreateAlbumViewController : UIViewController
{
    UINavigationItem *_navItem;
    PUPhotoStreamRecipientViewController *_composeRecipientController;
    id <PUCloudSharedCreateAlbumViewControllerDelegate> _delegate;
    NSString *_nextButtonTitle;
    NSArray *__albumRecipients;
}

@property(retain, nonatomic, setter=_setAlbumRecipients:) NSArray *_albumRecipients; // @synthesize _albumRecipients=__albumRecipients;
@property(retain, nonatomic) NSString *nextButtonTitle; // @synthesize nextButtonTitle=_nextButtonTitle;
@property(nonatomic) __weak id <PUCloudSharedCreateAlbumViewControllerDelegate> delegate; // @synthesize delegate=_delegate;
- (void).cxx_destruct;
- (struct CGSize)contentSizeForViewInPopover;
- (id)navigationItem;
- (void)composeRecipientViewControllerRecipientContainerViewDidResize:(id)arg1 fromFrame:(struct CGRect)arg2 toFrame:(struct CGRect)arg3;
- (void)alertView:(id)arg1 didDismissWithButtonIndex:(long long)arg2;
- (_Bool)_validateRecipientsToAdd:(id)arg1;
- (void)_saveUserEnterredInfo;
- (void)_doneAction:(id)arg1;
- (void)_cancelAction:(id)arg1;
- (void)_handleCompletionWithSuccess:(_Bool)arg1;
@property(readonly, nonatomic) NSArray *albumRecipients;
- (_Bool)shouldAutorotateToInterfaceOrientation:(long long)arg1;
- (void)loadView;
- (void)dealloc;
- (id)init;

@end

