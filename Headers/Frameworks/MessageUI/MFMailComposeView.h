/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITransitionView.h"

#import "MFComposeBodyFieldDelegate-Protocol.h"
#import "MFDragContext-Protocol.h"
#import "MFMailComposeContactsSearchControllerDelegate-Protocol.h"
#import "UIScrollViewDelegate-Protocol.h"
#import "UITableViewDataSource-Protocol.h"
#import "UITableViewDelegate-Protocol.h"
#import "UITextContentViewDelegate-Protocol.h"

@class MFComposeBodyField, MFComposeFromView, MFComposeImageSizeView, MFComposeMultiView, MFComposeScrollView, MFComposeSubjectView, MFComposeTextContentView, MFFromAddressViewController, MFMailComposeContactsSearchController, MFMailComposeRecipientView, NSArray, NSInvocation, UIPickerView, UIResponder, UITableView, UIView;

@interface MFMailComposeView : UITransitionView <UITextContentViewDelegate, UIScrollViewDelegate, UITableViewDelegate, UITableViewDataSource, MFMailComposeContactsSearchControllerDelegate, MFComposeBodyFieldDelegate, MFDragContext>
{
    id <MFMailPopoverManagerDelegate> _popoverOwner;
    id <MFMailComposeViewDelegate> _mailComposeViewDelegate;
    id <MFComposeRecipientViewDelegate> _composeRecipientViewDelegate;
    UIView *_headerView;
    UIView *_contentView;
    UIView *_shadowView;
    MFComposeBodyField *_bodyField;
    MFComposeScrollView *_bodyScroller;
    MFComposeTextContentView *_textView;
    MFMailComposeRecipientView *_toField;
    MFMailComposeRecipientView *_ccField;
    MFMailComposeRecipientView *_bccField;
    MFMailComposeRecipientView *_lastChangedRecipientView;
    MFMailComposeRecipientView *_activeRecipientView;
    MFComposeSubjectView *_subjectField;
    MFComposeFromView *_fromField;
    MFComposeMultiView *_multiField;
    MFComposeImageSizeView *_imageSizeField;
    UIPickerView *_fromAddressPickerView;
    MFFromAddressViewController *_fromAddressViewController;
    UIView *_fromAddressPickerBackgroundView;
    UIResponder *_firstResponderBeforeSheet;
    UIResponder *_pinningResponder;
    NSInvocation *_delayedPopoverInvocation;
    MFMailComposeContactsSearchController *_searchController;
    NSArray *_searchResults;
    UITableView *_searchResultsTable;
    double _offsetBeforeSearch;
    double _keyboardIntersection;
    unsigned long long _options;
    struct CGSize _currentContentSize;
    unsigned int _isChangingRecipients:1;
    unsigned int _isLoading:1;
    unsigned int _isShowingPeoplePicker:1;
    unsigned int _isRotating:1;
    unsigned int _isClosing:1;
    unsigned int _isShowingFromAddressPickerWheel:1;
    unsigned int _isForEditing:1;
    unsigned int _isAnimationDisabled:1;
    unsigned int _shouldShowOptionalHeaders:1;
    unsigned int _isDraggingRecipients:1;
    unsigned int _hasAppeared:1;
    unsigned long long _notifyingBodyField;
}

@property(readonly, nonatomic) MFComposeTextContentView *bodyTextView; // @synthesize bodyTextView=_textView;
@property(readonly, nonatomic) MFComposeScrollView *bodyScroller; // @synthesize bodyScroller=_bodyScroller;
@property(readonly, nonatomic) MFComposeBodyField *bodyField; // @synthesize bodyField=_bodyField;
@property(readonly, nonatomic) MFComposeMultiView *multiField; // @synthesize multiField=_multiField;
@property(readonly, nonatomic) MFComposeImageSizeView *imageSizeField; // @synthesize imageSizeField=_imageSizeField;
@property(readonly, nonatomic) MFComposeFromView *fromField; // @synthesize fromField=_fromField;
@property(readonly, nonatomic) MFComposeSubjectView *subjectField; // @synthesize subjectField=_subjectField;
@property(readonly, nonatomic) MFMailComposeRecipientView *bccField; // @synthesize bccField=_bccField;
@property(readonly, nonatomic) MFMailComposeRecipientView *ccField; // @synthesize ccField=_ccField;
@property(readonly, nonatomic) MFMailComposeRecipientView *toField; // @synthesize toField=_toField;
@property(nonatomic) id <MFMailPopoverManagerDelegate> popoverOwner; // @synthesize popoverOwner=_popoverOwner;
@property(nonatomic) id <MFComposeRecipientViewDelegate> composeRecipientDelegate; // @synthesize composeRecipientDelegate=_composeRecipientViewDelegate;
@property(nonatomic) id <MFMailComposeViewDelegate> composeViewDelegate; // @synthesize composeViewDelegate=_mailComposeViewDelegate;
- (void)scrollViewDidEndDecelerating:(id)arg1;
- (void)scrollViewDidEndDragging:(id)arg1 willDecelerate:(_Bool)arg2;
- (void)scrollViewWillBeginDragging:(id)arg1;
- (void)scrollViewDidScroll:(id)arg1;
- (void)textContentView:(id)arg1 didChangeSize:(struct CGSize)arg2;
- (_Bool)textContentView:(id)arg1 shouldChangeSizeForContentSize:(struct CGSize)arg2;
- (_Bool)textContentView:(id)arg1 shouldScrollForPendingContentSize:(struct CGSize)arg2;
- (void)willDisappear;
- (void)didAppear;
- (void)parentDidClose;
- (void)parentWillClose;
- (void)clearSearchForRecipientView:(id)arg1 reflow:(_Bool)arg2 clear:(_Bool)arg3;
- (void)tableView:(id)arg1 didSelectRowAtIndexPath:(id)arg2;
- (void)selectSearchResultsRecipientAtIndexPath:(id)arg1;
- (void)tableView:(id)arg1 accessoryButtonTappedForRowWithIndexPath:(id)arg2;
- (id)tableView:(id)arg1 cellForRowAtIndexPath:(id)arg2;
- (long long)tableView:(id)arg1 numberOfRowsInSection:(long long)arg2;
- (double)tableView:(id)arg1 heightForRowAtIndexPath:(id)arg2;
- (double)tableView:(id)arg1 estimatedHeightForRowAtIndexPath:(id)arg2;
- (void)composeContactsSearchController:(id)arg1 didFindCorecipients:(id)arg2;
- (void)composeContactsSearchController:(id)arg1 finishedWithResults:(_Bool)arg2;
- (void)composeContactsSearchController:(id)arg1 didSortResults:(id)arg2;
- (id)sendingAddressForComposeContactsSearchController:(id)arg1;
- (void)findCorecipientsWithRecipientView:(id)arg1;
- (void)invalidateSearchResultRecipient:(id)arg1;
- (void)cancelSearch;
- (void)beginSearchForText:(id)arg1 recipientView:(id)arg2;
- (_Bool)presentSearchResults:(id)arg1;
- (void)dismissSearchResults;
- (_Bool)presentSearchResults;
- (_Bool)chooseSelectedSearchResult;
- (void)selectPreviousSearchResult;
- (void)selectNextSearchResult;
@property(readonly, nonatomic, getter=isSearching) _Bool searching;
- (void)menuDidHide;
- (void)_updateOptionalHeaderVisibilityForceVisible:(_Bool)arg1;
- (void)updateOptionalHeaderVisibility;
- (void)viewDidBecomeFirstResponder:(id)arg1;
- (void)layoutForChangedComposeRecipientView:(id)arg1 size:(struct CGSize)arg2;
- (void)setScrollsToTop:(_Bool)arg1;
- (void)scrollToTopAnimated:(_Bool)arg1;
- (void)focusFirstResponderAfterRecipientView:(id)arg1;
- (void)restoreFirstResponderWithKeyboardPinning:(_Bool)arg1;
- (void)restoreFirstResponder;
- (void)saveFirstResponderWithKeyboardPinning:(_Bool)arg1;
- (void)saveFirstResponder;
- (double)_heightForBottomView;
- (_Bool)isKeyboardVisible;
- (void)setKeyboardVisible:(_Bool)arg1 animate:(_Bool)arg2;
- (void)automaticKeyboardFinishedDisappearing:(id)arg1;
- (void)automaticKeyboardFinishedAppearing:(id)arg1;
- (void)_updateKeyboardIntersection:(struct CGRect)arg1;
- (void)fromAddressPickerNeedsToBeRefreshed;
- (_Bool)isFromAddressPickerVisible;
- (void)setFromAddressPickerVisible:(_Bool)arg1 animated:(_Bool)arg2;
- (void)setFromAddressPickerVisible:(_Bool)arg1;
- (void)fromAddressPickerPopoverWasDismissed;
- (struct CGRect)_frameForFromAddressPicker;
- (void)_adjustScrollerForBottomView;
- (void)layoutSubviews;
- (void)composeBodyFieldDidFirstVisuallyNonEmptyLayout:(id)arg1;
- (void)composeBodyFieldDidDraw:(id)arg1;
- (void)composeBodyFieldFrameChanged:(id)arg1;
- (void)didRotateFromInterfaceOrientation:(long long)arg1;
- (void)willAnimateRotationToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)_finishUpRotationToInterfaceOrientation:(long long)arg1;
- (id)_focusedRecipientView;
- (void)willRotateToInterfaceOrientation:(long long)arg1 duration:(double)arg2;
- (void)_adjustScrollerContentSize;
- (id)dragScrollView;
- (id)dragWindow;
- (void)dragEnded;
- (void)dragBeganInWindow:(id)arg1;
- (void)_cancelDelayedPopover;
- (void)_presentDelayedPopover;
- (void)cancelDelayedPopover;
- (void)_adjustHeaderFieldsPreferredContentSize;
- (void)_layoutMultiFieldWithChangingView:(id)arg1 toSize:(struct CGSize)arg2 fieldFrame:(struct CGRect)arg3;
- (void)_layoutFromFieldWithChangingView:(id)arg1 toSize:(struct CGSize)arg2 fieldFrame:(struct CGRect)arg3;
- (void)_setupField:(id *)arg1 withLabel:(id)arg2 navTitle:(id)arg3 frame:(struct CGRect)arg4;
- (void)_multiFieldClicked;
@property(nonatomic, getter=isShowingPeoplePicker) _Bool showingPeoplePicker;
@property(nonatomic, getter=isChangingRecipients) _Bool changingRecipients;
@property(nonatomic, getter=isAnimationDisabled) _Bool animationDisabled;
@property(nonatomic) _Bool isForEditing;
- (void)searchResultsPopoverWasDismissed;
- (id)hitTest:(struct CGPoint)arg1 withEvent:(id)arg2;
@property(nonatomic, getter=isLoading) _Bool loading;
- (void)setRecipientFieldsEditable:(_Bool)arg1;
- (_Bool)endEditing:(_Bool)arg1;
- (void)setAutoresizingMask:(unsigned long long)arg1;
- (id)bottomView;
- (void)toggleImageSizeFieldIfNecessary;
- (void)_layoutSubviews:(_Bool)arg1;
- (void)_layoutSubviews:(_Bool)arg1 changingView:(id)arg2 toSize:(struct CGSize)arg3 searchResultsWereDismissed:(_Bool)arg4;
- (void)_layoutSubviews:(_Bool)arg1 changingView:(id)arg2 toSize:(struct CGSize)arg3;
- (_Bool)isSearchResultsPopoverVisible;
- (void)_layoutSubviewsWithActiveRecipientView:(_Bool)arg1 changingView:(id)arg2 toSize:(struct CGSize)arg3;
- (void)_setupBodyFieldWithHeaderFrame:(struct CGRect)arg1 enclosingFrame:(struct CGRect)arg2 changingView:(id)arg3 frameToPin:(struct CGRect)arg4 wasSearching:(_Bool)arg5;
- (void)composeHeaderViewClicked:(id)arg1;
- (void)_collectKeyViews:(id)arg1;
- (void)removeFromSuperview;
- (void)resetContentSize;
- (void)_cancelAnimations;
- (id)_searchResultsTable;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1 options:(unsigned long long)arg2;

@end

