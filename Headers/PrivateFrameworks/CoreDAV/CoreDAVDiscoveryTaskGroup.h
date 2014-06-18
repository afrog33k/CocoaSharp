/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <CoreDAV/CoreDAVTaskGroup.h>

#import "CoreDAVOptionsTaskDelegate-Protocol.h"
#import "CoreDAVPropFindTaskDelegate-Protocol.h"

@class NSArray, NSMutableArray, NSString;

@interface CoreDAVDiscoveryTaskGroup : CoreDAVTaskGroup <CoreDAVOptionsTaskDelegate, CoreDAVPropFindTaskDelegate>
{
    NSString *_requiredComplianceClass;
    NSArray *_httpPorts;
    NSArray *_httpsPorts;
    NSString *_httpServiceString;
    NSString *_httpsServiceString;
    NSString *_wellKnownPath;
    NSArray *_potentialContextPaths;
    NSMutableArray *_discoveries;
    _Bool _didReceiveAuthenticationError;
    _Bool _shouldBailEarly;
    id <CoreDAVAccountInfoProvider> _discoveredAccountInfo;
}

@property(retain, nonatomic) NSArray *potentialContextPaths; // @synthesize potentialContextPaths=_potentialContextPaths;
@property(retain, nonatomic) NSString *wellKnownPath; // @synthesize wellKnownPath=_wellKnownPath;
@property(retain) id <CoreDAVAccountInfoProvider> discoveredAccountInfo; // @synthesize discoveredAccountInfo=_discoveredAccountInfo;
@property _Bool shouldBailEarly; // @synthesize shouldBailEarly=_shouldBailEarly;
@property _Bool didReceiveAuthenticationError; // @synthesize didReceiveAuthenticationError=_didReceiveAuthenticationError;
- (void)getDiscoveryStatus:(id)arg1 priorFailed:(id *)arg2 subsequentFailed:(id *)arg3 priorIncomplete:(id *)arg4 subsequentIncomplete:(id *)arg5 priorSuccess:(id *)arg6 subsequentSuccess:(id *)arg7;
- (void)addToDiscoveryArray:(id *)arg1 discovery:(id)arg2;
- (id)cleanedStringsFromResponseHeaders:(id)arg1 forHeader:(id)arg2;
- (id)extractPrincipalURLFromPropFindTask:(id)arg1 error:(id *)arg2;
- (id)propFindProperties;
- (void)noteDefinitiveAuthFailureFromTask:(id)arg1;
- (void)completeDiscovery:(id)arg1 error:(id)arg2;
- (void)propFindTaskFinished:(id)arg1;
- (void)optionsTask:(id)arg1 error:(id)arg2;
- (void)completeOptionsTask:(id)arg1 error:(id)arg2;
- (void)srvLookupTask:(id)arg1 error:(id)arg2;
- (void)task:(id)arg1 didFinishWithError:(id)arg2;
- (void)startPropfindTask:(id)arg1;
- (void)startOptionsTask:(id)arg1;
- (void)startWellKnownFallbackHeadTask:(id)arg1 withURL:(id)arg2;
- (void)startWellKnownLocationTask:(id)arg1 withURL:(id)arg2;
- (void)startSRVLookup:(id)arg1 serviceString:(id)arg2;
- (id)allDiscoveryPaths:(id)arg1;
- (id)allDiscoveryPorts:(id)arg1 withScheme:(id)arg2;
- (id)setupDiscoveries:(id)arg1 withSchemes:(id)arg2;
- (void)syncAway;
- (void)startTaskGroup;
- (void)cancelTaskGroup;
- (void)taskGroupWillCancelWithError:(id)arg1;
- (void)dealloc;
- (id)initWithAccountInfoProvider:(id)arg1 taskManager:(id)arg2;
- (id)initWithAccountInfoProvider:(id)arg1 taskManager:(id)arg2 httpPorts:(id)arg3 httpsPorts:(id)arg4 httpServiceString:(id)arg5 httpsServiceString:(id)arg6 wellKnownPaths:(id)arg7 requiredComplianceClass:(id)arg8;
- (id)initWithAccountInfoProvider:(id)arg1 taskManager:(id)arg2 httpPorts:(id)arg3 httpsPorts:(id)arg4 httpServiceString:(id)arg5 httpsServiceString:(id)arg6 wellKnownPath:(id)arg7 potentialContextPaths:(id)arg8 requiredComplianceClass:(id)arg9;

// Remaining properties
@property(nonatomic) id <CoreDAVDiscoveryTaskGroupDelegate> delegate; // @dynamic delegate;

@end

