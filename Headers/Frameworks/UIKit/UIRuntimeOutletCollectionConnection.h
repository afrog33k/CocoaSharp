/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIRuntimeConnection.h>

@class NSString;

// Not exported
@interface UIRuntimeOutletCollectionConnection : UIRuntimeConnection
{
    NSString *runtimeCollectionClassName;
    _Bool addsContentToExistingCollection;
}

@property _Bool addsContentToExistingCollection; // @synthesize addsContentToExistingCollection;
@property(copy) NSString *runtimeCollectionClassName; // @synthesize runtimeCollectionClassName;
- (id)description;
- (void)connectForSimulator;
- (void)connect;
- (void)performConnect;
- (void)dealloc;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;

@end

