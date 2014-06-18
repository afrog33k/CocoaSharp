/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class TSDEditableBezierPathSource, TSUPointerKeyDictionary;

// Not exported
@interface TSDEditableBezierPathSourceMorphInfo : NSObject
{
    TSDEditableBezierPathSource *mOriginal;
    TSDEditableBezierPathSource *mSmoothOriginal;
    TSUPointerKeyDictionary *mOriginalNodeIndexMapping;
}

@property(retain, nonatomic) TSDEditableBezierPathSource *smoothOriginal; // @synthesize smoothOriginal=mSmoothOriginal;
@property(retain, nonatomic) TSDEditableBezierPathSource *original; // @synthesize original=mOriginal;
- (id)originalSmoothNodeForNode:(id)arg1;
- (unsigned long long)originalNodeIndexForNode:(id)arg1;
- (unsigned long long)originalSubpathIndexForNode:(id)arg1;
- (id)originalNodeForNode:(id)arg1;
- (void)dealloc;
- (id)initWithEditableBezierPathSource:(id)arg1;

@end

