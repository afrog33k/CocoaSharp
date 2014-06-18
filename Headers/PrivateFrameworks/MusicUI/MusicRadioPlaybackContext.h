/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <MusicUI/MusicPlaybackContext.h>

@class MPAVItem, RadioStation;

@interface MusicRadioPlaybackContext : MusicPlaybackContext
{
    RadioStation *_station;
    unsigned long long _initialTrackIndex;
    MPAVItem *_prefixItem;
}

+ (Class)queueFeederClass;
@property(retain, nonatomic) MPAVItem *prefixItem; // @synthesize prefixItem=_prefixItem;
@property(nonatomic) unsigned long long initialTrackIndex; // @synthesize initialTrackIndex=_initialTrackIndex;
@property(readonly, nonatomic) RadioStation *station; // @synthesize station=_station;
- (void).cxx_destruct;
- (int)playbackMode;
- (id)initWithStation:(id)arg1;

@end

