using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSProcessInfo_Class/index.html#//apple_ref/occ/cl/NSProcessInfo	/// <summary>	/// The NSProcessInfo class provides methods to access information about the current process. Each process has a single, shared NSProcessInfo object, known as process information agent.	/// </summary>	[iOSVersion(2)]	public class NSProcessInfo : NSObject	{		/// <summary>		/// Returns the process information agent for the process.		/// </summary>		/// <returns>Shared process information agent for the process.</returns>		[iOSVersion(2)]		[Export("processInfo")]		public static NSProcessInfo ProcessInfo() { return null; }				/// <summary>		/// Returns the command-line arguments for the process.		/// </summary>		/// <returns>Array of strings with the process’s command-line arguments.</returns>		[iOSVersion(2)]		[Export("arguments")]		public AnyObject[] Arguments { get; private set; }				/// <summary>		/// Returns the variable names and their values in the environment from which the process was launched.		/// </summary>		/// <returns>Dictionary of environment-variable names (keys) and their values.</returns>		[iOSVersion(2)]		[Export("environment")]		public NSDictionary Environment { get; private set; }				/// <summary>		/// Returns the identifier of the process.		/// </summary>		/// <returns>Process ID of the process.</returns>		[iOSVersion(2)]		[Export("processIdentifier")]		public Cint ProcessIdentifier { get; private set; }				/// <summary>		/// Returns a global unique identifier for the process.		/// </summary>		/// <returns>Global ID for the process. The ID includes the host name, process ID, and a time stamp, which ensures that the ID is unique for the network.</returns>		[iOSVersion(2)]		[Export("globallyUniqueString")]		public string GloballyUniqueString { get; private set; }				/// <summary>		/// Returns the name of the process.		/// </summary>		/// <returns>Name of the process.</returns>		[iOSVersion(2)]		[Export("processName")]		public string ProcessName { get; set; }				/// <summary>		/// Returns the name of the host computer.		/// </summary>		/// <returns>Host name of the computer.</returns>		[iOSVersion(2)]		[Export("hostName")]		public string HostName { get; private set; }				/// <summary>		/// Returns a constant to indicate the operating system on which the process is executing.		/// </summary>		/// <returns>Operating system identifier. See Constants for a list of possible values. In OS X, it’s NSMACHOperatingSystem.</returns>		[iOSVersion(2)]		[Export("operatingSystem")]		public int OperatingSystem() { return 0; }				/// <summary>		/// Returns a string containing the name of the operating system on which the process is executing.		/// </summary>		/// <returns>Operating system name. In OS X, it’s @&quot;NSMACHOperatingSystem&quot;</returns>		[iOSVersion(2)]		[Export("operatingSystemName")]		public string OperatingSystemName() { return ""; }				/// <summary>		/// Returns a string containing the version of the operating system on which the process is executing.		/// </summary>		/// <returns>Operating system version. This string is human readable, localized, and is appropriate for displaying to the user. This string is not appropriate for parsing.</returns>		[iOSVersion(2)]		[Export("operatingSystemVersionString")]		public string OperatingSystemVersionString { get; private set; }				/// <summary>		/// Provides the amount of physical memory on the computer.		/// </summary>		/// <returns>Amount of physical memory in bytes.</returns>		[iOSVersion(2)]		[Export("physicalMemory")]		public CUnsignedLongLong PhysicalMemory { get; private set; }				/// <summary>		/// Provides the number of processing cores available on the computer.		/// </summary>		/// <returns>Number of processing cores.</returns>		[iOSVersion(2)]		[Export("processorCount")]		public int ProcessorCount { get; private set; }				/// <summary>		/// Provides the number of active processing cores available on the computer.		/// </summary>		/// <returns>Number of active processing cores.</returns>		[iOSVersion(2)]		[Export("activeProcessorCount")]		public int ActiveProcessorCount { get; private set; }				/// <summary>		/// Returns how long it has been since the computer has been restarted.		/// </summary>		/// <returns>An NSTimeinterval indicating how long since the computer has been restarted.</returns>		[iOSVersion(4)]		[Export("systemUptime")]		public NSTimeinterval SystemUptime { get; private set; }				/// <summary>		/// Begin an activity using the given options and reason.		/// </summary>		/// <param name="options">Options for the activity. See Activity Options for possible values.</param>		/// <param name="reason">A string used in debugging to indicate the reason the activity began.</param>		/// <returns>An object token representing the activity.</returns>		[iOSVersion(7)]		[Export("beginActivityWithOptions")]		public NSObjectProtocol BeginActivityWithOptions(NSActivityOptions options, string reason) { return null; }				/// <summary>		/// Ends the given activity.		/// </summary>		/// <param name="activity">An activity object returned by beginActivityWithOptions:reason:.</param>		[iOSVersion(7)]		[Export("endActivity")]		public void EndActivity(NSObjectProtocol activity) { }				/// <summary>		/// Synchronously perform an activity defined by a given block using the given options.		/// </summary>		/// <param name="options">Options for the activity. See Activity Options for possible values.</param>		/// <param name="reason">A string used in debugging to indicate the reason the activity began.</param>		/// <param name="usingBlock">A block containing the work to be performed by the activity.</param>		[iOSVersion(7)]		[Export("performActivityWithOptions")]		public void PerformActivityWithOptions(NSActivityOptions options, string reason, Action usingBlock) { }				/// <summary>		/// Option flags used with beginActivityWithOptions:reason: and performActivityWithOptions:reason:usingBlock:.		/// </summary>		public enum NSActivityOptions		{			/// <summary>			/// Flag to require the screen to stay powered on.			/// </summary>			[iOSVersion(7)]			IdleDisplaySleepDisabled,						/// <summary>			/// Flag to prevent idle sleep.			/// </summary>			[iOSVersion(7)]			IdleSystemSleepDisabled,						/// <summary>			/// Flag to prevent sudden termination.			/// </summary>			[iOSVersion(7)]			SuddenTerminationDisabled,						/// <summary>			/// Flag to prevent automatic termination.			/// </summary>			[iOSVersion(7)]			AutomaticTerminationDisabled,						/// <summary>			/// Flag to indicate the app is performing a user-requested action.			/// </summary>			[iOSVersion(7)]			UserInitiated,						/// <summary>			/// Flag to indicate the app is performing a user-requested action, but that the system can sleep on idle.			/// </summary>			[iOSVersion(7)]			UserInitiatedAllowingIdleSystemSleep,						/// <summary>			/// Flag to indicate the app has initiated some kind of work, but not as the direct result of user request.			/// </summary>			[iOSVersion(7)]			Background,						/// <summary>			/// Flag to indicate the activity requires the highest amount of timer and I/O precision available.			/// </summary>			[iOSVersion(7)]			LatencyCritical,		}		/// <summary>		/// The following constants are provided by the NSProcessInfo class as return values for operatingSystem.		/// </summary>				/// <summary>		/// Indicates the HP UX operating system.		/// </summary>		[iOSVersion(8)]		public int NSHPUXOperatingSystem { get; private set; }				/// <summary>		/// Indicates the OS X operating system.		/// </summary>		[iOSVersion(8)]		public int NSMACHOperatingSystem { get; private set; }				/// <summary>		/// Indicates the OSF/1 operating system.		/// </summary>		[iOSVersion(8)]		public int NSOSF1OperatingSystem { get; private set; }				/// <summary>		/// Indicates the Solaris operating system.		/// </summary>		[iOSVersion(8)]		public int NSSolarisOperatingSystem { get; private set; }				/// <summary>		/// Indicates the Sun OS operating system.		/// </summary>		[iOSVersion(8)]		public int NSSunOSOperatingSystem { get; private set; }				/// <summary>		/// Indicates the Windows 95 operating system.		/// </summary>		[iOSVersion(8)]		public int NSWindows95OperatingSystem { get; private set; }				/// <summary>		/// Indicates the Windows NT operating system.		/// </summary>		[iOSVersion(8)]		public int NSWindowsNTOperatingSystem { get; private set; }	}}