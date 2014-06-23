using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMetadataQueryAttributeValueTuple_Class/index.html#//apple_ref/occ/cl/NSMetadataQueryAttributeValueTuple	/// <summary>	/// The NSMetadataQueryAttributeValueTuple class represents attribute-value tuples, which are objects that contain the attribute name and value of a metadata attribute.	/// </summary>	[iOSVersion(5)]	public class NSMetadataQueryAttributeValueTuple : NSObject	{		/// <summary>		/// Returns the receiver’s attribute name.		/// </summary>		/// <returns>The receiver’s attribute name.</returns>		[iOSVersion(5)]		[Export("attribute")]		public string Attribute { get; private set; }				/// <summary>		/// Returns the number of instances of the value that exist for the attribute name of the receiver.		/// </summary>		/// <returns>The number of instantes of the value that exist for the attribute name of the receiver.</returns>		[iOSVersion(5)]		[Export("count")]		public int Count { get; private set; }				/// <summary>		/// Returns the receiver’s attribute value.		/// </summary>		/// <returns>The receiver’s attribute value.</returns>		[iOSVersion(5)]		[Export("value")]		public AnyObject Value { get; private set; }	}}