/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableDictionary, ODIState;

// Not exported
@interface ODIHierarchy : NSObject
{
    int mType;
    int mMaxMappableTreeDepth;
    ODIState *mState;
    NSMutableDictionary *mNodeInfoMap;
}

+ (_Bool)mapIdentifier:(id)arg1 state:(id)arg2;

@end

