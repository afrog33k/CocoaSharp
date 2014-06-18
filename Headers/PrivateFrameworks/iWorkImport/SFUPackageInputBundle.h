/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "SFUInputBundle-Protocol.h"

@class NSString;

// Not exported
@interface SFUPackageInputBundle : NSObject <SFUInputBundle>
{
    NSString *_rootPath;
}

- (void)copyEntry:(id)arg1 toFile:(id)arg2;
- (unsigned int)crc32ForEntry:(id)arg1;
- (long long)lengthOfEntry:(id)arg1;
- (id)bufferedInputStreamForEntry:(id)arg1;
- (id)inputStreamForEntry:(id)arg1;
- (_Bool)hasEntryWithName:(id)arg1;
- (id)_existingPathForEntryName:(id)arg1 isGz:(_Bool *)arg2;
- (void)dealloc;
- (id)initWithPath:(id)arg1;

@end

