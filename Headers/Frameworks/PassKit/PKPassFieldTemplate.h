/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSNumber, UIFont;

@interface PKPassFieldTemplate : NSObject
{
    NSNumber *_boxedTextAlignment;
    NSNumber *_boxedVerticalPadding;
    NSNumber *_boxedSuppressesLabel;
    NSNumber *_boxedValueCanWrap;
    NSNumber *_boxedSuppressesEmptyLabel;
    UIFont *_labelFont;
    UIFont *_valueFont;
    Class _viewSubclass;
}

+ (id)_templateByResolvingTemplate:(id)arg1 withDefault:(id)arg2;
+ (id)fieldTemplateWithViewSubclass:(Class)arg1;
+ (id)fieldTemplateWithVerticalPadding:(double)arg1;
+ (id)fieldTemplateWithTextAlignment:(long long)arg1;
@property(retain, nonatomic) Class viewSubclass; // @synthesize viewSubclass=_viewSubclass;
@property(retain, nonatomic) UIFont *valueFont; // @synthesize valueFont=_valueFont;
@property(retain, nonatomic) UIFont *labelFont; // @synthesize labelFont=_labelFont;
@property(retain, nonatomic) NSNumber *boxedSuppressesEmptyLabel; // @synthesize boxedSuppressesEmptyLabel=_boxedSuppressesEmptyLabel;
@property(retain, nonatomic) NSNumber *boxedValueCanWrap; // @synthesize boxedValueCanWrap=_boxedValueCanWrap;
@property(retain, nonatomic) NSNumber *boxedSuppressesLabel; // @synthesize boxedSuppressesLabel=_boxedSuppressesLabel;
@property(retain, nonatomic) NSNumber *boxedVerticalPadding; // @synthesize boxedVerticalPadding=_boxedVerticalPadding;
@property(retain, nonatomic) NSNumber *boxedTextAlignment; // @synthesize boxedTextAlignment=_boxedTextAlignment;
@property(nonatomic) _Bool valueCanWrap;
@property(nonatomic) _Bool suppressesEmptyLabel;
@property(nonatomic) _Bool suppressesLabel;
@property(nonatomic) double verticalPadding;
@property(nonatomic) long long textAlignment;
- (void)dealloc;

@end

