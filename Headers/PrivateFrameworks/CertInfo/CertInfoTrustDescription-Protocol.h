/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol CertInfoTrustDescription <NSObject>
- (id)certificateExpirationDateAtIndex:(unsigned long long)arg1;
- (id)certificateIssuerSummaryAtIndex:(unsigned long long)arg1;
- (id)certificateSubjectSummaryAtIndex:(unsigned long long)arg1;
- (id)certificatePropertiesAtIndex:(unsigned long long)arg1;
- (unsigned long long)certificateCount;
- (id)summaryDescriptionItems;
- (_Bool)isTrusted;
- (id)summarySubtitle;
- (id)summaryTitle;
@end

