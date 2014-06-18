/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class PUSectionedGridLayout;

@interface PULayoutAnimationsHelper : NSObject
{
    _Bool _shouldAnimateTemporaryImageView;
    PUSectionedGridLayout *_layout;
}

@property(nonatomic) _Bool shouldAnimateTemporaryImageView; // @synthesize shouldAnimateTemporaryImageView=_shouldAnimateTemporaryImageView;
@property(readonly, nonatomic) PUSectionedGridLayout *layout; // @synthesize layout=_layout;
- (void).cxx_destruct;
- (void)_applyDefaultLayoutAttributes:(id)arg1 toView:(id)arg2;
- (void)_configureAnimationsForReusableView:(id)arg1 toLayoutAttributes:(id)arg2 withCompletionBlock:(id)arg3;
- (id)_adjustDecorationViewAnimation:(id)arg1 forReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_adjustRenderedStripAnimation:(id)arg1 forReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_adjustSectionHeaderAnimation:(id)arg1 forReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_adjustCellAnimation:(id)arg1 forReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_adjustAnimation:(id)arg1 forReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_defaultAnimationForKeyPath:(id)arg1 ofReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_createDefaultZoomingInAnimationForKeyPath:(id)arg1 ofReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (id)_createDefaultZoomingOutAnimationForKeyPath:(id)arg1 ofReusableView:(id)arg2 toLayoutAttributes:(id)arg3;
- (void)didFinishLayoutTransitionAnimations:(_Bool)arg1 transitionIsAppearing:(_Bool)arg2;
- (id)animationsForReusableView:(SEL)arg1 toLayoutAttributes:(id)arg2;
- (id)initWithSectionedGridLayout:(id)arg1;

@end

