/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

@class EDAlignmentInfo, EDBorders, EDContentFormat, EDFill, EDFont, EDProtection;

// Not exported
@interface EDDifferentialStyle : NSObject <NSCopying>
{
    EDAlignmentInfo *mAlignmentInfo;
    EDBorders *mBorders;
    EDFill *mFill;
    EDFont *mFont;
    EDProtection *mProtection;
    EDContentFormat *mContentFormat;
}

+ (id)differentialStyle;
@property(retain, nonatomic) EDContentFormat *contentFormat; // @synthesize contentFormat=mContentFormat;
@property(retain, nonatomic) EDProtection *protection; // @synthesize protection=mProtection;
@property(retain, nonatomic) EDFont *font; // @synthesize font=mFont;
@property(retain, nonatomic) EDFill *fill; // @synthesize fill=mFill;
@property(retain, nonatomic) EDBorders *borders; // @synthesize borders=mBorders;
@property(retain, nonatomic) EDAlignmentInfo *alignmentInfo; // @synthesize alignmentInfo=mAlignmentInfo;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)dealloc;

@end

