/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "UIActionSheetDelegate-Protocol.h"

@class ABPersonViewControllerHelper;

@interface ABPersonViewController_DeletionDelegate : NSObject <UIActionSheetDelegate>
{
    ABPersonViewControllerHelper *_controller;
}

- (void)alertView:(id)arg1 didDismissWithButtonIndex:(long long)arg2;
- (void)actionSheet:(id)arg1 clickedButtonAtIndex:(long long)arg2;
- (id)initWithPersonViewController:(id)arg1;

@end

