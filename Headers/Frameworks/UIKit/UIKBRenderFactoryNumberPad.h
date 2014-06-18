/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIKBRenderFactory.h>

// Not exported
@interface UIKBRenderFactoryNumberPad : UIKBRenderFactory
{
}

- (void)setupLayoutSegments;
- (id)_traitsForKey:(id)arg1 onKeyplane:(id)arg2;
- (void)_customizeSymbolStyle:(id)arg1 secondaryStyle:(id)arg2 forKey:(id)arg3 contents:(id)arg4;
- (struct CGPoint)loneZeroOffset;
- (struct CGPoint)rightColumnLetterOffset;
- (struct CGPoint)rightColumnNumberOffset;
- (struct CGPoint)centerColumnLetterOffset;
- (struct CGPoint)centerColumnNumberOffset;
- (struct CGPoint)leftColumnLetterOffset;
- (struct CGPoint)leftColumnNumberOffset;
- (struct CGPoint)dictationGlyphOffset;
- (struct CGPoint)deleteGlyphOffset;
- (double)letterFontSize;
- (double)numberFontSize;
- (id)backgroundTraitsForKeyplane:(id)arg1;

@end

