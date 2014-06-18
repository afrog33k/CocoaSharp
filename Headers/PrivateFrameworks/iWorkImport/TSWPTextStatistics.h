/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

// Not exported
@interface TSWPTextStatistics : NSObject <NSCopying>
{
    unsigned long long _wordCount;
    unsigned long long _charactersNoWhiteSpace;
    unsigned long long _paragraphCount;
    _Bool _isAccurate;
}

@property(nonatomic) _Bool isAccurate; // @synthesize isAccurate=_isAccurate;
@property(nonatomic) unsigned long long paragraphCount; // @synthesize paragraphCount=_paragraphCount;
@property(nonatomic) unsigned long long charactersNoWhiteSpace; // @synthesize charactersNoWhiteSpace=_charactersNoWhiteSpace;
@property(nonatomic) unsigned long long wordCount; // @synthesize wordCount=_wordCount;
- (_Bool)isEqual:(id)arg1;
- (void)removeTextStatistics:(id)arg1;
- (void)addTextStatistics:(id)arg1;
- (void)setTextStatistics:(id)arg1;
- (void)resetStatistics;
- (id)copyWithZone:(struct _NSZone *)arg1;

@end

