/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"
#import "SSXPCCoding-Protocol.h"

@class NSArray, NSData, NSNumber, NSString;

@interface SSPlayInfoRequestContext : NSObject <SSXPCCoding, NSCopying>
{
    NSNumber *_accountIdentifier;
    NSNumber *_contentIdentifier;
    NSString *_playerGUID;
    NSData *_sic;
    NSArray *_sinfs;
}

@property(copy, nonatomic) NSArray *sinfs; // @synthesize sinfs=_sinfs;
@property(copy, nonatomic) NSData *SICData; // @synthesize SICData=_sic;
@property(copy, nonatomic) NSString *playerGUID; // @synthesize playerGUID=_playerGUID;
@property(copy, nonatomic) NSNumber *contentIdentifier; // @synthesize contentIdentifier=_contentIdentifier;
@property(copy, nonatomic) NSNumber *accountIdentifier; // @synthesize accountIdentifier=_accountIdentifier;
- (id)initWithXPCEncoding:(id)arg1;
- (id)copyXPCEncoding;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)dealloc;

@end

