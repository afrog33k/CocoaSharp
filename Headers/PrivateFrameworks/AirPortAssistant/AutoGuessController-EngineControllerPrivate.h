/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AirPortAssistant/AutoGuessController.h>

@interface AutoGuessController (EngineControllerPrivate)
- (void)runAutoGuessThread:(id)arg1;
- (void)bonjourTXTRemoved:(id)arg1;
- (void)bonjourTXTUpdated:(id)arg1;
- (void)browseReadyTimerCallback:(id)arg1;
- (void)stopWiFiScanner;
- (void)cancelWiFiScanner;
- (void)wirelessScanDone:(id)arg1;
- (void)stopBonjourBrowser;
- (void)cancelBonjourBrowser;
- (int)startBonjourBrowser;
- (int)bonjourBrowseStatus;
- (void)setBonjourBrowseStatus:(int)arg1;
- (int)wifiScanStatus;
- (void)setWiFiScanStatus:(int)arg1;
- (_Bool)okToSwitchToShortBonjourTimeout:(id)arg1;
- (void)uiAssetsUpdated:(id)arg1;
- (void)updateTargetInfo:(_Bool)arg1;
- (id)targetInfo;
- (void)autoGuessEngineComplete;
- (void)startAutoGuessIfReady;
- (int)startAutoGuessForUnconfiguredMACAddress:(id)arg1 withWifiScanInfos:(id)arg2;
@end

