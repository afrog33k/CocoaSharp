/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <EventKitUI/EKEventEditItem.h>

#import "UITextFieldDelegate-Protocol.h"

@class UITableViewCell;

// Not exported
@interface EKEventURLInlineEditItem : EKEventEditItem <UITextFieldDelegate>
{
    UITableViewCell *_cell;
}

- (void).cxx_destruct;
- (_Bool)textField:(id)arg1 shouldChangeCharactersInRange:(struct _NSRange)arg2 replacementString:(id)arg3;
- (void)textFieldDidEndEditing:(id)arg1;
- (void)textFieldDidBeginEditing:(id)arg1;
- (_Bool)saveAndDismissWithForce:(_Bool)arg1;
- (_Bool)isInline;
- (id)cellForSubitemAtIndex:(unsigned long long)arg1 inSubsection:(unsigned long long)arg2;
- (void)reset;
- (double)defaultCellHeightForSubitemAtIndex:(unsigned long long)arg1 inSubsection:(unsigned long long)arg2 forWidth:(double)arg3;
- (_Bool)canBeConfiguredForCalendarConstraints:(id)arg1;

@end
