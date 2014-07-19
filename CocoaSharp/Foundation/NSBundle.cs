using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// An NSBundle object represents a location in the file system that groups code and resources that can be used in a program. NSBundle objects locate program resources, dynamically load and unload executable code, and assist in localization. You build a bundle in Xcode using one of these project types: Application, Framework, plug-ins.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSBundle_Class/index.html#//apple_ref/occ/cl/NSBundle"/>	[iOSVersion(2)]	public class NSBundle : NSObject//, AnyObject, NSObjectProtocol	{		/// <summary>		/// Returns an NSBundle object initialized to correspond to the specified file URL.		/// </summary>		/// <param name="URL">The file URL to a directory. This must be a full URL for a directory; if it contains any symbolic links, they must be resolvable.</param>		[iOSVersion(4)]		public NSBundle(NSURL URL) { }				/// <summary>		/// Returns an NSBundle object initialized to correspond to the specified directory.		/// </summary>		/// <param name="path">The path to a directory. This must be a full pathname for a directory; if it contains any symbolic links, they must be resolvable.</param>		[iOSVersion(2)]		public NSBundle(string path) { }				/// <summary>		/// Returns the NSBundle object with which the specified class is associated.		/// </summary>		/// <param name="forClass">A class.</param>		[iOSVersion(2)]		public NSBundle(AnyClass forClass) { }				/// <summary>		/// Returns the previously created NSBundle instance that has the specified bundle identifier.		/// </summary>		/// <param name="identifier">The identifier for an existing NSBundle instance.</param>		[iOSVersion(2)]		public NSBundle(string identifier) { }				/// <summary>		/// Returns the NSBundle object that corresponds to the directory where the current application executable is located.		/// </summary>		[iOSVersion(2)]		[Export("mainBundle")]		public static NSBundle MainBundle() { return default(NSBundle); }				/// <summary>		/// Returns an array of all the application’s non-framework bundles.		/// </summary>		[iOSVersion(2)]		[Export("allBundles")]		public static AnyObject[] AllBundles() { return default(AnyObject[]); }				/// <summary>		/// Returns an array of all of the application’s bundles that represent frameworks.		/// </summary>		[iOSVersion(2)]		[Export("allFrameworks")]		public static AnyObject[] AllFrameworks() { return default(AnyObject[]); }				/// <summary>		/// Returns the Class object for the specified name.		/// </summary>		/// <param name="className">The name of a class.</param>		[iOSVersion(2)]		[Export("classNamed")]		public AnyClass ClassNamed(string className) { return default(AnyClass); }				/// <summary>		/// Returns the file URL for the resource file identified by the specified name and extension and residing in a given bundle directory.		/// </summary>		/// <param name="name">The name of a resource file contained in the directory specified by bundleURL.</param>		/// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>		/// <param name="subdirectory">The path of a top-level bundle directory. This must be a valid path. For example, to specify the bundle directory for a Mac app, you might specify the path /Applications/MyApp.app.</param>		[iOSVersion(4)]		public NSURL URLForResource(string name, string withExtension, string subdirectory) { return default(NSURL); }				/// <summary>		/// Returns the full pathname for the resource file identified by the specified name and extension and residing in a given bundle directory.		/// </summary>		/// <param name="name">The name of a resource file contained in the directory specified by bundlePath.</param>		/// <param name="ofType">If extension is an empty string or nil, the extension is assumed not to exist and the file is the first file encountered that exactly matches name.</param>		/// <param name="inDirectory">The path of a top-level bundle directory. This must be a valid path. For example, to specify the bundle directory for a Mac app, you might specify the path /Applications/MyApp.app.</param>		[iOSVersion(2)]		[Export("pathForResource")]		public static string PathForResource(string name, string ofType, string inDirectory) { return default(string); }				/// <summary>		/// Returns the file URL for the resource identified by the specified name and file extension.		/// </summary>		/// <param name="name">The name of the resource file.</param>		/// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>		[iOSVersion(4)]		public NSURL URLForResource(string name, string withExtension) { return default(NSURL); }				/// <summary>		/// Returns the full pathname for the resource identified by the specified name and file extension.		/// </summary>		/// <param name="name">The name of the resource file. If name is an empty string or nil, returns the first file encountered of the supplied type.</param>		/// <param name="ofType">If extension is an empty string or nil, the extension is assumed not to exist and the file is the first file encountered that exactly matches name.</param>		[iOSVersion(2)]		[Export("pathForResource")]		public string PathForResource(string name, string ofType) { return default(string); }				/// <summary>		/// Returns the file URL for the resource identified by the specified name and file extension and located in the specified bundle subdirectory.		/// </summary>		/// <param name="extension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>		/// <param name="subdirectory">The name of the bundle subdirectory.</param>		[iOSVersion(4)]		public AnyObject[] URLsForResourcesWithExtension(string extension, string subdirectory) { return default(AnyObject[]); }				/// <summary>		/// Returns the full pathname for the resource identified by the specified name and file extension and located in the specified bundle subdirectory.		/// </summary>		/// <param name="name">The name of the resource file.</param>		/// <param name="ofType">If extension is an empty string or nil, all the files in subpath and its subdirectories are returned. If an extension is provided the subdirectories are not searched.</param>		/// <param name="inDirectory">The name of the bundle subdirectory. Can be nil.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[Export("pathForResource")]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public string PathForResource(string name, string ofType, string inDirectory, bool NAME_YOUR_PARAMS = false) { return default(string); }				/// <summary>		/// Returns the file URL for the resource identified by the specified name and file extension, located in the specified bundle subdirectory, and limited to global resources and those associated with the specified localization.		/// </summary>		/// <param name="name">The name of the resource file.</param>		/// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>		/// <param name="subdirectory">The name of the bundle subdirectory to search.</param>		/// <param name="localization">The language ID for the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>		[iOSVersion(4)]		public NSURL URLForResource(string name, string withExtension, string subdirectory, string localization) { return default(NSURL); }				/// <summary>		/// Returns the full pathname for the resource identified by the specified name and file extension, located in the specified bundle subdirectory, and limited to global resources and those associated with the specified localization.		/// </summary>		/// <param name="name">The name of the resource file.</param>		/// <param name="ofType">If extension is an empty string or nil, the extension is assumed not to exist and the file is the first file encountered that exactly matches name.</param>		/// <param name="inDirectory">The name of the bundle subdirectory to search.</param>		/// <param name="forLocalization">The language ID for of the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>		[iOSVersion(2)]		[Export("pathForResource")]		public string PathForResource(string name, string ofType, string inDirectory, string forLocalization) { return default(string); }				/// <summary>		/// Returns an array containing the pathnames for all bundle resources having the specified extension and residing in the bundle directory at the specified path.		/// </summary>		/// <param name="extension">The file extension. If extension is an empty string or nil, the extension is assumed not to exist, all the files in bundlePath are returned.</param>		/// <param name="inDirectory">The top-level directory of a bundle. This must represent a valid path.</param>		[iOSVersion(2)]		[Export("pathsForResourcesOfType")]		public static AnyObject[] PathsForResourcesOfType(string extension, string inDirectory) { return default(AnyObject[]); }				/// <summary>		/// Returns an array containing the pathnames for all bundle resources having the specified filename extension and residing in the resource subdirectory.		/// </summary>		/// <param name="extension">The file extension. If extension is an empty string or nil, the extension is assumed not to exist, all the files in subpath are returned.</param>		/// <param name="inDirectory">The name of the bundle subdirectory to search.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[Export("pathsForResourcesOfType")]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public AnyObject[] PathsForResourcesOfType(string extension, string inDirectory, bool NAME_YOUR_PARAMS = false) { return default(AnyObject[]); }				/// <summary>		/// Returns an array containing the file URLs for all bundle resources having the specified filename extension, residing in the specified resource subdirectory, and limited to global resources and those associated with the specified localization.		/// </summary>		/// <param name="ext">The file extension of the files to retrieve.</param>		/// <param name="subdirectory">The name of the bundle subdirectory to search.</param>		/// <param name="localization">The language ID for the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>		[iOSVersion(4)]		public AnyObject[] URLsForResourcesWithExtension(string ext, string subdirectory, string localization) { return default(AnyObject[]); }				/// <summary>		/// Returns an array containing the file for all bundle resources having the specified filename extension, residing in the specified resource subdirectory, and limited to global resources and those associated with the specified localization.		/// </summary>		/// <param name="extension">The file extension of the files to retrieve.</param>		/// <param name="inDirectory">The name of the bundle subdirectory to search.</param>		/// <param name="forLocalization">The language ID for the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>		[iOSVersion(2)]		[Export("pathsForResourcesOfType")]		public AnyObject[] PathsForResourcesOfType(string extension, string inDirectory, string forLocalization) { return default(AnyObject[]); }				/// <summary>		/// Creates and returns a file URL for the resource with the specified name and extension in the specified bundle.		/// </summary>		/// <param name="name">The name of the resource file.</param>		/// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>		/// <param name="subdirectory">The name of the bundle subdirectory to search.</param>		/// <param name="inBundleWithURL">The file URL of the bundle to search.</param>		[iOSVersion(4)]		public static NSURL URLForResource(string name, string withExtension, string subdirectory, NSURL inBundleWithURL) { return default(NSURL); }				/// <summary>		/// Returns an array containing the file URLs for all bundle resources having the specified filename extension, residing in the specified resource subdirectory, within the specified bundle.		/// </summary>		/// <param name="ext">The file extension of the files to retrieve.</param>		/// <param name="subdirectory">The name of the bundle subdirectory to search.</param>		/// <param name="inBundleWithURL">The file URL of the bundle to search.</param>		[iOSVersion(4)]		public static AnyObject[] URLsForResourcesWithExtension(string ext, string subdirectory, NSURL inBundleWithURL) { return default(AnyObject[]); }				/// <summary>		/// Returns the value associated with the specified key in the receiver's information property list.		/// </summary>		/// <param name="key">A key in the receiver's property list.</param>		[iOSVersion(2)]		[Export("objectForInfoDictionaryKey")]		public AnyObject ObjectForInfoDictionaryKey(string key) { return default(AnyObject); }				/// <summary>		/// Returns the file URL of the executable with the specified name in the receiver’s bundle.		/// </summary>		/// <param name="executableName">The name of an executable file.</param>		[iOSVersion(4)]		public NSURL URLForAuxiliaryExecutable(string executableName) { return default(NSURL); }				/// <summary>		/// Returns the full pathname of the executable with the specified name in the receiver’s bundle.		/// </summary>		/// <param name="executableName">The name of an executable file.</param>		[iOSVersion(2)]		[Export("pathForAuxiliaryExecutable")]		public string PathForAuxiliaryExecutable(string executableName) { return default(string); }				/// <summary>		/// Returns a localized version of the string designated by the specified key and residing in the specified table.		/// </summary>		/// <param name="key">The key for a string in the table identified by tableName.</param>		/// <param name="value">The value to return if key is nil or if a localized string for key can’t be found in the table.</param>		/// <param name="table">The receiver’s string table to search. If tableName is nil or is an empty string, the method attempts to use the table in Localizable.strings.</param>		[iOSVersion(2)]		[Export("localizedStringForKey")]		public string LocalizedStringForKey(string key, string value, string table) { return default(string); }				/// <summary>		/// Returns a Boolean value indicating whether the bundle’s executable code could be loaded successfully.		/// </summary>		/// <param name="error">On input, a pointer to an error object variable. On output, this variable may contain an error object indicating why the bundle’s executable could not be loaded. If no error would occur, this parameter is left unmodified. You may specify nil for this parameter if you are not interested in the error information.</param>		[iOSVersion(2)]		[Export("preflightAndReturnError")]		public bool PreflightAndReturnError(AutoreleasingUnsafePointer<NSError> error) { return default(bool); }				/// <summary>		/// Dynamically loads the bundle’s executable code into a running program, if the code has not already been loaded.		/// </summary>		[iOSVersion(2)]		[Export("load")]		public bool Load() { return default(bool); }				/// <summary>		/// Loads the bundle’s executable code and returns any errors.		/// </summary>		/// <param name="error">On input, a pointer to an error object variable. On output, this variable may contain an error object indicating why the bundle’s executable could not be loaded. If no error occurred, this parameter is left unmodified. You may specify nil for this parameter if you are not interested in the error information.</param>		[iOSVersion(2)]		[Export("loadAndReturnError")]		public bool LoadAndReturnError(AutoreleasingUnsafePointer<NSError> error) { return default(bool); }				/// <summary>		/// Unloads the code associated with the receiver.		/// </summary>		[iOSVersion(2)]		[Export("unload")]		public bool Unload() { return default(bool); }				/// <summary>		/// Returns one or more localizations from the specified list that a bundle object would use to locate resources for the current user.		/// </summary>		/// <param name="localizationsArray">An array of NSString objects, each of which specifies the language ID for a localization that the bundle supports.</param>		[iOSVersion(2)]		[Export("preferredLocalizationsFromArray")]		public static AnyObject[] PreferredLocalizationsFromArray(AnyObject[] localizationsArray) { return default(AnyObject[]); }				/// <summary>		/// Returns the localizations that a bundle object would prefer, given the specified bundle and user’s language preferences.		/// </summary>		/// <param name="localizationsArray">An array of NSString objects, each of which specifies the language ID for a localization that the bundle supports.</param>		/// <param name="forPreferences">An array of NSString objects containing the user's preferred localizations. If this parameter is nil, the method uses the user's localization preferences.</param>		[iOSVersion(2)]		[Export("preferredLocalizationsFromArray")]		public static AnyObject[] PreferredLocalizationsFromArray(AnyObject[] localizationsArray, AnyObject[] forPreferences) { return default(AnyObject[]); }				/// <summary>		/// Returns the receiver’s principal class.		/// </summary>		[iOSVersion(2)]		[Export("principalClass")]		public AnyClass PrincipalClass { get; private set; }				/// <summary>		/// Returns the full pathname of the receiving bundle’s subdirectory containing resources.		/// </summary>		[iOSVersion(2)]		[Export("resourcePath")]		public string ResourcePath { get; private set; }				/// <summary>		/// Returns the file URL for the bundle’s App Store receipt.		/// </summary>		[iOSVersion(7)]		[Export("appStoreReceiptURL")]		public NSURL AppStoreReceiptURL { get; private set; }				/// <summary>		/// Returns the full URL of the receiver’s bundle directory.		/// </summary>		[iOSVersion(4)]		[Export("bundleURL")]		public NSURL BundleURL { get; private set; }				/// <summary>		/// Returns the full pathname of the receiver’s bundle directory.		/// </summary>		[iOSVersion(2)]		[Export("bundlePath")]		public string BundlePath { get; private set; }				/// <summary>		/// Returns the receiver’s bundle identifier.		/// </summary>		[iOSVersion(2)]		[Export("bundleIdentifier")]		public string BundleIdentifier { get; private set; }				/// <summary>		/// Returns a dictionary that contains information about the receiver.		/// </summary>		[iOSVersion(2)]		[Export("infoDictionary")]		public Dictionary<NSObject, AnyObject> InfoDictionary { get; private set; }				/// <summary>		/// Returns the file URL of the receiver's subdirectory containing plug-ins.		/// </summary>		[iOSVersion(4)]		[Export("builtInPlugInsURL")]		public NSURL BuiltInPlugInsURL { get; private set; }				/// <summary>		/// Returns the full pathname of the receiver's subdirectory containing plug-ins.		/// </summary>		[iOSVersion(2)]		[Export("builtInPlugInsPath")]		public string BuiltInPlugInsPath { get; private set; }				/// <summary>		/// Returns the file URL of the receiver's executable file.		/// </summary>		[iOSVersion(4)]		[Export("executableURL")]		public NSURL ExecutableURL { get; private set; }				/// <summary>		/// Returns the full pathname of the receiver's executable file.		/// </summary>		[iOSVersion(2)]		[Export("executablePath")]		public string ExecutablePath { get; private set; }				/// <summary>		/// Returns the file URL of the receiver's subdirectory containing private frameworks.		/// </summary>		[iOSVersion(4)]		[Export("privateFrameworksURL")]		public NSURL PrivateFrameworksURL { get; private set; }				/// <summary>		/// Returns the full pathname of the receiver's subdirectory containing private frameworks.		/// </summary>		[iOSVersion(2)]		[Export("privateFrameworksPath")]		public string PrivateFrameworksPath { get; private set; }				/// <summary>		/// Returns the file URL of the receiver's subdirectory containing shared frameworks.		/// </summary>		[iOSVersion(4)]		[Export("sharedFrameworksURL")]		public NSURL SharedFrameworksURL { get; private set; }				/// <summary>		/// Returns the full pathname of the receiver's subdirectory containing shared frameworks.		/// </summary>		[iOSVersion(2)]		[Export("sharedFrameworksPath")]		public string SharedFrameworksPath { get; private set; }				/// <summary>		/// Returns the file URL of the receiver's subdirectory containing shared support files.		/// </summary>		[iOSVersion(4)]		[Export("sharedSupportURL")]		public NSURL SharedSupportURL { get; private set; }				/// <summary>		/// Returns the full pathname of the receiver's subdirectory containing shared support files.		/// </summary>		[iOSVersion(2)]		[Export("sharedSupportPath")]		public string SharedSupportPath { get; private set; }				/// <summary>		/// Returns the file URL of the receiver's subdirectory containing resource files.		/// </summary>		[iOSVersion(4)]		[Export("resourceURL")]		public NSURL ResourceURL { get; private set; }				/// <summary>		/// Returns an array of numbers indicating the architecture types supported by the bundle’s executable.		/// </summary>		[iOSVersion(2)]		[Export("executableArchitectures")]		public AnyObject[] ExecutableArchitectures { get; private set; }				/// <summary>		/// Returns an ordered list of preferred localizations contained in the receiver’s bundle.		/// </summary>		[iOSVersion(2)]		[Export("preferredLocalizations")]		public AnyObject[] PreferredLocalizations { get; private set; }				/// <summary>		/// Returns the localization for the development language.		/// </summary>		[iOSVersion(2)]		[Export("developmentLocalization")]		public string DevelopmentLocalization { get; private set; }				/// <summary>		/// Returns a list of all the localizations contained in the receiver’s bundle.		/// </summary>		[iOSVersion(2)]		[Export("localizations")]		public AnyObject[] Localizations { get; private set; }				/// <summary>		/// Returns a dictionary with the keys from the bundle’s localized property list.		/// </summary>		[iOSVersion(2)]		[Export("localizedInfoDictionary")]		public Dictionary<NSObject, AnyObject> LocalizedInfoDictionary { get; private set; }				/// <summary>		/// These constants describe the CPU types that a bundle’s executable code may support.		/// </summary>		public int NSBundleExecutableArchitectureI386 { get; set; }	}}