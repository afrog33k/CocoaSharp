/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <ChatKit/CKBalloonImageView.h>

#import "UIGestureRecognizerDelegate-Protocol.h"

@class CKBalloonControl, CKManualUpdater, NSObject<CKBalloonViewDelegate>, UIColor, UILongPressGestureRecognizer, UITapGestureRecognizer;

@interface CKBalloonView : CKBalloonImageView <UIGestureRecognizerDelegate>
{
    CKBalloonControl *_control;
    BOOL _orientation;
    _Bool _hasTail;
    _Bool _filled;
    _Bool _showingMenu;
    _Bool _canUseOpaqueMask;
    _Bool _hasOverlay;
    _Bool _wantsSkinnyMask;
    NSObject<CKBalloonViewDelegate> *_delegate;
    UITapGestureRecognizer *_doubleTapGestureRecognizer;
    UILongPressGestureRecognizer *_longPressGestureRecognizer;
    CKManualUpdater *_displayUpdater;
    CKBalloonImageView *_overlay;
    struct UIEdgeInsets _textAlignmentInsets;
}

@property(retain, nonatomic) CKBalloonImageView *overlay; // @synthesize overlay=_overlay;
@property(retain, nonatomic) CKManualUpdater *displayUpdater; // @synthesize displayUpdater=_displayUpdater;
@property(nonatomic) _Bool wantsSkinnyMask; // @synthesize wantsSkinnyMask=_wantsSkinnyMask;
@property(nonatomic) _Bool hasOverlay; // @synthesize hasOverlay=_hasOverlay;
@property(nonatomic) _Bool canUseOpaqueMask; // @synthesize canUseOpaqueMask=_canUseOpaqueMask;
@property(nonatomic, getter=isShowingMenu) _Bool showingMenu; // @synthesize showingMenu=_showingMenu;
@property(readonly, nonatomic) UILongPressGestureRecognizer *longPressGestureRecognizer; // @synthesize longPressGestureRecognizer=_longPressGestureRecognizer;
@property(readonly, nonatomic) UITapGestureRecognizer *doubleTapGestureRecognizer; // @synthesize doubleTapGestureRecognizer=_doubleTapGestureRecognizer;
@property(nonatomic) struct UIEdgeInsets textAlignmentInsets; // @synthesize textAlignmentInsets=_textAlignmentInsets;
@property(nonatomic, getter=isFilled) _Bool filled; // @synthesize filled=_filled;
@property(nonatomic) _Bool hasTail; // @synthesize hasTail=_hasTail;
@property(nonatomic) BOOL orientation; // @synthesize orientation=_orientation;
@property(nonatomic) NSObject<CKBalloonViewDelegate> *delegate; // @synthesize delegate=_delegate;
- (SEL)delegateActionForAction:(SEL)arg1;
- (void)willHideMenu:(id)arg1;
- (void)willShowMenu:(id)arg1;
- (void)showMenu;
- (void)longPress:(id)arg1 forEvent:(id)arg2;
- (void)doubleTap:(id)arg1 forEvent:(id)arg2;
- (void)doDoubleTapOrLongPress;
- (void)tap:(id)arg1 forEvent:(id)arg2;
- (void)touchCancelForControl:(id)arg1;
- (void)touchDown:(id)arg1 forEvent:(id)arg2;
- (void)setHasOverlay:(_Bool)arg1 autoDismiss:(_Bool)arg2;
- (void)_dismissOverlay;
@property(readonly, nonatomic) UIColor *overlayColor;
- (void)prepareForReuse;
- (void)prepareForDisplay;
- (void)prepareForDisplayIfNeeded;
- (void)setNeedsPrepareForDisplay;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1 textAlignmentInsets:(struct UIEdgeInsets *)arg2;
- (void)layoutSubviews;
- (_Bool)resignFirstResponder;
- (_Bool)becomeFirstResponder;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;
- (id)initWithFrame:(struct CGRect)arg1;
- (_Bool)canBecomeFirstResponder;
- (_Bool)canPerformAction:(SEL)arg1 withSender:(id)arg2;
- (id)methodSignatureForSelector:(SEL)arg1;
- (void)forwardInvocation:(id)arg1;
- (id)description;
- (void)dealloc;

@end

