/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSWPTextCommand.h>

@class TSWPDateTimeSmartField;

// Not exported
@interface TSWPInsertDateTimeFieldCommand : TSWPTextCommand
{
    TSWPDateTimeSmartField *_dateTimeField;
}

- (int)persistenceKind;
- (void)doCommit;
- (void)dealloc;
- (id)initWithStorage:(id)arg1 selection:(id)arg2 dateTimeField:(id)arg3;

@end

