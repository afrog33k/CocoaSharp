/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class CLGeocoderInternal;

@interface CLGeocoder : NSObject
{
    CLGeocoderInternal *_internal;
}

- (void)_notifyError:(id)arg1;
- (void)_notifyCancel;
- (void)_notifyNoResult;
- (void)_notifyPartialResult:(id)arg1;
- (void)_notifyResult:(id)arg1;
- (void)_notifyResult:(id)arg1 error:(id)arg2;
- (void)_ensureMainThreadExecutionContextForBlock:(id)arg1;
- (void)_setLoggingPropertiesForRequest:(id)arg1;
- (void)_request:(id)arg1 didReturnError:(id)arg2;
- (void)_request:(id)arg1 didReturnError:(id)arg2 partialResultForLocation:(id)arg3;
- (void)_request:(id)arg1 didReturnResponse:(id)arg2;
- (void)cancelGeocode;
- (void)geocodeAddressString:(id)arg1 inRegion:(id)arg2 completionHandler:(id)arg3;
- (void)geocodeAddressString:(id)arg1 completionHandler:(id)arg2;
- (void)geocodeAddressDictionary:(id)arg1 completionHandler:(id)arg2;
- (void)reverseGeocodeLocation:(id)arg1 heading:(double)arg2 localResultsOnly:(_Bool)arg3 completionHandler:(id)arg4;
- (void)reverseGeocodeLocation:(id)arg1 heading:(double)arg2 completionHandler:(id)arg3;
- (void)reverseGeocodeLocation:(id)arg1 completionHandler:(id)arg2;
- (void)reverseGeocodeLocation:(id)arg1 localResultsOnly:(_Bool)arg2 completionHandler:(id)arg3;
@property(readonly, nonatomic, getter=isGeocoding) _Bool geocoding;
- (void)dealloc;
- (id)init;

@end

