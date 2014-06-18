/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSArray, NSMutableDictionary;

@interface SUAudioPlayerSessionManager : NSObject
{
    NSMutableDictionary *_sessions;
}

+ (id)sessionManager;
- (void)_audioPlayerStatusChangeNotification:(id)arg1;
- (id)startSessionWithURL:(id)arg1;
- (id)endSessionForURL:(id)arg1;
- (id)audioPlayerForURL:(id)arg1;
@property(readonly, nonatomic) NSArray *allSessionURLs;
- (void)dealloc;
- (id)init;

@end

