/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class AVWeakReference, AVWeakReferencingDelegateStorage, NSArray, NSString;

@interface AVPlayerItemLegibleOutputInternal : NSObject
{
    id <AVPlayerItemLegibleOutputDependencyFactory> dependencyFactory;
    id <AVLegibleOutputDataSource> dataSource;
    AVWeakReference *weakReferenceToHost;
    _Bool suppressesPlayerRendering;
    NSString *figLegibleOutputsDictionaryKey;
    NSArray *nativeRepresentationSubtypes;
    double advanceInterval;
    NSString *textStylingResolution;
    AVWeakReferencingDelegateStorage *delegateStorage;
}

@end

