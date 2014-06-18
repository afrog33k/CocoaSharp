/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class TSSPropertyMap;

// Not exported
@interface TSCHConfiguration : NSObject
{
    _Bool mSupportsChartDataEditor;
    _Bool mSupportsChartRangeEditingMode;
    _Bool mSupportsNumberFormatSameAsSource;
    _Bool mShowMessageOnSelection;
    _Bool mDisableHighQualityRenderingIfNecessary;
    _Bool mSupports3DFillDataEmbeddingRecovery;
    _Bool mUse3DFillFor3DChartFallback;
    _Bool mExportsUsingSageKeynoteChartNonStyleDefaultsOverride;
    _Bool mSupportsTextBackground;
    Class mMultiDataChartOptionsControllerBuildSupportClass;
}

+ (void)resetSharedChartConfiguration;
+ (id)allocWithZone:(struct _NSZone *)arg1;
+ (id)sharedChartConfiguration;
+ (id)_singletonAlloc;
@property(nonatomic) Class multiDataChartOptionsControllerBuildSupportClass; // @synthesize multiDataChartOptionsControllerBuildSupportClass=mMultiDataChartOptionsControllerBuildSupportClass;
@property(nonatomic) _Bool supportsTextBackground; // @synthesize supportsTextBackground=mSupportsTextBackground;
@property(nonatomic) _Bool exportsUsingSageKeynoteChartNonStyleDefaultsOverride; // @synthesize exportsUsingSageKeynoteChartNonStyleDefaultsOverride=mExportsUsingSageKeynoteChartNonStyleDefaultsOverride;
@property(nonatomic) _Bool use3DFillFor3DChartFallback; // @synthesize use3DFillFor3DChartFallback=mUse3DFillFor3DChartFallback;
@property(nonatomic) _Bool supports3DFillDataEmbeddingRecovery; // @synthesize supports3DFillDataEmbeddingRecovery=mSupports3DFillDataEmbeddingRecovery;
@property(nonatomic) _Bool disableHighQualityRenderingIfNecessary; // @synthesize disableHighQualityRenderingIfNecessary=mDisableHighQualityRenderingIfNecessary;
@property(nonatomic) _Bool showMessageOnSelection; // @synthesize showMessageOnSelection=mShowMessageOnSelection;
@property(nonatomic) _Bool supportsNumberFormatSameAsSource; // @synthesize supportsNumberFormatSameAsSource=mSupportsNumberFormatSameAsSource;
@property(nonatomic) _Bool supportsChartRangeEditingMode; // @synthesize supportsChartRangeEditingMode=mSupportsChartRangeEditingMode;
@property(nonatomic) _Bool supportsChartDataEditor; // @synthesize supportsChartDataEditor=mSupportsChartDataEditor;
@property(readonly) TSSPropertyMap *appSpecificPropertyOverrides;
- (id)init;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)autorelease;
- (oneway void)release;
- (unsigned long long)retainCount;
- (id)retain;

@end

