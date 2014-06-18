/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSPReader.h>

#import "TSPDatabaseUnarchiverDelegate-Protocol.h"

@class NSHashTable, NSObject<OS_dispatch_queue>, TSPDatabase;

// Not exported
@interface TSPDatabaseReader : TSPReader <TSPDatabaseUnarchiverDelegate>
{
    NSObject<OS_dispatch_queue> *_databaseQueue;
    TSPDatabase *_database;
    unsigned long long _databaseVersion;
    struct hash_map<const long long, bool, TSP::IdentifierHash, std::__1::equal_to<const long long>, std::__1::allocator<std::__1::pair<const long long, bool>>> _readIdentifiers;
    NSHashTable *_datas;
}

- (id).cxx_construct;
- (void).cxx_destruct;
- (set_6550bfbd *)filterIdentifiers:(const set_6550bfbd *)arg1;
- (id)filenameFromOldDataArchive:(const struct DatabaseDataArchive *)arg1;
- (id)dataForOldDataArchive:(const struct DatabaseDataArchive *)arg1;
- (struct Message *)newImageDataMessageForDatabaseObject:(id)arg1;
- (struct Message *)newDataMessageForDatabaseObject:(id)arg1;
- (_Bool)validateObjectIdentifierForObject:(id)arg1;
- (void)didUnarchiveObject:(id)arg1 withUnarchiver:(id)arg2;
- (id)newUnarchiverWithDatabaseObject:(id)arg1;
- (void)unarchiveObjectWithIdentifierAsync:(long long)arg1;
- (void)beginReadingWithCompletionQueue:(id)arg1 completion:(id)arg2;
- (void)dealloc;
- (id)initWithComponent:(id)arg1 finalizeHandlerQueue:(id)arg2 delegate:(id)arg3 database:(id)arg4 databaseVersion:(unsigned long long)arg5;
- (id)initWithComponent:(id)arg1 delegate:(id)arg2;
- (id)init;

// Remaining properties
@property(readonly, nonatomic) _Bool didFinishResolvingReferences;
@property(readonly, nonatomic) _Bool documentHasCurrentFileFormatVersion;
@property(readonly, nonatomic) _Bool isCrossAppPaste;
@property(readonly, nonatomic) _Bool isCrossDocumentPaste;
@property(readonly, nonatomic) _Bool isFromPasteboard;

@end

