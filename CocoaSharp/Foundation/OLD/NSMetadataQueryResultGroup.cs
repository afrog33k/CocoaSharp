using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMetadataQueryResultGroup_Class/index.html#//apple_ref/occ/cl/NSMetadataQueryResultGroup	/// <summary>	/// The NSMetadataQueryResultGroup class represents a collection of grouped attribute results returned by an NSMetadataQuery object.	/// </summary>	[iOSVersion(5)]	public class NSMetadataQueryResultGroup : NSObject	{		/// <summary>		/// Returns the attribute name for the receiver’s result group.		/// </summary>		/// <returns>The attribute name for the receiver’s result group.</returns>		[iOSVersion(5)]		[Export("attribute")]		public string Attribute { get; private set; }				/// <summary>		/// Returns the value of the attribute name for the receiver.		/// </summary>		/// <returns>The value of the attribute name for the receiver.</returns>		[iOSVersion(5)]		[Export("value")]		public AnyObject Value { get; private set; }				/// <summary>		/// Returns an array containing the result objects for the receiver.		/// </summary>		/// <returns>An array containing the result objects for the receiver.</returns>		[iOSVersion(5)]		[Export("results")]		public AnyObject[] Results { get; private set; }				/// <summary>		/// Returns the number of results returned by the receiver.		/// </summary>		/// <returns>The number of results returned by the receiver.</returns>		[iOSVersion(5)]		[Export("resultCount")]		public int ResultCount { get; private set; }				/// <summary>		/// Returns the query result at a specific index.		/// </summary>		/// <param name="index">The index of the desired result.</param>		/// <returns>The query result at a specific index.</returns>		[iOSVersion(5)]		[Export("resultAtIndex")]		public AnyObject ResultAtIndex(int index) { return null; }				/// <summary>		/// Returns an array containing the subgroups of the receiver.		/// </summary>		/// <returns>An array containing the subgroups of the receiver.</returns>		[iOSVersion(5)]		[Export("subgroups")]		public AnyObject[] Subgroups { get; private set; }	}}