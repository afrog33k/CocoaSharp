/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <VectorKit/VGLMesh.h>

// Not exported
@interface VGLGroupCullableMesh : VGLMesh
{
    struct vector<VGLGroupInfo, vk_allocator<VGLGroupInfo>> _groupInfoCollection;
    struct {
        struct _NSRange indexRange;
        CDStruct_f3463f58 bounds;
        struct vector<int, vk_allocator<int>> groupInfoIndices;
        struct unordered_set<int, std::__1::hash<int>, std::__1::equal_to<int>, vk_allocator<int>> overflowSourceFragments;
    } _fragments[16];
    float _fragmentSize;
    struct bitset<16> _fragmentsToDrawBitset;
    _Bool _didFreeze;
    struct unordered_map<unsigned long, unsigned long, std::__1::hash<unsigned long>, std::__1::equal_to<unsigned long>, vk_allocator<std::__1::pair<const unsigned long, unsigned long>>> _groupIDToInfoIndex;
}

- (id).cxx_construct;
- (void).cxx_destruct;
- (void)groupsContainingPositionA:(CDStruct_03942939)arg1 positionB:(CDStruct_03942939)arg2 groupIDs:(unsigned long long *)arg3 groupIDCount:(unsigned long long *)arg4 maxGroupIDs:(unsigned long long)arg5;
- (void)freeze;
- (void)drawInRects:(const CDStruct_818bb265 *)arg1 rectCount:(unsigned long long)arg2 context:(id)arg3;
- (void)drawGroups:(const vector_a3ee659f *)arg1 context:(id)arg2;
- (void)drawInRects:(const CDStruct_818bb265 *)arg1 rectCount:(unsigned long long)arg2 excludeGroups:(const vector_a3ee659f *)arg3 context:(id)arg4;
- (void)drawLinesInPreparedCulls:(id)arg1 excludeGroups:(const vector_a3ee659f *)arg2;
- (void)drawLinesInPreparedCulls:(id)arg1;
- (void)drawInPreparedCulls:(id)arg1;
- (void)drawInPreparedCulls:(id)arg1 excludeGroups:(const vector_a3ee659f *)arg2;
- (void)prepareCullsInRects:(const CDStruct_818bb265 *)arg1 numRects:(unsigned long long)arg2;
- (_Bool)addGroupForIndexRange:(struct _NSRange)arg1 boundingBox:(CDStruct_f3463f58)arg2 center:(CDStruct_03942939)arg3 groupID:(unsigned long long)arg4;

@end

