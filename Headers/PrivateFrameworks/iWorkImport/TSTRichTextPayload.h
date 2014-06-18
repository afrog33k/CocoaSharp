/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSPObject.h>

#import "TSPCopying-Protocol.h"

@class TSWPStorage;

// Not exported
@interface TSTRichTextPayload : TSPObject <TSPCopying>
{
    TSWPStorage *mStorage;
}

- (_Bool)requiresRichText;
- (id)string;
- (void)saveToArchiver:(id)arg1;
- (id)initFromUnarchiver:(id)arg1;
- (id)copyWithContext:(id)arg1;
- (void)dealloc;
- (id)initWithContext:(id)arg1 storage:(id)arg2;
- (id)initWithStorage:(id)arg1;
@property(retain, nonatomic) TSWPStorage *storage; // @synthesize storage=mStorage;

@end

