/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "CoreDAVLeafDataPayload.h"

#import "CalDAVCalendarItemProtocol-Protocol.h"

@class CalDAVCalendarServerScheduleChangesItem, CalDAVUpdateOwnerItem, NSString;

@interface CalDAVCalendarItemData : CoreDAVLeafDataPayload <CalDAVCalendarItemProtocol>
{
    NSString *_scheduleTag;
    CalDAVCalendarServerScheduleChangesItem *_scheduleChanges;
    CalDAVUpdateOwnerItem *_createdBy;
    CalDAVUpdateOwnerItem *_updatedBy;
}

@property(retain) CalDAVUpdateOwnerItem *updatedBy; // @synthesize updatedBy=_updatedBy;
@property(retain) CalDAVUpdateOwnerItem *createdBy; // @synthesize createdBy=_createdBy;
@property(retain) NSString *scheduleTag; // @synthesize scheduleTag=_scheduleTag;
@property(retain) CalDAVCalendarServerScheduleChangesItem *scheduleChanges; // @synthesize scheduleChanges=_scheduleChanges;
- (void)dealloc;

@end

