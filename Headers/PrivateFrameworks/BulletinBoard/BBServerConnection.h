/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <BulletinBoard/BBXPCOutgoingConnection.h>

@interface BBServerConnection : BBXPCOutgoingConnection
{
    int _serverListeningToken;
}

- (void)_configureRemoteProxy;
- (void)connect;
- (void)invalidate;
- (void)dealloc;
- (id)initWithServiceName:(id)arg1 queue:(id)arg2 target:(id)arg3 remoteProtocol:(id)arg4;

@end

