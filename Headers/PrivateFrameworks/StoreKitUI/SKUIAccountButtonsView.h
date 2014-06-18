/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@class NSString, SKUIClientContext, SKUIColorScheme, SKUIRoundedRectButton, UIButton, UILabel;

@interface SKUIAccountButtonsView : UIView
{
    UILabel *_accountCreditsLabel;
    SKUIRoundedRectButton *_appleIDButton;
    SKUIClientContext *_clientContext;
    SKUIColorScheme *_colorScheme;
    SKUIRoundedRectButton *_giftingButton;
    long long _interfaceOrientation;
    UIButton *_termsAndConditionsButton;
    SKUIRoundedRectButton *_usernameButton;
    UIButton *_redeemButton;
}

@property(readonly, nonatomic) UIButton *termsAndConditionsButton; // @synthesize termsAndConditionsButton=_termsAndConditionsButton;
@property(readonly, nonatomic) UIButton *redeemButton; // @synthesize redeemButton=_redeemButton;
@property(nonatomic) long long interfaceOrientation; // @synthesize interfaceOrientation=_interfaceOrientation;
@property(readonly, nonatomic) UIButton *giftingButton; // @synthesize giftingButton=_giftingButton;
@property(copy, nonatomic) SKUIColorScheme *colorScheme; // @synthesize colorScheme=_colorScheme;
@property(readonly, nonatomic) UIButton *appleIDButton; // @synthesize appleIDButton=_appleIDButton;
- (void).cxx_destruct;
- (void)_layoutForIPhone;
- (void)_layoutForIPad;
- (struct CGSize)sizeThatFits:(struct CGSize)arg1;
- (void)layoutSubviews;
@property(nonatomic, getter=isTermsAndConditionsHidden) _Bool termsAndConditionsHidden;
@property(nonatomic, getter=isGiftingHidden) _Bool giftingHidden;
@property(copy, nonatomic) NSString *accountCredits;
- (id)initWithClientContext:(id)arg1;
- (id)_termsChevronImage;

@end

