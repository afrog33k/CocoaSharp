/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "SBFileLoggerDelegate-Protocol.h"

@class NSMutableDictionary;

@interface SBFileLogManager : NSObject <SBFileLoggerDelegate>
{
    NSMutableDictionary *_loggersByName;
}

+ (id)sharedInstance;
- (void)loggerEnabledStateChanged:(id)arg1;
- (void)_recordForLogNamed:(id)arg1 format:(id)arg2 arguments:(struct __va_list_tag [1])arg3;
- (void)_enableOrDisableLoggerIfNecessary:(id)arg1;
- (void)_addLogger:(id)arg1;
- (_Bool)isClass:(Class)arg1 aKindOfClass:(Class)arg2;
- (void)_loadFileLoggers;
- (void)flush;
- (void)reloadFromDefaults;
- (id)loggerForName:(id)arg1;
- (void)dealloc;
- (id)init;

@end

