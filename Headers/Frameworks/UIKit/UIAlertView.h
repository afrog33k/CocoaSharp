/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIView.h>

@class NSMutableArray, NSMutableDictionary, NSString, UILabel, UIToolbar, UIViewController, UIWindow, _UIModalItem;

@interface UIAlertView : UIView
{
    id <UIAlertViewDelegate> _delegate;
    UILabel *_titleLabel;
    UILabel *_subtitleLabel;
    UILabel *_bodyTextLabel;
    UILabel *_taglineTextLabel;
    double _startY;
    struct CGPoint _center;
    id _context;
    long long _cancelButton;
    long long _defaultButton;
    long long _firstOtherButton;
    UIToolbar *_toolbar;
    UIWindow *_originalWindow;
    UIWindow *_dimWindow;
    long long _suspendTag;
    long long _dismissButtonIndex;
    double _bodyTextHeight;
    NSMutableArray *_buttons;
    NSMutableArray *_textFields;
    UIView *_keyboard;
    UIView *_table;
    UIView *_dimView;
    UIView *_backgroundImageView;
    UIView *_contentViewNeue;
    UIView *_textFieldBackgroundView;
    UIWindow *_blurWindow;
    UIView *_backdropView;
    NSMutableDictionary *_separatorsViews;
    struct {
        unsigned int numberOfRows:7;
        unsigned int delegateAlertSheetButtonClicked:1;
        unsigned int delegateDidPresentAlertSheet:1;
        unsigned int delegateDidDismissAlertSheet:1;
        unsigned int hideButtonBar:1;
        unsigned int alertStyle:3;
        unsigned int dontDimBackground:1;
        unsigned int dismissSuspended:1;
        unsigned int dontBlockInteraction:1;
        unsigned int sheetWasPoppedUp:1;
        unsigned int animating:1;
        unsigned int hideWhenDoneAnimating:1;
        unsigned int layoutWhenDoneAnimating:1;
        unsigned int titleMaxLineCount:2;
        unsigned int bodyTextMaxLineCount:3;
        unsigned int runsModal:1;
        unsigned int runningModal:1;
        unsigned int addedTextView:1;
        unsigned int addedTableShadows:1;
        unsigned int showOverSBAlerts:1;
        unsigned int showMinTableContent:1;
        unsigned int bodyTextTruncated:1;
        unsigned int orientation:3;
        unsigned int groupsTextFields:1;
        unsigned int includesCancel:1;
        unsigned int useUndoStyle:1;
        unsigned int delegateBodyTextAlignment:1;
        unsigned int delegateClickedButtonAtIndex:1;
        unsigned int delegateClickedButtonAtIndex2:1;
        unsigned int delegateCancel:1;
        unsigned int delegateCancel2:1;
        unsigned int delegateWillPresent:1;
        unsigned int delegateWillPresent2:1;
        unsigned int delegateDidPresent:1;
        unsigned int delegateDidPresent2:1;
        unsigned int delegateWillDismiss:1;
        unsigned int delegateWillDismiss2:1;
        unsigned int delegateDidDismiss:1;
        unsigned int delegateDidDismiss2:1;
        unsigned int delegateShouldEnableFirstOtherButton:1;
        unsigned int forceHorizontalButtonsLayout:1;
        unsigned int suppressKeyboardOnPopup:1;
        unsigned int keyboardShowing:1;
        unsigned int dontCallDismissDelegate:1;
        unsigned int useAutomaticKB:1;
        unsigned int manualKeyboardVisible:1;
        unsigned int rotatingManualKeybaord:1;
        unsigned int shouldHandleFirstKeyUpEvent:1;
        unsigned int forceKeyboardUse:1;
        unsigned int cancelWhenDoneAnimating:1;
        unsigned int alertViewStyle:3;
        unsigned int isSBAlert:1;
        unsigned int isBeingDismissed:1;
        unsigned int useLookNeue:1;
    } _modalViewFlags;
    NSMutableArray *_buttonTitlesNeue;
    NSString *_titleTextNeue;
    NSString *_messageTextNeue;
    UIViewController *_hostingViewControllerNeue;
    UIWindow *_windowFOrSBNeueCompatibility;
    UIView *_accessoryView;
    UIViewController *_accessoryViewController;
    _Bool _textFieldsHidden;
    _UIModalItem *_representedModalItem;
}

- (void)_willRotateKeyboard;
- (void)_keyboardDidHide:(id)arg1;
- (void)_keyboardWillHide:(id)arg1;
- (void)_keyboardWillShow:(id)arg1;
- (void)_useLegacyUI:(_Bool)arg1;
- (void)_useUndoStyle:(_Bool)arg1;
- (_Bool)_shouldUseUndoStyle;
- (id)textFieldAtIndex:(long long)arg1;
- (void)_addTextEntryFieldsWithStyle:(long long)arg1;
- (void)show;
- (void)showWithAnimationType:(int)arg1;
- (id)initWithFrame:(struct CGRect)arg1;
- (id)initWithTitle:(id)arg1 message:(id)arg2 delegate:(id)arg3 cancelButtonTitle:(id)arg4 otherButtonTitles:(id)arg5;
- (void)dismissWithClickedButtonIndex:(long long)arg1 animated:(_Bool)arg2;
@property(nonatomic) long long alertViewStyle;
@property(readonly, nonatomic) long long firstOtherButtonIndex;
- (void)_setFirstOtherButtonIndex:(long long)arg1;
@property(nonatomic) long long cancelButtonIndex;
- (long long)defaultButtonIndex;
- (void)setDefaultButtonIndex:(long long)arg1;
@property(readonly, nonatomic, getter=isVisible) _Bool visible;
@property(readonly, nonatomic) long long numberOfButtons;
- (id)buttonTitleAtIndex:(long long)arg1;
- (long long)addButtonWithTitle:(id)arg1;
@property(copy, nonatomic) NSString *message;
@property(copy, nonatomic) NSString *title;
@property(nonatomic) id delegate;
- (void)dealloc;
- (id)initWithTitle:(id)arg1 message:(id)arg2 delegate:(id)arg3 defaultButton:(id)arg4 cancelButton:(id)arg5 otherButtons:(id)arg6;

@end

