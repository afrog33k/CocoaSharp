/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AddressBookUI/ABContactAction.h>

#import "ABNewPersonViewControllerDelegate-Protocol.h"

@class CNContact, UIViewController;

@interface ABContactCreateNewContactAction : ABContactAction <ABNewPersonViewControllerDelegate>
{
    CNContact *_createdContact;
    UIViewController *_presentingViewController;
}

@property(nonatomic) UIViewController *presentingViewController; // @synthesize presentingViewController=_presentingViewController;
@property(retain, nonatomic) CNContact *createdContact; // @synthesize createdContact=_createdContact;
- (void)newPersonViewController:(id)arg1 didCompleteWithNewPerson:(void *)arg2;
- (void)performActionWithSender:(id)arg1;
- (void)dealloc;

@end

