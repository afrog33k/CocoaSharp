/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

#import "EKDayAllDayViewDelegate-Protocol.h"
#import "EKDayTimeViewDelegate-Protocol.h"
#import "EKDayViewContentDelegate-Protocol.h"
#import "UIScrollViewDelegate-Protocol.h"

@class EKDayAllDayView, EKDayTimeView, EKDayViewContent, EKEvent, NSArray, NSCalendar, NSDate, NSDateComponents, NSTimer, UIColor, UIImageView, UIScrollAnimation, UIScrollView;

@interface EKDayView : UIView <UIScrollViewDelegate, EKDayAllDayViewDelegate, EKDayViewContentDelegate, EKDayTimeViewDelegate>
{
    long long _orientation;
    double _dayStart;
    double _dayEnd;
    double _nextDSTTransition;
    _Bool _scrollbarShowsInside;
    _Bool _scrollingToOccurrence;
    _Bool _settingDate;
    _Bool _userScrolling;
    _Bool _scrollToOccurrencesOnNextReload;
    UIImageView *_topVerticalGridExtension;
    UIImageView *_bottomVerticalGridExtension;
    UIView *_bottomLine;
    NSArray *_existingTimedOcurrences;
    NSDate *_lastInspectedOccurrenceOnDate;
    struct CGSize _scrolledToFirstVisibleSecondForSize;
    EKDayAllDayView *_allDayView;
    EKDayViewContent *_dayContent;
    EKDayTimeView *_timeView;
    UIScrollAnimation *_scrollAnimation;
    UIScrollView *_scroller;
    NSTimer *_timeMarkerTimer;
    _Bool _allowsOccurrenceSelection;
    _Bool _alignsMidnightToTop;
    _Bool _shouldEverShowTimeIndicators;
    _Bool _usesVibrantGridDrawing;
    int _outlineStyle;
    id <EKDayViewDelegate> _delegate;
    id <EKDayViewDataSource> _dataSource;
    NSDateComponents *_displayDate;
    NSCalendar *_calendar;
    UIColor *_occurrenceTextBackgroundColor;
}

@property(nonatomic) _Bool usesVibrantGridDrawing; // @synthesize usesVibrantGridDrawing=_usesVibrantGridDrawing;
@property(retain, nonatomic) UIColor *occurrenceTextBackgroundColor; // @synthesize occurrenceTextBackgroundColor=_occurrenceTextBackgroundColor;
@property(nonatomic) int outlineStyle; // @synthesize outlineStyle=_outlineStyle;
@property(nonatomic) _Bool shouldEverShowTimeIndicators; // @synthesize shouldEverShowTimeIndicators=_shouldEverShowTimeIndicators;
@property(nonatomic) _Bool alignsMidnightToTop; // @synthesize alignsMidnightToTop=_alignsMidnightToTop;
@property(nonatomic) _Bool allowsOccurrenceSelection; // @synthesize allowsOccurrenceSelection=_allowsOccurrenceSelection;
@property(readonly, nonatomic) double dayEnd; // @synthesize dayEnd=_dayEnd;
@property(readonly, nonatomic) double dayStart; // @synthesize dayStart=_dayStart;
@property(copy, nonatomic) NSCalendar *calendar; // @synthesize calendar=_calendar;
@property(copy, nonatomic) NSDateComponents *displayDate; // @synthesize displayDate=_displayDate;
@property(nonatomic) __weak id <EKDayViewDataSource> dataSource; // @synthesize dataSource=_dataSource;
@property(nonatomic) __weak id <EKDayViewDelegate> delegate; // @synthesize delegate=_delegate;
- (void).cxx_destruct;
- (void)addViewToScroller:(id)arg1 isAllDay:(_Bool)arg2;
- (_Bool)isAllDayLabelHighlighted;
- (void)setAllDayLabelHighlighted:(_Bool)arg1;
- (double)highlightedHour;
- (void)highlightHour:(double)arg1;
- (double)allDayRegionHeight;
- (_Bool)scrollTowardPoint:(struct CGPoint)arg1;
- (struct CGPoint)pointAtDate:(double)arg1 isAllDay:(_Bool)arg2;
- (double)_adjustSecondBackwardForDSTHole:(double)arg1;
- (double)_adjustSecondForwardForDSTHole:(double)arg1;
- (double)dateAtPoint:(struct CGPoint)arg1 isAllDay:(_Bool *)arg2 requireAllDayRegionInsistence:(_Bool)arg3;
- (double)dateAtPoint:(struct CGPoint)arg1 isAllDay:(_Bool *)arg2;
- (id)occurrenceViewAtPoint:(struct CGPoint)arg1;
- (void)_timeViewTapped:(id)arg1;
- (void)dayViewContent:(id)arg1 didTapPinnedOccurrence:(id)arg2;
- (void)dayViewContent:(id)arg1 didTapInEmptySpaceOnDay:(double)arg2;
- (void)dayViewContent:(id)arg1 didSelectEvent:(id)arg2;
- (void)dayViewContent:(id)arg1 didCreateOccurrenceViews:(id)arg2;
- (void)occurrencePressed:(id)arg1 onDay:(double)arg2;
- (void)allDayViewDidLayoutSubviews:(id)arg1;
- (void)allDayView:(id)arg1 didSelectEvent:(id)arg2;
- (void)reloadData;
- (void)relayoutExistingTimedOccurrences;
- (void)setScrollerYInset:(double)arg1 keepingYPointVisible:(double)arg2;
- (void)scrollEventsIntoViewAnimated:(_Bool)arg1;
- (void)_disposeAllDayView;
- (void)_createAllDayView;
- (void)scrollViewDidEndScrollingAnimation:(id)arg1;
- (void)scrollViewDidEndDecelerating:(id)arg1;
- (void)scrollViewDidEndDragging:(id)arg1 willDecelerate:(_Bool)arg2;
- (void)firstVisibleSecondChanged;
- (void)scrollViewDidScroll:(id)arg1;
- (void)scrollViewWillBeginDragging:(id)arg1;
- (void)_notifyDelegateOfFinishedScrollingToOccurrence;
@property(retain, nonatomic) EKEvent *dimmedOccurrence;
- (id)selectedEvent;
- (void)selectEvent:(id)arg1;
- (struct CGRect)rectForEvent:(id)arg1;
- (double)yPositionPerhapsMatchingAllDayOccurrence:(id)arg1;
- (id)occurrenceViewForEvent:(id)arg1;
- (void)resetLastSelectedOccurrencePoint;
- (id)_generateVerticalGridExtensionImage;
- (void)_clearVerticalGridExtensionImageCache;
- (struct CGRect)_scrollerRect;
- (int)_secondAtPosition:(double)arg1;
- (double)_positionOfSecond:(int)arg1;
@property(readonly, nonatomic) double leftContentInset;
@property(readonly, nonatomic) double scrollBarOffset;
- (double)_verticalOffset;
- (void)insertViewForEvent:(id)arg1 belowViewForOtherEvent:(id)arg2;
- (void)bringEventToFront:(id)arg1;
@property(readonly, nonatomic) NSArray *occurrenceViews;
- (void)dayAllDayView:(id)arg1 occurrenceViewClicked:(id)arg2;
- (void)dayContentView:(id)arg1 atPoint:(struct CGPoint)arg2;
- (void)dayOccurrenceViewClicked:(id)arg1 atPoint:(struct CGPoint)arg2;
- (CDStruct_79f9e052)_selectedDate;
- (void)scrollToDate:(id)arg1 animated:(_Bool)arg2 whenFinished:(id)arg3;
- (void)_finishedScrollToSecond;
- (void)_scrollToSecond:(int)arg1 animated:(_Bool)arg2 whenFinished:(id)arg3;
- (void)scrollToEvent:(id)arg1 animated:(_Bool)arg2;
@property(nonatomic) struct CGPoint normalizedContentOffset;
@property(readonly, nonatomic) double scrollOffset;
@property(readonly, nonatomic) EKDayAllDayView *allDayView;
@property(nonatomic) int occurrenceBackgroundStyle;
@property(retain, nonatomic) UIColor *occurrenceLocationColor;
@property(retain, nonatomic) UIColor *occurrenceTitleColor;
@property(retain, nonatomic) UIColor *gridLineColor;
@property(nonatomic) struct _NSRange hoursToRender;
@property(retain, nonatomic) UIColor *timeViewTextColor;
@property(nonatomic) _Bool allowsScrolling;
@property(nonatomic) int firstVisibleSecond;
@property(nonatomic) _Bool showsLeftBorder;
@property(nonatomic) _Bool eventsFillGrid;
@property(nonatomic) _Bool showsTimeLine;
- (struct CGRect)currentTimeRectInView:(id)arg1;
@property(nonatomic) _Bool showsTimeMarker;
- (void)adjustForSignificantTimeChange;
- (void)setOrientation:(long long)arg1;
- (void)setTimeZone:(id)arg1;
- (void)updateMarkerPosition;
- (void)_invalidateMarkerTimer;
- (void)_startMarkerTimer;
- (void)_adjustForDateOrCalendarChange;
- (void)_stopScrolling;
- (void)adjustFrameToSpanToMidnightFromStartDate:(id)arg1;
- (void)dealloc;
- (void)layoutSubviews;
- (void)removeFromSuperview;
- (void)willMoveToSuperview:(id)arg1;
- (void)_localeChanged;
- (id)description;
- (id)initWithFrame:(struct CGRect)arg1 orientation:(long long)arg2 displayDate:(id)arg3 backgroundColor:(id)arg4 opaque:(_Bool)arg5 scrollbarShowsInside:(_Bool)arg6;

@end

