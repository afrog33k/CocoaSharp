/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSDictionary, NSObject<OS_dispatch_queue>;

@interface MCCloudConfiguration : NSObject
{
    NSObject<OS_dispatch_queue> *_memberQueue;
    NSDictionary *_memberQueueDetails;
}

+ (id)sharedConfiguration;
@property(retain, nonatomic) NSDictionary *memberQueueDetails; // @synthesize memberQueueDetails=_memberQueueDetails;
@property(retain, nonatomic) NSObject<OS_dispatch_queue> *memberQueue; // @synthesize memberQueue=_memberQueue;
- (void).cxx_destruct;
- (_Bool)isSupervised;
@property(copy, nonatomic) NSDictionary *details;
- (void)refreshDetailsFromDisk;
- (id)init;

@end
