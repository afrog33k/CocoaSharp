/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <StoreServices/SSMetricsBaseEvent.h>

@class NSNumber, NSString;

@interface SSMetricsSearchEvent : SSMetricsBaseEvent
{
}

- (id)description;
@property(retain, nonatomic) NSString *searchTerm;
@property(retain, nonatomic) NSString *hintText;
@property(retain, nonatomic) NSNumber *hintIndex;
- (id)init;

@end

