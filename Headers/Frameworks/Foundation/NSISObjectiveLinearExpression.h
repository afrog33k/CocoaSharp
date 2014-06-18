/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSISRowBody-Protocol.h"

@class NSMutableArray;

@interface NSISObjectiveLinearExpression : NSObject <NSISRowBody>
{
    struct __CFDictionary *_priorityMap;
    NSMutableArray *_variablesSortedByPriorityVectors;
    struct __CFData *_constant;
}

- (void)verifyInternalIntegrity;
- (void)leadingPriority:(double *)arg1 andValue:(double *)arg2 forVariable:(id)arg3;
- (id)restrictedVariableWithCoefficientOfLargestNegativeMagnitude;
- (void)replaceVariable:(id)arg1 withExpression:(id)arg2 processVariableNewToReceiver:(id)arg3 processVariableDroppedFromReceiver:(void)arg4;
- (void)replaceVariable:(id)arg1 withVariablePlusDelta:(double)arg2 timesVariable:(id)arg3 processVariableNewToReceiver:(id)arg4 processVariableDroppedFromReceiver:(void)arg5;
- (void)replaceVariable:(id)arg1 withVariablePlusDelta:(double)arg2;
- (void)addExpression:(id)arg1 priority:(double)arg2 times:(double)arg3 processVariableNewToReceiver:(id)arg4 processVariableDroppedFromReceiver:(void)arg5;
- (void)addVariable:(id)arg1 priority:(double)arg2 times:(double)arg3 processVariableNewToReceiver:(id)arg4 processVariableDroppedFromReceiver:(void)arg5;
- (void)addVariable:(id)arg1 priority:(double)arg2 times:(double)arg3;
- (void)setPriorityVector:(struct __CFData *)arg1 forKnownAbsentVariable:(id)arg2;
- (void)removeVariable:(id)arg1;
- (struct __CFData *)priorityVectorForVariable:(id)arg1;
- (unsigned long long)variableCount;
- (void)enumerateVariables:(id)arg1;
- (_Bool)constantTermIsZero;
- (void)incrementConstantWithPriorityVector:(struct __CFData *)arg1 timesScalarCoefficient:(double)arg2;
- (void)incrementConstantWithPriority:(double)arg1 value:(double)arg2;
- (id)description;
- (void)dealloc;
- (id)initWithLinearExpression:(id)arg1 priority:(double)arg2;
- (id)init;

@end

