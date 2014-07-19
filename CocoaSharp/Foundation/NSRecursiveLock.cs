using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSRecursiveLock defines a lock that may be acquired multiple times by the same thread without causing a deadlock, a situation where a thread is permanently blocked waiting for itself to relinquish a lock. While the locking thread has one or more locks, all other threads are prevented from accessing the code protected by the lock.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSRecursiveLock_Class/index.html#//apple_ref/occ/cl/NSRecursiveLock"/>	[iOSVersion(2)]	public class NSRecursiveLock : NSObject, AnyObject, NSLocking, NSObjectProtocol	{		/// <summary>		/// Attempts to acquire a lock before a given date.		/// </summary>		/// <param name="limit">The time before which the lock should be acquired.</param>		[iOSVersion(2)]		[Export("lockBeforeDate")]		public bool LockBeforeDate(NSDate limit) { return default(bool); }				/// <summary>		/// Attempts to acquire a lock, and immediately returns a Boolean value that indicates whether the attempt was successful.		/// </summary>		[iOSVersion(2)]		[Export("tryLock")]		public bool TryLock() { return default(bool); }				/// <summary>		/// Assigns a name to the receiver		/// </summary>		[iOSVersion(2)]		[Export("name")]		public string Name { get; set; }	}}