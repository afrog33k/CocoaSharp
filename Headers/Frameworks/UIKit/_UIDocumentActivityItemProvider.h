/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIActivityItemProvider.h>

@class UIDocumentInteractionController;

// Not exported
@interface _UIDocumentActivityItemProvider : UIActivityItemProvider
{
    UIDocumentInteractionController *_documentInteractionController;
}

@property UIDocumentInteractionController *documentInteractionController; // @synthesize documentInteractionController=_documentInteractionController;
- (id)activityViewController:(id)arg1 itemForActivityType:(id)arg2;
- (id)activityViewControllerPlaceholderItem:(id)arg1;
- (id)item;

@end

