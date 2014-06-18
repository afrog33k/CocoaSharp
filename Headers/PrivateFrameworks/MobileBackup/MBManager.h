/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSObject<MBManagerDelegate>;

@interface MBManager : NSObject
{
    id _delegate;
}

@property(nonatomic) NSObject<MBManagerDelegate> *delegate; // @synthesize delegate=_delegate;
- (void)rebootDevice;
- (_Bool)allowiTunesBackup;
- (void)setAllowiTunesBackup:(_Bool)arg1;
- (int)getLogLevel;
- (void)setLogLevel:(int)arg1;
- (id)restoreInfo;
- (id)getAppleIDsForBackupUDID:(id)arg1 snapshotID:(unsigned long long)arg2 error:(id *)arg3;
- (_Bool)deleteItemFromBackupUDID:(id)arg1 snapshotID:(unsigned long long)arg2 domainName:(id)arg3 relativePath:(id)arg4 error:(id *)arg5;
- (_Bool)addFileToBackupUDID:(id)arg1 snapshotID:(unsigned long long)arg2 domainName:(id)arg3 relativePath:(id)arg4 fromPath:(id)arg5 error:(id *)arg6;
- (_Bool)extractItemFromBackupUDID:(id)arg1 snapshotID:(unsigned long long)arg2 domainName:(id)arg3 relativePath:(id)arg4 toPath:(id)arg5 error:(id *)arg6;
- (void)setBackupEnabled:(_Bool)arg1 forDomainName:(id)arg2;
- (_Bool)isBackupEnabledForDomainName:(id)arg1;
- (_Bool)removeDomainName:(id)arg1 error:(id *)arg2;
- (id)domainInfoList;
- (id)domainInfoForName:(id)arg1;
- (unsigned long long)nextBackupSize;
- (_Bool)startScanWithError:(id *)arg1;
- (_Bool)deleteBackupUDID:(id)arg1 error:(id *)arg2;
- (void)cancelRestore;
- (void)cancel;
- (void)insufficientFreeSpaceToRestore;
- (void)finishRestore;
- (_Bool)cancelApplicationRestoreWithBundleID:(id)arg1 error:(id *)arg2;
- (_Bool)restoreApplicationWithBundleID:(id)arg1 failed:(_Bool)arg2 context:(id)arg3 error:(id *)arg4;
- (_Bool)restoreApplicationWithBundleID:(id)arg1 failed:(_Bool)arg2 error:(id *)arg3;
- (void)restoreFileWithPath:(id)arg1;
- (_Bool)restoreFileWithPath:(id)arg1 context:(id)arg2 error:(id *)arg3;
- (_Bool)restoreFileWithPath:(id)arg1 error:(id *)arg2;
- (_Bool)startRestoreForBackupUDID:(id)arg1 snapshotID:(unsigned long long)arg2 error:(id *)arg3;
- (void)startRestoreForBackupUDID:(id)arg1 snapshotID:(unsigned long long)arg2;
- (id)dateOfNextScheduledBackup;
- (id)dateOfLastBackup;
- (void)prioritizeRestoreFileWithPath:(id)arg1;
- (id)restoreFilesForDomain:(id)arg1 relativePath:(id)arg2 pendingOnly:(_Bool)arg3 range:(struct _NSRange)arg4 error:(id *)arg5;
- (id)restoreFilesForDomain:(id)arg1 relativePath:(id)arg2 pendingOnly:(_Bool)arg3 error:(id *)arg4;
- (id)restoreFilesForDomain:(id)arg1 error:(id *)arg2;
- (_Bool)restoreDataExistsForApplicationWithBundleID:(id)arg1 size:(unsigned long long *)arg2;
- (_Bool)restoreFileExistsWithPath:(id)arg1;
- (id)restoreState;
- (_Bool)startBackupWithError:(id *)arg1;
- (void)startBackup;
- (unsigned long long)countOfRestoreFailuresForDataclass:(id)arg1 assetType:(id)arg2;
- (id)restoreFailuresForDataclass:(id)arg1 assetType:(id)arg2 range:(struct _NSRange)arg3;
- (_Bool)recordRestoreFailure:(id)arg1 error:(id *)arg2;
- (id)getBackupListWithFiltering:(_Bool)arg1 error:(id *)arg2;
- (id)getBackupListWithError:(id *)arg1;
- (id)backupList;
- (id)backupState;
- (void)syncBackupEnabled;
- (void)setBackupEnabled:(_Bool)arg1;
- (_Bool)isBackupEnabled;
- (_Bool)setupBackupWithPasscode:(id)arg1 error:(id *)arg2;
- (id)_init;
- (id)init;
- (id)initWithDelegate:(id)arg1;
- (id)initWithDelegate:(id)arg1 eventQueue:(id)arg2;

@end

