/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "_UIViewServiceDeputyXPCInterface-Protocol.h"

@class NSXPCInterface;

// Not exported
@interface _UIViewServiceViewControllerDeputyXPCInterface : NSObject <_UIViewServiceDeputyXPCInterface>
{
    NSXPCInterface *_exportedInterface;
    NSXPCInterface *_remoteViewControllerInterface;
}

+ (id)interfaceWithExportedInterface:(id)arg1 remoteViewControllerInterface:(id)arg2;
- (SEL)connectionSelector;
- (id)connectionProtocol;
- (id)hostObjectInterface;
- (id)exportedInterface;
- (void)dealloc;

@end

