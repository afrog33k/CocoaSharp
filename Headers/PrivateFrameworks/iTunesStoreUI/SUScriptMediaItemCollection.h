/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iTunesStoreUI/SUScriptObject.h>

@class MPMediaItemCollection, NSArray, SUScriptMediaItem;

@interface SUScriptMediaItemCollection : SUScriptObject
{
    NSArray *_items;
    SUScriptMediaItem *_representativeItem;
    _Bool _watchingLibrary;
}

+ (void)initialize;
+ (id)webScriptNameForKeyName:(id)arg1;
- (id)scriptAttributeKeys;
- (id)attributeKeys;
- (void)_beginWatchingLibraryIfNecessary;
- (void)_libraryChangedNotification:(id)arg1;
@property(readonly) SUScriptMediaItem *representativeItem;
@property(readonly) NSArray *mediaTypes;
@property(readonly) NSArray *items;
@property(readonly) long long count;
- (id)_className;
@property(readonly, nonatomic) MPMediaItemCollection *nativeCollection;
- (void)dealloc;
- (id)initWithItems:(id)arg1;

@end
