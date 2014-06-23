using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMachPort_Class/index.html#//apple_ref/occ/cl/NSMachPort	/// <summary>	/// NSMachPort is a subclass of NSPort that can be used as an endpoint for distributed object connections (or raw messaging). NSMachPort is an object wrapper for a Mach port, the fundamental communication port in OS X. NSMachPort allows for local (on the same machine) communication only. A companion class, NSSocketPort, allows for both local and remote distributed object communication, but may be more expensive than NSMachPort for the local case.	/// </summary>	[iOSVersion(2)]	public class NSMachPort : NSPort	{		/// <summary>		/// Creates and returns a port object configured with the given Mach port.		/// </summary>		/// <param name="machPort">The Mach port for the new port. This parameter should originally be of type mach_port_t.</param>		/// <returns>An NSMachPort object that uses machPort to send or receive messages.</returns>		[iOSVersion(2)]		[Export("portWithMachPort")]		public static NSPort PortWithMachPort(Uint32 machPort) { return null; }				/// <summary>		/// Creates and returns a port object configured with the specified options and the given Mach port.		/// </summary>		/// <param name="machPort">The Mach port for the new port. This parameter should originally be of type mach_port_t.</param>		/// <param name="options">Specifies options for what to do with the underlying port rights when the NSMachPort object is invalidated or destroyed. For a list of constants, see Mach Port Rights.</param>		/// <returns>An NSMachPort object that uses machPort to send or receive messages.</returns>		[iOSVersion(2)]		[Export("portWithMachPort")]		public static NSPort PortWithMachPort(Uint32 machPort, int options) { return null; }				/// <summary>		/// Initializes a newly allocated NSMachPort object with a given Mach port.		/// </summary>		/// <param name="machPort">The Mach port for the new port. This parameter should originally be of type mach_port_t.</param>		/// <returns>Returns an initialized NSMachPort object that uses machPort to send or receive messages. The returned object might be different than the original receiver</returns>		[iOSVersion(2)]		public NSMachPort(Uint32 machPort) { }				/// <summary>		/// Initializes a newly allocated NSMachPort object with a given Mach port and the specified options.		/// </summary>		/// <param name="machPort">The Mach port for the new port. This parameter should originally be of type mach_port_t.</param>		/// <param name="options">Specifies options for what to do with the underlying port rights when the NSMachPort object is invalidated or destroyed. For a list of constants, see Mach Port Rights.</param>		/// <returns>Returns an initialized NSMachPort object that uses machPort to send or receive messages. The returned object might be different than the original receiver</returns>		[iOSVersion(2)]		public NSMachPort(Uint32 machPort, int options) { }				/// <summary>		/// Returns as an int the Mach port used by the receiver.		/// </summary>		/// <returns>The Mach port used by the receiver. Cast this value to a mach_port_t when using it with Mach system calls.</returns>		[iOSVersion(2)]		[Export("machPort")]		public Uint32 MachPort { get; private set; }				/// <summary>		/// Removes the receiver from the run loop mode mode of runLoop.		/// </summary>		/// <param name="runLoop">The run loop from which to remove the receiver.</param>		/// <param name="forMode">The run loop mode from which to remove the receiver.</param>		[iOSVersion(2)]		[Export("removeFromRunLoop")]		public void RemoveFromRunLoop(NSRunLoop runLoop, string forMode) { }				/// <summary>		/// Schedules the receiver into the run loop mode mode of runLoop.		/// </summary>		/// <param name="runLoop">The run loop to which to add the receiver.</param>		/// <param name="forMode">The run loop mode in which to add the receiver.</param>		[iOSVersion(2)]		[Export("scheduleInRunLoop")]		public void ScheduleInRunLoop(NSRunLoop runLoop, string forMode) { }				/// <summary>		/// Returns the receiver’s delegate.		/// </summary>		/// <returns>The receiver’s delegate.</returns>		[iOSVersion(4)]		[Export("delegate")]		public NSMachPortDelegate Delegate() { return null; }				/// <summary>		/// Sets the receiver’s delegate to a given object.		/// </summary>		/// <param name="anObject">The delegate for the receiver.</param>		[iOSVersion(4)]		[Export("setDelegate")]		public void SetDelegate(NSMachPortDelegate anObject) { }				/// <summary>		/// Used to remove access rights to a mach port when the NSMachPort object is invalidated or destroyed.		/// </summary>				/// <summary>		/// Do not remove any send or receive rights.		/// </summary>		[iOSVersion(2)]		public int { get } NSMachPortDeallocateNone { get; private set; }				/// <summary>		/// Deallocate a send right when the NSMachPort object is invalidated or destroyed.		/// </summary>		[iOSVersion(2)]		public int { get } NSMachPortDeallocateSendRight { get; private set; }				/// <summary>		/// Remove a receive right when the NSMachPort object is invalidated or destroyed.		/// </summary>		[iOSVersion(2)]		public int { get } NSMachPortDeallocateReceiveRight { get; private set; }	}}