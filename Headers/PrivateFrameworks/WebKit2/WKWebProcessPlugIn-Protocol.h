/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol WKWebProcessPlugIn <NSObject>

@optional
- (void)webProcessPlugInInitialize:(id)arg1;
- (void)webProcessPlugIn:(id)arg1 willDestroyBrowserContextController:(id)arg2;
- (void)webProcessPlugIn:(id)arg1 didCreateBrowserContextController:(id)arg2;
- (void)webProcessPlugIn:(id)arg1 initializeWithObject:(id)arg2;
@end

