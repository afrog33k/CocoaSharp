/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <AddressBookUI/ABPickerViewController.h>

@interface ABTonePickerViewController : ABPickerViewController
{
    _Bool _isTextToneViewController;
}

- (void)cancelButtonClicked:(id)arg1;
- (void)ringtoneSaveButtonClicked:(id)arg1;
- (void)_getRotationContentSettings:(CDStruct_ebaa735e *)arg1;
- (void)viewWillDisappear:(_Bool)arg1;
- (double)ab_heightToFitForViewInPopoverView;
- (void)loadView;
@property(readonly, nonatomic) id tonePicker;
- (void)setStyleProvider:(id)arg1;
- (id)initAsRingtoneViewController:(_Bool)arg1;
- (id)init;

@end

