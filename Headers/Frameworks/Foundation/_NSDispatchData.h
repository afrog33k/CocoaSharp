/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSData.h"

// Not exported
@interface _NSDispatchData : NSData
{
}

+ (_Bool)supportsSecureCoding;
- (Class)classForCoder;
- (id)initWithCoder:(id)arg1;
- (void)encodeWithCoder:(id)arg1;
- (_Bool)_allowsDirectEncoding;
- (_Bool)_isDispatchData;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)mutableCopyWithZone:(struct _NSZone *)arg1;
- (struct _NSRange)rangeOfData:(id)arg1 options:(unsigned long long)arg2 range:(struct _NSRange)arg3;
- (id)subdataWithRange:(struct _NSRange)arg1;
- (unsigned long long)hash;
- (_Bool)isEqualToData:(id)arg1;
- (void)getBytes:(void *)arg1 range:(struct _NSRange)arg2;
- (void)enumerateByteRangesUsingBlock:(id)arg1;
- (void)getBytes:(void *)arg1 length:(unsigned long long)arg2;
- (void)getBytes:(void *)arg1;
- (const void *)bytes;
- (const void *)_bytesIfCompact;
- (unsigned long long)length;

@end

