/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSWPStorage.h>

@interface TSWPStorage (TSWPStorage_copying)
- (struct _NSRange)replaceCharactersInSelection:(id)arg1 withStorage:(id)arg2 usePasteRules:(_Bool)arg3 dolcContext:(id)arg4 changeSession:(id)arg5 undoTransaction:(struct TSWPStorageTransaction *)arg6;
- (struct _NSRange)replaceCharactersInRange:(struct _NSRange)arg1 withStorage:(id)arg2 usePasteRules:(_Bool)arg3 dolcContext:(id)arg4 undoTransaction:(struct TSWPStorageTransaction *)arg5;
- (void)transferAttributeArraySource:(struct TSWPAttributeArray *)arg1 toAttributeArrayDest:(struct TSWPAttributeArray *)arg2 atCharIndex:(unsigned long long)arg3 dolcContext:(id)arg4 undoTransaction:(struct TSWPStorageTransaction *)arg5;
@end

