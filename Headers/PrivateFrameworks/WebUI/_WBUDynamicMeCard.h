/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableArray;

@interface _WBUDynamicMeCard : NSObject
{
    void *_me;
    NSMutableArray *_blocksPendingMeCard;
}

+ (int)_ABPropertyIDForString:(id)arg1;
+ (_Bool)isProxyProperty:(id)arg1;
- (void)performWhenReady:(id)arg1;
- (id)valueForProxyProperty:(id)arg1;
- (id)valueForProperty:(id)arg1 isMultiValue:(_Bool *)arg2;
- (void)_addressBookChanged:(id)arg1;
- (void)dealloc;
- (id)init;

@end

