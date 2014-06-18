/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "TSKCompatibilityDelegate-Protocol.h"

// Not exported
@interface KNBaseCompatibilityDelegate : NSObject <TSKCompatibilityDelegate>
{
}

- (id)nestedDocumentFilename;
- (id)needNewerVersionIndexXmlContentString;
- (id)indexXmlFilename;
- (_Bool)isSageDocumentType:(id)arg1;
- (_Bool)isTCMessageExceptionErrorDomain:(id)arg1;
- (id)exportableTypes;
- (Class)exportOptionsControllerClass;
- (Class)pdfExporterClassForOptions:(id)arg1;
- (Class)exporterClassForType:(id)arg1 options:(id)arg2;
- (Class)importerClassForType:(id)arg1;
- (id)newExportableDocumentTypesForFlag:(unsigned long long)arg1;

@end

