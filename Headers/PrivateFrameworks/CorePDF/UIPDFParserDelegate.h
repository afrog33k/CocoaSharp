/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSXMLParserDelegate-Protocol.h"

@interface UIPDFParserDelegate : NSObject <NSXMLParserDelegate>
{
    struct CGPoint _p[4];
    struct CGPath *_path;
    _Bool _parserError;
}

@property(readonly) _Bool parserError; // @synthesize parserError=_parserError;
- (void)parser:(id)arg1 didEndElement:(id)arg2 namespaceURI:(id)arg3 qualifiedName:(id)arg4;
- (void)parser:(id)arg1 didStartElement:(id)arg2 namespaceURI:(id)arg3 qualifiedName:(id)arg4 attributes:(id)arg5;
- (void)parserDidStartDocument:(id)arg1;
- (void)parser:(id)arg1 parseErrorOccurred:(id)arg2;
@property(readonly) struct CGPath *path; // @dynamic path;
- (void)dealloc;
- (id)init;

@end
