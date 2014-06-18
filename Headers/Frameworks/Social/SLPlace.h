/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSSecureCoding-Protocol.h"

@class NSString, NSURL;

@interface SLPlace : NSObject <NSSecureCoding>
{
    NSString *_identifier;
    NSString *_name;
    NSURL *_pictureURL;
    NSString *_category;
    double _latitude;
    double _longitude;
    double _distance;
}

+ (_Bool)supportsSecureCoding;
@property double distance; // @synthesize distance=_distance;
@property double longitude; // @synthesize longitude=_longitude;
@property double latitude; // @synthesize latitude=_latitude;
@property(retain) NSString *category; // @synthesize category=_category;
@property(retain) NSURL *pictureURL; // @synthesize pictureURL=_pictureURL;
@property(retain) NSString *name; // @synthesize name=_name;
@property(retain) NSString *identifier; // @synthesize identifier=_identifier;
- (void).cxx_destruct;
- (id)description;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (id)encodableProperties;

@end

