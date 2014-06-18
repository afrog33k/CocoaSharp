/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <VectorKit/VKMapTileModel.h>

#import "VKMapLayer-Protocol.h"

@class NSMutableArray, VGLMesh, VGLRenderState, VGLTexture, VKPolygonDrawStyle;

// Not exported
@interface VKGroundCoverMapModel : VKMapTileModel <VKMapLayer>
{
    NSMutableArray *_sortedTiles;
    VKPolygonDrawStyle *_landStyle;
    _Bool _usePlainFillColor;
    _Bool _hasVegetationSettings;
    float _alpha;
    float _brightness;
    _Bool _showVegetation;
    VGLRenderState *_renderState;
    VGLTexture *_landTexture;
    VGLTexture *_landTextureVariant;
    double _layoutMaxZ;
    double _layoutContentScale;
    _Bool _needsLandSettingsUpdate;
    VGLMesh *_groundMesh;
    int _groundMeshCapacity;
}

+ (_Bool)reloadOnActiveTileGroupChange;
+ (_Bool)reloadOnStylesheetChange;
- (void)stylesheetDidChange;
- (void)stylesheetWillChange;
- (void)activeTileGroupChanged;
- (void)setActive:(_Bool)arg1;
- (id)groundMeshForTiles:(id)arg1 relativeToTile:(id)arg2;
- (void)drawScene:(id)arg1 withContext:(id)arg2;
- (void)layoutScene:(id)arg1 withContext:(id)arg2;
- (void)updateVegetationSettingsFromStylesheet;
- (void)reset;
- (unsigned int)supportedRenderPasses;
- (unsigned long long)mapLayerPosition;
- (void)loadLandSettingsForLevelOfDetail:(unsigned long long)arg1 scale:(double)arg2;
- (void)dealloc;
- (id)init;

@end

