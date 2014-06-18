/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "UITableView.h"

#import "UITableViewDataSource-Protocol.h"
#import "UITableViewDelegate-Protocol.h"

@class NSString;

@interface CalendarEventAlarmTable : UITableView <UITableViewDelegate, UITableViewDataSource>
{
    long long _alarmIdentifier;
    NSString *_customString;
    long long _selectedItem;
    _Bool _immediateAlarmCreation;
    _Bool _useAllDayAlarms;
    _Bool _shouldAllowAlarmsTriggeringAfterStartDate;
    _Bool _customSelected;
    id <CalendarEventAlarmTableDelegate> _alarmTableDelegate;
    id <EKStyleProvider> _styleProvider;
}

@property(nonatomic) _Bool customSelected; // @synthesize customSelected=_customSelected;
@property(nonatomic) _Bool shouldAllowAlarmsTriggeringAfterStartDate; // @synthesize shouldAllowAlarmsTriggeringAfterStartDate=_shouldAllowAlarmsTriggeringAfterStartDate;
@property(nonatomic) _Bool useAllDayAlarms; // @synthesize useAllDayAlarms=_useAllDayAlarms;
@property(retain, nonatomic) id <EKStyleProvider> styleProvider; // @synthesize styleProvider=_styleProvider;
@property(nonatomic) __weak id <CalendarEventAlarmTableDelegate> alarmTableDelegate; // @synthesize alarmTableDelegate=_alarmTableDelegate;
- (void).cxx_destruct;
- (long long)presetIdentifierAtIndex:(unsigned long long)arg1;
- (unsigned long long)countOfPresets;
- (int)intervalForPresetIdentifier:(long long)arg1;
- (void)tableView:(id)arg1 didSelectRowAtIndexPath:(id)arg2;
- (id)tableView:(id)arg1 cellForRowAtIndexPath:(id)arg2;
- (long long)tableView:(id)arg1 numberOfRowsInSection:(long long)arg2;
- (void)setCustomString:(id)arg1;
- (long long)presetIdentifier;
- (void)setPresetIdentifier:(long long)arg1;
- (void)_selectRow:(long long)arg1;
- (long long)_presetIdentifierForRow:(long long)arg1;
- (long long)rowForPresetIdentifier:(long long)arg1;
- (id)initWithFrame:(struct CGRect)arg1;

@end

