/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "TSARenderingExporterDelegate-Protocol.h"

@class NSString, TSARenderingExporter;

// Not exported
@interface TSAPdfRenderingExporterDelegate : NSObject <TSARenderingExporterDelegate>
{
    TSARenderingExporter *mRenderingExporter;
    NSString *mPassphraseOpen;
    NSString *mPassphrasePrintCopy;
    _Bool mRequireOpenPassword;
    _Bool mRequireCopyPassword;
    _Bool mRequirePrintPassword;
    int mRenderingQuality;
}

- (_Bool)supportsRenderingQuality;
- (_Bool)supportsPaging;
- (void)releaseCGContext:(struct CGContext *)arg1;
- (struct CGContext *)newCGContextForURL:(id)arg1;
- (double)viewScale;
- (void)teardown;
- (void)setup;
- (int)renderingQuality;
- (void)setRenderingQuality:(int)arg1;
- (void)setCopyPassphrase:(id)arg1 hint:(id)arg2;
- (void)setPrintPassphrase:(id)arg1 hint:(id)arg2;
- (void)setPassphrase:(id)arg1 hint:(id)arg2;
- (void)dealloc;
- (id)initWithRenderingExporter:(id)arg1;

@end

