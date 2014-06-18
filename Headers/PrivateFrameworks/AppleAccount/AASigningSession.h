/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSString;

@interface AASigningSession : NSObject
{
    struct NACContextOpaque_ *_context;
    NSString *_certURL;
    NSString *_sessionURL;
    int _error;
}

@property(readonly, nonatomic) int error; // @synthesize error=_error;
- (void).cxx_destruct;
- (void)dealloc;
- (id)signatureForData:(id)arg1;
- (void)establishSession;
- (id)initWithCertURL:(id)arg1 sessionURL:(id)arg2;

@end

