/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSARenderingExporter.h>

@class NSMutableArray, TNPageController, TNPdfHyperlinkController;

// Not exported
@interface TNRenderingExporter : TSARenderingExporter
{
    unsigned long long mSheetIndex;
    unsigned long long mPageIndex;
    unsigned long long mTotalPagesCount;
    vector_88016b54 mSheetPageCountArray;
    vector_88016b54 mSheetPageStartArray;
    TNPageController *mPageController;
    TNPdfHyperlinkController *mHyperlinkController;
    NSMutableArray *mCanvasBasedSheets;
    _Bool _renderingAllSheets;
}

@property(nonatomic, getter=isRenderingAllSheets) _Bool renderingAllSheets; // @synthesize renderingAllSheets=_renderingAllSheets;
- (id).cxx_construct;
- (void).cxx_destruct;
- (_Bool)isPageInPortraitOrientation:(unsigned long long)arg1;
- (struct CGRect)p_boundsRectForFirstPage;
- (_Bool)p_isActiveSheetForm;
- (id)p_canvasBasedSheets;
- (double)totalProgess;
- (void)drawCurrentPageWithContext:(struct CGContext *)arg1 returnSuccess:(_Bool *)arg2;
- (void)drawAllPagesWithContext:(struct CGContext *)arg1 returnSuccess:(_Bool *)arg2;
- (id)p_activeSheet;
- (void)teardown;
- (void)setup;
- (void)dealloc;
- (id)initWithDocumentRoot:(id)arg1;
- (id)pageController;

@end

