/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/WDRun.h>

@class OADDrawable, WDCharacterProperties;

// Not exported
@interface WDOfficeArt : WDRun
{
    WDCharacterProperties *mProperties;
    OADDrawable *mDrawable;
    _Bool mFloating;
}

+ (int)textBoxTextTypeForRegularTextType:(int)arg1;
- (void)propagateTextTypeToDrawables;
- (void)setTextType:(int)arg1 recursivelyToDrawable:(id)arg2;
- (id)imageName;
- (id)imageData;
- (void)setImageBlipRef:(id)arg1;
- (id)imageBlipRef;
- (void)setFloating:(_Bool)arg1;
- (_Bool)isFloating;
- (void)clearDrawable;
- (_Bool)isDrawableOverridden;
- (id)overrideDrawable;
- (void)setDrawable:(id)arg1;
- (id)drawable;
- (void)clearProperties;
- (void)setProperties:(id)arg1;
- (id)properties;
- (int)runType;
- (void)dealloc;
- (id)initWithParagraph:(id)arg1;

@end

