/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCoding-Protocol.h"

@class NSString;

@interface MFOfflineTransferFailureSnapshot : NSObject <NSCoding>
{
    NSString *_originalRemoteID;
    NSString *_originalMailboxID;
    unsigned long long _originalMessageFlags;
}

@property(readonly, nonatomic) unsigned long long originalMessageFlags; // @synthesize originalMessageFlags=_originalMessageFlags;
@property(readonly, nonatomic) NSString *originalMailboxID; // @synthesize originalMailboxID=_originalMailboxID;
@property(readonly, nonatomic) NSString *originalRemoteID; // @synthesize originalRemoteID=_originalRemoteID;
- (id)description;
- (void)dealloc;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)initWithOriginalRemoteID:(id)arg1 mailboxID:(id)arg2 messageFlags:(unsigned long long)arg3;

@end

