/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSString.h"

@interface NSString (MobileBackup)
+ (id)stringWithFileSystemRepresentation:(const char *)arg1 length:(unsigned long long)arg2;
+ (id)stringWithFileSystemRepresentation:(const char *)arg1;
- (id)MBAppendGreenteaSuffix;
- (_Bool)pathComponentExistsInSet:(id)arg1;
- (id)stringByAppendingSlash;
- (const char *)FSR;
@end

