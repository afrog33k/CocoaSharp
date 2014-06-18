/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSString, TSPComponent, TSPObjectContext, TSPUnknownContent;

// Not exported
@interface TSPObject : NSObject
{
    long long _identifier;
    long long _modifyObjectToken;
    long long _unarchiverIdentifier;
    TSPUnknownContent *_unknownContent;
    long long _creationModifyObjectToken;
    TSPComponent *_component;
    id <TSPObjectDelegate> _delegate;
}

+ (_Bool)tsp_isTransientObjectIdentifier:(long long)arg1;
+ (id)newObjectForUnarchiver:(id)arg1;
@property(nonatomic) __weak id <TSPObjectDelegate> tsp_delegate; // @synthesize tsp_delegate=_delegate;
@property(nonatomic) __weak TSPComponent *tsp_component; // @synthesize tsp_component=_component;
@property(nonatomic) long long tsp_modifyObjectToken; // @synthesize tsp_modifyObjectToken=_modifyObjectToken;
@property(readonly, nonatomic) long long tsp_creationModifyObjectToken; // @synthesize tsp_creationModifyObjectToken=_creationModifyObjectToken;
@property(readonly, nonatomic) TSPUnknownContent *tsp_unknownContent; // @synthesize tsp_unknownContent=_unknownContent;
@property(readonly, nonatomic) long long tsp_unarchiverIdentifier; // @synthesize tsp_unarchiverIdentifier=_unarchiverIdentifier;
@property(nonatomic) long long tsp_identifier; // @synthesize tsp_identifier=_identifier;
- (void).cxx_destruct;
@property(readonly, nonatomic) _Bool needsArchiving;
- (void)didFinishUnarchiving;
@property(readonly, nonatomic) _Bool dirtiesDocumentPackage;
@property(readonly, nonatomic) _Bool allowsDuplicatesOutsideOfDocumentPackage;
- (void)saveToArchiver:(id)arg1;
- (id)initFromUnarchiver:(id)arg1;
@property(readonly, nonatomic) _Bool isCommandObject;
- (void)didLoadChildObjectFromDocumentSupport:(id)arg1;
@property(readonly, nonatomic) unsigned int delayedArchivingPriority;
@property(readonly, nonatomic) _Bool shouldDelayArchiving;
@property(readonly, nonatomic) _Bool allowsImplicitComponentOwnership;
@property(readonly, nonatomic) TSPObject *componentRootObject;
@property(readonly, nonatomic) _Bool storeOutsideObjectArchive;
@property(readonly, nonatomic) _Bool isComponentRoot;
@property(readonly, nonatomic) NSString *packageLocator;
- (void)willModifyForUpgrade;
- (void)willModify;
- (id)initDocumentObjectWithContext:(id)arg1;
- (id)initWithContext:(id)arg1;
@property(readonly, nonatomic) TSPObjectContext *context;
- (id)init;

@end

