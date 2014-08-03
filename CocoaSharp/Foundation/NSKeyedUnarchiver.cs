using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSKeyedUnarchiver, a concrete subclass of NSCoder, defines methods for decoding a set of named objects (and scalar values) from a keyed archive. Such archives are produced by instances of the NSKeyedArchiver class.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSKeyedUnarchiver_Class/index.html#//apple_ref/occ/cl/NSKeyedUnarchiver"/>    [iOSVersion(2)]    public class NSKeyedUnarchiver : NSCoder//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Initializes the receiver for decoding an archive previously encoded by NSKeyedArchiver.        /// </summary>        /// <param name="forReadingWithData">An archive previously encoded by NSKeyedArchiver.</param>        [iOSVersion(2)]        public NSKeyedUnarchiver(NSData forReadingWithData) { }                /// <summary>        /// Decodes and returns the object graph previously encoded by NSKeyedArchiver and stored in a given NSData object.        /// </summary>        /// <param name="data">An object graph previously encoded by NSKeyedArchiver.</param>        [iOSVersion(2)]        [Export("unarchiveObjectWithData")]        public static AnyObject UnarchiveObjectWithData(NSData data) { return default(AnyObject); }                /// <summary>        /// Decodes and returns the object graph previously encoded by NSKeyedArchiver written to the file at a given path.        /// </summary>        /// <param name="path">A path to a file that contains an object graph previously encoded by NSKeyedArchiver.</param>        [iOSVersion(2)]        [Export("unarchiveObjectWithFile")]        public static AnyObject UnarchiveObjectWithFile(string path) { return default(AnyObject); }                /// <summary>        /// Indicates whether the receiver requires all unarchived classes to conform to NSSecureCoding.        /// </summary>        /// <param name="flag">true if the receiver requires NSSecureCoding; false if not.</param>        [iOSVersion(6)]        [Export("setRequiresSecureCoding")]        public void SetRequiresSecureCoding(bool flag) {  }                /// <summary>        /// Returns a Boolean value that indicates whether the archive contains a value for a given key within the current decoding scope.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("containsValueForKey")]        public bool ContainsValueForKey(string key) { return default(bool); }                /// <summary>        /// Decodes a Boolean value associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeBoolForKey")]        public bool DecodeBoolForKey(string key) { return default(bool); }                /// <summary>        /// Decodes a stream of bytes associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        /// <param name="returnedLength">Upon return, contains the number of bytes returned.</param>        [iOSVersion(2)]        [Export("decodeBytesForKey")]        public ConstUnsafePointer<UInt8> DecodeBytesForKey(string key, UnsafePointer<int> returnedLength) { return default(ConstUnsafePointer<UInt8>); }                /// <summary>        /// Decodes a double-precision floating-point value associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeDoubleForKey")]        public Double DecodeDoubleForKey(string key) { return default(Double); }                /// <summary>        /// Decodes a single-precision floating-point value associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeFloatForKey")]        public float DecodeFloatForKey(string key) { return default(float); }                /// <summary>        /// Decodes an integer value associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeIntForKey")]        public int DecodeIntForKey(string key) { return default(int); }                /// <summary>        /// Decodes a 32-bit integer value associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeInt32ForKey")]        public int DecodeInt32ForKey(string key) { return default(int); }                /// <summary>        /// Decodes a 64-bit integer value associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeInt64ForKey")]        public Int64 DecodeInt64ForKey(string key) { return default(Int64); }                /// <summary>        /// Decodes and returns an object associated with a given key.        /// </summary>        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>        [iOSVersion(2)]        [Export("decodeObjectForKey")]        public AnyObject DecodeObjectForKey(string key) { return default(AnyObject); }                /// <summary>        /// Tells the receiver that you are finished decoding objects.        /// </summary>        [iOSVersion(2)]        [Export("finishDecoding")]        public void FinishDecoding() {  }                /// <summary>        /// Adds a class translation mapping to NSKeyedUnarchiver whereby objects encoded with a given class name are decoded as instances of a given class instead.        /// </summary>        /// <param name="cls">The class with which to replace instances of the class named codedName.</param>        /// <param name="forClassName">The ostensible name of a class in an archive.</param>        [iOSVersion(2)]        [Export("setClass")]        public static void SetClass(AnyClass cls, string forClassName) {  }                /// <summary>        /// Returns the class from which NSKeyedUnarchiver instantiates an encoded object with a given class name.        /// </summary>        /// <param name="codedName">The ostensible name of a class in an archive.</param>        [iOSVersion(2)]        [Export("classForClassName")]        public static AnyClass ClassForClassName(string codedName) { return default(AnyClass); }                /// <summary>        /// Adds a class translation mapping to the receiver whereby objects encoded with a given class name are decoded as instances of a given class instead.        /// </summary>        /// <param name="cls">The class with which to replace instances of the class named codedName.</param>        /// <param name="forClassName">The ostensible name of a class in an archive.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("setClass")]        [IgnoreParameters("NAME_YOUR_PARAMS")]        public void SetClass(AnyClass cls, string forClassName, bool NAME_YOUR_PARAMS = false) {  }                /// <summary>        /// Returns the class from which the receiver instantiates an encoded object with a given class name.        /// </summary>        /// <param name="codedName">The name of a class.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("classForClassName")]        [IgnoreParameters("NAME_YOUR_PARAMS")]        public AnyClass ClassForClassName(string codedName, bool NAME_YOUR_PARAMS = false) { return default(AnyClass); }                /// <summary>        /// Returns the receiver’s delegate.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public NSKeyedUnarchiverDelegate Delegate { get; set; }    }}