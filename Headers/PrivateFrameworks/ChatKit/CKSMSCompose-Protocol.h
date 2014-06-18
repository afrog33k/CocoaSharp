/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol CKSMSCompose <NSObject>
+ (_Bool)canSendPhotos:(int)arg1 videos:(int)arg2 audioClips:(int)arg3;
+ (double)maxTrimDurationForVideo;
+ (double)maxTrimDurationForAudio;
+ (_Bool)acceptsMIMEType:(id)arg1;
- (void)setUICustomizationData:(id)arg1;
- (void)forceMMS;
- (void)forceCancelComposition;
- (void)setText:(id)arg1 subject:(id)arg2 addresses:(id)arg3;
- (void)setText:(id)arg1 addresses:(id)arg2;
- (void)setTextEntryContentsVisible:(_Bool)arg1;
- (void)disableCameraAttachments;
- (void)setCanEditRecipients:(_Bool)arg1;
- (void)setPendingAddresses:(id)arg1;
- (_Bool)insertFilename:(id)arg1 MIMEType:(id)arg2 exportedFilename:(id)arg3 options:(id)arg4;
- (_Bool)insertFilename:(id)arg1 MIMEType:(id)arg2 exportedFilename:(id)arg3;
- (_Bool)insertData:(id)arg1 MIMEType:(id)arg2 exportedFilename:(id)arg3;
- (_Bool)insertAttachmentWithURL:(id)arg1 andDescription:(id)arg2;
- (_Bool)insertTextPart:(id)arg1;
@end

