/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PBCodable.h"

// Not exported
@interface VKPStyleAttribute : PBCodable
{
    CDStruct_95bda58d _intValues;
    int _key;
    int _score;
    struct {
        unsigned int score:1;
    } _has;
}

@property(nonatomic) int key; // @synthesize key=_key;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (void)copyTo:(id)arg1;
- (void)writeTo:(id)arg1;
- (_Bool)readFrom:(id)arg1;
- (id)dictionaryRepresentation;
- (id)description;
@property(nonatomic) _Bool hasScore;
@property(nonatomic) int score; // @synthesize score=_score;
- (void)setIntValues:(int *)arg1 count:(unsigned long long)arg2;
- (int)intValueAtIndex:(unsigned long long)arg1;
- (void)addIntValue:(int)arg1;
- (void)clearIntValues;
@property(readonly, nonatomic) int *intValues;
@property(readonly, nonatomic) unsigned long long intValuesCount;
- (void)dealloc;

@end

