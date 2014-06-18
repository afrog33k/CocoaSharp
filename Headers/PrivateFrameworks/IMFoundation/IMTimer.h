/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSDictionary, NSString;

@interface IMTimer : NSObject
{
    id _timer;
    id _target;
    NSDictionary *_userInfo;
    NSString *_name;
    double _timeInterval;
    SEL _selector;
    _Bool _wakeDevice;
}

@property(readonly, nonatomic) id userInfo; // @synthesize userInfo=_userInfo;
- (void)dealloc;
- (void)invalidate;
- (void)setFireTimeInterval:(double)arg1;
- (id)initWithTimeInterval:(double)arg1 name:(id)arg2 shouldWake:(_Bool)arg3 target:(id)arg4 selector:(SEL)arg5 userInfo:(id)arg6;

@end

