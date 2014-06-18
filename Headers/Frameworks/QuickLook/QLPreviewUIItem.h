/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import <QuickLook/QLPreviewUIItem-Protocol.h>

@class NSString, NSURL, QLPreviewThumbnailGenerator, UIImage;

@interface QLPreviewUIItem : NSObject <QLPreviewUIItem>
{
    id <QLPreviewItem> _previewItem;
    QLPreviewThumbnailGenerator *_thumbnailGenerator;
    long long _index;
}

+ (id)genericIconForPreviewItem:(id)arg1;
+ (id)uiItemForPreviewItem:(id)arg1 index:(long long)arg2;
@property(readonly) long long previewItemIndex;
@property(readonly) long long level;
- (void)cancelIconUpdate;
- (void)updateIconWithSize:(struct CGSize)arg1 completionBlock:(id)arg2;
@property(readonly) UIImage *icon;
@property(readonly) _Bool isFolder;
@property(readonly) NSString *previewItemTitle;
@property(readonly) NSURL *previewItemURL;
- (void)dealloc;

@end

