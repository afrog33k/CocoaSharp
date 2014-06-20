/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class MCProfile, NSArray, NSDictionary, NSString;

@interface MCPayload : NSObject
{
    MCProfile *_profile;
    NSString *_type;
    NSString *_payloadDescription;
    NSString *_displayName;
    NSString *_identifier;
    NSString *_organization;
    NSString *_UUID;
    long long _version;
    NSString *_persistentResourceID;
    _Bool _mustInstallNonInteractively;
}

+ (id)localizedPluralForm;
+ (id)localizedSingularForm;
+ (id)localizedParenthesizedFormDescriptionForPayloadCount:(unsigned long long)arg1;
+ (id)localizedDescriptionForPayloadCount:(unsigned long long)arg1;
+ (id)typeStrings;
@property(nonatomic) _Bool mustInstallNonInteractively; // @synthesize mustInstallNonInteractively=_mustInstallNonInteractively;
@property(retain, nonatomic) NSString *persistentResourceID; // @synthesize persistentResourceID=_persistentResourceID;
@property(readonly, nonatomic) long long version; // @synthesize version=_version;
@property(readonly, nonatomic) NSString *UUID; // @synthesize UUID=_UUID;
@property(readonly, nonatomic) NSString *organization; // @synthesize organization=_organization;
@property(readonly, nonatomic) NSString *identifier; // @synthesize identifier=_identifier;
@property(retain, nonatomic) NSString *displayName; // @synthesize displayName=_displayName;
@property(readonly, nonatomic) NSString *payloadDescription; // @synthesize payloadDescription=_payloadDescription;
@property(readonly, nonatomic) NSString *type; // @synthesize type=_type;
@property(readonly, nonatomic) MCProfile *profile; // @synthesize profile=_profile;
- (void).cxx_destruct;
- (id)subtitle2Description;
- (id)subtitle2Label;
- (id)subtitle1Description;
- (id)subtitle1Label;
- (id)title;
@property(readonly, nonatomic) NSArray *installationWarnings;
- (id)description;
@property(readonly, nonatomic) NSString *friendlyName;
@property(readonly, nonatomic) NSDictionary *restrictions;

@end
