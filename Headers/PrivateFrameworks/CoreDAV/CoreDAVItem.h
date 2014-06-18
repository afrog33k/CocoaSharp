/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import <CoreDAV/CoreDAVItem-Protocol.h>

@class NSData, NSMutableArray, NSMutableSet, NSString;

@interface CoreDAVItem : NSObject <CoreDAVItem>
{
    NSString *_name;
    NSString *_nameSpace;
    NSMutableSet *_attributes;
    NSMutableArray *_extraChildItems;
    NSData *_payload;
    _Bool _useCDATA;
}

+ (id)parseRuleCache;
+ (id)copyParseRules;
@property _Bool useCDATA; // @synthesize useCDATA=_useCDATA;
@property(retain) NSData *payload; // @synthesize payload=_payload;
@property(retain) NSMutableArray *extraChildItems; // @synthesize extraChildItems=_extraChildItems;
@property(retain) NSMutableSet *attributes; // @synthesize attributes=_attributes;
@property(retain) NSString *nameSpace; // @synthesize nameSpace=_nameSpace;
@property(retain) NSString *name; // @synthesize name=_name;
- (id)generateXMLString;
- (void)parserSuggestsBaseURL:(id)arg1;
- (void)setPayloadAsString:(id)arg1;
- (id)payloadAsString;
- (_Bool)validate;
- (void)write:(id)arg1;
- (id)childrenToWrite;
- (void)parserFoundAttributes:(id)arg1;
- (void)parserFoundPayload:(id)arg1;
- (void)parserFoundUnrecognizedElement:(id)arg1;
- (id)copyParseRules;
- (id)hashString;
- (id)description;
- (void)dealloc;
- (id)initWithNameSpace:(id)arg1 andName:(id)arg2;
- (id)init;

@end

