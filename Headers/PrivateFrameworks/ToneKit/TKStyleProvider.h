/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "TKVibrationRecorderStyleProvider-Protocol.h"

@class NSBundle, NSMutableDictionary, UIColor, UIFont, UIImage, UIScreen;

@interface TKStyleProvider : NSObject <TKVibrationRecorderStyleProvider>
{
    UIScreen *_screen;
    NSBundle *_bundle;
    NSMutableDictionary *_cachedStyleProperties;
}

@property(retain, nonatomic, setter=_setCachedStyleProperties:) NSMutableDictionary *_cachedStyleProperties; // @synthesize _cachedStyleProperties;
@property(retain, nonatomic, setter=_setBundle:) NSBundle *_bundle; // @synthesize _bundle;
@property(retain, nonatomic) UIScreen *screen; // @synthesize screen=_screen;
@property(readonly, nonatomic) double vibrationRecorderRippleFingerMovingSpeed;
@property(readonly, nonatomic) double vibrationRecorderRippleFingerStillSpeed;
@property(readonly, nonatomic) double vibrationRecorderRippleFinalRadius;
@property(readonly, nonatomic) double vibrationRecorderRippleInitialRadius;
@property(readonly, nonatomic) double vibrationRecorderRippleRingLineWidth;
@property(readonly, nonatomic) UIColor *vibrationRecorderRippleViewBackgroundColor;
@property(readonly, nonatomic) double vibrationRecorderProgressViewAccessibilityAdditionalHeight;
@property(readonly, nonatomic) UIImage *vibrationRecorderProgressViewResizableDotImage;
@property(readonly, nonatomic) double vibrationRecorderProgressViewDotHorizontalInset;
@property(readonly, nonatomic) UIColor *vibrationRecorderProgressViewTrackColor;
@property(readonly, nonatomic) double vibrationRecorderProgressViewHeight;
@property(readonly, nonatomic) double vibrationRecorderProgressViewHorizontalOffsetFromEdge;
@property(readonly, nonatomic) double vibrationRecorderProgressToolbarAdditionalHeight;
@property(readonly, nonatomic) double vibrationRecorderProgressToolbarVerticalOffset;
@property(readonly, nonatomic) double vibrationRecorderControlsToolbarItemsHorizontalOffsetFromEdge;
@property(readonly, nonatomic) double vibrationRecorderControlsToolbarAdditionalHeight;
@property(readonly, nonatomic) double vibrationRecorderControlsToolbarVerticalOffset;
@property(readonly, nonatomic) double vibrationRecorderInstructionsLabelFadeAnimationDuration;
@property(readonly, nonatomic) struct UIEdgeInsets vibrationRecorderInstructionsLabelEdgeInsets;
@property(readonly, nonatomic) struct UIOffset vibrationRecorderInstructionsLabelPositionOffset;
@property(readonly, nonatomic) UIColor *vibrationRecorderInstructionsLabelBackgroundColor;
@property(readonly, nonatomic) UIColor *vibrationRecorderInstructionsLabelTextColor;
@property(readonly, nonatomic) UIFont *vibrationRecorderInstructionsLabelFont;
@property(readonly, nonatomic) UIColor *vibrationRecorderBarsBackgroundColor;
@property(readonly, nonatomic) double defaultAnimationDuration;
- (void)_didReceiveMemoryWarning:(id)arg1;
- (id)_cachedResizableImageForPropertyWithSelector:(SEL)arg1 capInsets:(struct UIEdgeInsets)arg2 size:(struct CGSize)arg3 opaque:(_Bool)arg4 withDrawingBlock:(id)arg5;
- (id)_cachedImageForPropertyWithSelector:(SEL)arg1 size:(struct CGSize)arg2 opaque:(_Bool)arg3 withDrawingBlock:(id)arg4;
- (id)_cachedImageWithName:(id)arg1 forPropertyWithSelector:(SEL)arg2;
- (void)_setCachedStyleObject:(id)arg1 forPropertyWithSelector:(SEL)arg2;
- (id)_cachedStyleObjectForPropertyWithSelector:(SEL)arg1;
- (void)dealloc;
- (id)init;

@end

