/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"
#import "NSFastEnumeration-Protocol.h"
#import "NSMutableCopying-Protocol.h"
#import "NSSecureCoding-Protocol.h"

@interface NSSet : NSObject <NSCopying, NSMutableCopying, NSSecureCoding, NSFastEnumeration>
{
}

+ (_Bool)supportsSecureCoding;
+ (id)setWithSet:(id)arg1;
+ (id)setWithSet:(id)arg1 copyItems:(_Bool)arg2;
+ (id)setWithOrderedSet:(id)arg1;
+ (id)setWithOrderedSet:(id)arg1 copyItems:(_Bool)arg2;
+ (id)setWithOrderedSet:(id)arg1 range:(struct _NSRange)arg2;
+ (id)setWithOrderedSet:(id)arg1 range:(struct _NSRange)arg2 copyItems:(_Bool)arg3;
+ (id)setWithArray:(id)arg1;
+ (id)setWithArray:(id)arg1 copyItems:(_Bool)arg2;
+ (id)setWithArray:(id)arg1 range:(struct _NSRange)arg2;
+ (id)setWithArray:(id)arg1 range:(struct _NSRange)arg2 copyItems:(_Bool)arg3;
+ (id)setWithObjects:(id)arg1;
+ (id)newSetWithObjects:(const id *)arg1 count:(unsigned long long)arg2;
+ (id)set;
+ (id)setWithObject:(id)arg1;
+ (id)setWithObjects:(const id *)arg1 count:(unsigned long long)arg2;
+ (id)allocWithZone:(struct _NSZone *)arg1;
- (id)setByAddingObjectsFromSet:(id)arg1;
- (id)setByAddingObjectsFromArray:(id)arg1;
- (id)setByAddingObject:(id)arg1;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)mutableCopyWithZone:(struct _NSZone *)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)initWithSet:(id)arg1;
- (id)initWithSet:(id)arg1 copyItems:(_Bool)arg2;
- (id)initWithOrderedSet:(id)arg1;
- (id)initWithOrderedSet:(id)arg1 copyItems:(_Bool)arg2;
- (id)initWithOrderedSet:(id)arg1 range:(struct _NSRange)arg2;
- (id)initWithOrderedSet:(id)arg1 range:(struct _NSRange)arg2 copyItems:(_Bool)arg3;
- (id)initWithArray:(id)arg1;
- (id)initWithArray:(id)arg1 copyItems:(_Bool)arg2;
- (id)initWithArray:(id)arg1 range:(struct _NSRange)arg2;
- (id)initWithArray:(id)arg1 range:(struct _NSRange)arg2 copyItems:(_Bool)arg3;
- (id)initWithObjects:(id)arg1;
- (id)initWithObject:(id)arg1;
- (id)initWithObjects:(const id *)arg1 count:(unsigned long long)arg2;
- (id)description;
- (id)descriptionWithLocale:(id)arg1;
- (id)descriptionWithLocale:(id)arg1 indent:(unsigned long long)arg2;
- (void)getObjects:(id *)arg1 range:(struct _NSRange)arg2;
- (_Bool)__getValue:(id *)arg1 forObj:(id)arg2;
- (void)__applyValues:(void *)arg1 context:(void *)arg2;
- (id)sortedArrayUsingComparator:(id)arg1;
- (id)sortedArrayWithOptions:(unsigned long long)arg1 usingComparator:(id)arg2;
- (id)objectsPassingTest:(id)arg1;
- (id)objectsWithOptions:(unsigned long long)arg1 passingTest:(id)arg2;
- (id)objectPassingTest:(id)arg1;
- (id)objectWithOptions:(unsigned long long)arg1 passingTest:(id)arg2;
- (id)members:(id)arg1 notFoundMarker:(id)arg2;
- (void)makeObjectsPerformSelector:(SEL)arg1 withObject:(id)arg2;
- (void)makeObjectsPerformSelector:(SEL)arg1;
- (_Bool)isSubsetOfSet:(id)arg1;
- (_Bool)isSubsetOfOrderedSet:(id)arg1;
- (_Bool)isEqual:(id)arg1;
- (_Bool)isEqualToSet:(id)arg1;
- (_Bool)intersectsSet:(id)arg1;
- (_Bool)intersectsOrderedSet:(id)arg1;
- (unsigned long long)hash;
- (void)getObjects:(id *)arg1;
- (void)getObjects:(id *)arg1 count:(unsigned long long)arg2;
- (void)enumerateObjectsUsingBlock:(id)arg1;
- (void)enumerateObjectsWithOptions:(unsigned long long)arg1 usingBlock:(id)arg2;
- (unsigned long long)countForObject:(id)arg1;
- (unsigned long long)countByEnumeratingWithState:(CDStruct_70511ce9 *)arg1 objects:(id *)arg2 count:(unsigned long long)arg3;
- (_Bool)containsObject:(id)arg1;
- (id)anyObject;
- (id)allObjects;
- (_Bool)isNSSet__;
- (unsigned long long)_cfTypeID;
- (id)objectEnumerator;
- (id)member:(id)arg1;
- (unsigned long long)count;

@end

