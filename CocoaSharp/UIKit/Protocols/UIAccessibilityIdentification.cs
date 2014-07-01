using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAccessibilityIdentification_Protocol/index.html#//apple_ref/occ/intf/UIAccessibilityIdentification	/// <summary>	/// The UIAccessibilityIdentification protocol is used to associate a unique identifier with elements in your user interface. You can use the identifiers you define in UI Automation scripts because the value of accessibilityIdentifier corresponds to the return value of the name method of UIAElement.	/// </summary>	[iOSVersion(5)]	public interface UIAccessibilityIdentification	{		/// <summary>		/// A string that identifies the element. (required)		/// </summary>		[iOSVersion(5)]		[Export("accessibilityIdentifier")]		string AccessibilityIdentifier { get; set; }	}}