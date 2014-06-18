/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <WebKit/WebFrame.h>

@interface WebFrame (WebInternal)
+ (void)_createMainFrameWithSimpleHTMLDocumentWithPage:(struct Page *)arg1 frameView:(id)arg2 style:(id)arg3;
+ (PassRefPtr_4af616b4)_createSubframeWithOwnerElement:(struct HTMLFrameOwnerElement *)arg1 frameName:(const struct String *)arg2 frameView:(id)arg3;
+ (void)_createMainFrameWithPage:(struct Page *)arg1 frameName:(const struct String *)arg2 frameView:(id)arg3;
+ (PassRefPtr_4af616b4)_createFrameWithPage:(struct Page *)arg1 frameName:(const struct String *)arg2 frameView:(id)arg3 ownerElement:(struct HTMLFrameOwnerElement *)arg4;
- (void)_commitData:(id)arg1;
- (_Bool)_canSaveAsWebArchive;
- (_Bool)_canProvideDocumentSource;
- (void)_setTypingStyle:(id)arg1 withUndoAction:(int)arg2;
- (id)_typingStyle;
- (id)_characterRangeAtPoint:(struct CGPoint)arg1;
- (struct VisiblePosition)_visiblePositionForPoint:(struct CGPoint)arg1;
- (void)_insertParagraphSeparatorInQuotedContent;
- (void)_replaceSelectionWithNode:(id)arg1 selectReplacement:(_Bool)arg2 smartReplace:(_Bool)arg3 matchStyle:(_Bool)arg4;
- (id)_documentFragmentWithNodesAsParagraphs:(id)arg1;
- (id)_documentFragmentWithMarkupString:(id)arg1 baseURLString:(id)arg2;
- (id)_smartDeleteRangeForProposedRange:(id)arg1;
- (id)_markDOMRange;
- (struct _NSRange)_convertDOMRangeToNSRange:(id)arg1;
- (id)_convertNSRangeToDOMRange:(struct _NSRange)arg1;
- (PassRefPtr_d7fc6f43)_convertToDOMRange:(struct _NSRange)arg1;
- (struct _NSRange)_convertToNSRange:(struct Range *)arg1;
- (int)_selectionGranularity;
- (_Bool)_needsLayout;
- (void)_scrollDOMRangeToVisible:(id)arg1 withInset:(double)arg2;
- (void)_scrollDOMRangeToVisible:(id)arg1;
- (struct CGRect)_firstRectForDOMRange:(id)arg1;
- (struct CGRect)_caretRectAtPosition:(const struct Position *)arg1 affinity:(int)arg2;
- (id)_stringByEvaluatingJavaScriptFromString:(id)arg1 forceUserGesture:(_Bool)arg2;
- (id)_stringByEvaluatingJavaScriptFromString:(id)arg1;
- (_Bool)_getVisibleRect:(struct CGRect *)arg1;
- (void)_drawRect:(struct CGRect)arg1 contentsOnly:(_Bool)arg2;
- (_Bool)_shouldFlattenCompositingLayers:(struct CGContext *)arg1;
- (id)_stringForRange:(id)arg1;
- (id)_selectedString;
- (id)_markupStringFromRange:(id)arg1 nodes:(id *)arg2;
- (id)_nodesFromList:(Vector_ee76a023 *)arg1;
- (id)_stringWithDocumentTypeStringAndMarkupString:(id)arg1;
- (void)_setIsCommitting:(_Bool)arg1;
- (_Bool)_isCommitting;
- (id)_dataSource;
- (void)_clearSelectionInOtherFrames;
- (id)_findFrameWithSelection;
- (void)_clearSelection;
- (_Bool)_hasSelection;
- (void)_unmarkAllMisspellings;
- (void)_unmarkAllBadGrammar;
- (id)_internalLoadDelegate;
- (void)_setInternalLoadDelegate:(id)arg1;
- (void)_updateBackgroundAndUpdatesWhileOffscreen;
- (void)_clearCoreFrame;
- (id)_initWithWebFrameView:(id)arg1 webView:(id)arg2;
- (void)_detachScriptDebugger;
- (void)_attachScriptDebugger;
- (_Bool)_isIncludedInWebKitStatistics;
@end

