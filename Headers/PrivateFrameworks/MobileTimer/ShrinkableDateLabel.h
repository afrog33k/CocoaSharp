/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIDateLabel.h"

@class UIFont;

@interface ShrinkableDateLabel : UIDateLabel
{
    UIFont *_timeDesignatorFont;
}

@property(retain, nonatomic) UIFont *timeDesignatorFont; // @synthesize timeDesignatorFont=_timeDesignatorFont;
- (void)shrinkFontsToFitWidth:(double)arg1;
- (void)dealloc;

@end

