/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITableViewHeaderFooterView.h"

@class MPUItemOfferButton, NSString, UIImage, UIImageView, UILabel, UIView;

@interface MusicFlipsideAlbumDetailHeaderView : UITableViewHeaderFooterView
{
    UIImageView *_artworkImageView;
    UIView *_hairlineView;
    MPUItemOfferButton *_itemOfferButton;
    UILabel *_artistLabel;
    UILabel *_albumLabel;
    UILabel *_songLabel;
    UILabel *_durationLabel;
    UILabel *_copyrightYearLabel;
    UIView *_topCellSeparatorView;
    double _cloudRightInset;
    id _downloadActionBlock;
    long long _songCount;
    double _totalDuration;
    NSString *_copyright;
    NSString *_year;
}

+ (double)defaultHeight;
+ (struct CGSize)artworkSize;
@property(readonly, nonatomic) NSString *year; // @synthesize year=_year;
@property(readonly, nonatomic) NSString *copyright; // @synthesize copyright=_copyright;
@property(nonatomic) double totalDuration; // @synthesize totalDuration=_totalDuration;
@property(nonatomic) long long songCount; // @synthesize songCount=_songCount;
@property(copy, nonatomic) id downloadActionBlock; // @synthesize downloadActionBlock=_downloadActionBlock;
@property(nonatomic) double cloudRightInset; // @synthesize cloudRightInset=_cloudRightInset;
- (void).cxx_destruct;
- (void)_itemOfferButtonAction:(id)arg1;
- (void)setCopyright:(id)arg1 year:(id)arg2;
@property(copy, nonatomic) NSString *album;
@property(copy, nonatomic) NSString *artist;
@property(nonatomic) double backgroundTransitionProgress;
@property(nonatomic, getter=isDownloadable) _Bool downloadable;
@property(retain, nonatomic) UIImage *artworkImage;
- (void)setTableViewStyle:(long long)arg1;
- (void)layoutSubviews;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

