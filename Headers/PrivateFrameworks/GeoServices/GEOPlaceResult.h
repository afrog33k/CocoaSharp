/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PBCodable.h"

#import "NSCopying-Protocol.h"

@class GEOAddress, GEOPlace, GEOPlaceSearchRequest, NSMutableArray, NSString;

@interface GEOPlaceResult : PBCodable <NSCopying>
{
    double _confidence;
    NSMutableArray *_additionalPlaces;
    NSMutableArray *_matchedTokens;
    NSMutableArray *_namedFeatures;
    GEOPlace *_place;
    NSString *_quad;
    GEOPlaceSearchRequest *_revgeoRequestTemplate;
    NSString *_suggestedQuery;
    GEOAddress *_tokenEntity;
    unsigned int _travelTime;
    NSMutableArray *_unmatchedStrings;
    struct {
        unsigned int confidence:1;
        unsigned int travelTime:1;
    } _has;
}

@property(retain, nonatomic) NSMutableArray *matchedTokens; // @synthesize matchedTokens=_matchedTokens;
@property(retain, nonatomic) GEOPlaceSearchRequest *revgeoRequestTemplate; // @synthesize revgeoRequestTemplate=_revgeoRequestTemplate;
@property(retain, nonatomic) NSMutableArray *namedFeatures; // @synthesize namedFeatures=_namedFeatures;
@property(retain, nonatomic) NSMutableArray *unmatchedStrings; // @synthesize unmatchedStrings=_unmatchedStrings;
@property(retain, nonatomic) NSString *quad; // @synthesize quad=_quad;
@property(retain, nonatomic) GEOAddress *tokenEntity; // @synthesize tokenEntity=_tokenEntity;
@property(nonatomic) unsigned int travelTime; // @synthesize travelTime=_travelTime;
@property(retain, nonatomic) NSString *suggestedQuery; // @synthesize suggestedQuery=_suggestedQuery;
@property(retain, nonatomic) NSMutableArray *additionalPlaces; // @synthesize additionalPlaces=_additionalPlaces;
@property(nonatomic) double confidence; // @synthesize confidence=_confidence;
@property(retain, nonatomic) GEOPlace *place; // @synthesize place=_place;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)copyTo:(id)arg1;
- (void)writeTo:(id)arg1;
- (_Bool)readFrom:(id)arg1;
- (id)dictionaryRepresentation;
- (id)description;
- (id)matchedTokenAtIndex:(unsigned long long)arg1;
- (unsigned long long)matchedTokensCount;
- (void)addMatchedToken:(id)arg1;
- (void)clearMatchedTokens;
@property(readonly, nonatomic) _Bool hasRevgeoRequestTemplate;
- (id)namedFeatureAtIndex:(unsigned long long)arg1;
- (unsigned long long)namedFeaturesCount;
- (void)addNamedFeature:(id)arg1;
- (void)clearNamedFeatures;
- (id)unmatchedStringAtIndex:(unsigned long long)arg1;
- (unsigned long long)unmatchedStringsCount;
- (void)addUnmatchedString:(id)arg1;
- (void)clearUnmatchedStrings;
@property(readonly, nonatomic) _Bool hasQuad;
@property(readonly, nonatomic) _Bool hasTokenEntity;
@property(nonatomic) _Bool hasTravelTime;
@property(readonly, nonatomic) _Bool hasSuggestedQuery;
- (id)additionalPlaceAtIndex:(unsigned long long)arg1;
- (unsigned long long)additionalPlacesCount;
- (void)addAdditionalPlace:(id)arg1;
- (void)clearAdditionalPlaces;
@property(nonatomic) _Bool hasConfidence;
- (void)dealloc;

@end

