/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCECellValue.h>

// Not exported
@interface TSCEDateCellValue : TSCECellValue
{
    struct TSCEDateValue *mDateValue;
}

- (void)encodeToArchive:(struct DateCellValueArchive *)arg1;
- (id)initWithArchive:(const struct DateCellValueArchive *)arg1;
- (_Bool)isEqualToCellValue:(id)arg1;
- (id)displayString;
- (CDStruct_95e644ef)formatStruct;
- (struct TSCEDateValue *)dateValue;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)dealloc;
- (id)initWithDateValue:(struct TSCEDateValue *)arg1;
- (id)initWithDate:(id)arg1;

@end

