/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UICollectionViewCell.h"

@class NSMutableArray, NSString, UIButton, UIImage, UILabel;

@interface _MusicGeniusMixCollectionViewCell : UICollectionViewCell
{
    UILabel *_artistsLabel;
    UILabel *_basedOnLabel;
    NSMutableArray *_coverViews;
    UILabel *_titleLabel;
    _Bool _offline;
    _Bool _playing;
    UIImage *_combinedArtworkImage;
    UIButton *_playButton;
}

@property(nonatomic, getter=isPlaying) _Bool playing; // @synthesize playing=_playing;
@property(nonatomic, getter=isOffline) _Bool offline; // @synthesize offline=_offline;
@property(readonly, nonatomic) UIButton *playButton; // @synthesize playButton=_playButton;
@property(retain, nonatomic) UIImage *combinedArtworkImage; // @synthesize combinedArtworkImage=_combinedArtworkImage;
- (void).cxx_destruct;
- (void)_updatePlayButtonAlpha;
- (void)_updateCoverViewsAlpha;
- (id)_pressedPlayButtonImage;
@property(copy, nonatomic) NSString *title;
- (void)setPlaying:(_Bool)arg1 animated:(_Bool)arg2;
@property(copy, nonatomic) NSString *artistsText;
- (void)layoutSubviews;
- (id)initWithFrame:(struct CGRect)arg1;

@end

