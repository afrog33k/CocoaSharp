/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCoding-Protocol.h"
#import "NSCopying-Protocol.h"
#import "SSXPCCoding-Protocol.h"

@class NSArray, NSData, NSDictionary, NSMutableDictionary, NSNumber, NSObject<OS_dispatch_queue>, NSString, SSDownloadPolicy, SSItem, SSItemOffer, SSNetworkConstraints, SSURLRequestProperties;

@interface SSPurchase : NSObject <SSXPCCoding, NSCoding, NSCopying>
{
    NSNumber *_accountIdentifier;
    NSString *_affiliateIdentifier;
    _Bool _backgroundPurchase;
    long long _batchIdentifier;
    NSString *_buyParameters;
    _Bool _createsDownloads;
    NSObject<OS_dispatch_queue> *_dispatchQueue;
    SSDownloadPolicy *_downloadPolicy;
    NSMutableDictionary *_downloadProperties;
    long long _expectedDownloadFileSize;
    NSArray *_filteredAssetTypes;
    NSArray *_gratisIdentifiers;
    _Bool _ignoresForcedPasswordRestriction;
    SSItem *_item;
    SSItemOffer *_itemOffer;
    SSNetworkConstraints *_networkConstraints;
    long long _placeholderDownloadIdentifier;
    SSURLRequestProperties *_requestProperties;
    id _requiredDeviceCapabilities;
    long long _uniqueIdentifier;
    _Bool _usesLocalRedownloadParametersIfPossible;
}

+ (id)purchaseWithBuyParameters:(id)arg1;
- (void)setDownloadMetadata:(id)arg1;
- (id)downloadMetadata;
- (id)initWithXPCEncoding:(id)arg1;
- (id)copyXPCEncoding;
- (_Bool)isEqual:(id)arg1;
- (unsigned long long)hash;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (void)_setValuesUsingDatabaseEncoding:(id)arg1;
- (void)_addEntriesToDatabaseEncoding:(id)arg1;
@property _Bool usesLocalRedownloadParametersIfPossible;
@property long long uniqueIdentifier;
@property(copy) id requiredDeviceCapabilities;
@property long long placeholderDownloadIdentifier;
@property(copy) NSArray *gratisIdentifiers;
@property long long expectedDownloadFileSize;
- (void)setDefaultUserAgent:(id)arg1;
@property long long batchIdentifier;
- (id)itemOffer;
- (id)item;
@property(readonly) NSData *databaseEncoding;
- (id)initWithDatabaseEncoding:(id)arg1;
- (id)valueForDownloadProperty:(id)arg1;
- (void)setValue:(id)arg1 forDownloadProperty:(id)arg2;
@property(copy) SSURLRequestProperties *requestProperties;
@property(copy) SSNetworkConstraints *networkConstraints;
@property _Bool ignoresForcedPasswordRestriction;
@property(copy) NSArray *filteredAssetTypes;
@property(copy) NSDictionary *downloadProperties;
@property(copy) SSDownloadPolicy *downloadPolicy;
@property(nonatomic) _Bool createsDownloads;
@property(copy) NSString *buyParameters;
@property(getter=isBackgroundPurchase) _Bool backgroundPurchase;
@property(copy) NSString *affiliateIdentifier;
@property(retain) NSNumber *accountIdentifier;
- (void)dealloc;
- (id)initWithItem:(id)arg1 offer:(id)arg2;
- (id)initWithItem:(id)arg1;
- (id)init;
- (id)_initSSPurchase;

@end

