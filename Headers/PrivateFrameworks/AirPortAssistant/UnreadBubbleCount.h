/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

@interface UnreadBubbleCount : UIView
{
    struct CGSize _textSize;
    _Bool _isSelected;
    long long _count;
}

+ (void)deallocImageCache;
+ (int)initImageCache;
@property(nonatomic) _Bool isSelected; // @synthesize isSelected=_isSelected;
@property(nonatomic) long long count; // @synthesize count=_count;
- (void)calculateTextMetrics;
- (void)drawRect:(struct CGRect)arg1;
- (void)layoutSubviews;
- (_Bool)isHighlighted;
- (void)setHighlighted:(_Bool)arg1;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

