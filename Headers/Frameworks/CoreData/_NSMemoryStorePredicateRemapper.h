/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSManagedObjectContext;

// Not exported
@interface _NSMemoryStorePredicateRemapper : NSObject
{
    NSManagedObjectContext *_context;
}

+ (id)defaultInstance;
- (void)visitPredicateExpression:(id)arg1;
- (void)visitPredicate:(id)arg1;
- (id)createPredicateForFetchFromPredicate:(id)arg1 withContext:(id)arg2;
- (id)createPredicateForFetchFromPredicate:(id)arg1;
- (void)dealloc;
- (id)initWithContext:(id)arg1;
- (id)init;

@end

