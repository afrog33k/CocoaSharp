/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCH3DTileImageSceneRenderPipelineImageGenerator.h>

@class NSMutableArray;

// Not exported
@interface TSCH3DTileImageSceneRenderPipelineMultipleImagesGenerator : TSCH3DTileImageSceneRenderPipelineImageGenerator
{
    NSMutableArray *mImages;
}

- (id)images;
- (void)processSourceRegion:(const box_0260e9b3 *)arg1 targetRegion:(const box_0260e9b3 *)arg2;
- (void)dealloc;
- (id)init;

@end

