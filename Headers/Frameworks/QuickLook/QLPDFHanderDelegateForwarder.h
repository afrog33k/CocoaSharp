/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "UIWebPDFViewHandlerDelegate-Protocol.h"

@class UIWebView;

@interface QLPDFHanderDelegateForwarder : NSObject <UIWebPDFViewHandlerDelegate>
{
    id <NSObject><UIWebPDFViewHandlerDelegate> _delegate;
    UIWebView *_webView;
}

@property(nonatomic) UIWebView *webView; // @synthesize webView=_webView;
@property(nonatomic) id <NSObject><UIWebPDFViewHandlerDelegate> delegate; // @synthesize delegate=_delegate;
- (void)forwardInvocation:(id)arg1;
- (_Bool)respondsToSelector:(SEL)arg1;
- (id)methodSignatureForSelector:(SEL)arg1;

@end

