/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class TSWPRep;

// Not exported
@interface TSWPBeginMagnificationUserInfo : NSObject
{
    TSWPRep *_target;
    struct CGPoint _magnificationPoint;
    struct CGPoint _offset;
    _Bool _animated;
}

@property(nonatomic) _Bool animated; // @synthesize animated=_animated;
@property(nonatomic) struct CGPoint offset; // @synthesize offset=_offset;
@property(nonatomic) struct CGPoint magnificationPoint; // @synthesize magnificationPoint=_magnificationPoint;
@property(nonatomic) TSWPRep *target; // @synthesize target=_target;
- (id).cxx_construct;

@end

