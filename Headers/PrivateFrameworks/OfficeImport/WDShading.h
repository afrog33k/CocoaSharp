/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

@class TSUColor;

// Not exported
@interface WDShading : NSObject <NSCopying>
{
    int mStyle;
    TSUColor *mForegroundColor;
    TSUColor *mBackgroundColor;
}

+ (id)autoBackgroundColor;
+ (id)autoForegroundColor;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)setBackground:(id)arg1;
- (id)background;
- (void)setForeground:(id)arg1;
- (id)foreground;
- (void)setStyle:(int)arg1;
- (int)style;
- (void)setShading:(id)arg1;
- (_Bool)isEqual:(id)arg1;
- (_Bool)isEqualToShading:(id)arg1;
- (void)dealloc;
- (id)init;

@end

