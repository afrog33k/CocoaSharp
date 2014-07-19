using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// An instance of NSPointerFunctions defines callout functions appropriate for managing a pointer reference held somewhere else.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPointerFunctions_Class/index.html#//apple_ref/occ/cl/NSPointerFunctions"/>	[iOSVersion(6)]	public class NSPointerFunctions : NSObject, AnyObject, NSCopying, NSObjectProtocol	{		/// <summary>		/// Returns an NSPointerFunctions object initialized with the given options.		/// </summary>		/// <param name="options">The options for the new NSPointerFunctions object.</param>		[iOSVersion(6)]		public NSPointerFunctions(NSPointerFunctionsOptions options) { }				/// <summary>		/// Returns a new NSPointerFunctions object initialized with the given options.		/// </summary>		/// <param name="options">The options for the new NSPointerFunctions object.</param>		[iOSVersion(6)]		[Export("pointerFunctionsWithOptions")]		public static NSPointerFunctions PointerFunctionsWithOptions(NSPointerFunctionsOptions options) { return default(NSPointerFunctions); }				/// <summary>		/// The hash function.		/// </summary>		[iOSVersion(6)]		[Export("hashFunction")]		public CFunctionPointer<Func<ConstUnsafePointer<Action>, CFunctionPointer<Func<ConstUnsafePointer<, WEIRD>>, int>> HashFunction { get; set; }				/// <summary>		/// The function used to compare pointers.		/// </summary>		[iOSVersion(6)]		[Export("isEqualFunction")]		public CFunctionPointer<Func<ConstUnsafePointer<Action>, ConstUnsafePointer<Action>, CFunctionPointer<Func<ConstUnsafePointer<, WEIRD>>, bool>> IsEqualFunction { get; set; }				/// <summary>		/// The function used to determine the size of pointers.		/// </summary>		[iOSVersion(6)]		[Export("sizeFunction")]		public CFunctionPointer<Func<ConstUnsafePointer<Action>, int>> SizeFunction { get; set; }				/// <summary>		/// The function used to describe elements.		/// </summary>		[iOSVersion(6)]		[Export("descriptionFunction")]		public CFunctionPointer<Func<ConstUnsafePointer<Action>, string>> DescriptionFunction { get; set; }				/// <summary>		/// The function used to acquire memory.		/// </summary>		[iOSVersion(6)]		[Export("acquireFunction")]		public CFunctionPointer<Func<ConstUnsafePointer<Action>, CFunctionPointer<Func<ConstUnsafePointer<, WEIRD>>, UnsafePointer<Action>>> AcquireFunction { get; set; }				/// <summary>		/// The function used to relinquish memory.		/// </summary>		[iOSVersion(6)]		[Export("relinquishFunction")]		public CFunctionPointer<Action<ConstUnsafePointer<Action>, CFunctionPointer<Func<ConstUnsafePointer<, WEIRD>>>> RelinquishFunction { get; set; }				/// <summary>		/// Specifies whether, in a garbage collected environment, pointers should be assigned using a strong write barrier.		/// </summary>		[iOSVersion(6)]		[Export("usesStrongWriteBarrier")]		public bool UsesStrongWriteBarrier { get; set; }				/// <summary>		/// Specifies whether, in a garbage collected environment, pointers should use weak read and write barriers.		/// </summary>		[iOSVersion(6)]		[Export("usesWeakReadAndWriteBarriers")]		public bool UsesWeakReadAndWriteBarriers { get; set; }				/// <summary>		/// Specify memory and personality options for an NSPointerFunctions object.		/// </summary>		public int NSPointerFunctionsStrongMemory { get; set; }	}	/// <summary>	/// Defines the memory and personality options for an NSPointerFunctions object.	/// </summary>	[iOSVersion(6)]	public struct NSPointerFunctionsOptions	{		static public implicit operator NSPointerFunctionsOptions(int value)		{			return default(NSPointerFunctionsOptions);		}		static public implicit operator int(NSPointerFunctionsOptions value)		{			return default(int);		}	}	