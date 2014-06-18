/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <CoreDAV/CoreDAVTaskGroup.h>

#import "CoreDAVTaskDelegate-Protocol.h"

@class NSString, NSURL;

@interface CoreDAVContainerInfoSyncTaskGroup : CoreDAVTaskGroup <CoreDAVTaskDelegate>
{
    NSString *_previousSyncToken;
    NSURL *_containerURL;
}

- (id)copyContainerParserMappings;
- (Class)containerItemClass;
- (void)task:(id)arg1 didFinishWithError:(id)arg2;
- (void)startTaskGroup;
- (id)description;
- (void)dealloc;
@property(nonatomic) id <CoreDAVContainerInfoSyncProvider> delegate;
- (id)initWithContainerURL:(id)arg1 previousSyncToken:(id)arg2 accountInfoProvider:(id)arg3 taskManager:(id)arg4;

@end

