/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/GQPProcessor.h>

// Not exported
@interface GQPBGProcessor : GQPProcessor
{
    Class mGenerator;
}

- (Class)generator;
- (_Bool)go;
- (void)pushInitialState;
- (id)initWithPath:(id)arg1 zipArchive:(id)arg2 indexFileName:(id)arg3 outputType:(int)arg4 outputPath:(struct __CFString *)arg5 previewRequest:(struct __QLPreviewRequest *)arg6 progressiveHelper:(id)arg7 generator:(Class)arg8 cryptoKey:(id)arg9;
- (id)initWithPath:(id)arg1 indexFileName:(id)arg2 outputType:(int)arg3 outputPath:(struct __CFString *)arg4 previewRequest:(struct __QLPreviewRequest *)arg5 progressiveHelper:(id)arg6 generator:(Class)arg7 zipArchive:(id)arg8 cryptoKey:(id)arg9;

@end

