/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UIViewController.h"

#import "EKEditItemViewControllerProtocol-Protocol.h"

// Not exported
@interface EKEditItemViewController : UIViewController <EKEditItemViewControllerProtocol>
{
    struct CGRect _initialFrame;
    int _subitem;
    _Bool _modal;
    id <EKStyleProvider> _styleProvider;
    id <EKEditItemViewControllerDelegate> _editDelegate;
    _Bool _showsDoneButton;
    int _subsection;
}

@property(nonatomic) _Bool showsDoneButton; // @synthesize showsDoneButton=_showsDoneButton;
@property(nonatomic) _Bool modal; // @synthesize modal=_modal;
@property(nonatomic) int subsection; // @synthesize subsection=_subsection;
@property(nonatomic) int subitem; // @synthesize subitem=_subitem;
@property(nonatomic) __weak id <EKEditItemViewControllerDelegate> editDelegate; // @synthesize editDelegate=_editDelegate;
- (void).cxx_destruct;
- (double)tableView:(id)arg1 heightForFooterInSection:(long long)arg2;
- (double)tableView:(id)arg1 heightForHeaderInSection:(long long)arg2;
- (double)marginForTableView:(id)arg1;
- (void)setCell:(id)arg1 checked:(_Bool)arg2;
- (_Bool)fitsPopoverWhenKeyboardActive;
- (struct CGSize)preferredContentSize;
- (void)didReceiveMemoryWarning;
- (_Bool)validateAllowingAlert:(_Bool)arg1;
- (void)popIfNonModal;
- (void)saveAndDismissWithExtremePrejudice;
- (void)saveAndDismiss;
- (void)_saveAndDismissWithForce:(_Bool)arg1;
- (void)cancel;
- (void)viewWillDisappear:(_Bool)arg1;
- (unsigned long long)supportedInterfaceOrientations;
- (void)viewDidLoad;
- (void)viewWillAppear:(_Bool)arg1;
- (id)initWithFrame:(struct CGRect)arg1;
- (id)initWithFrame:(struct CGRect)arg1 styleProvider:(id)arg2;

@end

