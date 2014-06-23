using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSValue_Class/index.html#//apple_ref/occ/cl/NSValue	/// <summary>	/// An NSValue object is a simple container for a single C or Objective-C data item. It can hold any of the scalar types such as int, float, and char, as well as pointers, structures, and object ids. The purpose of this class is to allow items of such data types to be added to collections such as instances of NSArray and NSSet, which require their elements to be objects. NSValue objects are always immutable.	/// </summary>	[iOSVersion(2)]	public class NSValue : NSObject	{		/// <summary>		/// Initializes and returns an NSValue object that contains a given value, which is interpreted as being of a given Objective-C type.		/// </summary>		/// <param name="bytes">The value for the new NSValue object.</param>		/// <param name="objCType">The Objective-C type of value. type should be created with the Objective-C @encode() compiler directive; it should not be hard-coded as a C string.</param>		/// <returns>An initialized NSValue object that contains value, which is interpreted as being of the Objective-C type type. The returned object might be different than the original receiver.</returns>		[iOSVersion(2)]		public NSValue(CConstVoidPointer bytes, CString objCType) { }				/// <summary>		/// Creates and returns an NSValue object that contains a given value, which is interpreted as being of a given Objective-C type.		/// </summary>		/// <param name="value">The value for the new NSValue object.</param>		/// <param name="objCType">The Objective-C type of value. type should be created with the Objective-C @encode() compiler directive; it should not be hard-coded as a C string.</param>		/// <returns>A new NSValue object that contains value, which is interpreted as being of the Objective-C type type.</returns>		[iOSVersion(2)]		[Export("valueWithBytes")]		public static NSValue ValueWithBytes(CConstVoidPointer value, CString objCType) { return null; }				/// <summary>		/// Creates and returns an NSValue object that contains a given value which is interpreted as being of a given Objective-C type.		/// </summary>		/// <param name="value">The value for the new NSValue object.</param>		/// <param name="withObjCType">The Objective-C type of value. type should be created with the Objective-C @encode() compiler directive; it should not be hard-coded as a C string.</param>		/// <returns>A new NSValue object that contains value, which is interpreted as being of the Objective-C type type.</returns>		[iOSVersion(2)]		public NSValue Init(CConstVoidPointer value, CString withObjCType) { }				/// <summary>		/// Creates and returns an NSValue object that contains a given object.		/// </summary>		/// <param name="nonretainedObject">The value for the new object.</param>		/// <returns>A new NSValue object that contains anObject.</returns>		[iOSVersion(2)]		public NSValue Init(AnyObject nonretainedObject) { }				/// <summary>		/// Creates and returns an NSValue object that contains a given pointer.		/// </summary>		/// <param name="pointer">The value for the new object.</param>		/// <returns>A new NSValue object that contains aPointer.</returns>		[iOSVersion(2)]		public NSValue Init(CConstVoidPointer pointer) { }				/// <summary>		/// Creates and returns an NSValue object that contains a given NSRange structure.		/// </summary>		/// <param name="range">The value for the new object.</param>		/// <returns>A new NSValue object that contains the value of range.</returns>		[iOSVersion(2)]		public NSValue Init(NSRange range) { }				/// <summary>		/// Copies the receiver’s value into a given buffer.		/// </summary>		/// <param name="buffer">A buffer into which to copy the receiver's value. buffer must be large enough to hold the value.</param>		[iOSVersion(2)]		[Export("getValue")]		public void GetValue(CMutableVoidPointer buffer) { }				/// <summary>		/// Returns the receiver's value as an id.		/// </summary>		/// <returns>The receiver's value as an id. If the receiver was not created to hold a pointer-sized data item, the result is undefined.</returns>		[iOSVersion(2)]		[Export("nonretainedObjectValue")]		public AnyObject NonretainedObjectValue { get; private set; }				/// <summary>		/// Returns a C string containing the Objective-C type of the data contained in the receiver.		/// </summary>		/// <returns>A C string containing the Objective-C type of the data contained in the receiver, as encoded by the @encode() compiler directive.</returns>		[iOSVersion(2)]		[Export("objCType")]		public CString ObjCType { get; private set; }				/// <summary>		/// Returns the receiver's value as a pointer to void.		/// </summary>		/// <returns>The receiver's value as a pointer to void. If the receiver was not created to hold a pointer-sized data item, the result is undefined.</returns>		[iOSVersion(2)]		[Export("pointerValue")]		public COpaquePointer PointerValue() { return null; }				/// <summary>		/// Returns an NSRange structure representation of the receiver.		/// </summary>		/// <returns>An NSRange structure representation of the receiver.</returns>		[iOSVersion(2)]		[Export("rangeValue")]		public NSRange RangeValue { get; private set; }				/// <summary>		/// Returns a Boolean value that indicates whether the receiver and another value are equal.		/// </summary>		/// <param name="aValue">The value with which to compare the receiver.</param>		/// <returns>true if the receiver and aValue are equal, otherwise false. For NSValue objects, the class, type, and contents are compared to determine equality.</returns>		[iOSVersion(2)]		[Export("isEqualToValue")]		public bool IsEqualToValue(NSValue aValue) { return false; }	}}