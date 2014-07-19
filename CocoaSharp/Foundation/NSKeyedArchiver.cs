using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSKeyedArchiver, a concrete subclass of NSCoder, provides a way to encode objects (and scalar values) into an architecture-independent format that can be stored in a file. When you archive a set of objects, the class information and instance variables for each object are written to the archive. NSKeyedArchiver’s companion class, NSKeyedUnarchiver, decodes the data in an archive and creates a set of objects equivalent to the original set.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSKeyedArchiver_Class/index.html#//apple_ref/occ/cl/NSKeyedArchiver"/>	[iOSVersion(2)]	public class NSKeyedArchiver : NSCoder, AnyObject, NSObjectProtocol	{		/// <summary>		/// Returns the receiver, initialized for encoding an archive into a given a mutable-data object.		/// </summary>		/// <param name="forWritingWithMutableData">The mutable-data object into which the archive is written.</param>		[iOSVersion(2)]		public NSKeyedArchiver(NSMutableData forWritingWithMutableData) { }				/// <summary>		/// Returns an NSData object containing the encoded form of the object graph whose root object is given.		/// </summary>		/// <param name="rootObject">The root of the object graph to archive.</param>		[iOSVersion(2)]		[Export("archivedDataWithRootObject")]		public static NSData ArchivedDataWithRootObject(AnyObject rootObject) { return default(NSData); }				/// <summary>		/// Archives an object graph rooted at a given object by encoding it into a data object then atomically writes the resulting data object to a file at a given path, and returns a Boolean value that indicates whether the operation was successful.		/// </summary>		/// <param name="rootObject">The root of the object graph to archive.</param>		/// <param name="toFile">The path of the file in which to write the archive.</param>		[iOSVersion(2)]		[Export("archiveRootObject")]		public static bool ArchiveRootObject(AnyObject rootObject, string toFile) { return default(bool); }				/// <summary>		/// Instructs the receiver to construct the final data stream.		/// </summary>		[iOSVersion(2)]		[Export("finishEncoding")]		public void FinishEncoding() {  }				/// <summary>		/// Indicates whether the receiver requires all archived classes to conform to NSSecureCoding.		/// </summary>		/// <param name="flag">true if the receiver requires NSSecureCoding; false if not.</param>		[iOSVersion(6)]		[Export("setRequiresSecureCoding")]		public void SetRequiresSecureCoding(bool flag) {  }				/// <summary>		/// Encodes a given Boolean value and associates it with a given key.		/// </summary>		/// <param name="boolv">The value to encode.</param>		/// <param name="forKey">The key with which to associate boolv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeBool")]		public void EncodeBool(bool boolv, string forKey) {  }				/// <summary>		/// Encodes a given number of bytes from a given C array of bytes and associates them with the a given key.		/// </summary>		/// <param name="bytesp">A C array of bytes to encode.</param>		/// <param name="length">The number of bytes from bytesp to encode.</param>		/// <param name="forKey">The key with which to associate the encoded value. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeBytes")]		public void EncodeBytes(ConstUnsafePointer<UInt8> bytesp, int length, string forKey) {  }				/// <summary>		/// Encodes a reference to a given object and associates it with a given key only if it has been unconditionally encoded elsewhere in the archive with encodeObject:forKey:.		/// </summary>		/// <param name="objv">The object to encode.</param>		/// <param name="forKey">The key with which to associate the encoded value. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeConditionalObject")]		public void EncodeConditionalObject(AnyObject objv, string forKey) {  }				/// <summary>		/// Encodes a given double value and associates it with a given key.		/// </summary>		/// <param name="realv">The value to encode.</param>		/// <param name="forKey">The key with which to associate realv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeDouble")]		public void EncodeDouble(Double realv, string forKey) {  }				/// <summary>		/// Encodes a given float value and associates it with a given key.		/// </summary>		/// <param name="realv">The value to encode.</param>		/// <param name="forKey">The key with which to associate realv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeFloat")]		public void EncodeFloat(Float realv, string forKey) {  }				/// <summary>		/// Encodes a given int value and associates it with a given key.		/// </summary>		/// <param name="intv">The value to encode.</param>		/// <param name="forKey">The key with which to associate intv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeInt")]		public void EncodeInt(int intv, string forKey) {  }				/// <summary>		/// Encodes a given 32-bit integer value and associates it with a given key.		/// </summary>		/// <param name="intv">The value to encode.</param>		/// <param name="forKey">The key with which to associate intv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeInt32")]		public void EncodeInt32(int intv, string forKey) {  }				/// <summary>		/// Encodes a given 64-bit integer value and associates it with a given key.		/// </summary>		/// <param name="intv">The value to encode.</param>		/// <param name="forKey">The key with which to associate intv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeInt64")]		public void EncodeInt64(Int64 intv, string forKey) {  }				/// <summary>		/// Encodes a given object and associates it with a given key.		/// </summary>		/// <param name="objv">The value to encode. This value may be nil.</param>		/// <param name="forKey">The key with which to associate objv. This value must not be nil.</param>		[iOSVersion(2)]		[Export("encodeObject")]		public void EncodeObject(AnyObject objv, string forKey) {  }				/// <summary>		/// Adds a class translation mapping to NSKeyedArchiver whereby instances of of a given class are encoded with a given class name instead of their real class names.		/// </summary>		/// <param name="codedName">The name of the class that NSKeyedArchiver uses in place of cls.</param>		/// <param name="forClass">The class for which to set up a translation mapping.</param>		[iOSVersion(2)]		[Export("setClassName")]		public static void SetClassName(string codedName, AnyClass forClass) {  }				/// <summary>		/// Returns the class name with which NSKeyedArchiver encodes instances of a given class.		/// </summary>		/// <param name="cls">The class for which to determine the translation mapping.</param>		[iOSVersion(2)]		[Export("classNameForClass")]		public static string ClassNameForClass(AnyClass cls) { return default(string); }				/// <summary>		/// Adds a class translation mapping to the receiver whereby instances of of a given class are encoded with a given class name instead of their real class names.		/// </summary>		/// <param name="codedName">The name of the class that the receiver uses uses in place of cls.</param>		/// <param name="forClass">The class for which to set up a translation mapping.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[Export("setClassName")]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public void SetClassName(string codedName, AnyClass forClass, bool NAME_YOUR_PARAMS = false) {  }				/// <summary>		/// Returns the class name with which the receiver encodes instances of a given class.		/// </summary>		/// <param name="cls">The class for which to determine the translation mapping.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[Export("classNameForClass")]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public string ClassNameForClass(AnyClass cls, bool NAME_YOUR_PARAMS = false) { return default(string); }				/// <summary>		/// Returns the format in which the receiver encodes its data.		/// </summary>		[iOSVersion(2)]		[Export("outputFormat")]		public NSPropertyListFormat OutputFormat { get; set; }				/// <summary>		/// Returns the receiver’s delegate.		/// </summary>		[iOSVersion(2)]		[Export("delegate")]		public NSKeyedArchiverDelegate Delegate { get; set; }	}}