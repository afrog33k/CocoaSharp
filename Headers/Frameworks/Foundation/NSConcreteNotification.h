/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <Foundation/NSNotification.h>

@class NSDictionary, NSString;

// Not exported
@interface NSConcreteNotification : NSNotification
{
    NSString *name;
    id object;
    NSDictionary *userInfo;
    _Bool dyingObject;
}

+ (id)newTempNotificationWithName:(id)arg1 object:(id)arg2 userInfo:(id)arg3;
- (void)recycle;
- (void)dealloc;
- (id)initWithName:(id)arg1 object:(id)arg2 userInfo:(id)arg3;
- (id)userInfo;
- (id)object;
- (id)name;

@end
