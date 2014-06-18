/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSTExpressionNode.h>

@class NSDate, NSString;

// Not exported
@interface TSTDateNode : TSTExpressionNode
{
    NSDate *mValue;
    _Bool mBlank;
    NSString *mDateFormat;
}

@property(nonatomic, getter=isBlank) _Bool blank; // @synthesize blank=mBlank;
- (id)description;
- (void)saveToArchive:(struct DateNodeArchive *)arg1 archiver:(id)arg2;
- (id)initFromArchive:(const struct DateNodeArchive *)arg1 unarchiver:(id)arg2;
- (void)saveToArchiver:(id)arg1;
- (id)initFromUnarchiver:(id)arg1;
- (struct TSTDurationWrapper)durationWrapper;
- (id)date;
- (id)exportString;
- (void)buildASTNodeArray:(struct TSCEASTNodeArray *)arg1 hostCell:(CDStruct_0441cfb5)arg2;
- (void)insertFormulaText:(id)arg1 includeWhitespace:(_Bool)arg2;
- (id)string;
- (int)tokenType;
@property(retain, nonatomic) NSString *format;
@property(retain, nonatomic) NSDate *value;
- (void)dealloc;
- (id)initAsCopyOf:(id)arg1 intoContext:(id)arg2 children:(id)arg3;
- (id)initWithContext:(id)arg1 children:(id)arg2 firstIndex:(unsigned long long)arg3 lastIndex:(unsigned long long)arg4;
- (id)initWithContext:(id)arg1 asBlank:(_Bool)arg2 firstIndex:(unsigned long long)arg3 lastIndex:(unsigned long long)arg4;
- (id)initWithContext:(id)arg1 dateValue:(id)arg2 firstIndex:(unsigned long long)arg3 lastIndex:(unsigned long long)arg4;

@end

