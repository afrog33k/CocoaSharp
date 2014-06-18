/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iLifeSlideshow/MCContainer.h>

@class NSArray, NSDictionary, NSMutableArray, NSMutableDictionary, NSSet, NSString;

@interface MCContainerEffect : MCContainer
{
    NSMutableArray *mSlides;
    NSMutableArray *mTexts;
    NSMutableDictionary *mActions;
    NSMutableDictionary *mEffectAttributes;
    _Bool mIsLive;
    NSString *mEffectID;
}

+ (id)keyPathsForValuesAffectingValueForKey:(id)arg1;
@property(nonatomic) _Bool isLive; // @synthesize isLive=mIsLive;
@property(copy) NSString *effectID; // @synthesize effectID=mEffectID;
@property(copy) NSDictionary *effectAttributes;
- (void)addEffectAttributes:(id)arg1;
- (void)setEffectAttribute:(id)arg1 forKey:(id)arg2;
- (id)effectAttributeForKey:(id)arg1;
- (void)moveTextsAtIndices:(id)arg1 toIndex:(unsigned long long)arg2;
- (void)removeAllTexts;
- (void)removeTextsAtIndices:(id)arg1;
- (id)insertTextsForAssets:(id)arg1 andKey:(id)arg2 atIndex:(unsigned long long)arg3;
- (id)insertTextForAsset:(id)arg1 andKey:(id)arg2 atIndex:(unsigned long long)arg3;
- (id)insertTextsForAttributedStrings:(id)arg1 atIndex:(unsigned long long)arg2;
- (id)insertTextForAttributedString:(id)arg1 atIndex:(unsigned long long)arg2;
- (id)addTextsForAssets:(id)arg1 andKey:(id)arg2;
- (id)addTextForAsset:(id)arg1 andKey:(id)arg2;
- (id)addTextsForAttributedStrings:(id)arg1;
- (id)addTextForAttributedString:(id)arg1;
- (id)textAtIndex:(unsigned long long)arg1;
@property(readonly, nonatomic) unsigned long long nextAvailableTextIndex;
@property(readonly, nonatomic) unsigned long long countOfTexts;
@property(readonly) NSArray *orderedTexts;
@property(readonly) NSSet *texts;
- (void)moveSlidesAtIndices:(id)arg1 toIndex:(unsigned long long)arg2;
- (void)removeAllSlides;
- (void)removeSlidesAtIndices:(id)arg1;
- (id)insertSlideForContainer:(id)arg1 atIndex:(unsigned long long)arg2;
- (id)addSlideForContainer:(id)arg1;
- (id)insertSlidesForAssets:(id)arg1 atIndex:(unsigned long long)arg2;
- (id)insertSlideForAsset:(id)arg1 atIndex:(unsigned long long)arg2;
- (id)addSlidesForAssets:(id)arg1;
- (id)addSlideForAsset:(id)arg1;
- (id)insertSlideAtIndex:(long long)arg1;
- (id)addSlides:(long long)arg1;
- (id)addSlide;
- (id)slideAtIndex:(unsigned long long)arg1;
@property(readonly, nonatomic) unsigned long long nextAvailableSlideIndex;
@property(readonly, nonatomic) unsigned long long countOfSlides;
@property(readonly) NSArray *orderedSlides;
@property(readonly) NSSet *slides;
- (void)observeValueForKeyPath:(id)arg1 ofObject:(id)arg2 change:(id)arg3 context:(void *)arg4;
- (id)imprint;
- (void)demolish;
- (id)initWithImprint:(id)arg1 andMontage:(id)arg2;

@end

