/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSKCommand.h>

@class NSArray;

// Not exported
@interface TSDExteriorTextWrapCommand : TSKCommand
{
    NSArray *_infosAndWraps;
}

- (void)p_registerSelectionChange;
- (void)saveToArchiver:(id)arg1;
- (id)initFromUnarchiver:(id)arg1;
- (void)saveToArchive:(struct ExteriorTextWrapCommandArchive *)arg1 archiver:(id)arg2;
- (void)loadFromArchive:(const struct ExteriorTextWrapCommandArchive *)arg1 unarchiver:(id)arg2;
- (id)actionString;
- (_Bool)canCoalesceWithCommand:(id)arg1;
- (void)redo;
- (void)undo;
- (void)commit;
- (_Bool)process;
- (void)dealloc;
- (id)initWithContext:(id)arg1 drawableInfos:(id)arg2 exteriorTextWrap:(id)arg3;

@end

