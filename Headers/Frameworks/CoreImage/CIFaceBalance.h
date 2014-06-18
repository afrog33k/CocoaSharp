/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <CoreImage/CIFilter.h>

#import "_CIFilterProperties-Protocol.h"

@class CIImage, NSNumber;

// Not exported
@interface CIFaceBalance : CIFilter <_CIFilterProperties>
{
    CIImage *inputImage;
    NSNumber *inputOrigI;
    NSNumber *inputOrigQ;
    NSNumber *inputStrength;
    NSNumber *inputWarmth;
}

+ (id)customAttributes;
@property(retain, nonatomic) NSNumber *inputWarmth; // @synthesize inputWarmth;
@property(retain, nonatomic) NSNumber *inputStrength; // @synthesize inputStrength;
@property(retain, nonatomic) NSNumber *inputOrigQ; // @synthesize inputOrigQ;
@property(retain, nonatomic) NSNumber *inputOrigI; // @synthesize inputOrigI;
@property(retain, nonatomic) CIImage *inputImage; // @synthesize inputImage;
- (id)_initFromProperties:(id)arg1;
- (id)_outputProperties;
- (id)outputImage;
- (_Bool)_isIdentity;
- (id)_kernel;
- (void)setDefaults;

@end

