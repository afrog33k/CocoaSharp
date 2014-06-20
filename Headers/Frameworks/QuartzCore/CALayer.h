/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "CAMediaTiming-Protocol.h"
#import "NSCoding-Protocol.h"

@class NSArray, NSDictionary, NSString;

@interface CALayer : NSObject <NSCoding, CAMediaTiming>
{
    struct _CALayerIvars _attr;
}

+ (id)defaultActionForKey:(id)arg1;
+ (_Bool)CA_automaticallyNotifiesObservers:(Class)arg1;
+ (_Bool)automaticallyNotifiesObserversForKey:(id)arg1;
+ (_Bool)_hasRenderLayerSubclass;
+ (id)layer;
+ (_Bool)needsDisplayForKey:(id)arg1;
+ (id)defaultValueForKey:(id)arg1;
- (id).cxx_construct;
@property _Bool allowsGroupOpacity;
@property _Bool allowsEdgeAntialiasing;
@property _Bool drawsAsynchronously;
@property double rasterizationScale;
@property _Bool shouldRasterize;
@property struct CGPath *shadowPath;
@property double shadowRadius;
@property struct CGSize shadowOffset;
@property struct CGColor *shadowColor;
@property float shadowOpacity;
@property double cornerRadius;
@property double borderWidth;
@property struct CGColor *borderColor;
@property(copy) NSDictionary *actions;
@property(copy) NSDictionary *style;
@property(copy) NSString *name;
@property(retain) id compositingFilter;
@property(copy) NSArray *backgroundFilters;
@property(copy) NSArray *filters;
@property _Bool masksToBounds;
@property struct CGColor *backgroundColor;
@property float opacity;
@property float minificationFilterBias;
@property(copy) NSString *minificationFilter;
@property(copy) NSString *magnificationFilter;
@property double contentsScale;
@property struct CGRect contentsCenter;
@property struct CGRect contentsRect;
@property struct CATransform3D sublayerTransform;
@property _Bool needsDisplayOnBoundsChange;
@property(getter=isOpaque) _Bool opaque;
@property(getter=isDoubleSided) _Bool doubleSided;
@property(getter=isHidden) _Bool hidden;
@property double zPosition;
@property double anchorPointZ;
@property struct CGPoint anchorPoint;
@property(copy) NSString *fillMode;
@property _Bool autoreverses;
@property double repeatDuration;
@property float repeatCount;
@property float speed;
@property double duration;
@property double timeOffset;
@property double beginTime;
- (void)layoutSublayers;
- (void)layoutIfNeeded;
- (struct CGSize)preferredFrameSize;
- (struct CGSize)_preferredSize;
- (_Bool)needsLayout;
- (void)setNeedsLayout;
- (void)drawInContext:(struct CGContext *)arg1;
- (void)_display;
- (void)display;
- (void)_renderBorderInContext:(struct CGContext *)arg1;
- (void)_renderSublayersInContext:(struct CGContext *)arg1;
- (void)_renderForegroundInContext:(struct CGContext *)arg1;
- (void)_renderBackgroundInContext:(struct CGContext *)arg1;
- (void)renderInContext:(struct CGContext *)arg1;
- (void)displayIfNeeded;
- (_Bool)needsDisplay;
- (void)setNeedsDisplayInRect:(struct CGRect)arg1;
- (void)setNeedsDisplay;
- (id)modelLayer;
- (id)presentationLayer;
- (void)_cancelAnimationTimer;
- (_Bool)_scheduleAnimationTimer;
- (id)animationKeys;
- (id)animationForKey:(id)arg1;
- (void)removeAnimationForKey:(id)arg1;
- (void)removeAllAnimations;
- (void)addAnimation:(id)arg1 forKey:(id)arg2;
- (id)actionForKey:(id)arg1;
- (void)replaceSublayer:(id)arg1 with:(id)arg2;
- (void)insertSublayer:(id)arg1 above:(id)arg2;
- (void)insertSublayer:(id)arg1 below:(id)arg2;
- (void)addSublayer:(id)arg1;
- (void)insertSublayer:(id)arg1 atIndex:(unsigned int)arg2;
- (void)removeFromSuperlayer;
@property id delegate;
@property(retain) CALayer *mask;
@property(readonly) CALayer *superlayer;
@property(copy) NSArray *sublayers;
- (void)setContentsScaling:(id)arg1;
- (id)contentsScaling;
@property(copy) NSString *contentsGravity;
@property unsigned int edgeAntialiasingMask;
@property(retain) id contents;
- (_Bool)containsPoint:(struct CGPoint)arg1;
- (id)hitTest:(struct CGPoint)arg1;
- (double)convertTime:(double)arg1 toLayer:(id)arg2;
- (double)convertTime:(double)arg1 fromLayer:(id)arg2;
- (struct CGRect)convertRect:(struct CGRect)arg1 toLayer:(id)arg2;
- (struct CGRect)convertRect:(struct CGRect)arg1 fromLayer:(id)arg2;
- (struct CGPoint)convertPoint:(struct CGPoint)arg1 toLayer:(id)arg2;
- (struct CGPoint)convertPoint:(struct CGPoint)arg1 fromLayer:(id)arg2;
- (_Bool)contentsAreFlipped;
@property(getter=isGeometryFlipped) _Bool geometryFlipped;
@property struct CGRect frame;
- (void)setAffineTransform:(struct CGAffineTransform)arg1;
- (struct CGAffineTransform)affineTransform;
@property struct CATransform3D transform;
@property struct CGPoint position;
@property struct CGRect bounds;
- (_Bool)shouldArchiveValueForKey:(id)arg1;
- (void)encodeWithCoder:(id)arg1;
- (id)initWithCoder:(id)arg1;
- (void)setValue:(id)arg1 forKeyPath:(id)arg2;
- (id)valueForKeyPath:(id)arg1;
- (void)setValue:(id)arg1 forUndefinedKey:(id)arg2;
- (void)setValue:(id)arg1 forKey:(id)arg2;
- (id)valueForUndefinedKey:(id)arg1;
- (id)valueForKey:(id)arg1;
- (id)debugDescription;
- (void)dealloc;
- (void)_dealloc;
- (id)_initWithReference:(id)arg1;
- (id)initWithLayer:(id)arg1;
- (id)initWithBounds:(struct CGRect)arg1;
- (id)init;
- (_Bool)allowsWeakReference;
- (unsigned long long)retainCount;
- (oneway void)release;
- (_Bool)retainWeakReference;
- (id)retain;

@end
