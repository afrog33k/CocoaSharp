/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/EDAnchor.h>

// Not exported
@interface EDTwoCellAnchor : EDAnchor
{
    struct EDCellAnchorMarker mFrom;
    struct EDCellAnchorMarker mTo;
    _Bool mIsRelative;
    int mEditAs;
}

- (id).cxx_construct;
- (void)setEditAs:(int)arg1;
- (int)editAs;
- (void)setRelative:(_Bool)arg1;
- (_Bool)isRelative;
- (void)setTo:(struct EDCellAnchorMarker)arg1;
- (struct EDCellAnchorMarker)to;
- (void)setFrom:(struct EDCellAnchorMarker)arg1;
- (struct EDCellAnchorMarker)from;
- (id)init;

@end

