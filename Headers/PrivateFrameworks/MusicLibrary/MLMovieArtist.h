/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

@class NSMutableDictionary, NSNumber, NSString;

// Not exported
@interface MLMovieArtist : NSObject <NSCopying>
{
    NSMutableDictionary *_dictionary;
}

- (void).cxx_destruct;
- (void)_setValueCopy:(id)arg1 forKey:(id)arg2;
- (void)_setValue:(id)arg1 forKey:(id)arg2;
- (id)copyMovieArtistDictionary;
@property(copy, nonatomic) NSNumber *ITunesStoreIdentifier;
@property(copy, nonatomic) NSString *artistName;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)initWithMovieArtistDictionary:(id)arg1;
- (id)init;

@end

