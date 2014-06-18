/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class MPSAPContext, NSData;

// Not exported
@interface MPSAPExchanger : NSObject
{
    MPSAPContext *_context;
    NSData *_certificate;
    struct FairPlayHWInfo_ _hardwareInfo;
    struct FPSAPContextOpaque_ *_session;
}

@property(readonly, nonatomic) MPSAPContext *SAPContext; // @synthesize SAPContext=_context;
- (void).cxx_destruct;
- (id)exchangeData:(id)arg1 error:(id *)arg2;
- (id)exchangeCertificate:(id)arg1 error:(id *)arg2;
- (void)dealloc;
- (id)init;

@end

