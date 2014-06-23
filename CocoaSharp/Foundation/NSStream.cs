using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSStream_Class/index.html#//apple_ref/occ/cl/NSStream	/// <summary>	/// NSStream is an abstract class for objects representing streams. Its interface is common to all Cocoa stream classes, including its concrete subclasses NSInputStream and NSOutputStream.	/// </summary>	[iOSVersion(2)]	public class NSStream : NSObject	{		/// <summary>		/// Returns the receiver’s property for a given key.		/// </summary>		/// <param name="key">The key for one of the receiver's properties. See Constants for a description of the available property-key constants and associated values.</param>		/// <returns>The receiver’s property for the key key.</returns>		[iOSVersion(2)]		[Export("propertyForKey")]		public AnyObject PropertyForKey(string key) { return null; }				/// <summary>		/// Attempts to set the value of a given property of the receiver and returns a Boolean value that indicates whether the value is accepted by the receiver.		/// </summary>		/// <param name="property">The value for key.</param>		/// <param name="forKey">The key for one of the receiver's properties. See Constants for a description of the available property-key constants and expected values.</param>		/// <returns>true if the value is accepted by the receiver, otherwise false.</returns>		[iOSVersion(2)]		[Export("setProperty")]		public bool SetProperty(AnyObject property, string forKey) { return false; }				/// <summary>		/// Returns the receiver’s delegate.		/// </summary>		/// <returns>The receiver’s delegate. The delegate must implement the NSStreamDelegate Protocol.</returns>		[iOSVersion(2)]		[Export("delegate")]		public NSStreamDelegate Delegate { get; set; }				/// <summary>		/// Sets the receiver’s delegate.		/// </summary>		/// <param name="delegate">The delegate for the receiver.</param>		[iOSVersion(2)]		[Export("delegate")]		public NSStreamDelegate Delegate { get; set; }				/// <summary>		/// Opens the receiving stream.		/// </summary>		[iOSVersion(2)]		[Export("open")]		public void Open() { }				/// <summary>		/// Closes the receiver.		/// </summary>		[iOSVersion(2)]		[Export("close")]		public void Close() { }				/// <summary>		/// Schedules the receiver on a given run loop in a given mode.		/// </summary>		/// <param name="aRunLoop">The run loop on which to schedule the receiver.</param>		/// <param name="forMode">The mode for the run loop.</param>		[iOSVersion(2)]		[Export("scheduleInRunLoop")]		public void ScheduleInRunLoop(NSRunLoop aRunLoop, string forMode) { }				/// <summary>		/// Removes the receiver from a given run loop running in a given mode.		/// </summary>		/// <param name="aRunLoop">The run loop on which the receiver was scheduled.</param>		/// <param name="forMode">The mode for the run loop.</param>		[iOSVersion(2)]		[Export("removeFromRunLoop")]		public void RemoveFromRunLoop(NSRunLoop aRunLoop, string forMode) { }				/// <summary>		/// Returns the receiver’s status.		/// </summary>		/// <returns>The receiver’s status.</returns>		[iOSVersion(2)]		[Export("streamStatus")]		public NSStreamStatus StreamStatus { get; private set; }				/// <summary>		/// Returns an NSError object representing the stream error.		/// </summary>		/// <returns>An NSError object representing the stream error, or nil if no error has been encountered.</returns>		[iOSVersion(2)]		[Export("streamError")]		public NSError StreamError { get; private set; }				/// <summary>		/// The type declared for the constants listed in Stream Status Constants.		/// </summary>		[iOSVersion(2)]		public 		//enum NSStreamStatus : Uint {			  case NotOpen			  case Opening			  case Open			  case Reading			  case Writing			  case AtEnd			  case Closed			  case Error		}				/// <summary>		/// These constants indicate the current status of a stream. They are returned by streamStatus.		/// </summary>		public 		//enum NSStreamStatus : Uint {			  case NotOpen			  case Opening			  case Open			  case Reading			  case Writing			  case AtEnd			  case Closed			  case Error		}				/// <summary>		/// One or more of these constants may be sent to the delegate as a bit field in the second parameter of stream:handleEvent:.		/// </summary>		public enum NSStreamEvent		{			/// <summary>			/// No event has occurred.			/// </summary>			[iOSVersion(2)]			None,						/// <summary>			/// The open has completed successfully.			/// </summary>			[iOSVersion(2)]			OpenCompleted,						/// <summary>			/// The stream has bytes to be read.			/// </summary>			[iOSVersion(2)]			HasBytesAvailable,						/// <summary>			/// The stream can accept bytes for writing.			/// </summary>			[iOSVersion(2)]			HasSpaceAvailable,						/// <summary>			/// An error has occurred on the stream.			/// </summary>			[iOSVersion(2)]			ErrorOccurred,						/// <summary>			/// The end of the stream has been reached.			/// </summary>			[iOSVersion(2)]			EndEncountered,		}		/// <summary>		/// NSStream defines these string constants as keys for accessing stream properties using propertyForKey: and setting properties with setProperty:forKey::		/// </summary>				/// <summary>		/// The security level of the target stream. See Secure-Socket Layer (SSL) Security Level for a list of possible values.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSecurityLevelKey { get; private set; }				/// <summary>		/// Value is an NSDictionary object containing SOCKS proxy configuration information.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyConfigurationKey { get; private set; }				/// <summary>		/// Value is an NSData instance containing the data written to a memory stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamDataWrittenToMemoryStreamKey { get; private set; }				/// <summary>		/// Value is an NSNumber object containing the current absolute offset of the stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamFileCurrentOffsetKey { get; private set; }				/// <summary>		/// The type of service for the stream. Providing the service type allows the system to properly handle certain attributes of the stream, including routing and suspension behavior. Most streams do not need to set this property. See Stream Service Types for a list of possible values.		/// </summary>		[iOSVersion(4)]		public string NSStreamNetworkServiceType { get; private set; }				/// <summary>		/// NSStream defines these string constants to represent error domains that can be returned by streamError:		/// </summary>				/// <summary>		/// The error domain used by NSError when reporting SSL errors.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSSLErrorDomain { get; private set; }				/// <summary>		/// The error domain used by NSError when reporting SOCKS errors.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSErrorDomain { get; private set; }				/// <summary>		/// NSStream defines these string constants for specifying the secure-socket layer (SSL) security level.		/// </summary>				/// <summary>		/// Specifies that no security level be set for a socket stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSecurityLevelNone { get; private set; }				/// <summary>		/// Specifies that SSL version 2 be set as the security protocol for a socket stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSecurityLevelSSLv2 { get; private set; }				/// <summary>		/// Specifies that SSL version 3 be set as the security protocol for a socket stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSecurityLevelSSLv3 { get; private set; }				/// <summary>		/// Specifies that TLS version 1 be set as the security protocol for a socket stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSecurityLevelTLSv1 { get; private set; }				/// <summary>		/// Specifies that the highest level security protocol that can be negotiated be set as the security protocol for a socket stream.		/// </summary>		[iOSVersion(2)]		public string NSStreamSocketSecurityLevelNegotiatedSSL { get; private set; }				/// <summary>		/// NSStream defines these string constants for use as keys to specify SOCKS proxy configuration values in an NSDictionary object.		/// </summary>				/// <summary>		/// Value is an NSString object that represents the SOCKS proxy host.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyHostKey { get; private set; }				/// <summary>		/// Value is an NSNumber object containing an integer that represents the port on which the proxy listens.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyPortKey { get; private set; }				/// <summary>		/// Value is either NSStreamSOCKSProxyVersion4 or NSStreamSOCKSProxyVersion5.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyVersionKey { get; private set; }				/// <summary>		/// Value is an NSString object containing the user’s name.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyUserKey { get; private set; }				/// <summary>		/// Value is an NSString object containing the user’s password.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyPasswordKey { get; private set; }				/// <summary>		/// Possible value for NSStreamSOCKSProxyVersionKey.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyVersion4 { get; private set; }				/// <summary>		/// Possible value for NSStreamSOCKSProxyVersionKey.		/// </summary>		[iOSVersion(2)]		public string NSStreamSOCKSProxyVersion5 { get; private set; }				/// <summary>		/// NSStream defines these string constants for specifying the service type of a stream.		/// </summary>				/// <summary>		/// Specifies that the stream is providing VoIP service.		/// </summary>		[iOSVersion(4)]		public string NSStreamNetworkServiceTypeVoIP { get; private set; }				/// <summary>		/// Specifies that the stream is providing video service.		/// </summary>		[iOSVersion(5)]		public string NSStreamNetworkServiceTypeVideo { get; private set; }				/// <summary>		/// Specifies that the stream is providing a background service.		/// </summary>		[iOSVersion(5)]		public string NSStreamNetworkServiceTypeBackground { get; private set; }				/// <summary>		/// Specifies that the stream is providing voice service.		/// </summary>		[iOSVersion(5)]		public string NSStreamNetworkServiceTypeVoice { get; private set; }	}}