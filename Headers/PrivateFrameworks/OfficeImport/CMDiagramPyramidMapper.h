/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/CMDiagramShapeMapper.h>

// Not exported
@interface CMDiagramPyramidMapper : CMDiagramShapeMapper
{
    _Bool mIsFlipped;
}

- (struct CGSize)sizeForNode:(id)arg1 atIndex:(unsigned long long)arg2;
- (id)_suggestedBoundsForNodeAtIndex:(unsigned long long)arg1;
- (void)mapChildrenAt:(id)arg1 withState:(id)arg2;
- (void)mapAt:(id)arg1 withState:(id)arg2;
- (void)setIsFlipped:(_Bool)arg1;

@end

