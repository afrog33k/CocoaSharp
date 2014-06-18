/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <CoreData/NSManagedObjectContext.h>

@interface NSManagedObjectContext (_NSInternalNotificationHandling)
- (void)_processReferenceQueue:(_Bool)arg1;
- (void)_processNotificationQueue;
- (void)_sendOrEnqueueNotification:(id)arg1 selector:(SEL)arg2;
- (id)_implicitObservationInfoForEntity:(id)arg1 forResultingClass:(Class *)arg2;
- (void)_processChangedStoreConfigurationNotification:(id)arg1;
- (void)_storeConfigurationChanged:(id)arg1;
- (void)_objectsChangedInStore:(id)arg1;
- (void)_unregisterForNotifications;
- (void)_registerForNotificationsWithCoordinator:(id)arg1;
- (void)_stopObservingUndoManagerNotifications;
- (void)_startObservingUndoManagerNotifications;
- (void)_enableChangeNotifications;
- (void)_disableChangeNotifications;
- (_Bool)_ignoringChangeNotifications;
- (void)_postObjectsDidChangeNotificationWithUserInfo:(id)arg1;
- (void)_processEndOfEventNotification:(id)arg1;
- (void)_enqueueEndOfEventNotification;
@end

