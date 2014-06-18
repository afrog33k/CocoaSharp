/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <OfficeImport/TSUNumberFormatter.h>

@interface TSUNumberFormatter (Private)
+ (id)formatterForLocale:(struct __CFLocale *)arg1;
- (struct __CFArray *)p_scientificFormatters;
- (struct __CFArray *)p_percentageFormatters;
- (struct __CFArray *)p_currencyFormatters;
- (struct __CFArray *)p_decimalFormatters;
- (id)localizedPercentSymbol;
- (id)defaultFormatStringForValueType:(int)arg1;
- (id)defaultFormatStringForValueType:(int)arg1 negativeStyle:(int)arg2;
- (id)currentLocaleCurrencyCode;
- (id)halfWidthCurrencySymbolForCurrencyCode:(id)arg1;
- (id)currencySymbolForCurrencyCode:(id)arg1;
- (id)displayNameForCurrencyCode:(id)arg1;
- (_Bool)findCurrencySymbolInString:(struct __CFString *)arg1 additionalCurrencyCode:(struct __CFString *)arg2 succesTSUlString:(const struct __CFString **)arg3;
- (_Bool)valueFromString:(struct __CFString *)arg1 formatters:(struct __CFArray *)arg2 value:(double *)arg3 formatString:(const struct __CFString **)arg4 currencyCode:(const struct __CFString **)arg5;
- (_Bool)fractionFromString:(struct __CFString *)arg1 value:(double *)arg2;
- (_Bool)scientificFromString:(struct __CFString *)arg1 value:(double *)arg2 formatString:(const struct __CFString **)arg3;
- (_Bool)percentageFromString:(struct __CFString *)arg1 value:(double *)arg2 formatString:(const struct __CFString **)arg3;
- (_Bool)currencyFromString:(struct __CFString *)arg1 additionalCurrencyCode:(struct __CFString *)arg2 value:(double *)arg3 formatString:(const struct __CFString **)arg4 currencyCode:(const struct __CFString **)arg5;
- (_Bool)decimalFromString:(struct __CFString *)arg1 value:(double *)arg2 formatString:(const struct __CFString **)arg3;
- (void)numberPreferencesChanged:(id)arg1;
- (void)dealloc;
- (id)initWithLocale:(struct __CFLocale *)arg1;
@end

