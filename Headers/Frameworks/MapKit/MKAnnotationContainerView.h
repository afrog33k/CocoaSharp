/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIView.h"

#import "MKAnnotationCalloutControllerDelegate-Protocol.h"

@class MKAnnotationCalloutController, MKAnnotationView, MKPinAnnotationView, NSMutableArray, NSMutableSet, UIPopoverController;

// Not exported
@interface MKAnnotationContainerView : UIView <MKAnnotationCalloutControllerDelegate>
{
    NSMutableArray *_annotationViews;
    NSMutableArray *_awaitingDropPins;
    _Bool _registeredForAddressBookChanges;
    MKAnnotationView *_selectedAnnotationView;
    MKAnnotationView *_annotationViewToSelect;
    id <MKAnnotationContainerViewDelegate> _delegate;
    MKAnnotationView *_draggingAnnotationView;
    struct CGPoint _mouseDownPoint;
    struct CGPoint _draggingAnnotationViewCenter;
    unsigned long long _mapType;
    _Bool _clickedOnAnnotationView;
    _Bool _didDragAnnotationView;
    MKAnnotationView *_userLocationView;
    double _annotationViewsRotationRadians;
    struct CGAffineTransform _mapTransform;
    _Bool _addingSubview;
    NSMutableSet *_viewsToAnimate;
    MKAnnotationCalloutController *_calloutController;
    double _mapPitchRadians;
    long long _mapDisplayStyle;
}

- (CDStruct_90e2a262)_mapRectWithFraction:(double)arg1 ofVisible:(CDStruct_90e2a262)arg2;
- (void)calloutControllerDidFinishMapsTransitionExpanding:(id)arg1;
- (void)calloutController:(id)arg1 annotationView:(id)arg2 calloutAccessoryControlTapped:(id)arg3;
- (void)calloutController:(id)arg1 scrollToRevealCalloutWithOffset:(struct CGPoint)arg2 annotationCoordinate:(CDStruct_c3b9c2ee)arg3 completionHandler:(id)arg4;
- (struct CGRect)calloutController:(id)arg1 visibleCenteringRectInAnnotationView:(id)arg2;
- (void)transitionFrom:(long long)arg1 to:(long long)arg2 duration:(double)arg3;
- (void)stopSuppressingUpdates;
- (void)suppressUpdates;
- (void)annotationViewDidChangeCenterOffset:(id)arg1;
- (void)annotationViewDidChangeZIndex:(id)arg1;
- (unsigned long long)indexForAnnotationView:(id)arg1;
@property(readonly, nonatomic) CDStruct_e1db73fe currentComparisonContext;
- (void)selectAnnotationView:(id)arg1 animated:(_Bool)arg2 avoid:(struct CGRect)arg3;
- (void)addSubview:(id)arg1;
- (void)dropPinsIfNeeded;
- (void)removeAnnotationView:(id)arg1;
- (void)finishAddingAnnotationViews;
- (void)addAnnotationView:(id)arg1 allowAnimation:(_Bool)arg2;
- (void)_updateAddedAnnotationRotation:(id)arg1;
- (void)_willRemoveInternalAnnotationView:(id)arg1;
- (void)_dropPinsIfNeeded:(_Bool)arg1;
- (void)setUserLocationView:(id)arg1;
@property(readonly, nonatomic) MKAnnotationView *userLocationView;
@property(readonly, nonatomic) _Bool hasPendingAnimations;
@property(readonly, nonatomic) _Bool hasDroppingPins;
- (struct UIEdgeInsets)accessoryPadding;
- (void)pinDidDrop:(id)arg1 animated:(_Bool)arg2;
- (void)_dropDraggingAnnotationViewAnimated:(_Bool)arg1;
- (struct CGPoint)draggingAnnotationViewDropPointForPoint:(struct CGPoint)arg1;
- (struct CGPoint)draggingAnnotationViewDropPoint;
- (void)draggingTouchMovedToPoint:(struct CGPoint)arg1;
- (void)_liftForDragging:(id)arg1 mouseDownPoint:(struct CGPoint)arg2;
- (id)annotationViewForPoint:(struct CGPoint)arg1;
- (id)_annotationViewForSelectionAtPoint:(struct CGPoint)arg1 avoidCurrent:(_Bool)arg2;
- (void)updateAnnotationLocationsDuringAnimation:(_Bool)arg1;
- (struct CGPoint)convertCoordinate:(CDStruct_c3b9c2ee)arg1 toPointToView:(struct UIView *)arg2;
- (void)_updateOrientationOfViews:(id)arg1;
- (void)_updateOrientationOfViews:(id)arg1 relative:(id)arg2 projectionView:(struct UIView *)arg3;
- (void)_updateOrientationOfViewsFast:(id)arg1 relative:(id)arg2 projectionView:(struct UIView *)arg3;
- (void)_updateOrientationOfViewsCorrect:(id)arg1 relative:(id)arg2 projectionView:(struct UIView *)arg3;
- (void)_findNextView:(id *)arg1 orientation:(int *)arg2 context:(id)arg3;
@property(readonly, nonatomic) NSMutableArray *annotationViews;
- (void)updateUserLocationView;
- (void)updateAnnotationView:(id)arg1;
- (void)_updateAnnotationView:(id)arg1;
- (struct CGPoint)pointForCoordinate:(CDStruct_c3b9c2ee)arg1;
- (CDStruct_c3b9c2ee)coordinateForAnnotationView:(id)arg1;
- (void)_updateAnnotationViewPerspective;
- (void)deselectAnnotationView:(id)arg1 animated:(_Bool)arg2;
- (void)_setSelectedAnnotationView:(id)arg1 bounce:(_Bool)arg2 pressed:(_Bool)arg3 scrollToFit:(_Bool)arg4;
- (void)_setSelectedAnnotationView:(id)arg1 bounce:(_Bool)arg2 pressed:(_Bool)arg3 scrollToFit:(_Bool)arg4 avoid:(struct CGRect)arg5;
- (void)_showBubbleForAnnotationView:(id)arg1 bounce:(_Bool)arg2 scrollToFit:(_Bool)arg3;
- (void)_showBubbleForAnnotationView:(id)arg1 bounce:(_Bool)arg2 scrollToFit:(_Bool)arg3 avoid:(struct CGRect)arg4;
- (void)removeAnnotationViewsRotationAnimations;
- (void)setAnnotationViewsRotationRadians:(double)arg1 animation:(id)arg2;
@property(readonly, nonatomic) MKPinAnnotationView *bubblePin;
@property(readonly, nonatomic) MKAnnotationView *calloutAnnotationView;
- (struct CGRect)_visibleRect;
- (struct CGRect)_visibleCenteringRectInView:(struct UIView *)arg1;
- (struct CGRect)_visibleCenteringRect;
- (_Bool)isCalloutExpanded;
- (_Bool)calloutContainsPoint:(struct CGPoint)arg1;
@property(nonatomic) Class calloutViewClass;
- (void)setMapDisplayStyle:(long long)arg1;
@property(nonatomic) unsigned long long mapType;
@property(nonatomic) _Bool allowsPopoverWhenNotInWindow;
@property(readonly, nonatomic) UIPopoverController *popoverController;
- (void)setMapPitchRadians:(double)arg1;
@property(nonatomic) id <MKAnnotationContainerViewDelegate> delegate;
- (void)dealloc;
- (id)initWithFrame:(struct CGRect)arg1;

@end

