using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSLocale_Class/index.html#//apple_ref/occ/cl/NSLocale
    /// <summary>
    /// Locales encapsulate information about linguistic, cultural, and technological conventions and standards. Examples of information encapsulated by a locale include the symbol used for the decimal separator in numbers and the way dates are formatted.
    /// </summary>
    [iOSVersion(2)]
    public class NSLocale : NSObject
    {
        /// <summary>
        /// Initializes the receiver using a given locale identifier.
        /// </summary>
        /// <param name="localeIdentifier">The identifier for the new locale.</param>
        /// <returns>The initialized locale.</returns>
        [iOSVersion(2)]
        public NSLocale(string localeIdentifier) { }
        
        /// <summary>
        /// Returns the current logical locale for the current user.
        /// </summary>
        /// <returns>The current logical locale for the current user. The locale is formed from the settings for the current user’s chosen system locale overlaid with any custom settings the user has specified in System Preferences.</returns>
        [iOSVersion(2)]
        [Export("autoupdatingCurrentLocale")]
        public static NSLocale AutoupdatingCurrentLocale() { return null; }
        
        /// <summary>
        /// Returns the logical locale for the current user.
        /// </summary>
        /// <returns>The logical locale for the current user. The locale is formed from the settings for the current user’s chosen system locale overlaid with any custom settings the user has specified in System Preferences.</returns>
        [iOSVersion(2)]
        [Export("currentLocale")]
        public static NSLocale CurrentLocale() { return null; }
        
        /// <summary>
        /// Returns the “root”, canonical locale, that contains fixed “backstop” settings that provide values for otherwise undefined keys.
        /// </summary>
        /// <returns>The “root”, canonical locale, that contains fixed “backstop” settings that provide values for otherwise undefined keys.</returns>
        [iOSVersion(2)]
        [Export("systemLocale")]
        public static NSLocale SystemLocale() { return null; }
        
        /// <summary>
        /// Returns the display name for the given value.
        /// </summary>
        /// <param name="key">Specifies which of the locale property keys value is (see Constants),</param>
        /// <param name="value">A value for key.</param>
        /// <returns>The display name for value.</returns>
        [iOSVersion(2)]
        [Export("displayNameForKey")]
        public string DisplayNameForKey(AnyObject key, AnyObject value) { return ""; }
        
        /// <summary>
        /// Returns the identifier for the receiver.
        /// </summary>
        /// <returns>The identifier for the receiver. This may not be the same string that the locale was created with, since NSLocale may canonicalize it.</returns>
        [iOSVersion(2)]
        [Export("localeIdentifier")]
        public string LocaleIdentifier { get; private set; }
        
        /// <summary>
        /// Returns the object corresponding to the specified key.
        /// </summary>
        /// <param name="key">The key for which to return the corresponding value. For valid values of key, see Constants.</param>
        /// <returns>The object corresponding to key.</returns>
        [iOSVersion(2)]
        [Export("objectForKey")]
        public AnyObject ObjectForKey(AnyObject key) { return null; }
        
        /// <summary>
        /// Returns an array of NSString objects, each of which identifies a locale available on the system.
        /// </summary>
        /// <returns>An array of NSString objects, each of which identifies a locale available on the system.</returns>
        [iOSVersion(2)]
        [Export("availableLocaleIdentifiers")]
        public static AnyObject[] AvailableLocaleIdentifiers() { return null; }
        
        /// <summary>
        /// Returns an array of NSString objects that represents all known legal country codes.
        /// </summary>
        /// <returns>An array of NSString objects that represents all known legal country codes.</returns>
        [iOSVersion(2)]
        [Export("ISOCountryCodes")]
        public static AnyObject[] ISOCountryCodes() { return null; }
        
        /// <summary>
        /// Returns an array of NSString objects that represents all known legal ISO currency codes.
        /// </summary>
        /// <returns>An array of NSString objects that represents all known legal ISO currency codes.</returns>
        [iOSVersion(2)]
        [Export("ISOCurrencyCodes")]
        public static AnyObject[] ISOCurrencyCodes() { return null; }
        
        /// <summary>
        /// Returns an array of NSString objects that represents all known legal ISO language codes.
        /// </summary>
        /// <returns>An array of NSString objects that represents all known legal ISO language codes.</returns>
        [iOSVersion(2)]
        [Export("ISOLanguageCodes")]
        public static AnyObject[] ISOLanguageCodes() { return null; }
        
        /// <summary>
        /// Returns an array of common ISO currency codes
        /// </summary>
        /// <returns>An array of NSString objects that represents common ISO currency codes.</returns>
        [iOSVersion(2)]
        [Export("commonISOCurrencyCodes")]
        public static AnyObject[] CommonISOCurrencyCodes() { return null; }
        
        /// <summary>
        /// Returns the canonical identifier for a given locale identification string.
        /// </summary>
        /// <param name="string">A locale identification string.</param>
        /// <returns>The canonical identifier for an the locale identified by string.</returns>
        [iOSVersion(2)]
        [Export("canonicalLocaleIdentifierFromString")]
        public static string CanonicalLocaleIdentifierFromString(string @string) { return ""; }
        
        /// <summary>
        /// Returns a dictionary that is the result of parsing a locale ID.
        /// </summary>
        /// <param name="string">A locale ID, consisting of language, script, country, variant, and keyword/value pairs, for example, &quot;en_US@calendar=japanese&quot;.</param>
        /// <returns>A dictionary that is the result of parsing string as a locale ID. The keys are the constant NSString constants corresponding to the locale ID components, and the values correspond to constants where available. For the complete set of dictionary keys, see Constants.</returns>
        [iOSVersion(2)]
        [Export("componentsFromLocaleIdentifier")]
        public static NSDictionary ComponentsFromLocaleIdentifier(string @string) { return null; }
        
        /// <summary>
        /// Returns a locale identifier from the components specified in a given dictionary.
        /// </summary>
        /// <param name="dict">A dictionary containing components that specify a locale. For valid dictionary keys, see Constants.</param>
        /// <returns>A locale identifier created from the components specified in dict.</returns>
        [iOSVersion(2)]
        [Export("localeIdentifierFromComponents")]
        public static string LocaleIdentifierFromComponents(NSDictionary dict) { return ""; }
        
        /// <summary>
        /// Returns a canonical language identifier by mapping an arbitrary locale identification string to the canonical identifier.
        /// </summary>
        /// <param name="string">A string representation of an arbitrary locale identifier.</param>
        /// <returns>A string that represents the canonical language identifier for the specified arbitrary locale identifier.</returns>
        [iOSVersion(4)]
        [Export("canonicalLanguageIdentifierFromString")]
        public static string CanonicalLanguageIdentifierFromString(string @string) { return ""; }
        
        /// <summary>
        /// Returns a locale identifier from a Windows locale code.
        /// </summary>
        /// <param name="lcid">The Windows locale code.</param>
        /// <returns>The locale identifier.</returns>
        [iOSVersion(4)]
        [Export("localeIdentifierFromWindowsLocaleCode")]
        public static string LocaleIdentifierFromWindowsLocaleCode(uint lcid) { return ""; }
        
        /// <summary>
        /// Returns a Window locale code from the locale identifier.
        /// </summary>
        /// <param name="localeIdentifier">The locale identifier.</param>
        /// <returns>The Windows locale code.</returns>
        [iOSVersion(4)]
        [Export("windowsLocaleCodeFromLocaleIdentifier")]
        public static uint WindowsLocaleCodeFromLocaleIdentifier(string localeIdentifier) { return 0; }
        
        /// <summary>
        /// Returns the user's language preference order as an array of strings.
        /// </summary>
        /// <returns>The user's preferred languages as an array of NSString objects, where each string is a language ID.</returns>
        [iOSVersion(2)]
        [Export("preferredLanguages")]
        public static AnyObject[] PreferredLanguages() { return null; }
        
        /// <summary>
        /// Returns the character direction for the specified ISO language code.
        /// </summary>
        /// <param name="isoLangCode">The ISO language code.</param>
        /// <returns>Returns the character direction for the language. See NSLocaleLanguageDirection for possible values. If the appropriate direction can’t be determined NSLocaleLanguageDirectionUnknown is returned.</returns>
        [iOSVersion(4)]
        [Export("characterDirectionForLanguage")]
        public static NSLocaleLanguageDirection CharacterDirectionForLanguage(string isoLangCode) { return NSLocaleLanguageDirection.LeftToRight; }
        
        /// <summary>
        /// Returns the line direction for the specified ISO language code.
        /// </summary>
        /// <param name="isoLangCode">The ISO language code.</param>
        /// <returns>Returns the line direction for the language. See NSLocaleLanguageDirection for possible values. If the appropriate direction can’t be determined NSLocaleLanguageDirectionUnknown is returned.</returns>
        [iOSVersion(4)]
        [Export("lineDirectionForLanguage")]
        public static NSLocaleLanguageDirection LineDirectionForLanguage(string isoLangCode) { return NSLocaleLanguageDirection.LeftToRight; }
        
        /// <summary>
        /// These constants describe the text direction for a language. Used by the methods lineDirectionForLanguage: and characterDirectionForLanguage:.
        /// </summary>
        [iOSVersion(4)]
        public enum NSLocaleLanguageDirection {
            /// <summary>
            /// The direction of the language is unknown.
            /// </summary>
            [iOSVersion(4)]
            Unknown,

            /// <summary>
            /// The language direction is from left to right.
            /// </summary>
            [iOSVersion(4)]
            LeftToRight,

            /// <summary>
            /// The language direction is from right to left.
            /// </summary>
            [iOSVersion(4)]
            RightToLeft,

            /// <summary>
            /// The language direction is from top to bottom.
            /// </summary>
            [iOSVersion(4)]
            TopToBottom,

            /// <summary>
            /// The language direction is from bottom to top.
            /// </summary>
            [iOSVersion(4)]
            BottomToTop
        }
        
        /// <summary>
        /// The following constants specify keys used to retrieve components of a locale with objectForKey:.
        /// </summary>
        
        /// <summary>
        /// The key for the locale identifier.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleIdentifier { get; private set; }
        
        /// <summary>
        /// The key for the locale language code.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleLanguageCode { get; private set; }
        
        /// <summary>
        /// The key for the locale country code.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleCountryCode { get; private set; }
        
        /// <summary>
        /// The key for the locale script code.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleScriptCode { get; private set; }
        
        /// <summary>
        /// The key for the locale variant code.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleVariantCode { get; private set; }
        
        /// <summary>
        /// The key for the exemplar character set for the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleExemplarCharacterSet { get; private set; }
        
        /// <summary>
        /// The key for the calendar associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleCalendar { get; private set; }
        
        /// <summary>
        /// The key for the collation associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleCollationIdentifier { get; private set; }
        
        /// <summary>
        /// The key for the flag that indicates whether the locale uses the metric system.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleUsesMetricSystem { get; private set; }
        
        /// <summary>
        /// The key for the measurement system associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleMeasurementSystem { get; private set; }
        
        /// <summary>
        /// The key for the decimal separator associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleDecimalSeparator { get; private set; }
        
        /// <summary>
        /// The key for the numeric grouping separator associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleGroupingSeparator { get; private set; }
        
        /// <summary>
        /// The key for the currency symbol associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleCurrencySymbol { get; private set; }
        
        /// <summary>
        /// The key for the currency code associated with the locale.
        /// </summary>
        [iOSVersion(2)]
        public string NSLocaleCurrencyCode { get; private set; }
        
        /// <summary>
        /// The key for the collation identifier for the locale.
        /// </summary>
        [iOSVersion(4)]
        public string NSLocaleCollatorIdentifier { get; private set; }
        
        /// <summary>
        /// The key for the begin quotation symbol associated with the locale.
        /// </summary>
        [iOSVersion(4)]
        public string NSLocaleQuotationBeginDelimiterKey { get; private set; }
        
        /// <summary>
        /// The key for the end quotation symbol associated with the locale.
        /// </summary>
        [iOSVersion(4)]
        public string NSLocaleQuotationEndDelimiterKey { get; private set; }
        
        /// <summary>
        /// The key for the alternating begin quotation symbol associated with the locale. In some locales, when quotations are nested, the quotation characters alternate. Thus, NSLocaleQuotationBeginDelimiterKey, then NSLocaleAlternateQuotationBeginDelimiterKey, etc.
        /// </summary>
        [iOSVersion(4)]
        public string NSLocaleAlternateQuotationBeginDelimiterKey { get; private set; }
        
        /// <summary>
        /// The key for the alternate end quotation symbol associated with the locale. In some locales, when quotations are nested, the quotation characters alternate. Thus, NSLocaleQuotationEndDelimiterKey, then NSLocaleAlternateQuotationEndDelimiterKey, etc.
        /// </summary>
        [iOSVersion(4)]
        public string NSLocaleAlternateQuotationEndDelimiterKey { get; private set; }
        
        /// <summary>
        /// These constants identify NSCalendar instances.
        /// </summary>
        
        /// <summary>
        /// Identifier for the Gregorian calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSGregorianCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Buddhist calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSBuddhistCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Chinese calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSChineseCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Hebrew calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSHebrewCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Islamic calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSIslamicCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Islamic civil calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSIslamicCivilCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Japanese calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSJapaneseCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Republic of China (Taiwan) calendar.
        /// </summary>
        [iOSVersion(8)]
        public string NSRepublicOfChinaCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Persian calendar
        /// </summary>
        [iOSVersion(8)]
        public string NSPersianCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the Indian calendar
        /// </summary>
        [iOSVersion(8)]
        public string NSIndianCalendar { get; private set; }
        
        /// <summary>
        /// Identifier for the ISO8601. The ISO8601 calendar is not yet implemented.
        /// </summary>
        [iOSVersion(8)]
        public string NSISO8601Calendar { get; private set; }

        //TODO: add NSCurrentLocaleDidChangeNotification

    }

    /// <summary>
    /// Notification that indicates that the user’s locale changed. 
    /// </summary>
    [iOSVersion(4)]
    public class NSCurrentLocaleDidChangeNotification : NSNotification
    {
        public NSCurrentLocaleDidChangeNotification() : base("", null) { }
    }
}