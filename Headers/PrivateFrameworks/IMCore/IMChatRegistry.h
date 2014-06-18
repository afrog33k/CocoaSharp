/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSFastEnumeration-Protocol.h"

@class IMTimer, NSArray, NSMutableArray, NSMutableDictionary, NSString;

@interface IMChatRegistry : NSObject <NSFastEnumeration>
{
    NSMutableArray *_allChats;
    NSMutableDictionary *_chatGUIDToCurrentThreadMap;
    NSMutableDictionary *_chatGUIDToInfoMap;
    NSMutableDictionary *_chatGUIDToChatMap;
    NSMutableDictionary *_threadNameToChatMap;
    NSMutableArray *_allChatsInThreadNameMap;
    NSMutableArray *_pendingQueries;
    NSMutableArray *_waitingForQueries;
    NSString *_historyModificationStamp;
    IMTimer *_markAsReadTimer;
    double _timerStartTimeInterval;
    _Bool _firstLoad;
    _Bool _loading;
    _Bool _daemonHadTerminated;
    _Bool _wantsHistoryReload;
    _Bool _postMessageSentNotifications;
    unsigned long long _defaultNumberOfMessagesToLoad;
    unsigned long long _daemonUnreadCount;
    long long _daemonLastFailedMessageID;
}

+ (Class)messageClass;
+ (void)setMessageClass:(Class)arg1;
+ (Class)chatClass;
+ (void)setChatClass:(Class)arg1;
+ (Class)chatRegistryClass;
+ (void)setChatRegistryClass:(Class)arg1;
+ (id)sharedInstance;
@property(nonatomic, setter=_setPostMessageSentNotifications:) _Bool _postMessageSentNotifications; // @synthesize _postMessageSentNotifications;
@property(readonly, nonatomic) _Bool _isLoading; // @synthesize _isLoading=_loading;
@property(nonatomic, setter=_setDefaultNumberOfMessagesToLoad:) unsigned long long _defaultNumberOfMessagesToLoad; // @synthesize _defaultNumberOfMessagesToLoad;
- (_Bool)_firstLoad;
- (void)systemApplicationDidResume;
- (void)_clearMarkAsReadTimerIfNecessary;
- (void)_startMarkAsReadTimerIfNecessary;
- (void)_blockUntilQueriesComplete:(id)arg1;
- (void)__blockUntilQueriesComplete;
- (id)_chatsWithMessage:(id)arg1;
- (id)_allGUIDsForChat:(id)arg1;
- (void)handleIMChatParticipantsDidChange:(id)arg1;
- (id)_chatForChatDictionary:(id)arg1 chatItems:(id)arg2 allowCreate:(_Bool)arg3 createdChat:(_Bool *)arg4 outGUID:(id *)arg5;
- (id)existingChatForRoom:(id)arg1 onAccount:(id)arg2 allowRetargeting:(_Bool)arg3;
- (id)existingChatForIMHandles:(id)arg1 allowRetargeting:(_Bool)arg2;
- (id)existingChatForIMHandle:(id)arg1 allowRetargeting:(_Bool)arg2;
- (id)existingChatForRoom:(id)arg1 onAccount:(id)arg2;
- (id)existingChatForIMHandles:(id)arg1;
- (id)existingChatForIMHandle:(id)arg1;
- (id)existingChatWithGUID:(id)arg1;
- (id)existingChatWithChatIdentifier:(id)arg1;
- (id)_lookupExistingChatWithIMHandle:(id)arg1;
- (id)_existingChatWithIdentifier:(id)arg1 style:(unsigned char)arg2 account:(id)arg3;
- (id)_existingChatWithIdentifier:(id)arg1 style:(unsigned char)arg2 service:(id)arg3;
@property(readonly, nonatomic) NSArray *allExistingChats;
@property(readonly, nonatomic) unsigned long long numberOfExistingChats;
- (_Bool)_hasChat:(id)arg1 forService:(id)arg2;
- (unsigned long long)countByEnumeratingWithState:(CDStruct_70511ce9 *)arg1 objects:(id *)arg2 count:(unsigned long long)arg3;
- (long long)lastFailedMessageID;
- (unsigned long long)unreadCount;
- (id)_createdChatForRoom:(id)arg1 onAccount:(id)arg2;
- (id)_createdChatForIMHandles:(id)arg1 style:(unsigned char)arg2;
- (id)_createdChatForIMHandle:(id)arg1;
- (id)_createdChatWithIdentifier:(id)arg1 style:(unsigned char)arg2 account:(id)arg3;
- (id)_allCreatedChats;
- (id)chatForRoom:(id)arg1 onAccount:(id)arg2;
- (id)chatForIMHandles:(id)arg1 chatName:(id)arg2;
- (id)chatForIMHandles:(id)arg1;
- (id)chatForIMHandle:(id)arg1;
- (void)_unregisterChatWithGUID:(id)arg1;
- (void)_unregisterChat:(id)arg1;
- (void)unregisterChatWithGUID:(id)arg1;
- (void)unregisterChat:(id)arg1;
- (void)_registerChat:(id)arg1 isIncoming:(_Bool)arg2 guid:(id)arg3;
- (void)_registerChatDictionary:(id)arg1 forChat:(id)arg2 isIncoming:(_Bool)arg3 newGUID:(id)arg4;
- (void)dealloc;
- (id)init;
- (id)_chatInstanceForGUID:(id)arg1;
- (void)_noteChatDealloc:(id)arg1;
- (void)_noteChatInit:(id)arg1;

@end

