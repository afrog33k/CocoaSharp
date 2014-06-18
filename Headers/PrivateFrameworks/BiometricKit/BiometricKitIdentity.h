/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSSecureCoding-Protocol.h"

@class NSString, NSUUID;

@interface BiometricKitIdentity : NSObject <NSSecureCoding>
{
    int _type;
    int _attribute;
    int _entity;
    NSUUID *_uuid;
    NSString *_name;
}

+ (_Bool)supportsSecureCoding;
+ (id)biometricKitIdentity;
@property(copy, nonatomic) NSString *name; // @synthesize name=_name;
@property(nonatomic) int entity; // @synthesize entity=_entity;
@property(nonatomic) int attribute; // @synthesize attribute=_attribute;
@property(nonatomic) int type; // @synthesize type=_type;
@property(retain, nonatomic) NSUUID *uuid; // @synthesize uuid=_uuid;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (void)dealloc;
- (id)init;

@end

