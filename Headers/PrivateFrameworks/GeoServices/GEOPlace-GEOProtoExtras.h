/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <GeoServices/GEOPlace.h>

@class GEOBusiness, GEORating;

@interface GEOPlace (GEOProtoExtras)
- (id)arrivalMapRegionForTransportType:(int)arg1;
- (id)arrivalMapRegion;
- (double)radialDistance;
- (CDStruct_c3b9c2ee)coordinate;
- (id)addressDictionary;
@property(readonly, nonatomic) GEORating *firstRating;
@property(readonly, nonatomic) GEOBusiness *firstBusiness;
@end

