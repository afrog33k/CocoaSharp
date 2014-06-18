/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@class SFUCryptoKey;

@protocol TSPPackage <NSObject>
@property(readonly, nonatomic) SFUCryptoKey *decryptionKey;
@property(readonly, nonatomic) id <TSPFileCoordinatorDelegate> fileCoordinatorDelegate;
@property(readonly, nonatomic) unsigned char packageIdentifier;
- (void)copyComponent:(id)arg1 toPackageURL:(id)arg2 packageLocator:(id)arg3 zipFileWriter:(id)arg4 encryptionKey:(id)arg5 completion:(id)arg6;
- (void)enumerateDatasUsingBlock:(id)arg1;
- (_Bool)containsData:(id)arg1;
- (void)didReferenceData:(id)arg1;
- (id)newDataStorageForFilename:(id)arg1 decryptionKey:(id)arg2;
- (id)newDataStorageForFilename:(id)arg1;
- (id)newReadChannelForComponent:(id)arg1;
@end

