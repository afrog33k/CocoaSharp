/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@interface CalendarListHeaderCellContentView : UIView
{
    double _date;
    _Bool _indentsForDots;
    _Bool _showWeekNumber;
}

@property(nonatomic) _Bool showWeekNumber; // @synthesize showWeekNumber=_showWeekNumber;
- (void)drawRect:(struct CGRect)arg1;
- (id)_weekNumberFont;
- (id)_normalTextShadowColor;
- (id)_normalTextColor;
- (void)drawTitle:(id)arg1 withColor:(id)arg2 withShadowColor:(id)arg3 inRect:(struct CGRect)arg4;
- (struct CGRect)_rectForOffetTextShadow:(struct CGRect)arg1;
@property(nonatomic) _Bool indentsForDots;
@property(nonatomic) double date;

@end

