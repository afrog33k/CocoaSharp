/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

// Not exported
@interface WebInspectorFrontend : NSObject
{
    struct WebInspectorFrontendClient *m_frontendClient;
}

- (void)showConsole;
- (void)setTimelineProfilingEnabled:(_Bool)arg1;
- (_Bool)isTimelineProfilingEnabled;
- (void)stopProfilingJavaScript;
- (void)startProfilingJavaScript;
- (_Bool)isProfilingJavaScript;
- (void)setDebuggingEnabled:(_Bool)arg1;
- (_Bool)isDebuggingEnabled;
- (void)detach;
- (void)attach;
- (id)initWithFrontendClient:(struct WebInspectorFrontendClient *)arg1;

@end

