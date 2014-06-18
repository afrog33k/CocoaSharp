/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import <AccessibilityUIService/AXUIAlertStyleProvider-Protocol.h>

@class NSBundle;

@interface AXUIAlertStyleProvider : NSObject <AXUIAlertStyleProvider>
{
    NSBundle *_bundle;
}

@property(retain, nonatomic) NSBundle *bundle; // @synthesize bundle=_bundle;
- (double)alertFadeAnimationDurationForType:(unsigned long long)arg1;
- (_Bool)alertShouldBeAsWideAsScreenForType:(unsigned long long)arg1;
- (int)alertPositionForType:(unsigned long long)arg1;
- (struct UIEdgeInsets)alertEdgeInsetsForType:(unsigned long long)arg1;
- (struct UIEdgeInsets)alertIconImageViewEdgeInsetsForType:(unsigned long long)arg1;
- (double)alertSubtitleTextLabelVerticalSpacingHeightWithTextLabelForType:(unsigned long long)arg1;
- (double)alertSubtitleTextLabelLineHeightOffsetForType:(unsigned long long)arg1;
- (struct UIOffset)alertSubtitleTextLabelShadowOffsetForType:(unsigned long long)arg1;
- (id)alertSubtitleTextLabelShadowColorForType:(unsigned long long)arg1;
- (id)alertSubtitleTextLabelBackgroundColorForType:(unsigned long long)arg1;
- (id)alertSubtitleTextLabelTextColorForType:(unsigned long long)arg1;
- (id)alertSubtitleTextLabelFontForType:(unsigned long long)arg1;
- (double)alertTextLabelLineHeightOffsetForType:(unsigned long long)arg1;
- (struct UIOffset)alertTextLabelShadowOffsetForType:(unsigned long long)arg1;
- (id)alertTextLabelShadowColorForType:(unsigned long long)arg1;
- (id)alertTextLabelBackgroundColorForType:(unsigned long long)arg1;
- (id)alertTextLabelTextColorForType:(unsigned long long)arg1;
- (id)alertTextLabelFontForType:(unsigned long long)arg1;
- (struct UIEdgeInsets)alertContentEdgeInsetsForType:(unsigned long long)arg1;
- (struct CGSize)alertBackgroundSizeForType:(unsigned long long)arg1;
- (double)alertBackgroundCornerRadiusForType:(unsigned long long)arg1;
- (int)alertBackgroundStyleForType:(unsigned long long)arg1;
- (void)dealloc;

@end

