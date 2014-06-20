/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "WAKView.h"

@class WebViewPrivate;

@interface WebView : WAKView
{
    WebViewPrivate *_private;
}

+ (void)registerViewClass:(Class)arg1 representationClass:(Class)arg2 forMIMEType:(id)arg3;
+ (void)registerURLSchemeAsLocal:(id)arg1;
+ (void)setMIMETypesShownAsHTML:(id)arg1;
+ (id)MIMETypesShownAsHTML;
+ (_Bool)canShowMIMETypeAsHTML:(id)arg1;
+ (_Bool)canShowMIMEType:(id)arg1;
+ (_Bool)_canShowMIMEType:(id)arg1 allowingPlugins:(_Bool)arg2;
+ (void)initialize;
- (id)previousValidKeyView;
- (id)currentNodeHighlight;
- (void)setCurrentNodeHighlight:(id)arg1;
- (_Bool)shouldUpdateWhileOffscreen;
- (void)setShouldUpdateWhileOffscreen:(_Bool)arg1;
- (_Bool)drawsBackground;
- (void)setDrawsBackground:(_Bool)arg1;
- (id)mainFrameDocument;
- (id)mainFrameIconURL;
- (id)mainFrameTitle;
- (_Bool)isLoading;
- (id)mainFrameURL;
- (void)setMainFrameURL:(id)arg1;
- (double)estimatedProgress;
- (id)groupName;
- (void)setGroupName:(id)arg1;
- (_Bool)searchFor:(id)arg1 direction:(_Bool)arg2 caseSensitive:(_Bool)arg3 wrap:(_Bool)arg4;
- (void)setNextKeyView:(id)arg1;
- (id)_webcore_effectiveFirstResponder;
- (_Bool)becomeFirstResponder;
- (_Bool)acceptsFirstResponder;
- (id)elementAtPoint:(struct CGPoint)arg1;
- (id)_elementAtWindowPoint:(struct CGPoint)arg1;
- (id)documentViewAtWindowPoint:(struct CGPoint)arg1;
- (id)hostWindow;
- (void)setHostWindow:(id)arg1;
- (id)userAgentForURL:(id)arg1;
- (struct String)_userAgentString;
- (id)windowScriptObject;
- (id)stringByEvaluatingJavaScriptFromString:(id)arg1;
- (id)customTextEncodingName;
- (id)_mainFrameOverrideEncoding;
- (void)setCustomTextEncodingName:(id)arg1;
- (_Bool)supportsTextEncoding;
- (id)mediaStyle;
- (void)setMediaStyle:(id)arg1;
- (id)customUserAgent;
- (void)setCustomUserAgent:(id)arg1;
- (id)applicationNameForUserAgent;
- (void)setApplicationNameForUserAgent:(id)arg1;
- (void)_resetZoom:(id)arg1 isTextOnly:(_Bool)arg2;
- (_Bool)_canResetZoom:(_Bool)arg1;
- (void)_zoomIn:(id)arg1 isTextOnly:(_Bool)arg2;
- (void)_zoomOut:(id)arg1 isTextOnly:(_Bool)arg2;
- (_Bool)_canZoomIn:(_Bool)arg1;
- (_Bool)_canZoomOut:(_Bool)arg1;
- (_Bool)_realZoomMultiplierIsTextOnly;
- (float)_realZoomMultiplier;
- (float)_zoomMultiplier:(_Bool)arg1;
- (void)_setZoomMultiplier:(float)arg1 isTextOnly:(_Bool)arg2;
- (float)textSizeMultiplier;
- (void)setTextSizeMultiplier:(float)arg1;
- (_Bool)goToBackForwardItem:(id)arg1;
- (_Bool)goForward;
- (_Bool)goBack;
- (void)setMaintainsBackForwardList:(_Bool)arg1;
- (id)backForwardList;
- (id)selectedFrame;
- (id)mainFrame;
- (id)frameLoadDelegate;
- (void)setFrameLoadDelegate:(id)arg1;
- (id)_frameLoadDelegateForwarder;
- (id)policyDelegate;
- (void)setPolicyDelegate:(id)arg1;
- (id)downloadDelegate;
- (void)setDownloadDelegate:(id)arg1;
- (id)resourceLoadDelegate;
- (void)setResourceLoadDelegate:(id)arg1;
- (id)_resourceLoadDelegateForwarder;
- (id)UIDelegate;
- (void)setUIDelegate:(id)arg1;
- (id)preferencesIdentifier;
- (void)setPreferencesIdentifier:(id)arg1;
- (id)preferences;
- (void)setPreferences:(id)arg1;
- (void)_updateScreenScaleFromWindow;
- (void)_wakWindowVisibilityChanged:(id)arg1;
- (void)_wakWindowScreenScaleChanged:(id)arg1;
- (void)viewDidMoveToWindow;
- (_Bool)shouldCloseWithWindow;
- (void)setShouldCloseWithWindow:(_Bool)arg1;
- (void)close;
- (void)finalize;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1 frameName:(id)arg2 groupName:(id)arg3;
- (id)initWithFrame:(struct CGRect)arg1;
- (id)_initWithArguments:(id)arg1;
- (_Bool)_isMIMETypeRegisteredAsPlugin:(id)arg1;
- (id)_pluginForExtension:(id)arg1;
- (id)_videoProxyPluginForMIMEType:(id)arg1;
- (id)_pluginForMIMEType:(id)arg1;
- (_Bool)_canShowMIMEType:(id)arg1;

@end
