/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCH3DLight.h>

#import "TSCH3DLightDirectional-Protocol.h"

// Not exported
@interface TSCH3DDirectionalLight : TSCH3DLight <TSCH3DLightDirectional>
{
    tvec3_17f03ce0 mDirection;
}

+ (Class)effectClass;
@property(nonatomic) tvec3_17f03ce0 direction; // @synthesize direction=mDirection;
- (id).cxx_construct;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)description;
- (id)init;

@end

