/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <ChatKit/CKImageBalloonView.h>

@class NSString, UIImageView, UILabel;

@interface CKTitledImageBalloonView : CKImageBalloonView
{
    UIImageView *_chevron;
    UILabel *_titleLabel;
}

@property(retain, nonatomic) UILabel *titleLabel; // @synthesize titleLabel=_titleLabel;
@property(retain, nonatomic) UIImageView *chevron; // @synthesize chevron=_chevron;
@property(copy, nonatomic) NSString *title;
- (void)setOrientation:(BOOL)arg1;
- (void)prepareForReuse;
- (struct UIEdgeInsets)alignmentRectInsets;
- (void)layoutSubviews;
- (id)initWithFrame:(struct CGRect)arg1;
- (void)dealloc;

@end

