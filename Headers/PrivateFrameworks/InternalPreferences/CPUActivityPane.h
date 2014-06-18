/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "PSEditingPane.h"

@class NSThread, UITextView;

@interface CPUActivityPane : PSEditingPane
{
    NSThread *_worker;
    UITextView *_textView;
    char _buf1[4096];
    char _buf2[4096];
    char *_readBuffer;
    char *_writeBuffer;
}

- (void)_worker;
- (void)_switchBuffers:(id)arg1;
- (void)setPreferenceSpecifier:(id)arg1;
- (void)willMoveToSuperview:(id)arg1;
- (void)_killWorker;
- (void)_startWorker;
- (void)_cleanupTextView;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

