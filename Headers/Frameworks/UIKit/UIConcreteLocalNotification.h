/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UILocalNotification.h>

@class NSCalendar, NSData, NSDate, NSString, NSTimeZone;

// Not exported
@interface UIConcreteLocalNotification : UILocalNotification
{
    NSDate *fireDate;
    NSTimeZone *timeZone;
    unsigned long long repeatInterval;
    NSCalendar *repeatCalendar;
    int totalRepeatCount;
    int remainingRepeatCount;
    NSString *alertBody;
    _Bool hasAction;
    NSString *alertAction;
    NSString *alertLaunchImage;
    NSString *soundName;
    long long applicationIconBadgeNumber;
    NSData *userInfoData;
    _Bool hideAlertTitle;
    _Bool allowSnooze;
    int soundType;
    _Bool interruptAudioAndLockDevice;
    _Bool resumeApplicationInBackground;
    _Bool fireNotificationsWhenAppRunning;
    _Bool showAlarmStatusBarItem;
    NSString *customLockSliderLabel;
    NSString *firedNotificationName;
    NSString *snoozedNotificationName;
    _Bool isSystemAlert;
}

- (void)setIsSystemAlert:(_Bool)arg1;
- (_Bool)isSystemAlert;
- (void)setSnoozedNotificationName:(id)arg1;
- (id)snoozedNotificationName;
- (void)setFiredNotificationName:(id)arg1;
- (id)firedNotificationName;
- (void)setCustomLockSliderLabel:(id)arg1;
- (id)customLockSliderLabel;
- (void)setShowAlarmStatusBarItem:(_Bool)arg1;
- (_Bool)showAlarmStatusBarItem;
- (void)setFireNotificationsWhenAppRunning:(_Bool)arg1;
- (_Bool)fireNotificationsWhenAppRunning;
- (void)setResumeApplicationInBackground:(_Bool)arg1;
- (_Bool)resumeApplicationInBackground;
- (void)setInterruptAudioAndLockDevice:(_Bool)arg1;
- (_Bool)interruptAudioAndLockDevice;
- (int)soundType;
- (void)setAllowSnooze:(_Bool)arg1;
- (_Bool)allowSnooze;
- (void)setHideAlertTitle:(_Bool)arg1;
- (_Bool)hideAlertTitle;
- (void)setRemainingRepeatCount:(int)arg1;
- (int)remainingRepeatCount;
- (int)totalRepeatCount;
- (void)setApplicationIconBadgeNumber:(long long)arg1;
- (long long)applicationIconBadgeNumber;
- (void)setSoundName:(id)arg1;
- (id)soundName;
- (void)setAlertLaunchImage:(id)arg1;
- (id)alertLaunchImage;
- (void)setAlertAction:(id)arg1;
- (id)alertAction;
- (void)setHasAction:(_Bool)arg1;
- (_Bool)hasAction;
- (void)setAlertBody:(id)arg1;
- (id)alertBody;
- (void)setRepeatCalendar:(id)arg1;
- (id)repeatCalendar;
- (void)setRepeatInterval:(unsigned long long)arg1;
- (unsigned long long)repeatInterval;
- (void)setTimeZone:(id)arg1;
- (id)timeZone;
- (void)setFireDate:(id)arg1;
- (id)fireDate;
- (void)clearNonSystemProperties;
- (_Bool)isValid;
- (id)nextFireDateAfterDate:(id)arg1 localTimeZone:(id)arg2;
- (id)nextFireDateForLastFireDate:(id)arg1;
- (id)description;
- (id)userInfo;
- (void)setUserInfo:(id)arg1;
- (void)_setUserInfoData:(id)arg1;
- (long long)compareFireDates:(id)arg1;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (void)dealloc;
- (id)init;
- (void)setTotalRepeatCount:(int)arg1;
- (void)setSoundType:(int)arg1;

@end

