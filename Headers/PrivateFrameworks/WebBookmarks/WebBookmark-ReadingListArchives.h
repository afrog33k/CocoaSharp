/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <WebBookmarks/WebBookmark.h>

@interface WebBookmark (ReadingListArchives)
- (_Bool)fullArchiveAvailable;
- (_Bool)shouldReattemptArchive;
- (void)clearArchiveSynchronously;
- (void)clearArchive;
- (void)_removeDirectoryAtPath:(id)arg1;
- (unsigned long long)archiveSize;
- (unsigned long long)_sizeForFileOrDirectory:(id)arg1 withAttributes:(id)arg2;
- (_Bool)writeOfflineWebView:(id)arg1 asArchive:(_Bool)arg2 inReaderForm:(_Bool)arg3;
- (id)webarchivePathForNextPageURL:(id)arg1;
- (id)webarchivePathInReaderForm:(_Bool)arg1 fileExists:(_Bool *)arg2;
- (id)_suggestedFileNameForWebView:(id)arg1;
@end

