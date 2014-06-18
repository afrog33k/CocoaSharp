/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class NSMutableArray, NSMutableData;

@interface PTPDevicePropDescDataset : NSObject
{
    unsigned short _devicePropertyCode;
    unsigned short _dataTypeCode;
    unsigned char _readWriteAttribute;
    id _factoryDefaultValue;
    id _currentValue;
    unsigned char _formFlag;
    id _minimumValue;
    id _maximumValue;
    id _stepSize;
    unsigned short _numberOfValues;
    NSMutableArray *_supportedValues;
    NSMutableData *_content;
    _Bool _dirty;
    _Bool _readOnlyObject;
}

- (void)setSupportedValues:(id)arg1;
- (id)supportedValues;
- (void)setNumberOfValues:(unsigned short)arg1;
- (unsigned short)numberOfValues;
- (void)setStepSize:(id)arg1;
- (id)stepSize;
- (void)setMaximumValue:(id)arg1;
- (id)maximumValue;
- (void)setMinimumValue:(id)arg1;
- (id)minimumValue;
- (void)setFormFlag:(unsigned char)arg1;
- (unsigned char)formFlag;
- (void)setCurrentValue:(id)arg1;
- (id)currentValue;
- (void)setFactoryDefaultValue:(id)arg1;
- (id)factoryDefaultValue;
- (void)setReadWriteAttribute:(unsigned char)arg1;
- (unsigned char)readWriteAttribute;
- (void)setDataTypeCode:(unsigned short)arg1;
- (unsigned short)dataTypeCode;
- (void)setDevicePropertyCode:(unsigned short)arg1;
- (unsigned short)devicePropertyCode;
- (id)description;
- (id)content;
- (void)updateContent;
- (void)dealloc;
- (id)initWithMutableData:(id)arg1;
- (id)initWithData:(id)arg1;
- (void)setContent:(id)arg1;
- (id)init;

@end

