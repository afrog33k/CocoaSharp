/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSSecureCoding-Protocol.h"

@class GEODirectionsResponse, GEODirectionsRouteResponse, GEORoute, MKMapItem, NSString, NSURL;

@interface _MKDirectionsETAResponse : NSObject <NSSecureCoding>
{
    MKMapItem *_source;
    MKMapItem *_destination;
    unsigned long long _transportType;
    struct CGImage *_routeImage;
    GEODirectionsRouteResponse *_geoResponse;
    struct CGImage *_incidentImage;
}

+ (_Bool)supportsSecureCoding;
@property(readonly, nonatomic) unsigned long long transportType; // @synthesize transportType=_transportType;
@property(readonly, nonatomic) MKMapItem *destination; // @synthesize destination=_destination;
@property(readonly, nonatomic) MKMapItem *source; // @synthesize source=_source;
@property(readonly, nonatomic) NSString *incidentDescription;
@property(readonly, nonatomic) struct CGImage *incidentImage;
@property(readonly, nonatomic) NSURL *mapsURL;
@property(readonly, nonatomic) unsigned int distance;
@property(readonly, nonatomic) struct CGImage *routeImage; // @synthesize routeImage=_routeImage;
@property(readonly, nonatomic) NSString *routeDescription;
@property(readonly, nonatomic) double typicalTrafficRatio;
@property(readonly, nonatomic) double duration;
@property(readonly, nonatomic) GEORoute *route;
@property(readonly, nonatomic) GEODirectionsResponse *directionsResponse;
- (id)initWithCoder:(id)arg1;
- (void)encodeWithCoder:(id)arg1;
- (void)dealloc;
- (id)initWithSource:(id)arg1 destination:(id)arg2 transportType:(unsigned long long)arg3 routeImage:(struct CGImage *)arg4 geoResponse:(id)arg5;

@end

