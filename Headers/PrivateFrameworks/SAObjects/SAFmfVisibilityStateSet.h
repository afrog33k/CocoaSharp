/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <SAObjects/SADomainCommand.h>

@interface SAFmfVisibilityStateSet : SADomainCommand
{
}

+ (id)visibilityStateSetWithDictionary:(id)arg1 context:(id)arg2;
+ (id)visibilityStateSet;
- (_Bool)requiresResponse;
@property(nonatomic) _Bool visible;
- (id)encodedClassName;
- (id)groupIdentifier;

@end

