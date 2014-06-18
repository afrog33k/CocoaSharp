/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSFileHandle, NSObject<OS_dispatch_queue>, NSObject<OS_dispatch_source>, SSLogFileOptions;

@interface SSRollableLog : NSObject
{
    NSObject<OS_dispatch_queue> *_dispatchQueue;
    double _lastFileStatTime;
    NSFileHandle *_fileHandle;
    NSObject<OS_dispatch_source> *_fileObserverSource;
    SSLogFileOptions *_options;
}

- (void)_rollLogFiles;
- (void)_openLogFile;
- (id)_logFilePathWithIndex:(long long)arg1;
- (void)_closeLogFile;
- (void)_checkLogFileSize;
- (id)_activeLogFilePath;
- (void)writeString:(id)arg1;
@property(readonly) SSLogFileOptions *logOptions;
- (void)dealloc;
- (id)initWithLogOptions:(id)arg1;

@end

