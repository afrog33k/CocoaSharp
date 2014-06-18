/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <UIKit/UIKBCandidateCollectionView.h>

@class NSArray, UIKeyboardCandidateGridCollectionViewController, UITableViewIndex, UIView;

// Not exported
@interface UIKeyboardCandidateGridCollectionView : UIKBCandidateCollectionView
{
    double _indexMaximumHeight;
    UIKeyboardCandidateGridCollectionViewController *_parentViewController;
    double _previousGroupBarStartingY;
    UITableViewIndex *_index;
    UIView *_headerView;
}

@property(retain, nonatomic) UIView *headerView; // @synthesize headerView=_headerView;
@property(readonly, nonatomic) UITableViewIndex *index; // @synthesize index=_index;
@property(nonatomic) double previousGroupBarStartingY; // @synthesize previousGroupBarStartingY=_previousGroupBarStartingY;
@property(nonatomic) UIKeyboardCandidateGridCollectionViewController *parentViewController; // @synthesize parentViewController=_parentViewController;
@property(retain, nonatomic) NSArray *indexTitles;
- (void)keyboardWillShowNotification:(id)arg1;
- (void)keyboardDidHideNotification:(id)arg1;
- (void)selectItemAtIndexPath:(id)arg1 animated:(_Bool)arg2 scrollPosition:(unsigned long long)arg3;
- (void)setContentOffset:(struct CGPoint)arg1;
- (_Bool)shouldShowIndex;
- (void)showIndex:(_Bool)arg1;
- (void)delayUpdateIndex;
- (void)updateIndex;
- (void)updateIndex:(_Bool)arg1;
- (double)groupBarStartingY;
- (void)drawRect:(struct CGRect)arg1;
- (_Bool)isCellVisible:(id)arg1;
- (void)scrollToBottomWithAnimation:(_Bool)arg1;
- (void)scrollToOffsetFromTop:(double)arg1 withAnimation:(_Bool)arg2;
- (void)scrollToTopWithAnimation:(_Bool)arg1;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

