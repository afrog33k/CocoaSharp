/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSPredicate.h"

#import "EKDefaultPropertiesLoading-Protocol.h"

@interface EKNotifiableEventsPredicate : NSPredicate <EKDefaultPropertiesLoading>
{
}

+ (id)predicate;
- (id)defaultPropertiesToLoad;
- (_Bool)shouldLoadDefaultProperties;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (_Bool)evaluateWithObject:(id)arg1;

@end

