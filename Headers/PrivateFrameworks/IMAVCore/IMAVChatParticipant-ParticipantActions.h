/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <IMAVCore/IMAVChatParticipant.h>

@interface IMAVChatParticipant (ParticipantActions)
- (void)_connectTimeout:(id)arg1;
- (void)resetWaitingToConnectTimer;
- (void)setWaitingToConnect:(_Bool)arg1;
- (void)sendResponse:(unsigned int)arg1;
- (void)_sendResponse:(unsigned int)arg1 callInfo:(id)arg2;
- (void)cancelInvitation;
- (void)sendInvitation;
- (void)_reInitiate;
@end

