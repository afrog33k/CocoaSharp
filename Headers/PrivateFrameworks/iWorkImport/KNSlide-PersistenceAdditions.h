/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/KNSlide.h>

@interface KNSlide (PersistenceAdditions)
- (void)saveToArchiver:(id)arg1;
- (id)initFromUnarchiver:(id)arg1;
- (void)p_updateNumberOfBuildChunksImmediatelyWithoutUndoHistory;
- (void)p_updateOverlappingBuildEventTriggers;
- (void)saveToArchive:(struct SlideArchive *)arg1 archiver:(id)arg2;
- (void)loadFromArchive:(const struct SlideArchive *)arg1 unarchiver:(id)arg2;
- (_Bool)isComponentRoot;
- (id)packageLocator;
@end

