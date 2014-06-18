/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/OAXGeometry.h>

@interface OAXGeometry (Private)
+ (id)pathFillModeEnumMap;
+ (id)formulaKeywordEnumMap;
+ (id)formulaTypeEnumMap;
+ (id)shapeTypeEnumMap;
+ (void)readPathsFromCustomGeometryXmlNode:(struct _xmlNode *)arg1 toCustomGeometry:(id)arg2 formulaNameToIndexMap:(id)arg3;
+ (void)readTextRectFromCustomGeometryXmlNode:(struct _xmlNode *)arg1 toCustomGeometry:(id)arg2 formulaNameToIndexMap:(id)arg3;
+ (struct OADAdjustCoord)readAdjustCoordFromXmlNode:(struct _xmlNode *)arg1 name:(const char *)arg2 formulaNameToIndexMap:(id)arg3;
+ (void)addFormulasFromFile:(id)arg1 toCustomGeometry:(id)arg2 formulaNameToIndexMap:(id)arg3;
+ (void)readFormulasFromCustomGeometryXmlNode:(struct _xmlNode *)arg1 toCustomGeometry:(id)arg2 adjustValueNameToIndexMap:(id)arg3 formulaNameToIndexMap:(id)arg4;
+ (void)readAdjustValuesFromCustomGeometryXmlNode:(struct _xmlNode *)arg1 toCustomGeometry:(id)arg2 adjustValueNameToIndexMap:(id)arg3;
+ (id)readPresetGeometryFromXmlNode:(struct _xmlNode *)arg1;
+ (int)adjustValueWithGuideXmlNode:(struct _xmlNode *)arg1;
@end

