/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@interface PTPInitEventRequestPacket : NSObject
{
    unsigned int _connectionNumber;
}

- (void)setConnectionNumber:(unsigned int)arg1;
- (unsigned int)connectionNumber;
- (id)description;
- (id)contentForTCP;
- (id)initWithTCPBuffer:(void *)arg1;
- (id)initWithConnectionNumber:(unsigned int)arg1;

@end
