/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

@class NSArray, NSDictionary, NSNumber, NSURL;

@interface SSDictionaryResponse : NSObject <NSCopying>
{
    NSDictionary *_dictionary;
}

@property(readonly, nonatomic) NSDictionary *responseDictionary; // @synthesize responseDictionary=_dictionary;
- (id)_valueForProtocolKey:(id)arg1;
- (id)_copyAccount;
@property(readonly, nonatomic) NSURL *versionMismatchURL;
@property(readonly, nonatomic) NSArray *pingURLs;
@property(readonly, nonatomic, getter=isSupportedProtocolVersion) _Bool supportedProtocolVersion;
@property(readonly, nonatomic) NSNumber *failureType;
- (id)actionsWithActionType:(id)arg1;
@property(readonly, nonatomic) NSArray *actions;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)dealloc;
- (id)initWithResponseDictionary:(id)arg1;
- (id)init;

@end

