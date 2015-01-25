using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// An NSURL object represents a URL that can potentially contain the location of a resource on a remote server, the path of a local file on disk, or even an arbitrary piece of encoded data.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURL_Class/index.html#//apple_ref/occ/cl/NSURL"/>    [iOSVersion(2)]    [Export("")]    public class NSURL : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable, QLPreviewItem, Reflectable    {        public NSURL() { }        /// <summary>        /// Initializes and returns a newly created NSURL object as a file URL with a specified path.        /// </summary>        /// <param name="path">The path that the NSURL object will represent. path should be a valid system path. If path begins with a tilde, it must first be expanded with stringByExpandingTildeInPath. If path is a relative path, it is treated as being relative to the current working directory.        ///   Passing nil for this parameter produces an exception.</param>        /// <param name="isDirectory">A Boolean value that specifies whether path is treated as a directory path when resolving against relative path components. Pass true if the path indicates a directory, false otherwise.</param>        [iOSVersion(2)]        [Export("fileURLWithPath")]        [return:Optional]        public static NSURL FileURLWithPath(string path, bool isDirectory) { return default(NSURL); }                /// <summary>        /// Initializes and returns a newly created NSURL object as a file URL with a specified path.        /// </summary>        /// <param name="path">The path that the NSURL object will represent. path should be a valid system path. If path begins with a tilde, it must first be expanded with stringByExpandingTildeInPath. If path is a relative path, it is treated as being relative to the current working directory.        ///   Passing nil for this parameter produces an exception.</param>        [iOSVersion(2)]        [Export("fileURLWithPath")]        [return:Optional]        public static NSURL FileURLWithPath(string path) { return default(NSURL); }                /// <summary>        /// Initializes and returns a newly created NSURL object as a file URL with specified path components.        /// </summary>        /// <param name="components">An array of path components.        ///   Passing nil for this parameter produces an exception.</param>        [iOSVersion(4)]        [Export("fileURLWithPathComponents")]        [return:Optional]        public static NSURL FileURLWithPathComponents(AnyObject[] components) { return default(NSURL); }                /// <summary>        /// Returns a new URL object initialized with a C string representing a local file system path.        /// </summary>        /// <param name="path">A null-terminated C string in file system representation containing the path to represent as a URL. If this path is a relative path, it is treated as being relative to the current working directory.</param>        /// <param name="isDirectory">true if the last path part is a directory, otherwise false.</param>        /// <param name="relativeToURL">The base URL for the new URL object. This must be a file URL. If path is absolute, this URL is ignored.</param>        [iOSVersion(7)]        [Export("fileURLWithFileSystemRepresentation")]        [return:Optional]        public static NSURL FileURLWithFileSystemRepresentation(UnsafePointer<Int8> path, bool isDirectory, [Optional] NSURL relativeToURL) { return default(NSURL); }                /// <summary>        /// Fills the provided buffer with a C string representing a local file system path.        /// </summary>        /// <param name="buffer">A buffer large enough to hold the path. On return, contains a null-terminated C string in file system representation.</param>        /// <param name="maxLength">The size of buffer in bytes (typically MAXPATHLEN or PATH_MAX).</param>        [iOSVersion(7)]        [Export("getFileSystemRepresentation")]        public virtual bool GetFileSystemRepresentation(UnsafeMutablePointer<Int8> buffer, int maxLength) { return default(bool); }                /// <summary>        /// Returns whether the resource pointed to by a file URL can be reached.        /// </summary>        /// <param name="error">The error that occurred when the resource could not be reached.</param>        [iOSVersion(5)]        [Export("checkResourceIsReachableAndReturnError")]        public virtual bool CheckResourceIsReachableAndReturnError(NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns whether the URL is a file reference URL.        /// </summary>        [iOSVersion(5)]        [Export("isFileReferenceURL")]        public virtual bool IsFileReferenceURL() { return default(bool); }                /// <summary>        /// Returns a new file reference URL that points to the same resource as the receiver.        /// </summary>        [iOSVersion(5)]        [Export("fileReferenceURL")]        [return:Optional]        public virtual NSURL FileReferenceURL() { return default(NSURL); }                /// <summary>        /// Returns a new URL made by appending a path component to the original URL.        /// </summary>        /// <param name="pathComponent">The path component to add to the URL, in its original form (not URL encoded).</param>        [iOSVersion(4)]        public virtual NSURL URLByAppendingPathComponent(string pathComponent) { return default(NSURL); }                /// <summary>        /// Returns a new URL made by appending a path component to the original URL, along with a trailing slash if the component is designated a directory.        /// </summary>        /// <param name="pathComponent">The path component to add to the URL.</param>        /// <param name="isDirectory">If true, a trailing slash is appended after pathComponent.</param>        [iOSVersion(5)]        public virtual NSURL URLByAppendingPathComponent(string pathComponent, bool isDirectory) { return default(NSURL); }                /// <summary>        /// Returns a new URL made by appending a path extension to the original URL.        /// </summary>        /// <param name="pathExtension">The path extension to add to the URL.</param>        [iOSVersion(4)]        public virtual NSURL URLByAppendingPathExtension(string pathExtension) { return default(NSURL); }                /// <summary>        /// Initializes and returns bookmark data derived from an alias file pointed to by a specified URL.        /// </summary>        /// <param name="bookmarkFileURL">The URL that points to the alias file.</param>        /// <param name="error">The error that occurred in the case that the bookmark data cannot be derived.</param>        [iOSVersion(5)]        [Export("bookmarkDataWithContentsOfURL")]        [return:Optional]        public static NSData BookmarkDataWithContentsOfURL(NSURL bookmarkFileURL, NSErrorPointer error) { return default(NSData); }                /// <summary>        /// Returns a bookmark for the URL, created with specified options and resource values.        /// </summary>        /// <param name="options">Options taken into account when creating the bookmark for the URL. The possible flags (which can be combined with bitwise OR operations) are described in Bookmark Data Creation Options.        ///   To create a security-scoped bookmark to support App Sandbox, include the NSURLBookmarkCreationWithSecurityScope flag. When you later resolve the bookmark, you can use the resulting security-scoped URL to obtain read/write access to the file-system resource pointed to by the URL.        ///   If you instead want to create a security-scoped bookmark that, when resolved, enables you to obtain read-only access to a file-system resource, bitwise OR this parameter’s value with both the NSURLBookmarkCreationWithSecurityScope option and the NSURLBookmarkCreationSecurityScopeAllowOnlyReadAccess option.</param>        /// <param name="includingResourceValuesForKeys">An array of names of URL resource properties to store as part of the bookmark. You can later access these values (without resolving the bookmark) by calling the resourceValuesForKeys:fromBookmarkData: method.        ///   The values of these properties must be of a type that the bookmark generation code can serialize. Specifically, the values can contain any of the following primitive types:        ///   NSString or CFString        ///   NSData or CFData        ///   NSDate or CFDate        ///   NSNumber or CFNumber        ///   CFBoolean        ///   NSURL or CFURL        ///   kCFNull or NSNull        ///   CFUUID        ///   In addition, the properties can contain the following collection classes:        ///   NSArray or CFArray containing only the above primitive types        ///   NSDictionary or CFDictionary with NSString or CFString keys, in which all values contain only the above primitive types</param>        /// <param name="relativeToURL">The URL that the bookmark data will be relative to.        ///   If you are creating a security-scoped bookmark to support App Sandbox, use this parameter as follows:        ///   To create an app-scoped bookmark, use a value of nil.         ///   To create a document-scoped bookmark, use the absolute path (despite this parameter’s name) to the document file that is to own the new security-scoped bookmark.</param>        /// <param name="error">The error that occurred in the case that the bookmark data cannot be created.</param>        [iOSVersion(5)]        [Export("bookmarkDataWithOptions")]        [return:Optional]        public virtual NSData BookmarkDataWithOptions(NSURLBookmarkCreationOptions options, AnyObject[] includingResourceValuesForKeys, [Optional] NSURL relativeToURL, NSErrorPointer error) { return default(NSData); }                /// <summary>        /// Returns the resource values for properties identified by a specified array of keys contained in specified bookmark data.        /// </summary>        /// <param name="keys">An array of names of URL resource properties. In addition to the standard, system-defined resource properties, you can also request any custom properties that you provided when you created the bookmark. See the bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error: method for details.</param>        /// <param name="fromBookmarkData">The bookmark data from which you want to retrieve resource values.</param>        [iOSVersion(5)]        [Export("resourceValuesForKeys")]        public static Dictionary<NSObject, AnyObject> ResourceValuesForKeys(AnyObject[] keys, NSData fromBookmarkData) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Creates an alias file on disk at a specified location with specified bookmark data.        /// </summary>        /// <param name="bookmarkData">The bookmark data containing information for the alias file.</param>        /// <param name="toURL">The desired location of the alias file.</param>        /// <param name="options">Options taken into account when creating the alias file.</param>        /// <param name="error">The error that occurred in the case that the alias file cannot be created.</param>        [iOSVersion(5)]        [Export("writeBookmarkData")]        public static bool WriteBookmarkData(NSData bookmarkData, NSURL toURL, NSURLBookmarkFileCreationOptions options, NSErrorPointer error) { return default(bool); }                /// <summary>        /// In an app that has adopted App Sandbox, makes the resource pointed to by a security-scoped URL available to the app.        /// </summary>        [iOSVersion(8)]        [Export("startAccessingSecurityScopedResource")]        public virtual bool StartAccessingSecurityScopedResource() { return default(bool); }                /// <summary>        /// In an app that adopts App Sandbox, revokes access to the resource pointed to by a security-scoped URL.        /// </summary>        [iOSVersion(8)]        [Export("stopAccessingSecurityScopedResource")]        public virtual void StopAccessingSecurityScopedResource() {  }                /// <summary>        /// Returns the value of the resource property for the specified key.        /// </summary>        /// <param name="value">The location where the value for the resource property identified by key should be stored.</param>        /// <param name="forKey">The name of one of the URL’s resource properties.</param>        /// <param name="error">The error that occurred if the resource value could not be retrieved. This parameter is optional. If you are not interested in receiving error information, you can pass nil.</param>        [iOSVersion(5)]        [Export("getResourceValue")]        public virtual bool GetResourceValue(AutoreleasingUnsafeMutablePointer<AnyObject> value, string forKey, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns the resource values for the properties identified by specified array of keys.        /// </summary>        /// <param name="keys">An array of property keys for the desired resource properties.</param>        /// <param name="error">The error that occurred if one or more resource values could not be retrieved.  This parameter is optional. If you are not interested in receiving error information, you can pass nil.</param>        [iOSVersion(5)]        [Export("resourceValuesForKeys")]        public virtual Dictionary<NSObject, AnyObject> ResourceValuesForKeys(AnyObject[] keys, NSErrorPointer error) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Sets the URL’s resource property for a given key to a given value.        /// </summary>        /// <param name="value">The value for the resource property defined by key.</param>        /// <param name="forKey">The name of one of the URL’s resource properties.</param>        /// <param name="error">The error that occurred if the resource value could not be set.</param>        [iOSVersion(5)]        [Export("setResourceValue")]        public virtual bool SetResourceValue([Optional] AnyObject value, string forKey, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Sets the URL’s resource properties for a given set of keys to a given set of values.        /// </summary>        /// <param name="keyedValues">A dictionary of resource values to be set.</param>        /// <param name="error">The error that occurred if one or more resource values could not be set.</param>        [iOSVersion(5)]        [Export("setResourceValues")]        public virtual bool SetResourceValues(Dictionary<NSObject, AnyObject> keyedValues, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Removes all cached resource values and temporary resource values from the URL object.        /// </summary>        [iOSVersion(7)]        [Export("removeAllCachedResourceValues")]        public virtual void RemoveAllCachedResourceValues() {  }                /// <summary>        /// Removes the cached resource value identified by a given key from the URL object.        /// </summary>        /// <param name="key">The resource value key whose cached values you want to remove.</param>        [iOSVersion(7)]        [Export("removeCachedResourceValueForKey")]        public virtual void RemoveCachedResourceValueForKey(string key) {  }                /// <summary>        /// Sets a temporary resource value on the URL object.        /// </summary>        /// <param name="value">The value to store.</param>        /// <param name="forKey">The key where the value should be stored. This key must be unique and must not conflict with any system-defined keys. Reverse-domain-name notation is recommended.</param>        [iOSVersion(7)]        [Export("setTemporaryResourceValue")]        public virtual void SetTemporaryResourceValue([Optional] AnyObject value, string forKey) {  }                /// <summary>        /// Returns whether the promised item can be reached.        /// </summary>        /// <param name="error">The error that occurred when the promised item could not be reached.</param>        [iOSVersion(8)]        [Export("checkPromisedItemIsReachableAndReturnError")]        public virtual bool CheckPromisedItemIsReachableAndReturnError(NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns the value of the resource property for the specified key.        /// </summary>        /// <param name="value">The location where the value for the resource property identified by key should be stored.</param>        /// <param name="forKey">The name of one of the URL’s resource properties.</param>        /// <param name="error">The error that occurred in the case that the resource value cannot be retrieved.</param>        [iOSVersion(8)]        [Export("getPromisedItemResourceValue")]        public virtual bool GetPromisedItemResourceValue(AutoreleasingUnsafeMutablePointer<AnyObject> value, string forKey, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns the resource values for the properties identified by specified array of keys.        /// </summary>        /// <param name="keys">An array of names of URL resource properties.</param>        /// <param name="error">The error that occurred in the case that one or more resource values cannot be retrieved.</param>        [iOSVersion(8)]        [Export("promisedItemResourceValuesForKeys")]        public virtual Dictionary<NSObject, AnyObject> PromisedItemResourceValuesForKeys(AnyObject[] keys, NSErrorPointer error) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// A boolean value that determines whether the receiver is a file URL. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("fileURL")]        public bool FileURL { get; private set; }                /// <summary>        /// The URL string for the receiver as an absolute URL. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("absoluteString")]        [Optional]        public string AbsoluteString { get; private set; }                /// <summary>        /// An absolute URL that refers to the same resource as the receiver. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("absoluteURL")]        [Optional]        public NSURL AbsoluteURL { get; private set; }                /// <summary>        /// The base URL. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("baseURL")]        [Optional]        public NSURL BaseURL { get; private set; }                /// <summary>        /// A C string containing the URL’s file system path. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("fileSystemRepresentation")]        public UnsafePointer<Int8> FileSystemRepresentation { get; private set; }                /// <summary>        /// The fragment identifier, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("fragment")]        [Optional]        public string Fragment { get; private set; }                /// <summary>        /// The host, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("host")]        [Optional]        public string Host { get; private set; }                /// <summary>        /// The last path component. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("lastPathComponent")]        [Optional]        public string LastPathComponent { get; private set; }                /// <summary>        /// The parameter string conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("parameterString")]        [Optional]        public string ParameterString { get; private set; }                /// <summary>        /// The password conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("password")]        [Optional]        public string Password { get; private set; }                /// <summary>        /// The path, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("path")]        [Optional]        public string Path { get; private set; }                /// <summary>        /// An array containing the  path components. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("pathComponents")]        public AnyObject[] PathComponents { get; private set; }                /// <summary>        /// The path extension. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("pathExtension")]        [Optional]        public string PathExtension { get; private set; }                /// <summary>        /// The port, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("port")]        [Optional]        public NSNumber Port { get; private set; }                /// <summary>        /// The query string, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("query")]        [Optional]        public string Query { get; private set; }                /// <summary>        /// The relative path, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("relativePath")]        [Optional]        public string RelativePath { get; private set; }                /// <summary>        /// A string representation of the relative portion of the URL. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("relativeString")]        [Optional]        public string RelativeString { get; private set; }                /// <summary>        /// The resource specifier. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("resourceSpecifier")]        [Optional]        public string ResourceSpecifier { get; private set; }                /// <summary>        /// The scheme. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("scheme")]        [Optional]        public string Scheme { get; private set; }                /// <summary>        /// A copy of the URL with any instances of &quot;..&quot; or &quot;.&quot; removed from its path. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("standardizedURL")]        [Optional]        public NSURL StandardizedURL { get; private set; }                /// <summary>        /// The user name, conforming to RFC 1808. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("user")]        [Optional]        public string User { get; private set; }                /// <summary>        /// A file path URL that points to the same resource as the URL object. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("filePathURL")]        [Optional]        public NSURL FilePathURL { get; private set; }                /// <summary>        /// A URL created by taking the receiver and removing the last path component. (read-only)        /// </summary>        [iOSVersion(4)]        [Optional]        public NSURL URLByDeletingLastPathComponent { get; private set; }                /// <summary>        /// A URL created by taking the receiver and removing the path extension, if any. (read-only)        /// </summary>        [iOSVersion(4)]        [Optional]        public NSURL URLByDeletingPathExtension { get; private set; }                /// <summary>        /// A URL that points to the same resource as the receiver and includes no symbolic links. (read-only)        /// </summary>        [iOSVersion(4)]        [Optional]        public NSURL URLByResolvingSymlinksInPath { get; private set; }                /// <summary>        /// A URL that points to the same resource as the original URL using an absolute path. (read-only)        /// </summary>        [iOSVersion(4)]        [Optional]        public NSURL URLByStandardizingPath { get; private set; }                /// <summary>        /// These schemes are the ones that NSURL can parse.        /// </summary>        [Unwrapped]        public string NSURLFileScheme { get; set; }    }    /// <summary>    /// Options used when creating bookmark data.    /// </summary>    public enum NSURLBookmarkCreationOptions    {        /// <summary>        /// Specifies that when a bookmark created with this option is resolved, its embedded file ID should take precedence over other sources of information (file system path, for example) in the event of a conflict.        /// Available in iOS 4.0 and later.        /// Deprecated in iOS 7.0.        /// </summary>        [Obsolete]        PreferFileIDResolution,        /// <summary>        /// Specifies that a bookmark created with this option should be created with minimal information. This produces a smaller bookmark that can be resolved in fewer ways.        /// </summary>        [iOSVersion(4)]        MinimalBookmark,        /// <summary>        /// Specifies that the bookmark data should include properties required to create Finder alias files.        /// </summary>        [iOSVersion(4)]        SuitableForBookmarkFile,        /// <summary>        ///         /// </summary>        WithSecurityScope,        /// <summary>        ///         /// </summary>        SecurityScopeAllowOnlyReadAccess,    }    /// <summary>    /// Options used when resolving bookmark data.    /// </summary>    public enum NSURLBookmarkResolutionOptions    {        /// <summary>        /// Specifies that no UI feedback should accompany resolution of the bookmark data.        /// </summary>        [iOSVersion(4)]        WithoutUI,        /// <summary>        /// Specifies that no volume should be mounted during resolution of the bookmark data.        /// </summary>        [iOSVersion(4)]        WithoutMounting,        /// <summary>        ///         /// </summary>        WithSecurityScope,    }    /// <summary>    /// Options used when creating file bookmark data    /// </summary>    [iOSVersion(4)]    public struct NSURLBookmarkFileCreationOptions    {        static public implicit operator NSURLBookmarkFileCreationOptions(int value)        {            return default(NSURLBookmarkFileCreationOptions);        }        static public implicit operator int(NSURLBookmarkFileCreationOptions value)        {            return default(int);        }    }}