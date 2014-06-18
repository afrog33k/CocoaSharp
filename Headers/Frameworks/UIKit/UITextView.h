/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIScrollView.h>

#import "UIKeyboardInput-Protocol.h"
#import "UITextAutoscrolling-Protocol.h"
#import "UITextInput-Protocol.h"
#import "UITextInputControllerDelegate-Protocol.h"

@class NSAttributedString, NSDictionary, NSLayoutManager, NSString, NSTextContainer, NSTextStorage, UIAutoscroll, UIColor, UIFont, UITextInputController, UITextInputTraits, UITextInteractionAssistant, UITextPosition, UITextRange, UIView, _UITextContainerView, _UITextViewRestorableScrollPosition;

@interface UITextView : UIScrollView <UITextInputControllerDelegate, UITextAutoscrolling, UIKeyboardInput, UITextInput>
{
    id _private;
    NSTextStorage *_textStorage;
    NSTextContainer *_textContainer;
    NSLayoutManager *_layoutManager;
    _UITextContainerView *_containerView;
    id _inputDelegate;
    id <UITextInputTokenizer> _tokenizer;
    UITextInputController *_inputController;
    UITextInteractionAssistant *_interactionAssistant;
    UITextInputTraits *_textInputTraits;
    UIAutoscroll *_autoscroll;
    struct {
        unsigned int needsScrollToSelectionAfterLayout:1;
        unsigned int isInteractingWithLink:1;
        unsigned int linkInteractionIsLongPress:1;
        unsigned int editable:1;
        unsigned int reentrancyGuard:1;
        unsigned int usesExplicitPreferredMaxLayoutWidth:1;
        unsigned int determiningPreferredMaxLayoutWidth:1;
        unsigned int inSecondConstraintsPass:1;
        unsigned int interactiveSelectionDisabled:1;
        unsigned int selectable:1;
    } _tvFlags;
    id _linkInteractionItem;
    _UITextViewRestorableScrollPosition *_scrollTarget;
    struct CGPoint _scrollTargetOffset;
    unsigned long long _dataDetectorTypes;
    double _preferredMaxLayoutWidth;
    UIView *_inputAccessoryView;
    _Bool _clearsOnInsertion;
    UIView *_inputView;
}

+ (id)_bestInterpretationForDictationResult:(id)arg1;
+ (_Bool)_isCompatibilityTextView;
@property(readonly, nonatomic) NSTextStorage *textStorage; // @synthesize textStorage=_textStorage;
@property(readonly, nonatomic) NSLayoutManager *layoutManager; // @synthesize layoutManager=_layoutManager;
@property(readonly, nonatomic) NSTextContainer *textContainer; // @synthesize textContainer=_textContainer;
@property(retain) UIView *inputView; // @synthesize inputView=_inputView;
- (void)_resetDataDetectorsResults;
- (void)_startDataDetectors;
- (void)_cancelDataDetectors;
- (_Bool)_shouldStartDataDetectors;
- (unsigned long long)_effectiveDataDetectorTypes;
- (id)methodSignatureForSelector:(SEL)arg1;
- (_Bool)respondsToSelector:(SEL)arg1;
- (id)forwardingTargetForSelector:(SEL)arg1;
- (id)_textInputTraits;
- (id)metadataDictionariesForDictationResults;
- (void)_registerUndoOperationForReplacementWithActionName:(id)arg1 replacementText:(id)arg2;
- (void)_setDictationResult:(id)arg1 withCorrectionIdentifier:(id)arg2;
- (void)insertDictationResult:(id)arg1 withCorrectionIdentifier:(id)arg2;
- (_Bool)textInput:(id)arg1 shouldChangeCharactersInRange:(struct _NSRange)arg2 replacementText:(id)arg3;
- (id)automaticallySelectedOverlay;
- (void)keyboardInputChangedSelection:(id)arg1;
- (_Bool)keyboardInputChanged:(id)arg1;
- (_Bool)keyboardInputShouldDelete:(id)arg1;
- (_Bool)keyboardInput:(id)arg1 shouldInsertText:(id)arg2 isMarkedText:(_Bool)arg3;
- (_Bool)keyboardInput:(id)arg1 shouldReplaceTextInRange:(struct _NSRange)arg2 replacementText:(id)arg3;
- (void)_promptForReplace:(id)arg1;
- (void)replace:(id)arg1;
- (void)decreaseSize:(id)arg1;
- (void)increaseSize:(id)arg1;
- (void)_showTextStyleOptions:(id)arg1;
- (void)toggleUnderline:(id)arg1;
- (void)toggleItalics:(id)arg1;
- (void)toggleBoldface:(id)arg1;
- (void)makeTextWritingDirectionLeftToRight:(id)arg1;
- (void)makeTextWritingDirectionRightToLeft:(id)arg1;
- (void)selectAll:(id)arg1;
- (void)select:(id)arg1;
- (void)paste:(id)arg1;
- (_Bool)_isDisplayingShortcutViewController;
- (void)_addShortcut:(id)arg1;
- (void)_insertAttributedTextWithoutClosingTyping:(id)arg1;
- (void)_selectionMayChange:(id)arg1;
- (_Bool)_isDisplayingReferenceLibraryViewController;
- (void)_define:(id)arg1;
- (void)copy:(id)arg1;
- (void)cut:(id)arg1;
- (_Bool)canPerformAction:(SEL)arg1 withSender:(id)arg2;
- (void)cancelAutoscroll;
- (void)startAutoscroll:(struct CGPoint)arg1;
- (id)hitTest:(struct CGPoint)arg1 withEvent:(id)arg2;
@property(copy, nonatomic) NSDictionary *linkTextAttributes;
- (double)lineHeight;
- (void)setLineHeight:(double)arg1;
- (struct CGRect)visibleTextRect;
- (struct CGRect)visibleRect;
- (struct CGRect)visibleRectIgnoringKeyboard;
@property(nonatomic) struct UIEdgeInsets textContainerInset;
- (void)setMarginTop:(unsigned long long)arg1;
- (unsigned long long)marginTop;
- (void)setContentToHTMLString:(id)arg1;
- (id)webView;
@property(nonatomic) unsigned long long dataDetectorTypes;
- (void)disableClearsOnInsertion;
@property(nonatomic) _Bool clearsOnInsertion; // @synthesize clearsOnInsertion=_clearsOnInsertion;
- (void)setBecomesEditableWithGestures:(_Bool)arg1;
@property(nonatomic) struct _NSRange selectedRange;
@property(nonatomic) long long textAlignment;
@property(retain, nonatomic) UIColor *textColor;
@property(copy, nonatomic) NSString *text;
@property(retain, nonatomic) UIFont *font;
- (id)initWithFrame:(struct CGRect)arg1 font:(id)arg2;
- (void)textInputDidChangeSelection:(id)arg1;
- (void)textInputDidChange:(id)arg1;
- (void)setContinuousSpellCheckingEnabled:(_Bool)arg1;
@property(copy, nonatomic) NSDictionary *typingAttributes;
- (id)rangeWithTextAlternatives:(id *)arg1 atPosition:(id)arg2;
- (void)removeDictationResultPlaceholder:(id)arg1 willInsertResult:(_Bool)arg2;
- (struct CGRect)frameForDictationResultPlaceholder:(id)arg1;
- (id)insertDictationResultPlaceholder;
@property(nonatomic, getter=isSelectable) _Bool selectable;
@property(nonatomic, getter=isEditable) _Bool editable;
- (_Bool)_mightHaveSelection;
- (_Bool)isEditing;
- (id)characterRangeAtPoint:(struct CGPoint)arg1;
- (id)closestPositionToPoint:(struct CGPoint)arg1 withinRange:(id)arg2;
- (id)closestPositionToPoint:(struct CGPoint)arg1;
- (id)selectionRectsForRange:(id)arg1;
- (id)textStylingAtPosition:(id)arg1 inDirection:(long long)arg2;
- (struct CGRect)caretRectForPosition:(id)arg1;
- (struct CGRect)firstRectForRange:(id)arg1;
- (void)setBaseWritingDirection:(long long)arg1 forRange:(id)arg2;
- (long long)baseWritingDirectionForPosition:(id)arg1 inDirection:(long long)arg2;
@property(readonly, nonatomic) id <UITextInputTokenizer> tokenizer;
@property(nonatomic) id <UITextInputDelegate> inputDelegate;
- (id)undoManager;
- (id)characterRangeByExtendingPosition:(id)arg1 inDirection:(long long)arg2;
- (id)_textInputViewForAddingGestureRecognizers;
@property(readonly, nonatomic) UIView *textInputView;
- (id)positionWithinRange:(id)arg1 farthestInDirection:(long long)arg2;
- (long long)offsetFromPosition:(id)arg1 toPosition:(id)arg2;
- (long long)comparePosition:(id)arg1 toPosition:(id)arg2;
- (id)positionFromPosition:(id)arg1 inDirection:(long long)arg2 offset:(long long)arg3;
- (id)positionFromPosition:(id)arg1 offset:(long long)arg2;
- (id)textRangeFromPosition:(id)arg1 toPosition:(id)arg2;
@property(readonly, nonatomic) UITextPosition *endOfDocument;
@property(readonly, nonatomic) UITextPosition *beginningOfDocument;
- (void)unmarkText;
- (void)setMarkedText:(id)arg1 selectedRange:(struct _NSRange)arg2;
@property(copy, nonatomic) NSDictionary *markedTextStyle;
@property(readonly, nonatomic) UITextRange *markedTextRange;
@property(copy) UITextRange *selectedTextRange;
- (void)replaceRangeWithTextWithoutClosingTyping:(id)arg1 replacementText:(id)arg2;
- (void)replaceRange:(id)arg1 withText:(id)arg2;
- (id)textInRange:(id)arg1;
- (id)selectedText;
- (void)scrollSelectionToVisible:(_Bool)arg1;
- (void)_ensureSelectionVisible;
- (void)scrollRangeToVisible:(struct _NSRange)arg1;
- (void)_scrollRangeToVisible:(struct _NSRange)arg1 animated:(_Bool)arg2;
- (id)_restorableScrollPosition;
- (void)_restoreScrollPosition:(id)arg1 animated:(_Bool)arg2;
- (void)_setScrollTarget:(id)arg1;
- (struct _NSRange)_visibleRangeWithLayout:(_Bool)arg1;
- (struct CGPoint)_contentOffsetForScrollToVisible:(struct _NSRange)arg1;
- (struct CGRect)_rectForScrollToVisible:(struct _NSRange)arg1;
- (id)interactionAssistant;
- (id)selectionView;
- (void)updateSelection;
- (void)endSelectionChange;
- (void)beginSelectionChange;
- (void)deleteBackward;
- (void)insertText:(id)arg1;
- (_Bool)hasText;
@property(nonatomic, getter=_isInteractiveTextSelectionDisabled, setter=_setInteractiveTextSelectionDisabled:) _Bool interactiveTextSelectionDisabled;
- (void)setScrollEnabled:(_Bool)arg1;
- (void)setUsesTiledViews:(_Bool)arg1;
- (_Bool)usesTiledViews;
@property(nonatomic) _Bool allowsEditingTextAttributes;
- (_Bool)resignFirstResponder;
- (_Bool)canResignFirstResponder;
- (void)tintColorDidChange;
- (_Bool)becomeFirstResponder;
- (_Bool)canBecomeFirstResponder;
- (_Bool)_shouldScrollEnclosingScrollView;
- (void)_scrollSelectionToVisibleInContainingScrollView;
- (void)updateConstraints;
- (void)_setInSecondConstraintsPass:(_Bool)arg1;
- (void)_prepareForSecondIntrinsicContentSizeCalculationWithEngine:(id)arg1;
- (void)_prepareForFirstIntrinsicContentSizeCalculation;
- (void)nsis_valueOfVariable:(id)arg1 didChangeInEngine:(id)arg2;
- (_Bool)_needsDoubleUpdateConstraintsPass;
- (double)_currentPreferredMaxLayoutWidth;
- (struct CGSize)intrinsicContentSize;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;
- (struct CGSize)_intrinsicSizeWithinSize:(struct CGSize)arg1;
- (double)_preferredMaxLayoutWidth;
- (void)_setPreferredMaxLayoutWidth:(double)arg1;
- (void)setFrame:(struct CGRect)arg1;
- (void)setBounds:(struct CGRect)arg1;
- (void)layoutSubviews;
- (void)_resyncContainerFrameForNonAutolayout;
- (void)_scrollViewAnimationEnded:(id)arg1 finished:(_Bool)arg2;
- (void)_observedTextViewDidChange:(id)arg1;
- (unsigned long long)_totalNumberOfTextViewsInLayoutManager;
- (void)_textStorageDidProcessEditing:(id)arg1;
- (id)_containerView;
@property(copy, nonatomic) NSAttributedString *attributedText;
- (void)addTextAlternativesDisplayStyleToRange:(struct _NSRange)arg1;
@property(retain) UIView *inputAccessoryView;
- (void)dealloc;
- (void)_populateArchivedSubviews:(id)arg1;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)initReadonlyAndUnselectableWithFrame:(struct CGRect)arg1 textContainer:(id)arg2;
- (id)initWithFrame:(struct CGRect)arg1 textContainer:(id)arg2;
- (id)initWithFrame:(struct CGRect)arg1;
- (void)_commonInitWithTextContainer:(id)arg1 isDecoding:(_Bool)arg2 isEditable:(_Bool)arg3 isSelectable:(_Bool)arg4;

// Remaining properties
@property(nonatomic) long long autocapitalizationType; // @dynamic autocapitalizationType;
@property(nonatomic) long long autocorrectionType; // @dynamic autocorrectionType;
@property(nonatomic) id <UITextViewDelegate> delegate;
@property(nonatomic) _Bool enablesReturnKeyAutomatically; // @dynamic enablesReturnKeyAutomatically;
@property(nonatomic) long long keyboardAppearance; // @dynamic keyboardAppearance;
@property(nonatomic) long long keyboardType; // @dynamic keyboardType;
@property(nonatomic) long long returnKeyType; // @dynamic returnKeyType;
@property(nonatomic, getter=isSecureTextEntry) _Bool secureTextEntry; // @dynamic secureTextEntry;
@property(nonatomic) long long selectionAffinity;
@property(nonatomic) long long spellCheckingType; // @dynamic spellCheckingType;

@end

