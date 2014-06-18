/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

// Not exported
@interface VKMapTileList : NSObject
{
    struct vector<VKMapTile *, vk_allocator<VKMapTile *>> _list;
    vector_3bee010d _rectList[29];
    float _maximumStyleZ;
}

@property(readonly, nonatomic) float maximumStyleZ; // @synthesize maximumStyleZ=_maximumStyleZ;
- (id).cxx_construct;
- (void).cxx_destruct;
- (void)consolidateList;
- (void)clearList;
- (void)addTileToList:(id)arg1;
@property(readonly, nonatomic) unsigned long long numTiles;
- (unsigned long long)numRectForLayer:(unsigned long long)arg1;
- (const CDStruct_818bb265 *)rectListForLayer:(unsigned long long)arg1;
- (const vector_3bee010d *)rectListVectorForLayer:(unsigned long long)arg1;
@property(readonly, nonatomic) id *tileList;
- (id)init;

@end

