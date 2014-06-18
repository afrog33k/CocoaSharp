/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

// Not exported
@interface GQDPath : NSObject
{
    char *mPathString;
}

- (_Bool)horizontalFlip;
- (_Bool)verticalFlip;
- (_Bool)hasHorizontalFlip;
- (_Bool)hasVerticalFlip;
- (char *)pathStr;
- (struct CGPath *)createBezierPath;
- (_Bool)isRect;
- (_Bool)isRectangular;
- (void)dealloc;

@end

