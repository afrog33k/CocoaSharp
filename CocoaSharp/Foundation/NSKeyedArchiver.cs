﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectiveC;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSKeyedArchiver_Class/index.html#//apple_ref/occ/cl/NSKeyedArchiver
    /// <summary>
    /// NSKeyedArchiver, a concrete subclass of NSCoder, provides a way to encode objects (and scalar values) into an architecture-independent format that can be stored in a file. When you archive a set of objects, the class information and instance variables for each object are written to the archive. NSKeyedArchiver’s companion class, NSKeyedUnarchiver, decodes the data in an archive and creates a set of objects equivalent to the original set.
    /// </summary>
    public class NSKeyedArchiver : NSCoder
    {
        /// <summary>
        /// Returns the receiver, initialized for encoding an archive into a given a mutable-data object.
        /// </summary>
        /// <param name="data">The mutable-data object into which the archive is written.</param>
        /// <returns>The receiver, initialized for encoding an archive into data.</returns>
        [Export("init")]
        public void Init(NSMutableData data) { }

        /// <summary>
        /// Returns an NSData object containing the encoded form of the object graph whose root object is given.
        /// </summary>
        /// <param name="rootObject">The root of the object graph to archive.</param>
        /// <returns>An NSData object containing the encoded form of the object graph whose root object is rootObject. The format of the archive is NSPropertyListBinaryFormat_v1_0.</returns>
        [Export("archivedDataWithRootObject")]
        public static NSData ArchivedDataWithRootObject(AnyObject rootObject) { return null; }

        /// <summary>
        /// Archives an object graph rooted at a given object by encoding it into a data object then atomically writes the resulting data object to a file at a given path, and returns a Boolean value that indicates whether the operation was successful.
        /// </summary>
        /// <param name="rootObject">The root of the object graph to archive.</param>
        /// <param name="path">The path of the file in which to write the archive.</param>
        /// <returns>true if the operation was successful, otherwise false.</returns>
        [Export("archiveRootObject")]
        public static bool ArchiveRootObject(AnyObject rootObject, string path) { return false; }

        /// <summary>
        /// Instructs the receiver to construct the final data stream.
        /// </summary>
        [Export("finishEncoding")]
        public void FinishEncoding() { }

        /// <summary>
        /// Returns the format in which the receiver encodes its data.
        /// </summary>
        /// <returns>The format in which the receiver encodes its data. The available formats are NSPropertyListXMLFormat_v1_0 and NSPropertyListBinaryFormat_v1_0.</returns>
        [Export("outputFormat")]
        public static NSPropertyListFormat OutputFormat { get; private set; }

        /// <summary>
        /// Sets the format in which the receiver encodes its data.
        /// </summary>
        /// <param name="format">The format in which the receiver encodes its data. format can be NSPropertyListXMLFormat_v1_0 or NSPropertyListBinaryFormat_v1_0.</param>
        [Export("outputFormat")]
        public static NSPropertyListFormat OutputFormat { get; private set; }

        /// <summary>
        /// Indicates whether the receiver requires all archived classes to conform to NSSecureCoding.
        /// </summary>
        /// <param name="flag">true if the receiver requires NSSecureCoding; false if not.</param>
        [Export("setRequiresSecureCoding")]
        public void SetRequiresSecureCoding(bool flag) { }

        /// <summary>
        /// Encodes a given Boolean value and associates it with a given key.
        /// </summary>
        /// <param name="boolv">The value to encode.</param>
        /// <param name="key">The key with which to associate boolv. This value must not be nil.</param>
        [Export("encodeBool")]
        public void EncodeBool(bool boolv, string key) { }

        /// <summary>
        /// Encodes a given number of bytes from a given C array of bytes and associates them with the a given key.
        /// </summary>
        /// <param name="bytesp">A C array of bytes to encode.</param>
        /// <param name="lenv">The number of bytes from bytesp to encode.</param>
        /// <param name="key">The key with which to associate the encoded value. This value must not be nil.</param>
        [Export("encodeBytes")]
        public void EncodeBytes(CConstPointer<uint> bytesp, int lenv, string key) { }

        /// <summary>
        /// Encodes a reference to a given object and associates it with a given key only if it has been unconditionally encoded elsewhere in the archive with encodeObject:forKey:.
        /// </summary>
        /// <param name="objv">The object to encode.</param>
        /// <param name="key">The key with which to associate the encoded value. This value must not be nil.</param>
        [Export("encodeConditionalObject")]
        public void EncodeConditionalObject(AnyObject objv, string key) { }

        /// <summary>
        /// Encodes a given double value and associates it with a given key.
        /// </summary>
        /// <param name="realv">The value to encode.</param>
        /// <param name="key">The key with which to associate realv. This value must not be nil.</param>
        [Export("encodeDouble")]
        public void EncodeDouble(CDouble realv, string key) { }

        /// <summary>
        /// Encodes a given float value and associates it with a given key.
        /// </summary>
        /// <param name="realv">The value to encode.</param>
        /// <param name="key">The key with which to associate realv. This value must not be nil.</param>
        [Export("encodeFloat")]
        public void EncodeFloat(CFloat realv, string key) { }

        /// <summary>
        /// Encodes a given int value and associates it with a given key.
        /// </summary>
        /// <param name="intv">The value to encode.</param>
        /// <param name="key">The key with which to associate intv. This value must not be nil.</param>
        [Export("encodeInt")]
        public void EncodeInt(CInt intv, string key) { }

        /// <summary>
        /// Encodes a given 32-bit integer value and associates it with a given key.
        /// </summary>
        /// <param name="intv">The value to encode.</param>
        /// <param name="key">The key with which to associate intv. This value must not be nil.</param>
        [Export("encodeInt32")]
        public void EncodeInt32(Int32 intv, string key) { }

        /// <summary>
        /// Encodes a given 64-bit integer value and associates it with a given key.
        /// </summary>
        /// <param name="intv">The value to encode.</param>
        /// <param name="key">The key with which to associate intv. This value must not be nil.</param>
        [Export("encodeInt64")]
        public void EncodeInt64(Int64 intv, string key) { }

        /// <summary>
        /// Encodes a given object and associates it with a given key.
        /// </summary>
        /// <param name="objv">The value to encode. This value may be nil.</param>
        /// <param name="key">The key with which to associate objv. This value must not be nil.</param>
        [Export("encodeObject")]
        public void EncodeObject(AnyObject objv, string key) { }

        /// <summary>
        /// Returns the receiver’s delegate.
        /// </summary>
        /// <returns>The receiver's delegate.</returns>
        [Export("delegate")]
        public static NSKeyedArchiverDelegate Delegate { get; private set; }

        /// <summary>
        /// Sets the delegate for the receiver.
        /// </summary>
        /// <param name="delegate">The delegate for the receiver.</param>
        [Export("delegate")]
        public static NSKeyedArchiverDelegate Delegate { get; private set; }

        /// <summary>
        /// Adds a class translation mapping to NSKeyedArchiver whereby instances of of a given class are encoded with a given class name instead of their real class names.
        /// </summary>
        /// <param name="codedName">The name of the class that NSKeyedArchiver uses in place of cls.</param>
        /// <param name="cls">The class for which to set up a translation mapping.</param>
        [Export("setClassName")]
        public static void SetClassName(string codedName, AnyClass cls) { }

        /// <summary>
        /// Returns the class name with which NSKeyedArchiver encodes instances of a given class.
        /// </summary>
        /// <param name="cls">The class for which to determine the translation mapping.</param>
        /// <returns>The class name with which NSKeyedArchiver encodes instances of cls. Returns nil if NSKeyedArchiver does not have a translation mapping for cls.</returns>
        [Export("classNameForClass")]
        public static string ClassNameForClass(AnyClass cls) { return ""; }

        /// <summary>
        /// Adds a class translation mapping to the receiver whereby instances of of a given class are encoded with a given class name instead of their real class names.
        /// </summary>
        /// <param name="codedName">The name of the class that the receiver uses uses in place of cls.</param>
        /// <param name="cls">The class for which to set up a translation mapping.</param>
        [Export("setClassName")]
        public void SetClassName(string codedName, AnyClass cls) { }

        /// <summary>
        /// Returns the class name with which the receiver encodes instances of a given class.
        /// </summary>
        /// <param name="cls">The class for which to determine the translation mapping.</param>
        /// <returns>The class name with which the receiver encodes instances of cls. Returns nil if the receiver does not have a translation mapping for cls. The class’s separate translation map is not searched.</returns>
        [Export("classNameForClass")]
        public string ClassNameForClass(AnyClass cls) { return ""; }

        /// <summary>
        /// Names of exceptions that are raised by NSKeyedArchiver if there is a problem creating an archive.
        /// </summary>
        [Export("NSInvalidArchiveOperationException")]
        public static string NSInvalidArchiveOperationException { get; private set; }

        /// <summary>
        /// Keys that NSKeyedArchiver uses in the hierarchy of encoded objects.
        /// </summary>
        [Export("NSKeyedArchiveRootObjectKey")]
        public static string NSKeyedArchiveRootObjectKey { get; private set; }
    }
}