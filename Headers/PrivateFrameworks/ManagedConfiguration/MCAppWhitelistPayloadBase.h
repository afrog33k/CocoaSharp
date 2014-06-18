/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <ManagedConfiguration/MCPayload.h>

@class NSArray;

@interface MCAppWhitelistPayloadBase : MCPayload
{
    _Bool _allowAccessWithoutPasscode;
    _Bool _forceAllowSupervisorAccess;
    NSArray *_whitelistedAppsAndOptions;
}

+ (id)knownUserEnabledOptionKeys;
+ (id)knownOptionsKeys;
@property(nonatomic) _Bool forceAllowSupervisorAccess; // @synthesize forceAllowSupervisorAccess=_forceAllowSupervisorAccess;
@property(nonatomic) _Bool allowAccessWithoutPasscode; // @synthesize allowAccessWithoutPasscode=_allowAccessWithoutPasscode;
@property(retain, nonatomic) NSArray *whitelistedAppsAndOptions; // @synthesize whitelistedAppsAndOptions=_whitelistedAppsAndOptions;
- (void).cxx_destruct;
- (id)description;
- (id)stubDictionary;
- (id)restrictions;
- (id)initWithDictionary:(id)arg1 profile:(id)arg2 outError:(id *)arg3;

@end

