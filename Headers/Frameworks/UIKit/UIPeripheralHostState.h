/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSDictionary;

// Not exported
@interface UIPeripheralHostState : NSObject
{
    struct UIPeripheralAnimationGeometry _geometry;
    NSDictionary *_screenGeometry;
    _Bool _inPositionIsDestination;
}

+ (id)stateWithGeometry:(struct UIPeripheralAnimationGeometry)arg1 inPositionIsDestination:(_Bool)arg2;
@property(nonatomic) _Bool inPositionIsDestination; // @synthesize inPositionIsDestination=_inPositionIsDestination;
@property(retain, nonatomic) NSDictionary *screenGeometry; // @synthesize screenGeometry=_screenGeometry;
@property(nonatomic) struct UIPeripheralAnimationGeometry geometry; // @synthesize geometry=_geometry;
- (void)dealloc;

@end

