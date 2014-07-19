using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// An NSHTTPCookie object represents an HTTP cookie. It is an immutable object, initialized from a dictionary containing the cookie attributes.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSHTTPCookie_Class/index.html#//apple_ref/occ/cl/NSHTTPCookie"/>	[iOSVersion(2)]	public class NSHTTPCookie : NSObject, AnyObject, NSObjectProtocol	{		/// <summary>		/// Returns an array of NSHTTPCookie objects corresponding to the provided response header fields for the provided URL.		/// </summary>		/// <param name="headerFields">The header fields used to create the NSHTTPCookie objects.</param>		/// <param name="forURL">The URL associated with the created cookies.</param>		[iOSVersion(2)]		[Export("cookiesWithResponseHeaderFields")]		public static AnyObject[] CookiesWithResponseHeaderFields(Dictionary<NSObject, AnyObject> headerFields, NSURL forURL) { return default(AnyObject[]); }				/// <summary>		/// Creates and initializes an NSHTTPCookie object using the provided properties.		/// </summary>		/// <param name="properties">The properties for the new cookie object, expressed as key value pairs.</param>		[iOSVersion(2)]		[Export("cookieWithProperties")]		public static NSHTTPCookie CookieWithProperties(Dictionary<NSObject, AnyObject> properties) { return default(NSHTTPCookie); }				/// <summary>		/// Returns an initialized NSHTTPCookie object using the provided properties.		/// </summary>		/// <param name="properties">The properties for the new cookie object, expressed as key value pairs.</param>		[iOSVersion(2)]		public NSHTTPCookie(Dictionary<NSObject, AnyObject> properties) { }				/// <summary>		/// Returns a dictionary of header fields corresponding to a provided array of cookies.		/// </summary>		/// <param name="cookies">The cookies from which the header fields are created.</param>		[iOSVersion(2)]		[Export("requestHeaderFieldsWithCookies")]		public static Dictionary<NSObject, AnyObject> RequestHeaderFieldsWithCookies(AnyObject[] cookies) { return default(Dictionary<NSObject, AnyObject>); }				/// <summary>		/// Returns the receiver's comment string.		/// </summary>		[iOSVersion(2)]		[Export("comment")]		public string Comment { get; private set; }				/// <summary>		/// Returns the receiver’s comment URL.		/// </summary>		[iOSVersion(2)]		[Export("commentURL")]		public NSURL CommentURL { get; private set; }				/// <summary>		/// Returns the domain of the receiver’s cookie.		/// </summary>		[iOSVersion(2)]		[Export("domain")]		public string Domain { get; private set; }				/// <summary>		/// Returns the receiver’s expiration date.		/// </summary>		[iOSVersion(2)]		[Export("expiresDate")]		public NSDate ExpiresDate { get; private set; }				/// <summary>		/// Returns the receiver’s name.		/// </summary>		[iOSVersion(2)]		[Export("name")]		public string Name { get; private set; }				/// <summary>		/// Returns the receiver’s path.		/// </summary>		[iOSVersion(2)]		[Export("path")]		public string Path { get; private set; }				/// <summary>		/// Returns the receiver's port list.		/// </summary>		[iOSVersion(2)]		[Export("portList")]		public AnyObject[] PortList { get; private set; }				/// <summary>		/// Returns the receiver’s cookie properties.		/// </summary>		[iOSVersion(2)]		[Export("properties")]		public Dictionary<NSObject, AnyObject> Properties { get; private set; }				/// <summary>		/// Returns the receiver’s value.		/// </summary>		[iOSVersion(2)]		[Export("value")]		public string Value { get; private set; }				/// <summary>		/// Returns the receiver’s version.		/// </summary>		[iOSVersion(2)]		[Export("version")]		public int Version { get; private set; }	}}