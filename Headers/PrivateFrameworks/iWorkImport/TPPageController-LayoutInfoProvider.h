/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TPPageController.h>

#import "TPPageLayoutInfoProvider-Protocol.h"

@interface TPPageController (LayoutInfoProvider) <TPPageLayoutInfoProvider>
- (struct _NSRange)p_rangeOfContinuousSectionsAtPageIndex:(unsigned long long)arg1 startPage:(unsigned long long *)arg2;
- (id)p_pageMasterForPageIndex:(unsigned long long)arg1 inSection:(id)arg2 sectionHint:(id)arg3;
- (id)p_sectionAtSectionIndex:(unsigned long long)arg1;
- (int)contentFlagsForPageIndex:(unsigned long long)arg1;
- (unsigned long long)pageCountForPageIndex:(unsigned long long)arg1;
- (unsigned long long)pageNumberForPageIndex:(unsigned long long)arg1;
- (id)masterDrawableProviderForPageIndex:(unsigned long long)arg1;
- (_Bool)shouldHeaderFooterBeVisibleForPageIndex:(unsigned long long)arg1;
- (id)headerFooterProviderForPageIndex:(unsigned long long)arg1;
- (_Bool)canProvideNumberingInfoForPageIndex:(unsigned long long)arg1;
- (_Bool)canProvideInfoForPageIndex:(unsigned long long)arg1;
@end

