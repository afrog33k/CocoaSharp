/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <RTCReporting/RTCReportingBackEnd.h>

@class NSString;

@interface UploadBackend : RTCReportingBackEnd
{
    NSString *_uploadURL;
}

@property(copy) NSString *uploadURL; // @synthesize uploadURL=_uploadURL;
- (_Bool)uploadFileAtPath:(id)arg1;
- (void)dealloc;
- (id)initWithName:(id)arg1 profile:(id)arg2;

@end

