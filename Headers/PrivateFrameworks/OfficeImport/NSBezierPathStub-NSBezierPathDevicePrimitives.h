/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/NSBezierPathStub.h>

@interface NSBezierPathStub (NSBezierPathDevicePrimitives)
- (void)_doUserPathWithOp:(unsigned char)arg1 inContext:(struct CGContext *)arg2;
- (void)_deviceClosePath;
- (void)_deviceCurveToPoint:(struct CGPoint)arg1 controlPoint1:(struct CGPoint)arg2 controlPoint2:(struct CGPoint)arg3;
- (void)_deviceLineToPoint:(struct CGPoint)arg1;
- (void)_deviceMoveToPoint:(struct CGPoint)arg1;
- (void)_addPathSegment:(long long)arg1 point:(struct CGPoint)arg2;
@end

