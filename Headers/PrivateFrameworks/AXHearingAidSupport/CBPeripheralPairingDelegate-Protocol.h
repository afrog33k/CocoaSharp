/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject-Protocol.h"

@protocol CBPeripheralPairingDelegate <NSObject>

@optional
- (void)peripheralDidUnpair:(id)arg1;
- (void)peripheral:(id)arg1 didFinishPairingWithResult:(id)arg2;
- (void)peripheral:(id)arg1 didReceivePairingRequestOfType:(id)arg2 withPasskey:(id)arg3;
@end

