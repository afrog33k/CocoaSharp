/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

// Not exported
@interface GQDWPTextLabel : NSObject
{
    struct __CFString *mFormat;
    int mLabelType;
    int mFirst;
}

- (int)first;
- (int)labelType;
- (struct __CFString *)format;
- (void)dealloc;
- (int)readAttributesFromReader:(struct _xmlTextReader *)arg1;

@end

