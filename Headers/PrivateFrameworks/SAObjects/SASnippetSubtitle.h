/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <SAObjects/AceObject.h>

#import "SAAceSerializable-Protocol.h"

@class NSArray, NSString;

@interface SASnippetSubtitle : AceObject <SAAceSerializable>
{
}

+ (id)snippetSubtitleWithDictionary:(id)arg1 context:(id)arg2;
+ (id)snippetSubtitle;
@property(copy, nonatomic) NSString *text;
@property(copy, nonatomic) NSArray *regions;
- (id)encodedClassName;
- (id)groupIdentifier;

@end

