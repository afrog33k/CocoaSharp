/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <SAObjects/SADomainCommand.h>

@class NSNumber, SAPersonAttribute;

@interface SAPhoneCall : SADomainCommand
{
}

+ (id)callWithDictionary:(id)arg1 context:(id)arg2;
+ (id)call;
- (_Bool)requiresResponse;
@property(nonatomic) _Bool faceTimeAudio;
@property(nonatomic) _Bool faceTime;
@property(copy, nonatomic) NSNumber *emergencyCall;
@property(retain, nonatomic) SAPersonAttribute *callRecipient;
- (id)encodedClassName;
- (id)groupIdentifier;

@end

