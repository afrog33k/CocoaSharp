/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSWPStorage.h>

@interface TSWPStorage (TSWPStorage_private)
- (_Bool)p_shouldAcceptChangesForRange:(struct _NSRange)arg1 removeDeletedText:(_Bool *)arg2;
- (void)p_fillMarkers:(vector_88016b54 *)arg1 startingAtCharIndex:(unsigned long long)arg2 forCount:(unsigned long long)arg3;
- (void)p_fillMarkers:(vector_a36e5995 *)arg1 string:(id)arg2 length:(unsigned long long)arg3 hasAttachments:(_Bool *)arg4 hasFootnotes:(_Bool *)arg5 hasBreaks:(_Bool *)arg6;
- (void)p_lowLevelReplaceCharactersInRange:(struct _NSRange)arg1 withString:(id)arg2 length:(unsigned long long)arg3 undoTransaction:(struct TSWPStorageTransaction *)arg4;
- (void)p_replaceCharactersInSelection:(id)arg1 withString:(id)arg2 length:(unsigned long long)arg3 undoTransaction:(struct TSWPStorageTransaction *)arg4;
- (void)p_didChangeRange:(struct _NSRange)arg1 delta:(long long)arg2 broadcastKind:(int)arg3;
- (id)pDefaultSectionForContext:(id)arg1;
@end

