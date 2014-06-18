/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

@class TSTFormulaPredicate;

// Not exported
@interface TSTTableFilterRule : NSObject <NSCopying>
{
    TSTFormulaPredicate *mPredicate;
    _Bool mDisabled;
    _Bool mDoesNotNeedFormulaRewriteForImport;
}

+ (id)ruleWhereValuesInTable:(id)arg1 inColumn:(unsigned char)arg2 matchCell:(id)arg3;
+ (id)ruleWithFormulaPredicate:(id)arg1;
- (id)initFromArchive:(const struct FilterRuleArchive *)arg1;
- (void)encodeToArchive:(struct FilterRuleArchive *)arg1;
- (_Bool)isEnabled;
- (void)setEnabled:(_Bool)arg1;
- (id)localizedTextRepresentation;
- (id)p_formatDurationPredicate;
- (id)p_formatDatePredicate;
- (id)p_formatValuePredicate;
- (id)p_formatTextPredicate;
- (_Bool)matchesCell:(id)arg1;
- (unsigned char)columnIndexForFilterRuleInTableModel:(id)arg1;
- (_Bool)matchesRow:(unsigned short)arg1 withFormulaTableID:(struct __CFUUID *)arg2 withCalculationEngine:(id)arg3;
- (_Bool)needsFormulaRewriteForImport;
- (void)setDoesNotNeedFormulaRewriteForImport;
- (_Bool)needsThreshold;
- (unsigned long long)hash;
- (_Bool)isEqual:(id)arg1;
- (struct TSCEFormula *)formula;
- (id)predicate;
- (id)description;
- (void)dealloc;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)initRuleWhereValuesInTable:(id)arg1 inColumn:(unsigned char)arg2 matchCell:(id)arg3;
- (id)initWithFormulaPredicate:(id)arg1;

@end

