/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

@protocol CLIntersiloServiceProtocol
+ (id)getSilo;
- (void)heartAttack;

@optional
- (oneway void)release;
- (id)retain;
- (void)registerDelegate:(id)arg1 inSilo:(id)arg2;
- (void)endService;
- (void)beginService;
@end

