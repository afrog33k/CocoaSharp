/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSURL, NSUUID, TSUSafeSaveAssistant;

// Not exported
@interface TSPSupportSaveOperationState : NSObject
{
    _Bool _didWriteSupportBundleSuccessfuly;
    _Bool _shouldLeavePendingEndSave;
    NSUUID *_originalDocumentUUID;
    NSUUID *_originalVersionUUID;
    NSURL *_originalURL;
    unsigned long long _updateType;
    TSUSafeSaveAssistant *_safeSaveAssistant;
    NSUUID *_documentUUID;
    NSURL *_URL;
}

@property(nonatomic) _Bool shouldLeavePendingEndSave; // @synthesize shouldLeavePendingEndSave=_shouldLeavePendingEndSave;
@property(nonatomic) _Bool didWriteSupportBundleSuccessfuly; // @synthesize didWriteSupportBundleSuccessfuly=_didWriteSupportBundleSuccessfuly;
@property(copy, nonatomic) NSURL *URL; // @synthesize URL=_URL;
@property(copy, nonatomic) NSUUID *documentUUID; // @synthesize documentUUID=_documentUUID;
@property(retain, nonatomic) TSUSafeSaveAssistant *safeSaveAssistant; // @synthesize safeSaveAssistant=_safeSaveAssistant;
@property(readonly, nonatomic) unsigned long long updateType; // @synthesize updateType=_updateType;
@property(readonly, nonatomic) NSURL *originalURL; // @synthesize originalURL=_originalURL;
@property(readonly, nonatomic) NSUUID *originalVersionUUID; // @synthesize originalVersionUUID=_originalVersionUUID;
@property(readonly, nonatomic) NSUUID *originalDocumentUUID; // @synthesize originalDocumentUUID=_originalDocumentUUID;
- (void).cxx_destruct;
- (id)initWithOriginalDocumentUUID:(id)arg1 originalVersionUUID:(id)arg2 originalURL:(id)arg3 updateType:(unsigned long long)arg4;
- (id)init;

@end

