/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <PhotoLibraryServices/_PLManagedAsset.h>

#import "UIActivityItemSource-Protocol.h"

@class CLLocation, NSArray, NSData, NSDate, NSDictionary, NSError, NSMutableOrderedSet, NSMutableSet, NSNumber, NSSet, NSString, NSURL, UIImage;

@interface PLManagedAsset : _PLManagedAsset <UIActivityItemSource>
{
    _Bool _didPrepareForDeletion;
    _Bool _isRegisteredForChanges;
    _Bool _needsMomentUpdate;
    _Bool _disableDupeAnalysis;
    _Bool _disableFileSystemPersistency;
    _Bool _didPersistAvalanche;
    NSURL *cachedNonPersistedVideoPlaybackURL;
    NSDate *cachedNonPersistedVideoPlaybackURLExpiration;
    NSError *cachedNonPersistedVideoPlaybackURLError;
    UIImage *inflightImageInMemory;
    NSString *inflightImagePath;
    UIImage *inflightIndexSheetImage;
    NSDictionary *inflightMetadata;
}

+ (id)uuidFromAssetURL:(id)arg1;
+ (id)uuidFromAssetURL:(id)arg1 fileExtension:(id *)arg2 sidecarIndex:(id *)arg3;
+ (id)fileURLFromAssetURL:(id)arg1 photoLibrary:(id)arg2;
+ (id)photoFromAssetURL:(id)arg1 photoLibrary:(id)arg2 sidecar:(id *)arg3;
+ (id)photoFromAssetURL:(id)arg1 photoLibrary:(id)arg2;
+ (int)wildcatCachedStackImageFormat;
+ (int)wildcatStackFormat;
+ (int)wildcatPhotoScrubberFormat;
+ (int)formatForThumbnailGeneration;
+ (int)wildcatIndexSheetFormat;
+ (int)landscapeScrubberThumbnailFormat;
+ (int)portraitScrubberThumbnailFormat;
+ (int)masterThumbnailFormat;
+ (int)feedEntryThumbnailFormat;
+ (int)indexSheetUnbakedFormat;
+ (int)indexSheetBakedFormat;
+ (int)posterThumbnailFormat;
+ (int)thumbnailFormat;
+ (int)fullSizeImageFormat;
+ (id)preferredFileExtensionForType:(id)arg1;
+ (_Bool)isValidFileExtensionForImport:(id)arg1;
+ (id)diagnosticFilePathForMainFilePath:(id)arg1;
+ (id)slalomRegionsPathForMainFilePath:(id)arg1;
+ (id)extensionForMediumThumbnailFile;
+ (id)extensionForLargeThumbnailFile;
+ (id)URLForMetadataWithExtension:(id)arg1 forMediaInMainDirectory:(id)arg2 withFilename:(id)arg3;
+ (id)abbreviatedMetadataDirectoryForDirectory:(id)arg1;
+ (short)assetTypeFromUniformTypeIdentifier:(id)arg1;
+ (id)uniformTypeIdentifierFromPathExtension:(id)arg1 assetType:(short)arg2;
+ (id)keyPathsForValuesAffectingIsJPEG;
+ (id)keyPathsForValuesAffectingMimeType;
+ (id)keyPathsForValuesAffectingUtiType;
+ (id)bestCreationDateForAssetAtURL:(id)arg1 modificationDate:(id *)arg2 creationDateString:(id *)arg3;
+ (id)keyPathsForValuesAffectingIsAudio;
+ (id)keyPathsForValuesAffectingIsPhoto;
+ (id)keyPathsForValuesAffectingIsVideo;
+ (id)keyPathsForValuesAffectingIsPhotoStreamPhoto;
+ (id)keyPathsForValuesAffectingDate;
+ (id)keyPathsForValuesAffectingHasLocationInfo;
+ (id)keyPathsForValuesAffectingGpsCoordinate;
+ (id)keyPathsForValuesAffectingRecordModDate;
+ (id)keyPathsForValuesAffectingImageSize;
+ (id)keyPathsForValuesAffectingCaptureTime;
+ (id)keyPathsForValuesAffectingAssetKind;
+ (CDStruct_c3b9c2ee)locationFromAVAsset:(id)arg1;
+ (CDStruct_c3b9c2ee)locationFromImageProperties:(id)arg1;
+ (id)assetWithObjectID:(id)arg1 inManagedObjectContext:(id)arg2;
+ (id)assetWithUUID:(id)arg1 inManagedObjectContext:(id)arg2;
+ (id)pathsForAllIncompleteAssetsInManagedObjectContext:(id)arg1;
+ (id)incompleteAssetsInManagedObjectContext:(id)arg1;
+ (id)_pathsByAssetUUIDFromFetchResults:(id)arg1 absolute:(_Bool)arg2;
+ (id)assetsWithSavedAssetType:(long long)arg1 inManagedObjectContext:(id)arg2;
+ (unsigned long long)countUsedAssetsWithKind:(short)arg1 inManagedObjectContext:(id)arg2;
+ (unsigned long long)countAssetsWithKind:(short)arg1 inManagedObjectContext:(id)arg2;
+ (void)extractDirectory:(id *)arg1 andFilename:(id *)arg2 fromMainFileURL:(id)arg3;
+ (id)_insertAssetIntoPhotoLibrary:(id)arg1 mainFileURL:(id)arg2 savedAssetType:(long long)arg3 replacementUUID:(id)arg4 imageSource:(struct CGImageSource **)arg5 imageData:(id *)arg6 isPlaceholder:(_Bool)arg7;
+ (id)insertAssetIntoPhotoLibrary:(id)arg1 mainFileURL:(id)arg2 savedAssetType:(long long)arg3 replacementUUID:(id)arg4 imageSource:(struct CGImageSource **)arg5 imageData:(id *)arg6;
+ (id)insertAssetIntoPhotoLibrary:(id)arg1 mainFileURL:(id)arg2 savedAssetType:(long long)arg3 replacementUUID:(id)arg4 imageSource:(struct CGImageSource **)arg5 imageData:(id *)arg6 isPlaceholder:(_Bool)arg7;
+ (id)locationFromLocationData:(id)arg1;
+ (id)keyPathsForValuesAffectingValueForKey:(id)arg1;
+ (id)assetWithObjectID:(id)arg1 inLibrary:(id)arg2;
+ (id)assetsWithUUIDs:(id)arg1 includePendingChanges:(_Bool)arg2 inLibrary:(id)arg3;
+ (id)assetsWithUUIDs:(id)arg1 inLibrary:(id)arg2;
+ (id)assetWithUUID:(id)arg1 inLibrary:(id)arg2;
@property(nonatomic) _Bool disableFileSystemPersistency; // @synthesize disableFileSystemPersistency=_disableFileSystemPersistency;
@property(nonatomic) _Bool disableDupeAnalysis; // @synthesize disableDupeAnalysis=_disableDupeAnalysis;
@property(nonatomic) _Bool needsMomentUpdate; // @synthesize needsMomentUpdate=_needsMomentUpdate;
@property(retain, nonatomic) NSDictionary *inflightMetadata; // @synthesize inflightMetadata;
@property(retain, nonatomic) UIImage *inflightIndexSheetImage; // @synthesize inflightIndexSheetImage;
@property(retain, nonatomic) NSString *inflightImagePath; // @synthesize inflightImagePath;
@property(retain, nonatomic) UIImage *inflightImageInMemory; // @synthesize inflightImageInMemory;
@property(retain, nonatomic) NSError *cachedNonPersistedVideoPlaybackURLError; // @synthesize cachedNonPersistedVideoPlaybackURLError;
@property(retain, nonatomic) NSDate *cachedNonPersistedVideoPlaybackURLExpiration; // @synthesize cachedNonPersistedVideoPlaybackURLExpiration;
@property(retain, nonatomic) NSURL *cachedNonPersistedVideoPlaybackURL; // @synthesize cachedNonPersistedVideoPlaybackURL;
- (id)activityViewController:(id)arg1 itemForActivityType:(id)arg2;
- (id)activityViewControllerPlaceholderItem:(id)arg1;
- (id)shortenedFilePath;
- (_Bool)isInRegion:(CDStruct_90e2a262)arg1;
@property(readonly, nonatomic) NSURL *assetURL;
- (id)assetURLForSidecarFile:(id)arg1;
- (id)assetURLWithExtension:(id)arg1;
- (id)previewFrameImageFromDatabase;
@property(readonly, nonatomic) UIImage *wallpaperFullScreenImage;
@property(readonly, nonatomic) NSString *textBadgeString;
- (id)filteredImage:(id)arg1 withCIContext:(id)arg2;
- (id)pasteBoardRepresentation;
- (void)copyToPasteboard;
- (id)largestAvailableDataRepresentationAndType:(id *)arg1;
- (void)getLargestAvailableDataRepresentation:(id *)arg1 type:(id *)arg2;
- (id)newLowResolutionFullScreenImage;
- (id)newFullSizeImage;
- (id)newFullScreenImage:(const struct __CFDictionary **)arg1;
- (id)indexSheetImage;
- (id)imageWithFormat:(int)arg1 outImageProperties:(const struct __CFDictionary **)arg2;
- (id)imageWithFormat:(int)arg1;
- (id)mimeTypeForService:(id)arg1;
- (id)fileExtensionForService:(id)arg1;
- (id)pathForDiagnosticFile;
- (id)slalomRegionsUseDefaults:(_Bool)arg1;
@property(readonly, nonatomic) NSArray *slalomRegions;
@property(readonly, nonatomic) _Bool hasSlalomRegions;
@property(readonly, nonatomic) NSString *pathForSlalomRegionsArchive;
@property(readonly, nonatomic) NSString *pathForFlattenedVideoFile;
@property(readonly, nonatomic) _Bool isMogul;
- (_Bool)_deviceSupportsMogul;
@property(readonly, nonatomic) NSString *pathForXMPFile;
@property(readonly, nonatomic) NSURL *fileURLForPrebakedPortraitScrubberThumbnails;
@property(readonly, nonatomic) NSString *pathForPrebakedPortraitScrubberThumbnails;
@property(readonly, nonatomic) NSURL *fileURLForPrebakedLandscapeScrubberThumbnails;
@property(readonly, nonatomic) NSString *pathForPrebakedLandscapeScrubberThumbnails;
- (void)generateLargeThumbnailFileIfNecessary;
- (id)reservedPathForLargeDisplayableImageFileForceLarge:(_Bool)arg1;
@property(readonly, nonatomic) NSString *pathForLargeDisplayableImageFile;
@property(readonly, nonatomic) NSString *pathForVideoFile;
@property(readonly, nonatomic) NSString *pathForVideoPreviewFile;
@property(readonly, nonatomic) NSString *pathForTrimmedVideoFile;
@property(readonly, nonatomic) NSString *pathForPrebakedWildcatThumbnailsFile;
@property(readonly, nonatomic) NSString *pathForPrebakedThumbnail;
@property(readonly, nonatomic) NSURL *fileURLForThumbnailFile;
- (id)fileURLForMetadataWithExtension:(id)arg1;
- (id)pathForMetadataWithExtension:(id)arg1;
@property(readonly, nonatomic) NSString *pathForMetadataDirectory;
@property(readonly, nonatomic) NSString *fileExtension;
@property(readonly, nonatomic) NSArray *allUniformTypeIdentifiers;
- (id)allFileExtensions;
- (id)fileURLForSidecarFile:(id)arg1;
@property(readonly, nonatomic) NSString *pathForOriginalFile;
- (id)fileURLForMediumThumbnailFile;
@property(readonly, nonatomic) NSString *pathForMediumThumbnailFile;
@property(readonly, nonatomic) NSURL *fileURLForLargeThumbnailFile;
@property(readonly, nonatomic) NSString *pathForLargeThumbnailFile;
@property(readonly, nonatomic) NSSet *allFileURLs;
@property(readonly, nonatomic) NSSet *filePathsWithoutThumbs;
@property(readonly, nonatomic) NSString *pathForImageFile;
@property(readonly, nonatomic) NSURL *mainFileURL;
- (_Bool)isSavedPhotosAsset;
- (_Bool)couldBeStoredInDCIM;
- (_Bool)hasImageFile;
- (void)updateAssetKindFromUniformTypeIdentifier;
- (void)setUniformTypeIdentifierFromPathExtension:(id)arg1;
@property(readonly, nonatomic) _Bool isJPEG;
@property(readonly, nonatomic) NSString *mimeType;
@property(copy, nonatomic) NSString *utiType;
@property(readonly, nonatomic) NSArray *sortedSidecarFiles;
- (_Bool)hasJustBeenHidden;
- (_Bool)hasJustBeenShown;
- (_Bool)isIncludedInCloudFeeds;
- (_Bool)isIncludedInMoments;
- (_Bool)isCloudPlaceholder;
- (_Bool)canPerformSharingActions;
- (_Bool)canPerformEditOperation:(int)arg1;
@property(readonly, nonatomic) _Bool allowsWallpaperEditing;
@property(nonatomic) short visibilityStateValue;
- (_Bool)isEditable;
@property(readonly, nonatomic) _Bool isAudio;
- (_Bool)_hasPanoramaDimensions;
- (_Bool)isPanorama;
@property(readonly, nonatomic) _Bool isPhoto;
@property(readonly, nonatomic) _Bool isHDVideo;
@property(readonly, nonatomic) _Bool isStreamedVideo;
@property(readonly, nonatomic) _Bool isVideo;
@property(readonly, nonatomic) id <PLCloudSharedAlbumProtocol> cloudShareAlbum;
@property(readonly, nonatomic) _Bool isCloudSharedAsset;
@property(readonly, nonatomic) _Bool isUsedByiPhoto;
@property(readonly, nonatomic) _Bool isPhotoStreamPhoto;
@property(readonly, nonatomic) NSDate *date;
@property(readonly, nonatomic) _Bool hasLocationInfo;
@property(nonatomic) CDStruct_c3b9c2ee gpsCoordinate;
- (void)setRecordModDate;
@property(nonatomic) double recordModDate;
@property(nonatomic) struct CGSize imageSize;
@property(nonatomic) double captureTime;
@property(nonatomic) short assetKindSubtype;
@property(nonatomic) short assetKind;
- (void)generateAndUpdateThumbnailsWithPreviewImage:(id)arg1 thumbnailImage:(id)arg2 fromImageSource:(struct CGImageSource *)arg3 imageData:(id)arg4 thumbnailDataByFormatID:(struct __CFDictionary *)arg5 updateExistingLargePreview:(_Bool)arg6;
- (_Bool)setVideoInfoFromFileAtURL:(id)arg1;
- (void)setSavedAssetTypeFromImageProperties:(id)arg1;
- (void)setSizeAndOrientationFromImageProperties:(id)arg1;
- (void)setHDRFlagFromImageProperties:(id)arg1;
- (void)setThumbnailDataFromImageProperties:(id)arg1;
- (void)setLocationFromImageProperties:(id)arg1;
- (id)pictureTransferProtocolInformationWithAlbumsObjectIDs:(id)arg1;
- (_Bool)setAttributesFromMainFileURL:(id)arg1 savedAssetType:(long long)arg2 imageSource:(struct CGImageSource **)arg3 imageData:(id *)arg4;
@property short embeddedThumbnailHeightValue;
@property(retain, nonatomic) NSNumber *embeddedThumbnailHeight;
@property short embeddedThumbnailWidthValue;
@property(retain, nonatomic) NSNumber *embeddedThumbnailWidth;
@property int embeddedThumbnailLengthValue;
@property(retain, nonatomic) NSNumber *embeddedThumbnailLength;
@property int embeddedThumbnailOffsetValue;
@property(retain, nonatomic) NSNumber *embeddedThumbnailOffset;
@property(readonly, nonatomic) NSData *embeddedThumbnailData;
@property(readonly, nonatomic) _Bool hasEmbeddedThumbnail;
- (id)addFaceWithRelativeRect:(struct CGRect)arg1 identifier:(short)arg2 albumUUID:(id)arg3;
- (id)faceWithIdentifier:(short)arg1;
- (void)setPersistedFileSystemAttributes;
- (void)persistMetadataToFilesystem;
- (void)_persistAvalancheToFilesystem;
- (id)_prettyDescription;
- (id)_compactDebugDescription;
- (id)_kindDescription;
- (id)_savedAssetTypeDescription;
- (id)_highDynamicRangeTypeDescription;
- (void)unregisterForChanges;
- (void)registerForChanges;
- (_Bool)_isValidUTI:(id)arg1 forService:(id)arg2;
- (_Bool)_isSavedAssetTypeValueValid:(long long)arg1;
@property(readonly, nonatomic) UIImage *inflightImage;
@property(nonatomic) _Bool isInFlight;
- (id)pathToOriginalVideoFile;
- (void)setPublicGlobalUUID:(id)arg1;
- (_Bool)hasGPS;
@property(retain, nonatomic) PLManagedAsset *originalAsset;
- (id)adjustmentsXMPRepresentation;
- (void)updateAdjustmentsWithAdjustmentMetadata:(id)arg1;
- (void)updateAdjustmentsWithFiltersAndIdentifiers:(id)arg1;
- (id)_settingsDictionaryFromFilters:(id)arg1 inputImageExtent:(struct CGRect)arg2;
- (id)_settingsDictionaryFromFilter:(id)arg1;
- (id)_serializedPropertyDataFromFilter:(id)arg1;
- (id)addAdjustment;
- (void)didSave;
- (void)willSave;
- (void)deleteFromDatabaseOnly;
- (void)delete;
- (_Bool)isDeletableFromAssetsLibrary;
- (id)avalanchePickDescription;
- (_Bool)isAvalanchePhoto;
- (_Bool)isAvalancheStackPhoto;
- (_Bool)avalanchePickTypeIsVisible;
@property(nonatomic) int avalanchePickTypeValue;
@property(retain, nonatomic) CLLocation *location;
- (_Bool)isLocatedAtCoordinates:(CDStruct_c3b9c2ee)arg1;
@property(nonatomic) long long savedAssetTypeValue;
@property(nonatomic) int highDynamicRangeTypeValue;
- (void)prepareForDeletion;
- (id)thumbnailIdentifier;
- (_Bool)hasThumbnail;
@property unsigned long long effectiveThumbnailIndex;
@property long long thumbnailIndex;
- (void)willTurnIntoFault;
- (void)awakeFromSnapshotEvents:(unsigned long long)arg1;
- (void)awakeFromFetch;
- (void)awakeFromInsert;
- (void)dealloc;

// Remaining properties
@property(readonly, nonatomic) NSMutableOrderedSet *adjustments; // @dynamic adjustments;
@property(retain, nonatomic) NSMutableSet *faces; // @dynamic faces;

@end

