/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class CPBitmapStore;

@interface WeatherImageLoader : NSObject
{
    double _scale;
    CPBitmapStore *_store;
}

+ (id)yahooButtonImage;
+ (id)twcButtonImage;
+ (id)conditionImageNamed:(id)arg1;
+ (id)conditionImageWithConditionIndex:(long long)arg1;
+ (void)preCacheMiniIcons;
+ (void)cacheImageIfNecessary:(id)arg1;
+ (id)sharedImageLoader;
@property(retain, nonatomic) CPBitmapStore *store; // @synthesize store=_store;
- (void)setImage:(id)arg1 forKey:(id)arg2;
- (id)cachedImageForKey:(id)arg1;
- (void)dealloc;
- (id)init;

@end

