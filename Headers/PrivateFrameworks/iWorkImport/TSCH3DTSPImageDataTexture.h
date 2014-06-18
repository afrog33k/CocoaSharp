/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCH3DTexture.h>

@class NSNumber, TSCH3DTSPImageData, TSCH3DTSPMipmapData, TSPData;

// Not exported
@interface TSCH3DTSPImageDataTexture : TSCH3DTexture
{
    TSCH3DTSPImageData *mData;
    TSCH3DTSPMipmapData *mOptimizedMipmapData;
    NSNumber *mCachedHash;
}

+ (id)textureWithImageData:(id)arg1 optimizedMipmapData:(id)arg2;
@property(readonly, nonatomic) TSCH3DTSPImageData *data; // @synthesize data=mData;
- (void)setChanged:(_Bool)arg1;
- (id)optimizedMipmapBuffer;
- (_Bool)canLoadCachedFullMipmapBufferForDataCache:(id)arg1;
- (id)databufferForDataCache:(id)arg1;
@property(readonly, nonatomic) TSPData *imageData;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (void)dealloc;
- (id)initWithImageData:(id)arg1 optimizedMipmapData:(id)arg2;

@end

