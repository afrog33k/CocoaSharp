/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSSecureCoding-Protocol.h"

@class NSString;

@interface AVSpeechSynthesisVoice : NSObject <NSSecureCoding>
{
}

+ (_Bool)supportsSecureCoding;
+ (id)voiceWithLanguage:(id)arg1;
+ (id)currentLanguageCode;
+ (id)speechVoices;
+ (void)initialize;
- (void)dealloc;
- (id)initWithCoder:(id)arg1;
- (void)encodeWithCoder:(id)arg1;

// Remaining properties
@property(copy, nonatomic) NSString *language; // @dynamic language;

@end
