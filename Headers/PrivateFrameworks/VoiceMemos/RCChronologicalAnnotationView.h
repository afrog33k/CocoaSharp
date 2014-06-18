/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@interface RCChronologicalAnnotationView : UIView
{
    long long _totalTickMarks;
    long long _majorTickMarkInterval;
    long long _majorTickMarkOffset;
    CDStruct_73a5d3ca _visibleTimeRange;
    struct UIEdgeInsets _contentInset;
}

@property(nonatomic) struct UIEdgeInsets contentInset; // @synthesize contentInset=_contentInset;
@property(nonatomic) long long majorTickMarkOffset; // @synthesize majorTickMarkOffset=_majorTickMarkOffset;
@property(nonatomic) long long majorTickMarkInterval; // @synthesize majorTickMarkInterval=_majorTickMarkInterval;
@property(nonatomic) long long totalTickMarks; // @synthesize totalTickMarks=_totalTickMarks;
@property(nonatomic) CDStruct_73a5d3ca visibleTimeRange; // @synthesize visibleTimeRange=_visibleTimeRange;
- (id)_timeLabelAttributes;
- (void)drawRect:(struct CGRect)arg1;
- (struct CGSize)labelsSize;
- (id)initWithFrame:(struct CGRect)arg1;

@end

