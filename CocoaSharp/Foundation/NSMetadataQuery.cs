using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMetadataQuery_Class/index.html#//apple_ref/occ/cl/NSMetadataQuery	/// <summary>	/// The NSMetadataQuery class encapsulates the functionality provided by the MDQuery opaque type for querying the Spotlight metadata.	/// </summary>	[iOSVersion(5)]	public class NSMetadataQuery : NSObject	{		/// <summary>		/// Initializes an allocated NSMetadataQuery object.		/// </summary>		/// <returns>An initialized NSMetadataQuery object.</returns>		[iOSVersion(5)]		public NSMetadataQuery() { }				/// <summary>		/// An array containing the search scopes.		/// </summary>		[iOSVersion(5)]		[Export("searchScopes")]		public AnyObject[] SearchScopes { get; set; }				/// <summary>		/// The predicate used to filter query results.		/// </summary>		[iOSVersion(5)]		[Export("predicate")]		public NSPredicate Predicate { get; set; }				/// <summary>		/// An array of sort descriptor objects.		/// </summary>		[iOSVersion(5)]		[Export("sortDescriptors")]		public AnyObject[] SortDescriptors { get; set; }				/// <summary>		/// An array of attributes whose values are gathered by the query.		/// </summary>		[iOSVersion(5)]		[Export("valueListAttributes")]		public AnyObject[] ValueListAttributes { get; set; }				/// <summary>		/// An array of grouping attributes. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("groupingAttributes")]		public AnyObject[] GroupingAttributes { get; set; }				/// <summary>		/// The interval at which notification of updated results occurs.		/// </summary>		[iOSVersion(5)]		[Export("notificationBatchinginterval")]		public NSTimeinterval NotificationBatchinginterval { get; set; }				/// <summary>		/// The query’s delegate.		/// </summary>		[iOSVersion(5)]		[Export("delegate")]		public NSMetadataQueryDelegate Delegate { get; set; }				/// <summary>		/// An array of objects that define the query’s scope.		/// </summary>		[iOSVersion(7)]		[Export("searchItems")]		public AnyObject[] SearchItems { get; set; }				/// <summary>		/// A Boolean value that indicates whether the query has started. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("started")]		public bool Started { get; private set; }				/// <summary>		/// Attempts to start the query.		/// </summary>		/// <returns>true when successful; false otherwise.</returns>		[iOSVersion(5)]		[Export("startQuery")]		public bool StartQuery() { return false; }				/// <summary>		/// A Boolean value that indicates whether the receiver is in the initial gathering phase of the query. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("gathering")]		public bool Gathering { get; private set; }				/// <summary>		/// A Boolean value that indicates whether the query has stopped. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("stopped")]		public bool Stopped { get; private set; }				/// <summary>		/// Stops the receiver’s current query from gathering any further results.		/// </summary>		[iOSVersion(5)]		[Export("stopQuery")]		public void StopQuery() { }				/// <summary>		/// An array containing the query’s results. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("results")]		public AnyObject[] Results { get; private set; }				/// <summary>		/// The number of results returned by the query. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("resultCount")]		public int ResultCount { get; private set; }				/// <summary>		/// Returns the query result at a specific index.		/// </summary>		/// <param name="index">Index of the desired result in the query result array.</param>		/// <returns>Query result at the position specified by index.</returns>		[iOSVersion(5)]		[Export("resultAtIndex")]		public AnyObject ResultAtIndex(int index) { return null; }				/// <summary>		/// Returns the index of a query result object in the receiver’s results array.		/// </summary>		/// <param name="result">Query result object being inquired about.</param>		/// <returns>Index of result in the query result array.</returns>		[iOSVersion(5)]		[Export("indexOfResult")]		public int IndexOfResult(AnyObject result) { return 0; }				/// <summary>		/// An array containing hierarchical groups of query results. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("groupedResults")]		public AnyObject[] GroupedResults { get; private set; }				/// <summary>		/// Enumerates the current set of results using the given block.		/// </summary>		/// <param name="block">The block to execute for each current result.</param>		[iOSVersion(7)]		[Export("enumerateResultsUsingBlock")]		public void EnumerateResultsUsingBlock(Action<AnyObject, int, CMutablePointer<ObjCBool>> block) { }				/// <summary>		/// Enumerates the current set of results using the given options and block.		/// </summary>		/// <param name="opts">Options for the enumeration. You can</param>		/// <param name="usingBlock">The block to execute for each current result.</param>		[iOSVersion(7)]		[Export("enumerateResultsWithOptions")]		public void EnumerateResultsWithOptions(NSEnumerationOptions opts, Action<AnyObject, int, CMutablePointer<ObjCBool>> usingBlock) { }				/// <summary>		/// A dictionary containing the value lists generated by the query. (read-only)		/// </summary>		[iOSVersion(5)]		[Export("valueLists")]		public NSDictionary ValueLists { get; private set; }				/// <summary>		/// Returns the value for the attribute name attrName at the index in the results specified by idx.		/// </summary>		/// <param name="attributeName">The attribute of the result object at index being inquired about. The attribute must be specified in valueListAttributes, as a sorting key in a specified sort descriptor, or as one of the grouping attributes specified set for the query.</param>		/// <param name="forResultAtIndex">Index of the desired return object in the query results array.</param>		/// <returns>Value for attributeName in the result object at index in the query result array.</returns>		[iOSVersion(5)]		[Export("valueOfAttribute")]		public AnyObject ValueOfAttribute(string attributeName, int forResultAtIndex) { return null; }				/// <summary>		/// Enables updates to the query results.		/// </summary>		[iOSVersion(5)]		[Export("enableUpdates")]		public void EnableUpdates() { }				/// <summary>		/// Disables updates to the query results.		/// </summary>		[iOSVersion(5)]		[Export("disableUpdates")]		public void DisableUpdates() { }				/// <summary>		/// The queue on which query result notifications are posted.		/// </summary>		[iOSVersion(7)]		[Export("operationQueue")]		public NSOperationQueue OperationQueue { get; set; }				/// <summary>		/// Constants for the predefined search scopes used by searchScopes.		/// </summary>				/// <summary>		/// Search all files in the Documents directories of the application’s iCloud container directories.		/// </summary>		[iOSVersion(5)]		public string NSMetadataQueryUbiquitousDocumentsScope { get; private set; }				/// <summary>		/// Search all files not in the Documents directories of the application’s iCloud container directories.		/// </summary>		[iOSVersion(5)]		public string NSMetadataQueryUbiquitousDataScope { get; private set; }				/// <summary>		/// Search for documents outside the app’s container. This search can locate iCloud documents that the user previously opened using a document picker view controller. This lets your app access the documents again without requiring direct user interaction. The result’s NSMetadataItemURLKey attributes return security-scoped NSURLs. For more information on working with security-scoped URLs, see Security-Scoped URLs in NSURL Class Reference.		/// </summary>		[iOSVersion(8)]		public string NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope { get; private set; }				/// <summary>		/// In addition to the requested metadata attributes, a query result also includes content relevance, accessed with the following key.		/// </summary>		[Export("NSMetadataQueryResultContentRelevanceAttribute")]		public string NSMetadataQueryResultContentRelevanceAttribute { get; private set; }				/// <summary>		/// Constants for keys to retrieve the collection of changed items from a notification’s user info dictionary. Note that when querying the ubiquitous scope, these keys get added to the user info dictionary only in OS X v. 10.10 and iOS 8.0 or later. To track changes in earlier versions, you must use KVO on the query’s results property instead.		/// </summary>				/// <summary>		/// Key to retrieve an array of items added to the query result.		/// </summary>		[iOSVersion(8)]		public string NSMetadataQueryUpdateAddedItemsKey { get; private set; }				/// <summary>		/// Key to retrieve an array of items that have changed in the query result.		/// </summary>		[iOSVersion(8)]		public string NSMetadataQueryUpdateChangedItemsKey { get; private set; }				/// <summary>		/// Key to retrieve an array of items removed from the query result.		/// </summary>		[iOSVersion(8)]		public string NSMetadataQueryUpdateRemovedItemsKey { get; private set; }								WHAT								WHAT								WHAT								WHAT	}}