/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <Symbolication/VMUAddressRange.h>

#import "NSCopying-Protocol.h"

@class NSString;

@interface VMUSourceInfo : VMUAddressRange <NSCopying>
{
    NSString *_path;
    unsigned int _lineNumber;
    unsigned int _fileOffset;
}

+ (id)sourceInfoWithPath:(id)arg1 addressRange:(struct _VMURange)arg2 lineNumber:(unsigned int)arg3 fileOffset:(unsigned int)arg4;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (void)dealloc;
- (id)description;
- (_Bool)isEqualToSourceInfo:(id)arg1;
- (long long)compare:(id)arg1;
- (struct _VMURange)addressRange;
- (unsigned int)fileOffset;
- (unsigned int)lineNumber;
- (id)fileName;
- (id)path;
- (id)initWithPath:(id)arg1 addressRange:(struct _VMURange)arg2 lineNumber:(unsigned int)arg3 fileOffset:(unsigned int)arg4;

@end

