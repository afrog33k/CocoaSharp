using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAccessibility_Protocol/index.html#//apple_ref/doc/uid/TP40008786	/// <summary>	/// The UIAccessibility informal protocol provides accessibility information about an application’s user interface elements. Assistive applications, such as VoiceOver, convey this information to users with disabilities to help them use the application.	/// </summary>	[iOSVersion(3)]	public interface UIAccessibility	{		/// <summary>		/// A mask that contains the OR combination of the accessibility traits that best characterize an accessibility element.		/// </summary>		[iOSVersion(3)]				//typealias UIAccessibilityTraits = Uint64				/// <summary>		/// The types of system Zoom that can be in effect.		/// </summary>		enum UIAccessibilityZoomType		{			/// <summary>			/// The system zoom type is the text insertion point.			/// </summary>			[iOSVersion(5)]			InsertionPoint,		}		/// <summary>		/// A notification that an accessible application can send.		/// </summary>		[iOSVersion(3)]				//typealias UIAccessibilityNotifications = Uint32				/// <summary>		/// Accessibility traits that tell an assistive application how an accessibility element behaves or should be treated.		/// </summary>				/// <summary>		/// The accessibility element has no traits.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitNone { get; }				/// <summary>		/// The accessibility element should be treated as a button.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitButton { get; }				/// <summary>		/// The accessibility element should be treated as a link.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitLink { get; }				/// <summary>		/// The accessibility element should be treated as a search field.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitSearchField { get; }				/// <summary>		/// The accessibility element should be treated as an image.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitImage { get; }				/// <summary>		/// The accessibility element is currently selected.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitSelected { get; }				/// <summary>		/// The accessibility element plays its own sound when activated.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitPlaysSound { get; }				/// <summary>		/// The accessibility element behaves as a keyboard key.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitKeyboardKey { get; }				/// <summary>		/// The accessibility element should be treated as static text that cannot change.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitStaticText { get; }				/// <summary>		/// The accessibility element provides summary information when the application starts.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitSummaryElement { get; }				/// <summary>		/// The accessibility element is not enabled and does not respond to user interaction.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitNotEnabled { get; }				/// <summary>		/// The accessibility element frequently updates its label or value.		/// </summary>		[iOSVersion(3)]		UIAccessibilityTraits UIAccessibilityTraitUpdatesFrequently { get; }				/// <summary>		/// The accessibility element starts a media session when it is activated.		/// </summary>		[iOSVersion(4)]		UIAccessibilityTraits UIAccessibilityTraitStartsMediaSession { get; }				/// <summary>		/// The accessibility element allows continuous adjustment through a range of values.		/// </summary>		[iOSVersion(4)]		UIAccessibilityTraits UIAccessibilityTraitAdjustable { get; }				/// <summary>		/// The accessibility element allows direct touch interaction for VoiceOver users.		/// </summary>		[iOSVersion(5)]		UIAccessibilityTraits UIAccessibilityTraitAllowsDirectinteraction { get; }				/// <summary>		/// The accessibility element should cause an automatic page turn when VoiceOver finishes reading the text within it.		/// </summary>		[iOSVersion(5)]		UIAccessibilityTraits UIAccessibilityTraitCausesPageTurn { get; }				/// <summary>		/// The accessibility element is a header that divides content into sections, such as the title of a navigation bar.		/// </summary>		[iOSVersion(6)]		UIAccessibilityTraits UIAccessibilityTraitHeader { get; }				/// <summary>		/// Keys used in the userInfo parameter dictionary of notifications.		/// </summary>				/// <summary>		/// The text of the announcement that finished.		/// </summary>		[iOSVersion(6)]		string UIAccessibilityAnnouncementKeyStringValue { get; }				/// <summary>		/// Indicates whether the announcement was successfully made.		/// </summary>		[iOSVersion(6)]		string UIAccessibilityAnnouncementKeyWasSuccessful { get; }				/// <summary>		/// Attributes that you can apply to text in an attributed string to modify how that text is pronounced.		/// </summary>				/// <summary>		/// The value of this key is an NSNumber object that you should interpret as a Boolean value. When the value is true, all punctuation in the text is spoken. You might use this for code or other text where the punctuation is relevant.		/// </summary>		[iOSVersion(7)]		string UIAccessibilitySpeechAttributePunctuation { get; }				/// <summary>		/// The value of this key is an NSString object containing a BCP-47 language code. When applied to text in a string, the rules for the specified language govern how that string is pronounced.		/// </summary>		[iOSVersion(7)]		string UIAccessibilitySpeechAttributeLanguage { get; }				/// <summary>		/// The value of this key is an NSNumber object containing a floating-point value in the range 0.0 to 2.0. The value indicates whether the text should be specified spoken with a higher or lower pitch than the default. The default value for this attribute is 1.0, which indicates a normal pitch. Values between 0.0 and 1.0 result in a lower pitch and values between 1.0 and 2.0 result in a higher pitch.		/// </summary>		[iOSVersion(7)]		string UIAccessibilitySpeechAttributePitch { get; }								WHAT								WHAT								WHAT								WHAT								WHAT								WHAT								WHAT								WHAT								WHAT								WHAT	}}