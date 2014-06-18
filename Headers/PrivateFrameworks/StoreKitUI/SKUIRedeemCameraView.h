/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

#import "UITextFieldDelegate-Protocol.h"

@class NSString, SKUIRedeemCameraLandingView, SKUIRedeemTextField, UIButton, UIImage;

@interface SKUIRedeemCameraView : UIView <UITextFieldDelegate>
{
    id <SKUIRedeemCameraViewDelegate> _delegate;
    SKUIRedeemTextField *_inputAccessoryTextField;
    SKUIRedeemCameraLandingView *_landingView;
    UIView *_overlay;
    UIView *_redeemerView;
    UIButton *_termsButton;
    SKUIRedeemTextField *_textField;
}

@property(nonatomic) __weak id <SKUIRedeemCameraViewDelegate> delegate; // @synthesize delegate=_delegate;
- (void).cxx_destruct;
- (void)_showRedeemer:(_Bool)arg1;
- (void)_resumeRedeemer;
- (void)_pauseRedeemer;
- (id)_newTextFieldWithClientContext:(id)arg1 placeholderColor:(id)arg2;
- (_Bool)_isShowingRedeemer;
- (void)_hideKeyboard;
- (void)_termsButtonAction:(id)arg1;
- (void)_tapGestureAction:(id)arg1;
- (void)_landingButtonAction:(id)arg1;
- (_Bool)textFieldShouldReturn:(id)arg1;
- (void)textFieldTextDidChange:(id)arg1;
- (void)keyboardDidHide:(id)arg1;
- (void)keyboardWillHide:(id)arg1;
- (void)keyboardDidShow:(id)arg1;
- (void)keyboardWillShow:(id)arg1;
- (void)layoutSubviews;
- (void)start;
@property(nonatomic) _Bool enabled;
- (void)showKeyboard;
@property(retain, nonatomic) UIImage *image;
@property(copy, nonatomic) NSString *text;
- (void)dealloc;
- (id)initWithClientContext:(id)arg1;

@end

