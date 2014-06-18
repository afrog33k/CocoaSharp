/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "SBAlertItem.h"

#import "UIAlertViewDelegate-Protocol.h"

@class SBUserInstalledApplicationIcon;

@interface SBGameDeletionAlertItem : SBAlertItem <UIAlertViewDelegate>
{
    SBUserInstalledApplicationIcon *_icon;
}

- (_Bool)dismissOnLock;
- (_Bool)shouldShowInLockScreen;
- (void)configure:(_Bool)arg1 requirePasscodeForActions:(_Bool)arg2;
- (void)alertView:(id)arg1 clickedButtonAtIndex:(long long)arg2;
- (void)dealloc;
- (id)initWithIcon:(id)arg1;

@end

