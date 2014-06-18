/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <SAObjects/SABaseClientBoundCommand.h>

@class NSArray, NSString, NSURL;

@interface SAStockAdd : SABaseClientBoundCommand
{
}

+ (id)addWithDictionary:(id)arg1 context:(id)arg2;
+ (id)add;
- (_Bool)requiresResponse;
@property(copy, nonatomic) NSString *tickerSymbol;
@property(copy, nonatomic) NSArray *stocks;
@property(copy, nonatomic) NSArray *stockReferences;
@property(copy, nonatomic) NSString *companyName;
@property(copy, nonatomic) NSURL *targetAppId;
- (id)encodedClassName;
- (id)groupIdentifier;

@end

