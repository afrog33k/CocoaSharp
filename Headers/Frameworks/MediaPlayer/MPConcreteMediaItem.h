/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <MediaPlayer/MPMediaItem.h>

#import "MPCacheableConcreteMediaEntity-Protocol.h"
#import "MPMediaItemArrayPIDEncodableItem-Protocol.h"
#import "NSCoding-Protocol.h"
#import "NSCopying-Protocol.h"

@class MPConcreteMediaEntityPropertiesCache, MPMediaLibrary;

@interface MPConcreteMediaItem : MPMediaItem <NSCoding, NSCopying, MPMediaItemArrayPIDEncodableItem, MPCacheableConcreteMediaEntity>
{
    MPMediaLibrary *_library;
    unsigned long long _persistentID;
    MPConcreteMediaEntityPropertiesCache *_propertiesCache;
}

+ (_Bool)supportsSecureCoding;
+ (void)didChangeEntityWithDataProviderEntityClass:(Class)arg1 persistentID:(unsigned long long)arg2 deleted:(_Bool)arg3;
+ (id)concreteMediaItemWithPersistentID:(unsigned long long)arg1 library:(id)arg2;
+ (id)concreteMediaItemWithPersistentID:(unsigned long long)arg1;
- (void).cxx_destruct;
- (void)updateDateAccessedToCurrentDateWithWriteCompletionBlock:(id)arg1;
- (_Bool)incrementPlayCountForStopTime:(double)arg1;
- (void)incrementPlayCountForPlayingToEnd;
- (void)incrementSkipCount;
- (void)noteWasPlayedToTime:(double)arg1 skipped:(_Bool)arg2;
- (_Bool)didSkipWithPlayedToTime:(double)arg1;
- (double)nominalHasBeenPlayedThreshold;
- (void)markNominalAmountHasBeenPlayed;
- (void)reallyIncrementPlayCount;
- (void)enumerateValuesForProperties:(id)arg1 usingBlock:(id)arg2;
- (void)setValue:(id)arg1 forProperty:(id)arg2 withCompletionBlock:(id)arg3;
- (_Bool)setValue:(id)arg1 forProperty:(id)arg2;
- (id)valuesForProperties:(id)arg1;
- (id)valueForProperty:(id)arg1;
- (id)_nonBatchableOrCachedValueForProperty:(id)arg1 needsFetch:(_Bool *)arg2;
- (unsigned long long)persistentID;
- (id)mediaLibrary;
- (_Bool)existsInLibrary;
- (Class)itemArrayCoderPIDDataCodingClass;
- (Class)classForCoder;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)description;
- (void)invalidateCachedProperties;
@property(readonly, nonatomic) MPConcreteMediaEntityPropertiesCache *cachedPropertyValues;
- (void)dealloc;
- (id)_initWithPersistentID:(unsigned long long)arg1 library:(id)arg2 propertiesCache:(id)arg3;
- (id)initWithPersistentID:(unsigned long long)arg1 library:(id)arg2;
- (id)initWithPersistentID:(unsigned long long)arg1;
- (id)init;

@end
