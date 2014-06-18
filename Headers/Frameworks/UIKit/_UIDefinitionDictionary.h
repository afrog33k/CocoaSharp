/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class ASAsset, NSString;

// Not exported
@interface _UIDefinitionDictionary : NSObject
{
    struct __DCSDictionary *_dictionary;
    _Bool _activated;
    ASAsset *_rawAsset;
    NSString *_definitionLanguage;
}

@property _Bool activated; // @synthesize activated=_activated;
@property(readonly) NSString *definitionLanguage; // @synthesize definitionLanguage=_definitionLanguage;
@property(readonly) ASAsset *rawAsset; // @synthesize rawAsset=_rawAsset;
- (id)description;
- (id)_definitionValueForTerm:(id)arg1;
- (id)_attributedDefinitionForTerm:(id)arg1;
- (id)_fullHTMLDefinitionForTerm:(id)arg1;
- (id)_shortHTMLDefinitionForTerm:(id)arg1;
- (id)_HTMLDefinitionForTerm:(id)arg1 type:(long long)arg2;
- (_Bool)_hasDefinitionForTerm:(id)arg1;
@property(readonly) NSString *localizedDictionaryName;
- (void)dealloc;
- (id)initWithAsset:(id)arg1;

@end

