/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSArray, NSMutableArray, NSMutableIndexSet, NSString;

@interface SKUISearchResultGroup : NSObject
{
    NSMutableIndexSet *_editorialIndexSet;
    NSMutableArray *_entities;
    NSString *_groupKind;
}

@property(readonly, nonatomic) NSString *groupKind; // @synthesize groupKind=_groupKind;
- (void).cxx_destruct;
- (void)_setGroupKind:(id)arg1;
- (void)_addEntity:(id)arg1 withIdentifier:(id)arg2 type:(long long)arg3;
@property(readonly, nonatomic) long long numberOfEntities;
- (long long)entityTypeAtIndex:(long long)arg1;
- (id)entityAtIndex:(long long)arg1;
@property(readonly, nonatomic) NSArray *availableEntities;
- (id)init;

@end

