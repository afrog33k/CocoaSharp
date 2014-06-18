/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSDContainerRep.h>

#import "TSDDecorator-Protocol.h"
#import "TSKHighlightArrayControllerProtocol-Protocol.h"
#import "TSKPulseAnimationControllerProtocol-Protocol.h"
#import "TSWPHyperlinkHostRepProtocol-Protocol.h"

@class CALayer, CAShapeLayer, NSArray, TSKHighlightArrayController, TSKPulseAnimationController, TSWPEditingController, TSWPLayout, TSWPSearchReference, TSWPSelection, TSWPStorage;

// Not exported
@interface TSWPRep : TSDContainerRep <TSKHighlightArrayControllerProtocol, TSKPulseAnimationControllerProtocol, TSWPHyperlinkHostRepProtocol, TSDDecorator>
{
    CALayer *_textLayers[2];
    CALayer *_caretLayer;
    CAShapeLayer *_selectionLineLayers[2];
    CAShapeLayer *_selectionHighlightLayer;
    CAShapeLayer *_selectionParagraphBorderLayer;
    CAShapeLayer *_markHighlightLayer;
    CAShapeLayer *_smartFieldHighlightLayer;
    CAShapeLayer *_secondaryHighlightLayer;
    struct _NSRange _secondaryHighlightRange;
    int _secondaryHighlightPathStyle;
    TSKHighlightArrayController *_pulseArrayController;
    TSKHighlightArrayController *_highlightArrayController;
    TSKPulseAnimationController *_caretPulseController;
    _Bool _caretAnimationDisabled;
    _Bool _suppressCaret;
    struct _NSRange _suppressedMisspellingRange;
    _Bool _updatingHighlights;
    _Bool _suppressSelectionHighlight;
    struct _NSRange _dragRange;
    TSWPSelection *_lastSelection;
    _Bool _selectionChanged;
    _Bool _markChanged;
    unsigned long long _newSelectionFlags;
    _Bool _repFieldsAreActive;
    _Bool _secondaryHighlightChanged;
    CALayer *_indentAnimationLayer;
    long long _indentDelta;
    SEL _indentSelector;
    id _indentTarget;
    _Bool _hudStateDirty;
    _Bool _invalidateHUDState;
    _Bool _useKeyboardWhenEditing;
    CALayer *_dragAndDropCaretLayer;
    TSWPSelection *_dropSelection;
    _Bool _findIsShowing;
    TSWPSearchReference *_activeSearchReference;
    NSArray *_searchReferences;
}

@property(retain, nonatomic) NSArray *searchReferences; // @synthesize searchReferences=_searchReferences;
@property(nonatomic) _Bool findIsShowing; // @synthesize findIsShowing=_findIsShowing;
@property(retain, nonatomic) TSWPSearchReference *activeSearchReference; // @synthesize activeSearchReference=_activeSearchReference;
@property(nonatomic) TSWPSelection *dropSelection; // @synthesize dropSelection=_dropSelection;
@property(nonatomic) struct _NSRange dragRange; // @synthesize dragRange=_dragRange;
@property(nonatomic, getter=isSelectionHighlightSuppressed) _Bool suppressSelectionHighlight; // @synthesize suppressSelectionHighlight=_suppressSelectionHighlight;
@property(nonatomic) _Bool useKeyboardWhenEditing; // @synthesize useKeyboardWhenEditing=_useKeyboardWhenEditing;
- (id).cxx_construct;
- (id)imageForSearchReference:(id)arg1 forPath:(struct CGPath *)arg2 shouldPulsate:(_Bool)arg3;
- (struct CGPath *)newPathForSearchReference:(id)arg1;
- (void)p_updateHighlights;
- (void)p_didDismissPopover:(id)arg1;
- (void)p_setSearchReferencesToHighlight:(id)arg1;
- (void)p_findUIStateChangedNotification:(id)arg1;
- (void)p_setActiveSearchReference:(id)arg1;
- (void)p_activeFindHighlightChangedNotification:(id)arg1;
- (void)p_setPulseControllerActive:(_Bool)arg1 autohide:(_Bool)arg2;
- (void)pulseAnimationDidStopForPulse:(id)arg1;
- (void)pulseAnimationDidStop:(id)arg1;
- (id)selectionForDragAndDropNaturalPoint:(struct CGPoint)arg1 dragIsTopicSelection:(_Bool)arg2;
@property(readonly, nonatomic) struct CGAffineTransform transformToConvertNaturalToScaledRoot;
- (struct CGColor *)p_caretLayerColor;
- (_Bool)p_hasEmptyList;
- (_Bool)p_hasVisibleContents;
- (void)p_editingDidEndNotification:(id)arg1;
- (void)p_markChangedNotification:(id)arg1;
- (void)p_selectionContentsChangedNotification:(id)arg1;
- (void)p_selectionChangedNotification:(id)arg1;
- (void)p_invalidateCommentKnobs;
- (void)didDrawInLayer:(id)arg1 context:(struct CGContext *)arg2;
- (void)p_updateSmartFieldHighlightLayer;
- (void)p_hideSmartFieldHighlightLayer;
- (void)p_createSmartFieldHighlightLayer;
- (void)p_updateMarkHighlightLayer;
- (void)p_hideMarkHighlightLayer;
- (void)p_createMarkHighlightLayer;
- (void)p_showSelectionParagraphBorderLayerWithPath:(struct CGPath *)arg1;
- (void)p_hideSelectionParagraphBorderLayer;
- (void)p_hideSelectionHighlightLayer;
- (void)p_createSelectionParagraphBorderLayer;
- (void)p_createSelectionHighlightLayer;
- (void)p_setSelectionHighlightColor;
- (void)p_setSelectionLineLayersHidden:(_Bool)arg1;
- (void)p_createSelectionLineLayers;
- (void)p_stopCaretLayerAnimation;
- (void)p_startCaretLayerAnimation;
- (void)p_hideCaretLayer;
- (void)p_showCaretLayer;
- (_Bool)p_positionCaretLayer:(id)arg1 forSelection:(id)arg2 layerRelative:(_Bool)arg3;
- (id)p_newCaretLayerWithZPosition:(double)arg1;
- (void)p_destroyLayer:(int)arg1;
- (void)p_createLayer:(int)arg1;
- (void)p_drawTextInLayer:(id)arg1 context:(struct CGContext *)arg2 limitSelection:(id)arg3 rubyGlyphRange:(struct _NSRange)arg4 renderMode:(int)arg5 suppressInvisibles:(_Bool)arg6;
- (void)p_teardown;
@property(readonly, nonatomic) _Bool textIsVertical;
- (struct CGRect)visibleBoundsForTilingLayer:(id)arg1;
- (id)actionForLayer:(id)arg1 forKey:(id)arg2;
- (void)drawLayer:(id)arg1 inContext:(struct CGContext *)arg2;
- (void)p_drawTextBackgroundLayerInContext:(struct CGContext *)arg1;
- (void)p_drawTextLayerInContext:(struct CGContext *)arg1;
- (void)i_setNeedsDisplayForSelectionChange;
- (void)p_updateForCurrentSelectionWithFlags:(unsigned long long)arg1;
- (void)i_setNeedsErasableDisplayInRange:(struct _NSRange)arg1;
- (void)p_hideSelectionLayers;
- (_Bool)p_isSelectionSingleAnchoredDrawableAttachment;
- (void)p_updateLayersForRangeSelection:(id)arg1 selectionFlags:(unsigned long long)arg2;
- (struct CGPoint)p_pinPoint:(struct CGPoint)arg1 toRect:(struct CGRect)arg2;
- (id)lineSearchReferencesForSearchReference:(id)arg1;
- (id)p_lineSelectionsForSelection:(id)arg1;
- (struct CGPath *)p_newSelectionPathForRange:(struct _NSRange)arg1 headKnobRect:(struct CGRect *)arg2 tailKnobRect:(struct CGRect *)arg3 selectionType:(int)arg4 selection:(id)arg5;
- (struct CGPath *)p_createPathForParagraphSelection:(id)arg1 needsParagraphBorder:(_Bool)arg2;
- (_Bool)p_paragraphModeBorderNeededForColumn:(id)arg1 dragCharIndex:(unsigned long long)arg2 knobTag:(unsigned long long)arg3;
- (struct CGRect)p_paragraphModeRectangleForColumn:(id)arg1 selection:(id)arg2;
- (void)p_updateAnimationWithAnimatingPulse:(_Bool)arg1;
- (void)editingDidEnd;
- (_Bool)doesNeedDisplayOnEditingDidEnd;
- (_Bool)isOverflowing;
- (id)textImageForRect:(struct CGRect)arg1;
- (id)textImageForSelection:(id)arg1 frame:(struct CGRect *)arg2 usingGlyphRect:(_Bool)arg3 shouldPulsate:(_Bool)arg4 suppressInvisibles:(_Bool)arg5;
- (id)p_imageForRect:(struct CGRect)arg1 usingGlyphRect:(_Bool)arg2 drawBackground:(_Bool)arg3 shouldPulsate:(_Bool)arg4 forCaret:(_Bool)arg5 drawSelection:(id)arg6 suppressInvisibles:(_Bool)arg7;
- (void)p_addRoundedRectToContext:(struct CGContext *)arg1 rect:(struct CGRect)arg2 forCaret:(_Bool)arg3;
- (void)p_addRectToContext:(struct CGContext *)arg1 rect:(struct CGRect)arg2;
- (void)p_updateLayersForInsertionPointSelection:(id)arg1;
- (struct CGRect)p_convertNaturalRectToRotated:(struct CGRect)arg1 repAngle:(double)arg2;
- (struct CGRect)glyphRectForRubyFieldAtCharIndex:(unsigned long long)arg1 glyphRange:(struct _NSRange)arg2;
- (unsigned long long)glyphCountForRubyFieldAtCharIndex:(unsigned long long)arg1;
- (unsigned long long)charCountOfGlyphStartingAtCharIndex:(unsigned long long)arg1;
- (struct CGRect)glyphRectForRange:(struct _NSRange)arg1 includingLabel:(_Bool)arg2;
- (struct CGRect)columnRectForRange:(struct _NSRange)arg1;
- (struct CGRect)labelRectForCharIndex:(unsigned long long)arg1;
- (id)decoratorOverlayLayers;
- (void)animateIndent:(long long)arg1 target:(id)arg2 action:(SEL)arg3;
- (void)p_indentAfterAnimationWithOptions:(id)arg1;
- (_Bool)shouldCreateTextKnobs;
- (_Bool)shouldCreateLockedKnobs;
- (_Bool)shouldCreateSelectionKnobs;
- (void)addKnobsToArray:(id)arg1;
@property(readonly, nonatomic) TSWPSelection *selection;
@property(readonly, nonatomic) NSArray *columns;
@property(readonly, nonatomic) TSWPStorage *storage;
- (_Bool)wantsToHandleTapsWhenLocked;
- (_Bool)wantsToHandleTapsOnContainingGroup;
- (id)hyperlinkRegions;
- (_Bool)handleSingleTapAtPoint:(struct CGPoint)arg1;
- (void)willDisplayEditHyperlinkUIForHyperlinkField:(id)arg1 beginEditing:(_Bool)arg2;
- (id)hyperlinkContainerRep;
- (id)repForDragging;
- (id)siblings;
- (id)repForCharIndex:(unsigned long long)arg1 isStart:(_Bool)arg2;
- (void)pulseCaret;
- (void)didEnterBackground;
- (void)willEnterForeground;
- (void)enableCaretAnimation;
- (void)viewScrollingEnded;
- (void)viewScaleDidChange;
- (void)disableCaretAnimation;
- (void)viewDidAppear;
- (void)gesturesDidEnd;
- (void)didEndZooming;
- (void)willBeginZooming;
@property(readonly, nonatomic) TSWPEditingController *textEditor;
- (_Bool)isEditing;
- (id)columnForCharIndex:(unsigned long long)arg1;
- (id)closestColumnForPoint:(struct CGPoint)arg1;
- (_Bool)shouldIgnoreSingleTapAtPoint:(struct CGPoint)arg1 withRecognizer:(id)arg2;
- (void)setHighlightedHyperlinkField:(id)arg1;
- (void)clearSecondaryHighlight;
- (void)setSecondaryHighlightRange:(struct _NSRange)arg1 color:(struct CGColor *)arg2 pathStyle:(int)arg3;
- (void)p_updateSecondaryHighlightLayer;
- (id)footnoteReferenceAttachmentAtPoint:(struct CGPoint)arg1;
- (id)footnoteMarkAttachmentAtPoint:(struct CGPoint)arg1;
- (id)rubyFieldAtPoint:(struct CGPoint)arg1;
- (id)smartFieldAtPoint:(struct CGPoint)arg1;
- (_Bool)canEditWithEditor:(id)arg1;
- (id)beginEditing;
- (Class)wpEditorClass;
- (_Bool)handlesEditMenu;
- (struct CGRect)newTextLayerUnscaledBounds:(struct CGRect)arg1 forNewTextBounds:(struct CGRect)arg2;
- (void)screenScaleDidChange;
- (void)didUpdateLayer:(id)arg1;
- (struct CGRect)clipRect;
- (struct CGRect)p_clipRect:(struct CGRect)arg1;
- (void)updateFromLayout;
- (void)invalidateHUDState;
- (void)addAdditionalChildLayersToArray:(id)arg1;
- (void)drawRubyInContext:(struct CGContext *)arg1 rubyFieldStart:(unsigned long long)arg2 rubyGlyphRange:(struct _NSRange)arg3;
- (void)drawInContext:(struct CGContext *)arg1 limitSelection:(id)arg2 suppressInvisibles:(_Bool)arg3;
- (void)drawInContext:(struct CGContext *)arg1;
- (void)drawInLayerContext:(struct CGContext *)arg1;
- (void)setNeedsDisplayInRect:(struct CGRect)arg1;
- (void)setNeedsDisplayInRange:(struct _NSRange)arg1;
- (void)setNeedsDisplay;
- (id)textBackgroundLayer;
- (id)textLayer;
- (void)performBlockOnTextLayers:(id)arg1;
- (int)dragTypeAtCanvasPoint:(struct CGPoint)arg1;
- (id)p_hyperlinkAtPoint:(struct CGPoint)arg1;
- (void)spellCheckingStateChanged;
- (void)verticalTextPropertyChanged;
- (int)tilingMode;
- (_Bool)directlyManagesLayerContent;
- (Class)layerClass;
- (unsigned long long)charIndexFromPoint:(struct CGPoint)arg1 allowPastBreak:(_Bool)arg2 allowNotFound:(_Bool)arg3 pastCenterGoesToNextChar:(_Bool)arg4 isAtEndOfLine:(_Bool *)arg5 leadingEdge:(_Bool *)arg6;
- (unsigned long long)charIndexFromPoint:(struct CGPoint)arg1 allowPastBreak:(_Bool)arg2 allowNotFound:(_Bool)arg3 isAtEndOfLine:(_Bool *)arg4 leadingEdge:(_Bool *)arg5;
- (unsigned long long)charIndexFromPoint:(struct CGPoint)arg1 allowPastBreak:(_Bool)arg2 isAtEndOfLine:(_Bool *)arg3;
- (unsigned long long)charIndexForPointWithPinning:(struct CGPoint)arg1 isTail:(_Bool)arg2 selectionType:(int)arg3;
- (unsigned long long)charIndexForPointWithPinning:(struct CGPoint)arg1;
- (double)knobOffsetForKnob:(id)arg1 paragraphMode:(_Bool)arg2;
- (struct CGPoint)knobCenterForSelection:(id)arg1 knob:(id)arg2;
- (struct CGRect)closestCaretRectForPoint:(struct CGPoint)arg1 inSelection:(_Bool)arg2;
- (struct CGRect)p_topicDragRectForSelection:(id)arg1;
- (struct CGRect)p_caretRectForSelection:(id)arg1;
- (struct CGRect)caretRectForSelection:(id)arg1;
- (CDStruct_7e4c5a1e)wordMetricsAtCharIndex:(unsigned long long)arg1;
- (CDStruct_50f584da)lineMetricsAtCharIndex:(unsigned long long)arg1;
- (CDStruct_50f584da)lineMetricsAtPoint:(struct CGPoint)arg1;
- (struct CGRect)caretRectForCharIndex:(unsigned long long)arg1 leadingEdge:(_Bool)arg2 caretAffinity:(int)arg3;
- (struct CGRect)caretRectForCharIndex:(unsigned long long)arg1 caretAffinity:(int)arg2;
- (struct CGRect)naturalBoundsRectForHyperlinkField:(id)arg1;
- (struct CGRect)rectForSelection:(id)arg1 includeRuby:(_Bool)arg2;
- (struct CGRect)rectForSelection:(id)arg1;
- (_Bool)isPointInSelectedArea:(struct CGPoint)arg1;
- (struct CGRect)selectionRect;
- (struct CGRect)caretRect;
- (struct CGPoint)pinToClosestColumn:(struct CGPoint)arg1;
- (struct CGPoint)pinToNaturalBounds:(struct CGPoint)arg1 andLastLineFragment:(_Bool)arg2;
- (struct _NSRange)range;
- (void)willBeRemoved;
- (void)dealloc;
- (id)initWithLayout:(id)arg1 canvas:(id)arg2;
- (_Bool)shouldShowKnobs;
- (_Bool)p_shouldDisplaySelectionControls;

// Remaining properties
@property(readonly, nonatomic) TSWPLayout *layout;

@end

