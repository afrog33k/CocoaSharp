/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/_UIRotatingActionSheet.h>

@class UIWebDocumentView;

@interface UIWebRotatingSheet : _UIRotatingActionSheet
{
    _Bool _wasDeferringCallbacks;
    UIWebDocumentView *_webBrowserView;
}

- (_Bool)presentSheet;
- (void)doneWithSheet;
- (void)dealloc;
- (void)_enableWebView;
- (void)_disableWebView;
- (id)initWithUIWebDocumentView:(id)arg1;

@end
