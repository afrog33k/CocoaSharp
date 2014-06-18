/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITextInput-Protocol.h"
#import "UITextInputTokenizer-Protocol.h"
#import "UITextInputTraits_Private-Protocol.h"

@class UITextInteractionAssistant;

@protocol UITextInputPrivate <UITextInput, UITextInputTokenizer, UITextInputTraits_Private>
@property(readonly, nonatomic) UITextInteractionAssistant *interactionAssistant;
- (_Bool)hasSelection;
- (void)selectAll;
- (_Bool)hasContent;
- (struct _NSRange)selectionRange;
- (id)textInputTraits;

@optional
+ (void)_preheatDictationIfNecessary;
@property(nonatomic) long long selectionGranularity;
- (void)_insertAttributedTextWithoutClosingTyping:(id)arg1;
- (id)fontForCaretSelection;
- (id)textColorForCaretSelection;
- (void)replaceRangeWithTextWithoutClosingTyping:(id)arg1 replacementText:(id)arg2;
- (_Bool)_shouldRepeatInsertText:(id)arg1;
- (double)_delayUntilRepeatInsertText:(id)arg1;
- (_Bool)isAutoFillMode;
- (void)acceptedAutoFillWord:(id)arg1;
- (id)_dictationLanguage;
- (void)_stopDictation;
- (void)_startDictation;
- (void)dictationRecordingDidBegin;
- (id)rangeWithTextAlternatives:(id *)arg1 atPosition:(id)arg2;
- (id)metadataDictionariesForDictationResults;
- (void)insertDictationResult:(id)arg1 withCorrectionIdentifier:(id)arg2;
- (id)automaticallySelectedOverlay;
- (void)setBottomBufferHeight:(double)arg1;
- (void)handleKeyWebEvent:(id)arg1;
- (_Bool)requiresKeyEvents;
@end

