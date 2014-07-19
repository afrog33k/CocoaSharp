using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSMetadataQuery class encapsulates the functionality provided by the MDQuery opaque type for querying the Spotlight metadata.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMetadataQuery_Class/index.html#//apple_ref/occ/cl/NSMetadataQuery"/>	[iOSVersion(5)]	public class NSMetadataQuery : NSObject, AnyObject, NSObjectProtocol	{		/// <summary>		/// Initializes an allocated NSMetadataQuery object.		/// </summary>		[iOSVersion(5)]		public NSMetadataQuery() { }				/// <summary>		/// Attempts to start the query.		/// </summary>		[iOSVersion(5)]		[Export("startQuery")]		public bool StartQuery() { return default(bool); }				/// <summary>		/// Stops the receiver’s current query from gathering any further results.		/// </summary>		[iOSVersion(5)]		[Export("stopQuery")]		public void StopQuery() {  }				/// <summary>		/// Returns the query result at a specific index.		/// </summary>		/// <param name="index">Index of the desired result in the query result array.</param>		[iOSVersion(5)]		[Export("resultAtIndex")]		public AnyObject ResultAtIndex(int index) { return default(AnyObject); }				/// <summary>		/// Returns the index of a query result object in the receiver’s results array.		/// </summary>		/// <param name="result">Query result object being inquired about.</param>		[iOSVersion(5)]		[Export("indexOfResult")]		public int IndexOfResult(AnyObject result) { return default(int); }				/// <summary>		/// Enumerates the current set of results using the given block.		/// </summary>		/// <param name="block">The block to execute for each current result.</param>		[iOSVersion(7)]		[Export("enumerateResultsUsingBlock")]		public void EnumerateResultsUsingBlock(Action<AnyObject, int, UnsafePointer<ObjCBool>> block) {  }				/// <summary>		/// Enumerates the current set of results using the given options and block.		/// </summary>		/// <param name="opts">Options for the enumeration. You can</param>		/// <param name="usingBlock">The block to execute for each current result.</param>		[iOSVersion(7)]		[Export("enumerateResultsWithOptions")]		public void EnumerateResultsWithOptions(NSEnumerationOptions opts, Action<AnyObject, int, UnsafePointer<ObjCBool>> usingBlock) {  }				/// <summary>		/// Returns the value for the attribute name attrName at the index in the results specified by idx.		/// </summary>		/// <param name="attributeName">The attribute of the result object at index being inquired about. The attribute must be specified in valueListAttributes, as a sorting key in a specified sort descriptor, or as one of the grouping attributes specified set for the query.</param>		/// <param name="forResultAtIndex">Index of the desired return object in the query results array.</param>		[iOSVersion(5)]		[Export("valueOfAttribute")]		public AnyObject ValueOfAttribute(string attributeName, int forResultAtIndex) { return default(AnyObject); }				/// <summary>		/// Enables updates to the query results.		/// </summary>		[iOSVersion(5)]		[Export("enableUpdates")]		public void EnableUpdates() {  }				/// <summary>		/// Disables updates to the query results.		/// </summary>		[iOSVersion(5)]		[Export("disableUpdates")]		public void DisableUpdates() {  }				/// <summary>		/// An array containing the search scopes.		/// </summary>		[iOSVersion(5)]		[Export("searchScopes")]		public AnyObject[] SearchScopes { get; set; }				/// <summary>		/// The predicate used to filter query results.		/// </summary>		[iOSVersion(5)]		[Export("predicate")]		public NSPredicate Predicate { get; set; }				/// <summary>		/// An array of sort descriptor objects.		/// </summary>		[iOSVersion(5)]		[Export("sortDescriptors")]		public AnyObject[] SortDescriptors { get; set; }				/// <summary>		/// An array of attributes whose values are gathered by the query.		/// </summary>		[iOSVersion(5)]		[Export("valueListAttributes")]		public AnyObject[] ValueListAttributes { get; set; }				/// <summary>		/// An array of grouping attributes. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("groupingAttributes")]		public AnyObject[] GroupingAttributes { get; set; }				/// <summary>		/// The interval at which notification of updated results occurs.		/// </summary>		[iOSVersion(5)]		[Export("notificationBatchingInterval")]		public NSTimeInterval NotificationBatchingInterval { get; set; }				/// <summary>		/// The query’s delegate.		/// </summary>		[iOSVersion(5)]		[Export("delegate")]		public NSMetadataQueryDelegate Delegate { get; set; }				/// <summary>		/// An array of objects that define the query’s scope.		/// </summary>		[iOSVersion(7)]		[Export("searchItems")]		public AnyObject[] SearchItems { get; set; }				/// <summary>		/// A Boolean value that indicates whether the query has started. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("started")]		public bool Started { get; private set; }				/// <summary>		/// A Boolean value that indicates whether the receiver is in the initial gathering phase of the query. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("gathering")]		public bool Gathering { get; private set; }				/// <summary>		/// A Boolean value that indicates whether the query has stopped. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("stopped")]		public bool Stopped { get; private set; }				/// <summary>		/// An array containing the query’s results. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("results")]		public AnyObject[] Results { get; private set; }				/// <summary>		/// The number of results returned by the query. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("resultCount")]		public int ResultCount { get; private set; }				/// <summary>		/// An array containing hierarchical groups of query results. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("groupedResults")]		public AnyObject[] GroupedResults { get; private set; }				/// <summary>		/// A dictionary containing the value lists generated by the query. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("valueLists")]		public Dictionary<NSObject, AnyObject> ValueLists { get; private set; }				/// <summary>		/// The queue on which query result notifications are posted.		/// </summary>		[iOSVersion(7)]		[Export("operationQueue")]		public NSOperationQueue OperationQueue { get; set; }	}}