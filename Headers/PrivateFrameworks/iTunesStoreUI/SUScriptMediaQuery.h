/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iTunesStoreUI/SUScriptObject.h>

@class MPMediaQuery, NSArray, NSString;

@interface SUScriptMediaQuery : SUScriptObject
{
    NSArray *_collections;
    NSArray *_filterPredicates;
    NSArray *_items;
    _Bool _watchingLibrary;
}

+ (void)initialize;
+ (id)webScriptNameForSelector:(SEL)arg1;
+ (id)webScriptNameForKeyName:(id)arg1;
- (id)scriptAttributeKeys;
- (id)attributeKeys;
- (void)_resetCaches;
- (void)_beginWatchingLibraryIfNecessary;
- (void)_libraryChangedNotification:(id)arg1;
@property(readonly) NSString *groupingTypeTitle;
@property(readonly) NSString *groupingTypePodcastTitle;
@property(readonly) NSString *groupingTypePlaylist;
@property(readonly) NSString *groupingTypeGenre;
@property(readonly) NSString *groupingTypeComposer;
@property(readonly) NSString *groupingTypeArtist;
@property(readonly) NSString *groupingTypeAlbumArtist;
@property(readonly) NSString *groupingTypeAlbum;
@property(readonly) NSString *comparisonTypeEquals;
@property(readonly) NSString *comparisonTypeContains;
@property(copy) NSString *groupingType;
@property(copy) id filterPredicates;
@property(readonly) NSArray *items;
@property(readonly) NSArray *collections;
- (id)_className;
- (void)removeFilterPredicate:(id)arg1;
- (id)makeFilterPredicateWithProperty:(id)arg1 value:(id)arg2 comparisonType:(id)arg3;
- (id)canFilterByProperty:(id)arg1;
- (void)addFilterPredicate:(id)arg1;
@property(readonly, nonatomic) MPMediaQuery *nativeQuery;
- (void)dealloc;

@end

