/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "_UISettings.h"

@interface SBAlertItemsSettings : _UISettings
{
    _Bool _disableBBHandlers;
    long long _testItemToken;
}

+ (id)newTestItemForToken:(long long)arg1;
+ (id)settingsControllerModule;
@property(nonatomic) long long testItemToken; // @synthesize testItemToken=_testItemToken;
@property(nonatomic) _Bool disableBBHandlers; // @synthesize disableBBHandlers=_disableBBHandlers;
- (void)setDefaultValues;

@end

