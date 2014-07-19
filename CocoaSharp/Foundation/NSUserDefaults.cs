using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSUserDefaults class provides a programmatic interface for interacting with the defaults system. The defaults system allows an application to customize its behavior to match a user’s preferences. For example, you can allow users to determine what units of measurement your application displays or how often documents are automatically saved. Applications record such preferences by assigning values to a set of parameters in a user’s defaults database. The parameters are referred to as defaults since they’re commonly used to determine an application’s default state at startup or the way it acts by default.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSUserDefaults_Class/index.html#//apple_ref/occ/cl/NSUserDefaults"/>	[iOSVersion(2)]	public class NSUserDefaults : NSObject, AnyObject, NSObjectProtocol	{		/// <summary>		/// Returns the shared defaults object.		/// </summary>		[iOSVersion(2)]		[Export("standardUserDefaults")]		public static NSUserDefaults StandardUserDefaults() { return default(NSUserDefaults); }				/// <summary>		/// Synchronizes any changes made to the shared user defaults object and releases it from memory.		/// </summary>		[iOSVersion(2)]		[Export("resetStandardUserDefaults")]		public static void ResetStandardUserDefaults() {  }				/// <summary>		/// Returns an NSUserDefaults object initialized with the defaults for the current user account.		/// </summary>		[iOSVersion(2)]		public NSUserDefaults() { }				/// <summary>		/// Adds the contents of the specified dictionary to the registration domain.		/// </summary>		/// <param name="dictionary">The dictionary of keys and values you want to register.</param>		[iOSVersion(2)]		[Export("registerDefaults")]		public void RegisterDefaults(Dictionary<NSObject, AnyObject> dictionary) {  }				/// <summary>		/// Returns the array associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("arrayForKey")]		public AnyObject[] ArrayForKey(string defaultName) { return default(AnyObject[]); }				/// <summary>		/// Returns the Boolean value associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("boolForKey")]		public bool BoolForKey(string defaultName) { return default(bool); }				/// <summary>		/// Returns the data object associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("dataForKey")]		public NSData DataForKey(string defaultName) { return default(NSData); }				/// <summary>		/// Returns the dictionary object associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("dictionaryForKey")]		public Dictionary<NSObject, AnyObject> DictionaryForKey(string defaultName) { return default(Dictionary<NSObject, AnyObject>); }				/// <summary>		/// Returns the floating-point value associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("floatForKey")]		public Float FloatForKey(string defaultName) { return default(Float); }				/// <summary>		/// Returns the integer value associated with the specified key..		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("integerForKey")]		public int IntegerForKey(string defaultName) { return default(int); }				/// <summary>		/// Returns the object associated with the first occurrence of the specified default.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("objectForKey")]		public AnyObject ObjectForKey(string defaultName) { return default(AnyObject); }				/// <summary>		/// Returns the array of strings associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("stringArrayForKey")]		public AnyObject[] StringArrayForKey(string defaultName) { return default(AnyObject[]); }				/// <summary>		/// Returns the string associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("stringForKey")]		public string StringForKey(string defaultName) { return default(string); }				/// <summary>		/// Returns the double value associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(2)]		[Export("doubleForKey")]		public Double DoubleForKey(string defaultName) { return default(Double); }				/// <summary>		/// Returns the NSURL instance associated with the specified key.		/// </summary>		/// <param name="defaultName">A key in the current user's defaults database.</param>		[iOSVersion(4)]		public NSURL URLForKey(string defaultName) { return default(NSURL); }				/// <summary>		/// Sets the value of the specified default key to the specified Boolean value.		/// </summary>		/// <param name="value">The Boolean value to store in the defaults database.</param>		/// <param name="forKey">The key with which to associate with the value.</param>		[iOSVersion(2)]		[Export("setBool")]		public void SetBool(bool value, string forKey) {  }				/// <summary>		/// Sets the value of the specified default key to the specified floating-point value.		/// </summary>		/// <param name="value">The floating-point value to store in the defaults database.</param>		/// <param name="forKey">The key with which to associate with the value.</param>		[iOSVersion(2)]		[Export("setFloat")]		public void SetFloat(Float value, string forKey) {  }				/// <summary>		/// Sets the value of the specified default key to the specified integer value.		/// </summary>		/// <param name="value">The integer value to store in the defaults database.</param>		/// <param name="forKey">The key with which to associate with the value.</param>		[iOSVersion(2)]		[Export("setInteger")]		public void SetInteger(int value, string forKey) {  }				/// <summary>		/// Sets the value of the specified default key in the standard application domain.		/// </summary>		/// <param name="value">The object to store in the defaults database.</param>		/// <param name="forKey">The key with which to associate with the value.</param>		[iOSVersion(2)]		[Export("setObject")]		public void SetObject(AnyObject value, string forKey) {  }				/// <summary>		/// Sets the value of the specified default key to the double value.		/// </summary>		/// <param name="value">The double value.</param>		/// <param name="forKey">The key with which to associate with the value.</param>		[iOSVersion(2)]		[Export("setDouble")]		public void SetDouble(Double value, string forKey) {  }				/// <summary>		/// Sets the value of the specified default key to the specified URL.		/// </summary>		/// <param name="url">The NSURL to store in the defaults database.</param>		/// <param name="forKey">The key with which to associate with the value.</param>		[iOSVersion(4)]		[Export("setURL")]		public void SetURL(NSURL url, string forKey) {  }				/// <summary>		/// Removes the value of the specified default key in the standard application domain.		/// </summary>		/// <param name="defaultName">The key whose value you want to remove.</param>		[iOSVersion(2)]		[Export("removeObjectForKey")]		public void RemoveObjectForKey(string defaultName) {  }				/// <summary>		/// Writes any modifications to the persistent domains to disk and updates all unmodified persistent domains to what is on disk.		/// </summary>		[iOSVersion(2)]		[Export("synchronize")]		public bool Synchronize() { return default(bool); }				/// <summary>		/// Returns a dictionary containing the keys and values in the specified persistent domain.		/// </summary>		/// <param name="domainName">The domain whose keys and values you want.</param>		[iOSVersion(2)]		[Export("persistentDomainForName")]		public Dictionary<NSObject, AnyObject> PersistentDomainForName(string domainName) { return default(Dictionary<NSObject, AnyObject>); }				/// <summary>		/// Removes the contents of the specified persistent domain from the user’s defaults.		/// </summary>		/// <param name="domainName">The domain whose keys and values you want.</param>		[iOSVersion(2)]		[Export("removePersistentDomainForName")]		public void RemovePersistentDomainForName(string domainName) {  }				/// <summary>		/// Sets the dictionary for the specified persistent domain.		/// </summary>		/// <param name="domain">The dictionary of keys and values you want to assign to the domain.</param>		/// <param name="forName">The domain whose keys and values you want to set. This value should be equal to your application's bundle identifier.</param>		[iOSVersion(2)]		[Export("setPersistentDomain")]		public void SetPersistentDomain(Dictionary<NSObject, AnyObject> domain, string forName) {  }				/// <summary>		/// Returns a Boolean value indicating whether the specified key is managed by an administrator.		/// </summary>		/// <param name="key">The key whose status you want to check.</param>		[iOSVersion(2)]		[Export("objectIsForcedForKey")]		public bool ObjectIsForcedForKey(string key) { return default(bool); }				/// <summary>		/// Returns a Boolean value indicating whether the key in the specified domain is managed by an administrator.		/// </summary>		/// <param name="key">The key whose status you want to check.</param>		/// <param name="inDomain">The domain of the key.</param>		[iOSVersion(2)]		[Export("objectIsForcedForKey")]		public bool ObjectIsForcedForKey(string key, string inDomain) { return default(bool); }				/// <summary>		/// Returns a dictionary that contains a union of all key-value pairs in the domains in the search list.		/// </summary>		[iOSVersion(2)]		[Export("dictionaryRepresentation")]		public Dictionary<NSObject, AnyObject> DictionaryRepresentation() { return default(Dictionary<NSObject, AnyObject>); }				/// <summary>		/// Removes the specified volatile domain from the user’s defaults.		/// </summary>		/// <param name="domainName">The volatile domain you want to remove.</param>		[iOSVersion(2)]		[Export("removeVolatileDomainForName")]		public void RemoveVolatileDomainForName(string domainName) {  }				/// <summary>		/// Sets the dictionary for the specified volatile domain.		/// </summary>		/// <param name="domain">The dictionary of keys and values you want to assign to the domain.</param>		/// <param name="forName">The domain whose keys and values you want to set.</param>		[iOSVersion(2)]		[Export("setVolatileDomain")]		public void SetVolatileDomain(Dictionary<NSObject, AnyObject> domain, string forName) {  }				/// <summary>		/// Returns the dictionary for the specified volatile domain.		/// </summary>		/// <param name="domainName">The domain whose keys and values you want.</param>		[iOSVersion(2)]		[Export("volatileDomainForName")]		public Dictionary<NSObject, AnyObject> VolatileDomainForName(string domainName) { return default(Dictionary<NSObject, AnyObject>); }				/// <summary>		/// Inserts the specified domain name into the receiver’s search list.		/// </summary>		/// <param name="suiteName">The domain name to insert. This domain is inserted after the application domain.</param>		[iOSVersion(2)]		[Export("addSuiteNamed")]		public void AddSuiteNamed(string suiteName) {  }				/// <summary>		/// Removes the specified domain name from the receiver’s search list.		/// </summary>		/// <param name="suiteName">The domain name to remove.</param>		[iOSVersion(2)]		[Export("removeSuiteNamed")]		public void RemoveSuiteNamed(string suiteName) {  }				/// <summary>		/// Returns an array of the current volatile domain names.		/// </summary>		[iOSVersion(2)]		[Export("volatileDomainNames")]		public AnyObject[] VolatileDomainNames { get; private set; }	}}