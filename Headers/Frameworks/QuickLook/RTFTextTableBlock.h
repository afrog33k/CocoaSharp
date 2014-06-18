/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <QuickLook/RTFTextBlock.h>

@class RTFTextTable;

// Not exported
@interface RTFTextTableBlock : RTFTextBlock
{
    RTFTextTable *_table;
    long long _rowNum;
    long long _colNum;
    long long _rowSpan;
    long long _colSpan;
    void *_tableBlockPrimary;
    void *_tableBlockSecondary;
}

- (void)_setColumnSpan:(long long)arg1;
- (void)_setRowSpan:(long long)arg1;
- (long long)columnSpan;
- (long long)startingColumn;
- (long long)rowSpan;
- (long long)startingRow;
- (id)table;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)dealloc;
- (id)initWithTable:(id)arg1 startingRow:(long long)arg2 rowSpan:(long long)arg3 startingColumn:(long long)arg4 columnSpan:(long long)arg5;

@end

