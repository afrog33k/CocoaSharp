/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSString;

// Not exported
@interface _LocalLibraryNotification : NSObject
{
    _Bool _isSourceExternal;
    NSString *_notificationName;
}

@property(nonatomic) _Bool isSourceExternal; // @synthesize isSourceExternal=_isSourceExternal;
@property(retain, nonatomic) NSString *notificationName; // @synthesize notificationName=_notificationName;
- (void).cxx_destruct;
- (id)initWithNotificationName:(id)arg1 isSourceExternal:(_Bool)arg2;

@end
