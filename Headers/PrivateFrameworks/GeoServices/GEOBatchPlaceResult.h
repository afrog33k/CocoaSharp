/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PBCodable.h"

#import "NSCopying-Protocol.h"

@class GEOPlaceResult;

@interface GEOBatchPlaceResult : PBCodable <NSCopying>
{
    GEOPlaceResult *_placeResult;
    int _statusCode;
    CDStruct_bcb1eac0 _has;
}

@property(retain, nonatomic) GEOPlaceResult *placeResult; // @synthesize placeResult=_placeResult;
@property(nonatomic) int statusCode; // @synthesize statusCode=_statusCode;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)copyTo:(id)arg1;
- (void)writeTo:(id)arg1;
- (_Bool)readFrom:(id)arg1;
- (id)dictionaryRepresentation;
- (id)description;
@property(readonly, nonatomic) _Bool hasPlaceResult;
@property(nonatomic) _Bool hasStatusCode;
- (void)dealloc;

@end

