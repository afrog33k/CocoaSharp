/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PBCodable.h"

#import "NSCopying-Protocol.h"

@class NSString;

@interface GEOMatchedToken : PBCodable <NSCopying>
{
    CDStruct_62a50c50 _geoIds;
    int _geoType;
    NSString *_matchedToken;
    struct {
        unsigned int geoType:1;
    } _has;
}

@property(nonatomic) int geoType; // @synthesize geoType=_geoType;
@property(retain, nonatomic) NSString *matchedToken; // @synthesize matchedToken=_matchedToken;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)copyTo:(id)arg1;
- (void)writeTo:(id)arg1;
- (_Bool)readFrom:(id)arg1;
- (id)dictionaryRepresentation;
- (id)description;
- (void)setGeoIds:(unsigned long long *)arg1 count:(unsigned long long)arg2;
- (unsigned long long)geoIdAtIndex:(unsigned long long)arg1;
- (void)addGeoId:(unsigned long long)arg1;
- (void)clearGeoIds;
@property(readonly, nonatomic) unsigned long long *geoIds;
@property(readonly, nonatomic) unsigned long long geoIdsCount;
@property(nonatomic) _Bool hasGeoType;
- (void)dealloc;

@end

