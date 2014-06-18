/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PBCodable.h"

@class NSMutableArray;

// Not exported
@interface VKPGenericShield : PBCodable
{
    int _style;
    NSMutableArray *_variants;
}

@property(retain, nonatomic) NSMutableArray *variants; // @synthesize variants=_variants;
@property(nonatomic) int style; // @synthesize style=_style;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (void)copyTo:(id)arg1;
- (void)writeTo:(id)arg1;
- (_Bool)readFrom:(id)arg1;
- (id)dictionaryRepresentation;
- (id)description;
- (id)variantAtIndex:(unsigned long long)arg1;
- (unsigned long long)variantsCount;
- (void)addVariant:(id)arg1;
- (void)clearVariants;
- (void)dealloc;

@end

