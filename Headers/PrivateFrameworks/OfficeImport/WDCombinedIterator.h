/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/WDIterator.h>

// Not exported
@interface WDCombinedIterator : WDIterator
{
    WDIterator *mParentIterator;
    WDIterator *mChildIterator;
}

@property(retain, nonatomic) WDIterator *childIterator; // @synthesize childIterator=mChildIterator;
- (id)next;
- (_Bool)hasNext;
- (id)newChildIteratorFrom:(id)arg1;
- (id)childIteratorFrom:(id)arg1;
- (void)dealloc;
- (id)initWithParentIterator:(id)arg1;

@end

