/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/OCDDelayedMedia.h>

@class NSData, NSString;

// Not exported
@interface OADSound : OCDDelayedMedia
{
    NSData *mSoundData;
    NSString *mName;
    int mSizeInBytes;
}

- (_Bool)isLoaded;
- (void)setSizeInBytes:(int)arg1;
- (int)sizeInBytes;
- (void)setName:(id)arg1;
- (id)name;
- (void)setSoundData:(id)arg1;
- (id)soundData;
- (void)dealloc;
- (id)init;

@end

