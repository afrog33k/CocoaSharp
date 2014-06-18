/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableDictionary, NSString;

@interface IDSPublicKeyCacheEntry : NSObject
{
    NSString *_fromURI;
    NSString *_forURI;
    NSString *_forService;
    NSMutableDictionary *_map;
}

@property(retain, nonatomic) NSMutableDictionary *map; // @synthesize map=_map;
@property(copy, nonatomic) NSString *forService; // @synthesize forService=_forService;
@property(copy, nonatomic) NSString *forURI; // @synthesize forURI=_forURI;
@property(copy, nonatomic) NSString *fromURI; // @synthesize fromURI=_fromURI;
- (void)dealloc;

@end

