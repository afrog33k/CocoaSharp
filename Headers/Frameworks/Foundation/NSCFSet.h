/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSMutableSet.h"

// Not exported
@interface NSCFSet : NSMutableSet
{
}

+ (_Bool)automaticallyNotifiesObserversForKey:(id)arg1;
- (void)setSet:(id)arg1;
- (void)unionSet:(id)arg1;
- (void)minusSet:(id)arg1;
- (void)getObjects:(id *)arg1;
- (void)removeAllObjects;
- (void)removeObject:(id)arg1;
- (void)addObject:(id)arg1;
- (id)objectEnumerator;
- (unsigned long long)countByEnumeratingWithState:(CDStruct_70511ce9 *)arg1 objects:(id *)arg2 count:(unsigned long long)arg3;
- (unsigned long long)_trueCount;
- (id)member:(id)arg1;
- (unsigned long long)count;
- (id)mutableCopyWithZone:(struct _NSZone *)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (Class)classForCoder;
- (void)finalize;
- (_Bool)_isDeallocating;
- (_Bool)_tryRetain;
- (unsigned long long)retainCount;
- (oneway void)release;
- (id)retain;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;

@end

