/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/EPStyleFlattener.h>

@class EDPivotTable;

// Not exported
@interface EPPivotTableStyleFlattener : EPStyleFlattener
{
    EDPivotTable *mPivotTable;
    long long mFirstHeaderRow;
    long long mFirstDataRow;
    long long mFirstDataColumn;
    unsigned long long mRowFieldsCount;
    unsigned long long mColumnFieldsCount;
    unsigned long long mPageFieldsCount;
}

- (void)clearCache;
- (void)cacheSizes:(id)arg1 inObject:(id)arg2;
- (int)borderFlagsForStyleType:(int)arg1 row:(int)arg2 column:(int)arg3;
- (id)keysInTheOrderTheyShouldBeApplied;
- (id)extractCellStyleElements:(id)arg1 parentScope:(id)arg2 row:(int)arg3 column:(int)arg4;
- (id)extractRowStyleElements:(id)arg1 parentScope:(id)arg2 row:(int)arg3;
- (id)styleFromObject:(id)arg1;
- (id)collectionFromWorksheet:(id)arg1;
- (_Bool)isObjectSupported:(id)arg1;

@end

