using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSFileVersion_Class/index.html#//apple_ref/occ/cl/NSFileVersion    /// <summary>    /// An NSFileVersion object represents a snapshot of a file at a specific point in time. Use the methods of this class to access, create, and manage file revisions in your app.    /// </summary>    [iOSVersion(5)]    public class NSFileVersion : NSObject    {        /// <summary>        /// Returns the most recent version object for the file at the specified URL.        /// </summary>        /// <param name="url">The URL of the file whose version object you want.</param>        /// <returns>The version object representing the current version of the file or nil if there is no such file.</returns>        [iOSVersion(5)]        [Export("currentVersionOfItemAtURL")]        public static NSFileVersion CurrentVersionOfItemAtURL(NSURL url) { return null; }                /// <summary>        /// Returns all versions of the specified file except the current version.        /// </summary>        /// <param name="url">The URL of the file whose versions you want.</param>        /// <returns>An array of file version objects or nil if there is no such file. The array does not contain the version object returned by the currentVersionOfItemAtURL: method.</returns>        [iOSVersion(5)]        [Export("otherVersionsOfItemAtURL")]        public static AnyObject[] OtherVersionsOfItemAtURL(NSURL url) { return null; }                /// <summary>        /// Returns the version of the file that has the specified persistent ID.        /// </summary>        /// <param name="ofItemAtURL">The URL of the file whose version you want.</param>        /// <param name="forPersistentIdentifier">The persistent ID of the NSFileVersion object you want.</param>        /// <returns>The file version object with the specified ID or nil if no such version object exists.</returns>        [iOSVersion(5)]
        public NSFileVersion(NSURL ofItemAtURL, AnyObject forPersistentIdentifier) { }                /// <summary>        /// The URL identifying the location of the file associated with the file version object. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("URL")]        public NSURL URL { get; private set; }                /// <summary>        /// The string containing the user-presentable name of the file version. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("localizedName")]        public string LocalizedName { get; private set; }                /// <summary>        /// The user-presentable name of the computer on which the revision was saved. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("localizedNameOfSavingComputer")]        public string LocalizedNameOfSavingComputer { get; private set; }                /// <summary>        /// The modification date of the version. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("modificationDate")]        public NSDate ModificationDate { get; private set; }                /// <summary>        /// The identifier for this version of the file. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("persistentIdentifier")]        public NSCoding PersistentIdentifier { get; private set; }                /// <summary>        /// A Boolean value indicating whether the contents of the version are in conflict with the contents of another version. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("conflict")]        public bool Conflict { get; private set; }                /// <summary>        /// A Boolean value that indicates the version object is not in conflict (true) or is in conflict (false).        /// </summary>        [iOSVersion(5)]        [Export("resolved")]        public bool Resolved { get; set; }                /// <summary>        /// Returns an array of version objects that are currently in conflict for the specified URL.        /// </summary>        /// <param name="url">The URL of the file that has associated version objects.</param>        /// <returns>An array of NSFileVersion objects that represent the versions in conflict or nil if the file at URL does not exist.</returns>        [iOSVersion(5)]        [Export("unresolvedConflictVersionsOfItemAtURL")]        public static AnyObject[] UnresolvedConflictVersionsOfItemAtURL(NSURL url) { return null; }                /// <summary>        /// Replace the contents of the specified file with the contents of the current version’s file.        /// </summary>        /// <param name="url">The file whose contents you want to replace. If the file at this URL does not exist, a new file is created at the location.</param>        /// <param name="options">Specify 0 to overwrite the file in place; otherwise, specify one of the constants described in “NSFileVersionReplacingOptions”.</param>        /// <param name="error">On input, a pointer to an error object. If an error occurs, this pointer is set to an NSError object with information about the error.</param>        /// <returns>The URL of the file that was written, which may be different than the one specified in the url parameter.</returns>        [iOSVersion(5)]        [Export("replaceItemAtURL")]        public NSURL ReplaceItemAtURL(NSURL url, NSFileVersionReplacingOptions options, NSErrorPointer error) { return null; }                /// <summary>        /// Remove this version object and its associated file from the version store.        /// </summary>        /// <param name="outError">On input, a pointer to an error object. If an error occurs, this pointer is set to an NSError object with information about the error.</param>        /// <returns>true if this version was removed successfully or false if it was not.</returns>        [iOSVersion(5)]        [Export("removeAndReturnError")]        public bool RemoveAndReturnError(NSErrorPointer outError) { return false; }                /// <summary>        /// Removes all versions of a file, except the current one, from the version store.        /// </summary>        /// <param name="inFileURL">The file whose older versions you want to delete. If the file at this URL does not exist, a new file is created at the location.</param>        /// <param name="error">On input, a pointer to an error object. If an error occurs, this pointer is set to an NSError object with information about the error.</param>        /// <returns>true if the older file versions were removed successfully or false if an error occurred.</returns>        [iOSVersion(5)]        [Export("removeOtherVersionsOfItemAtURL")]        public static bool RemoveOtherVersionsOfItemAtURL(NSURL inFileURL, NSErrorPointer error) { return false; }                /// <summary>        /// Options for adding a new file version.        /// </summary>        public enum NSFileVersionAddingOptions        {            /// <summary>            /// When adding a file, you can specify this option if you want to create the version by moving the source file to the specified location.            /// </summary>            [iOSVersion(5)]            ByMoving,        }        /// <summary>        /// Options for replacing a file version.        /// </summary>        public enum NSFileVersionReplacingOptions        {            /// <summary>            /// When replacing a file, move the old version of the file out of the version store instead of copying the new contents into the file’s version. You should use this option in conjunction with a file coordinator to make sure the operation is coordinated with other clients of the file.            /// </summary>            [iOSVersion(5)]            ByMoving,        }    }}