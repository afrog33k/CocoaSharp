/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <DataAccess/DAAccount.h>

@interface DAAccount (ContactsSupport)
- (void)synchronizeContactsFolder:(id)arg1 previousTag:(id)arg2 previousSyncToken:(id)arg3 actions:(id)arg4 highestIdContext:(CDStruct_1ef3fb1f *)arg5 isInitialUberSync:(_Bool)arg6 isResyncAfterConnectionFailed:(_Bool)arg7 previousTagIsSuspect:(_Bool)arg8 consumer:(id)arg9;
- (id)contactsFolders;
- (id)defaultContactsFolder;
@end

