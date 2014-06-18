/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITableViewController.h"

#import "UINavigationControllerDelegate-Protocol.h"

@class NSString, PTSHUDSettingsDetailViewController, UIView, _UISettingsGroup;

@interface PTSHUDSettingsGroupEditor : UITableViewController <UINavigationControllerDelegate>
{
    _UISettingsGroup *_group;
    UIView *_detailsView;
    NSString *_archiveFilename;
    PTSHUDSettingsDetailViewController *_detailViewController;
}

@property(retain, nonatomic) PTSHUDSettingsDetailViewController *detailViewController; // @synthesize detailViewController=_detailViewController;
@property(copy, nonatomic) NSString *archiveFilename; // @synthesize archiveFilename=_archiveFilename;
@property(retain, nonatomic) UIView *detailsView; // @synthesize detailsView=_detailsView;
@property(retain, nonatomic) _UISettingsGroup *group; // @synthesize group=_group;
- (void).cxx_destruct;
- (void)navigationController:(id)arg1 willShowViewController:(id)arg2 animated:(_Bool)arg3;
- (void)navigationController:(id)arg1 didShowViewController:(id)arg2 animated:(_Bool)arg3;
- (void)tableView:(id)arg1 didSelectRowAtIndexPath:(id)arg2;
- (_Bool)tableView:(id)arg1 canMoveRowAtIndexPath:(id)arg2;
- (void)tableView:(id)arg1 moveRowAtIndexPath:(id)arg2 toIndexPath:(id)arg3;
- (void)tableView:(id)arg1 commitEditingStyle:(long long)arg2 forRowAtIndexPath:(id)arg3;
- (_Bool)tableView:(id)arg1 canEditRowAtIndexPath:(id)arg2;
- (id)tableView:(id)arg1 cellForRowAtIndexPath:(id)arg2;
- (long long)tableView:(id)arg1 numberOfRowsInSection:(long long)arg2;
- (long long)numberOfSectionsInTableView:(id)arg1;
- (void)edit:(id)arg1;
- (void)done:(id)arg1;
- (void)viewDidLoad;
- (void)saveGroup;
- (id)initWithStyle:(long long)arg1;

@end

