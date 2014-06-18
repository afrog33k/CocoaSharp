/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIPickerViewDelegate-Protocol.h"
#import "UITableViewDataSource-Protocol.h"
#import "UITableViewDelegate-Protocol.h"

@protocol MFMailComposeViewDelegate <UIPickerViewDelegate, UITableViewDelegate, UITableViewDataSource>
- (id)attachmentStoreCreateIfNecessary;
- (id)popoverManager;
- (void)insertPhotoOrVideo;
- (int)compositionType;
- (id)currentScaleImageSize;
- (_Bool)hasAttachments;
- (_Bool)bccAddressesDirtied;
- (_Bool)sendingEmailDirtied;
- (_Bool)canShowImageSizeField;
- (_Bool)canShowFromField;
- (id)sendingAccountProxy;
- (void)updateSignature;
- (void)addSignature:(_Bool)arg1;
- (void)setSendingEmailAddress:(id)arg1;
- (id)sendingEmailAddress;
- (id)sendingEmailAddressIfExists;
- (id)emailAddresses;
- (void)scrollToSelectedEntryInFromAddressTableView:(id)arg1;
- (void)selectCurrentEntryForFromAddressPickerView:(id)arg1;

@optional
- (void)composeBodyFieldDidFinishLoad;
@end

