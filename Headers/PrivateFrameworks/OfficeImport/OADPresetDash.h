/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/OADDash.h>

// Not exported
@interface OADPresetDash : OADDash
{
    unsigned char mType;
    unsigned int mIsTypeOverridden:1;
}

+ (id)defaultProperties;
- (_Bool)isEqual:(id)arg1;
- (unsigned long long)hash;
- (id)equivalentCustomDash;
- (_Bool)isTypeOverridden;
- (void)setType:(int)arg1;
- (int)type;
- (id)initWithDefaults;
- (id)copyWithZone:(struct _NSZone *)arg1;

@end
