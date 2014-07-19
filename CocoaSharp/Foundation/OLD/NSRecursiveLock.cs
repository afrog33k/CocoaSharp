using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSRecursiveLock_Class/index.html#//apple_ref/occ/cl/NSRecursiveLock	/// <summary>	/// NSRecursiveLock defines a lock that may be acquired multiple times by the same thread without causing a deadlock, a situation where a thread is permanently blocked waiting for itself to relinquish a lock. While the locking thread has one or more locks, all other threads are prevented from accessing the code protected by the lock.	/// </summary>	[iOSVersion(2)]	public class NSRecursiveLock : NSObject	{		/// <summary>		/// Attempts to acquire a lock before a given date.		/// </summary>		/// <param name="limit">The time before which the lock should be acquired.</param>		/// <returns>true if the lock is acquired before limit, otherwise false.</returns>		[iOSVersion(2)]		[Export("lockBeforeDate")]		public bool LockBeforeDate(NSDate limit) { return false; }				/// <summary>		/// Attempts to acquire a lock, and immediately returns a Boolean value that indicates whether the attempt was successful.		/// </summary>		/// <returns>true if successful, otherwise false.</returns>		[iOSVersion(2)]		[Export("tryLock")]		public bool TryLock() { return false; }				/// <summary>		/// Assigns a name to the receiver		/// </summary>		/// <param name="newName">The new name for the receiver. This method makes a copy of the specified string.</param>		[iOSVersion(2)]		[Export("name")]		public string Name { get; set; }	}}