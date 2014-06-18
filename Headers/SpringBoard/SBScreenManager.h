/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSHashTable, NSMapTable;

@interface SBScreenManager : NSObject
{
    NSHashTable *_handlers;
    NSMapTable *_screenIDToHandlerMap;
    NSMapTable *_screenIDToObserversMap;
    NSMapTable *_screenIDToSuppressionReasonsMap;
    NSMapTable *_screenIDToMainWindowMap;
    NSMapTable *_screenIDToScreenMap;
    NSHashTable *_connectedScreenIDs;
}

+ (id)sharedInstance;
- (void)setMainWindow:(id)arg1 forScreen:(id)arg2;
- (void)addConnectionHandler:(id)arg1;
- (_Bool)isScreenSuppressed:(id)arg1;
- (_Bool)isScreenConnected:(id)arg1;
- (id)mainWindowForScreen:(id)arg1;
- (id)screenWithID:(unsigned int)arg1;
- (void)removeSuppressionReason:(id)arg1 forScreen:(id)arg2;
- (void)addSuppressionReason:(id)arg1 forScreen:(id)arg2;
- (void)removeScreenObserver:(id)arg1 forScreen:(id)arg2;
- (void)addScreenObserver:(id)arg1 forScreen:(id)arg2;
- (void)_screenDidDisconnect:(id)arg1;
- (void)_screenDidConnect:(id)arg1;
- (void)_updateHandlerForConnectionToScreen:(id)arg1;
- (void)dealloc;
- (id)init;

@end

