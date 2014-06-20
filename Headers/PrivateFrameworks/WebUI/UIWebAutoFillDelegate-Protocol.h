/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol UIWebAutoFillDelegate <NSObject>
- (void)webBrowserView:(id)arg1 acceptedAutoFillWord:(id)arg2;
- (id)webBrowserView:(id)arg1 suggestionsForString:(id)arg2;
- (_Bool)hasCurrentSuggestionsForWebBrowserView:(id)arg1;
- (void)webBrowserView:(id)arg1 didFocusTextField:(id)arg2 inFrame:(id)arg3;
- (void)webBrowserView:(id)arg1 didEndEditingTextField:(id)arg2 inFrame:(id)arg3;
- (void)webBrowserView:(id)arg1 didBeginEditingTextField:(id)arg2 inFrame:(id)arg3;
- (void)webBrowserView:(id)arg1 willSubmitForm:(id)arg2 toFrame:(id)arg3 fromFrame:(id)arg4 withValues:(id)arg5 submissionHandler:(id)arg6;
- (void)webBrowserView:(id)arg1 preFillInFrame:(id)arg2;
- (void)autoFillInWebBrowserView:(id)arg1;
- (void)webBrowserView:(id)arg1 updateAutoFillButton:(id)arg2;
- (_Bool)webBrowserViewShouldShowAutoFillButton:(id)arg1;

@optional
- (id)titleOfAutoFillButtonInWebBrowserView:(id)arg1;
- (void)webBrowserView:(id)arg1 willSendSubmitEventToForm:(id)arg2 inFrame:(id)arg3 withValues:(id)arg4;
- (void)webBrowserView:(id)arg1 clearFormAutoFillStateForFrame:(id)arg2;
@end
