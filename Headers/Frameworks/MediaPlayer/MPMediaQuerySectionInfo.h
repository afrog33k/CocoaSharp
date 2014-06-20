/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"
#import "NSMutableCopying-Protocol.h"
#import "NSSecureCoding-Protocol.h"

@class NSArray;

@interface MPMediaQuerySectionInfo : NSObject <NSCopying, NSMutableCopying, NSSecureCoding>
{
    NSArray *_sections;
    NSArray *_sectionIndexTitles;
}

+ (_Bool)supportsSecureCoding;
@property(copy, nonatomic) NSArray *sectionIndexTitles; // @synthesize sectionIndexTitles=_sectionIndexTitles;
@property(readonly, nonatomic) NSArray *sections; // @synthesize sections=_sections;
- (void).cxx_destruct;
@property(readonly, nonatomic) unsigned long long count;
- (unsigned long long)indexOfSectionForSectionIndexTitleAtIndex:(unsigned long long)arg1;
- (id)mutableCopyWithZone:(struct _NSZone *)arg1;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)description;

@end
