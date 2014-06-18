/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <MusicLibrary/ML3DatabaseResult.h>

@class ML3DatabaseDistantConnection, NSArray, NSString;

@interface ML3DatabaseDistantResult : ML3DatabaseResult
{
    NSArray *_cachedRows;
    ML3DatabaseDistantConnection *_distantConnection;
    NSString *_sql;
    NSArray *_parameters;
    NSString *_limitProperty;
    long long _limitValue;
}

@property(nonatomic) long long limitValue; // @synthesize limitValue=_limitValue;
@property(retain, nonatomic) NSString *limitProperty; // @synthesize limitProperty=_limitProperty;
@property(readonly, nonatomic) NSArray *parameters; // @synthesize parameters=_parameters;
@property(readonly, nonatomic) NSString *sql; // @synthesize sql=_sql;
@property(readonly, nonatomic) ML3DatabaseDistantConnection *distantConnection; // @synthesize distantConnection=_distantConnection;
- (void).cxx_destruct;
- (_Bool)_fetchRowsIfEmpty;
- (void)_localEnumerateRowsWithBlock:(id)arg1;
- (void)_remoteEnumerateRowsWithBlock:(id)arg1;
- (void)enumerateRowsWithBlock:(id)arg1;
- (id)columnNameIndexMap;
- (unsigned long long)indexForColumnName:(id)arg1;
- (void)setLimitProperty:(id)arg1 limitValue:(long long)arg2;
- (id)description;
- (id)init;
- (id)initWithStatement:(id)arg1;
- (id)initWithDistantConnection:(id)arg1 sql:(id)arg2 parameters:(id)arg3;

@end

