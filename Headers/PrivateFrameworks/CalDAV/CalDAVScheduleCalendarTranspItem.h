/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "CoreDAVItem.h"

@class CoreDAVItemWithNoChildren;

@interface CalDAVScheduleCalendarTranspItem : CoreDAVItem
{
    CoreDAVItemWithNoChildren *_transparent;
}

@property(retain) CoreDAVItemWithNoChildren *transparent; // @synthesize transparent=_transparent;
- (id)copyParseRules;
@property(readonly) _Bool isScheduleTransparent;
- (void)dealloc;
- (id)initWithNameSpace:(id)arg1 andName:(id)arg2;

@end

